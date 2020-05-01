using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLLogin
{
    class User
    {
        private string username;
        private string name;
        private Guid id;
        private int rights;
        private int loginatempts;

        public string Username { get; set; }
        public string Name { get; set; }
        public Guid Id { get; set; }
        public int Rights { get; set; }
        public int Loginatempts { get; set; }


        public User(string konusername, string konname, Guid konguid, int konrights, int konloginatempts)
        {
            this.username = konusername;
            this.name = konname;
            this.id = konguid;
            this.rights = konrights;
            this.loginatempts = konloginatempts;
        }
        public User()
        {

        }
    }
}
