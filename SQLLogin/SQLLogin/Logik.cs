using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SQLLogin
{
    class Logik
    {
        public static User loginuser = new User();
        public SqlConnection GetConnection() // make an connection method
        {
            //Declare my connection and which database I want to connect to
            return new SqlConnection("Data Source=(local);" + "Initial Catalog=LoginBase; Integrated Security=SSPI"); 
            
        }
        #region Login 
        public int CheckUsername(string usernameinput)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            int count;
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM User_Table WHERE Username = @UserNameParameter", conn);
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@UserNameParameter";
            parameter.Value = usernameinput;
            cmd.Parameters.Add(parameter);

            count = (int)cmd.ExecuteScalar();// I use ExecuteScalar because I just get one result from the statement
            conn.Close();

            if (count == 1) //If there a one username there match 
            {
                //Then I get the ID 
                GetUsersid(usernameinput); 
            }
            return count;
        }
        public int CheckPassword(string passwordinput, string usernameinput)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            int count;
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Password_Table WHERE ID = @IDParameter AND [Password] = @PasswordParameter", conn);
            SqlParameter idparameter = new SqlParameter();
            idparameter.ParameterName = "@IDParameter";
            idparameter.Value = GetUsersid(usernameinput);
            SqlParameter passwordparameter = new SqlParameter();
            passwordparameter.ParameterName = "@PasswordParameter";
            passwordparameter.Value = passwordinput;
            cmd.Parameters.Add(idparameter);
            cmd.Parameters.Add(passwordparameter);
            count = (int)cmd.ExecuteScalar();  //convert my result to an int
            conn.Close();
            MakeLoginUserObj(usernameinput); //Make the login to a obj
            return count;
        }
        private void SetLoginAtempts(Guid id)
        {
            SqlConnection conn = GetConnection();
            conn.Open();

            string insertString = @"UPDATE User_Table SET [LoginAtempts] = @loginatempts WHERE [ID] = @ID"; // update the login atempts

            SqlCommand cmd = new SqlCommand(insertString, conn);

            SqlParameter loginatemptsparameter = new SqlParameter();
            loginatemptsparameter.ParameterName = "@loginatempts";
            loginatemptsparameter.Value = GetLoginAtempts(id) + 1;
            cmd.Parameters.Add(loginatemptsparameter);

            SqlParameter idparameter = new SqlParameter();
            idparameter.ParameterName = "@ID";
            idparameter.Value = id;
            cmd.Parameters.Add(idparameter);
            cmd.ExecuteNonQuery(); // no respons = nonquery

            conn.Close();
        }
        private int GetLoginAtempts(Guid id)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [LoginAtempts] FROM User_Table WHERE [ID] = @idParameter", conn);
            SqlParameter parameter = new SqlParameter();
            cmd.Parameters.AddWithValue("@idParameter", id);

            int logincount = Convert.ToInt32(cmd.ExecuteScalar());//Convert my result to an int 

            conn.Close();
            return logincount;
        }
        public Guid GetUsersid(string usernameparameter)
        {
            Guid id = Guid.Parse("e6b86ea3-6479-48a2-b8d4-54bd6cbbdbc5");// an exemple for an GUID just so i can declare an variable as guid
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM User_Table WHERE Username = @UserNameParameter", conn);
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@UserNameParameter";
            parameter.Value = usernameparameter;
            cmd.Parameters.Add(parameter);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = (Guid)reader[0];//get the user id where i convert it to an GUID because its an unique in my database
            }
            conn.Close();
            return id;
        }
        #endregion
        public void MakeLoginUserObj(string username)
        {
            
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Username], [Name], [Rights], [LoginAtempts] FROM User_Table WHERE [ID] = @idParameter", conn);

            SqlParameter parameter = new SqlParameter();
            cmd.Parameters.AddWithValue("@idParameter", GetUsersid(username));

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //add all the variables to an user object for the user there are loged on 
                loginuser.Username = reader[0].ToString();
                loginuser.Name = reader[1].ToString();
                loginuser.Rights = Convert.ToInt32(reader[2]);
                loginuser.Id = GetUsersid(username);
                loginuser.Loginatempts = Convert.ToInt32(reader[3]);

            }
            conn.Close();

            
            SetLoginAtempts(GetUsersid(username));
        }
        public User Getuser()
        {
            return loginuser;
        }
        #region Opret bruger

        public void RegisterUser(string username, string name, string password)
        {

            SqlConnection conn = GetConnection();
            conn.Open();

            string insertString = @"EXEC [CreateAnUser] @Username, @Name, @Password";//Executer an stored procedure to create an user on the database
            
            SqlCommand cmd = new SqlCommand(insertString, conn);
            
            SqlParameter usernameparameter = new SqlParameter();
            usernameparameter.ParameterName = "@Username";
            usernameparameter.Value = username;
            cmd.Parameters.Add(usernameparameter);

            SqlParameter nameparameter = new SqlParameter();
            nameparameter.ParameterName = "@Name";
            nameparameter.Value = name;
            cmd.Parameters.Add(nameparameter);

            SqlParameter passwordparameter = new SqlParameter();
            passwordparameter.ParameterName = "@Password";
            passwordparameter.Value = password;
            cmd.Parameters.Add(passwordparameter);
            cmd.ExecuteNonQuery();

            conn.Close();

            MakeLoginUserObj(username);//When person is created, then automatic make an obj an log the person on.
        }
        #endregion

        #region Rights Methods
        public void ChangeRights(string usernameinput, int rightsinput)
        {

            SqlConnection conn = GetConnection(); // Declare my connection
            conn.Open(); //Open the connection to my database

            string insertString = @"UPDATE User_Table SET Rights=@RightsParameter WHERE [Username] = @UsernameParameter"; //Declare my SQL statement

            SqlCommand cmd = new SqlCommand(insertString, conn); //Make the sql command with statement and connection

            //"Declare" my parameters and give the parameters a value
            SqlParameter usernameparameter = new SqlParameter(); 
            usernameparameter.ParameterName = "@UsernameParameter";
            usernameparameter.Value = usernameinput;
            cmd.Parameters.Add(usernameparameter);

            SqlParameter rightdparameter = new SqlParameter();
            rightdparameter.ParameterName = "@RightsParameter";
            rightdparameter.Value = rightsinput;
            cmd.Parameters.Add(rightdparameter);
            //executer my SQL "query"
            cmd.ExecuteNonQuery();
            conn.Close(); // close the connection

        }

        public void InsertDataAboutUser(string lastname, string name, string adr, string city, string phone, Guid id)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            //Declare an insert statement 
            string insertString = @"INSERT INTO Persons_Table([LastName], [FirstName], [Address], [City], [Phone], [ID]) VALUES(@lastnameparameter, @nameparameter, @adrparameter, @cityparameter, @phoneparameter, @idparameter)";
                                                  
            SqlCommand cmd = new SqlCommand(insertString, conn);

            SqlParameter lastnameparameter = new SqlParameter();
            lastnameparameter.ParameterName = "@lastnameparameter";
            lastnameparameter.Value = lastname;
            cmd.Parameters.Add(lastnameparameter);

            SqlParameter nameparameter = new SqlParameter();
            nameparameter.ParameterName = "@nameparameter";
            nameparameter.Value = name;
            cmd.Parameters.Add(nameparameter);

            SqlParameter adrparameter = new SqlParameter();
            adrparameter.ParameterName = "@adrparameter";
            adrparameter.Value = adr;
            cmd.Parameters.Add(adrparameter);

            SqlParameter cityparameter = new SqlParameter();
            cityparameter.ParameterName = "@cityparameter";
            cityparameter.Value = city;
            cmd.Parameters.Add(cityparameter);

            SqlParameter phoneparameter = new SqlParameter();
            phoneparameter.ParameterName = "@phoneparameter";
            phoneparameter.Value = phone;
            cmd.Parameters.Add(phoneparameter);

            SqlParameter idparameter = new SqlParameter();
            cmd.Parameters.AddWithValue("@idParameter", id);

            cmd.ExecuteNonQuery(); //Executer my statement without response from sql
            conn.Close();
        }

        public List<string> ReadAmountOfUsers() // make and list to view login atempts for guest
        {
            List<string> seeuserslist = new List<string>(); //Declare the list with an string value
            SqlConnection conn = GetConnection();
            conn.Open(); //open the connection
            SqlCommand cmd = new SqlCommand("SELECT [Name], [LoginAtempts] FROM User_Table", conn);// declare the sql command with statement and connection
            SqlDataReader reader = cmd.ExecuteReader(); // I use sqldatareader because its an SELECT statement so i get respons from SQL Server.
            while (reader.Read()) //for every row in the table the while loop while run
            {
                // I add the name and login atempt to an string and then add it to and list so i can write in console
                seeuserslist.Add("Navn:    " + reader[0].ToString() + ",       Antal:  " + reader[1].ToString());
            }
            return seeuserslist; //returner the list
        }
        #endregion


    }
}
