using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM_calculate
{
    class Program
    {
        static void Main(string[] args)
        {

            var net1 ="10";
            var net2 = "0";
            var net3 = "0";
            var net4 = "0";


            var query = "address=10.10.0.0&mask=8&network1=4563&network2=436&network3=458&network4=4556";  //puts the contents of the query string into a variable called query. location.search just simply returns anything that is appended to the URL.
            
            string[] queryArray = query.Split('&');  //splits the query string into an array of label=value strings and removes all of the ampersands (&).
            var querynum = queryArray.Length;   //figures out how many label=value strings there are. The more networks that were entered, the more label=value strings there will be.
            var cidradd = queryArray[0].Substring(8, queryArray[0].Length);  //takes the "address=" off of the address block string and stores only the address block itself in a variable.
            int cidrmask = int.Parse(queryArray[1].Substring(5, queryArray[1].Length));  //takes the "mask=" off of the CIDR mask string and stores only the CIDR mask itself in a variable.
            var iparray = cidradd.Split('.');  //splits the address block into an array of the 4 decimal numbers of the address.

            var addNets = 0;  //this creates a variable that will add up the total number of hosts needed by all of the entered networks to test to see if the entered Address Block is large enough to handle it.
            for (int count2 = 2; count2 < querynum; count2++)
            {  //this for loop will extract the hosts needed by each network out of the query string and then add them up. A loop is needed here, because the amount of networks entered is variable.
               
               string[] tempArray2 = queryArray[count2].Split('=');  //splits the number off of the label=value pair of each network. For example, it changes "network3=84" to an array containg 2 values, "network3" & "84" (the equals sign is removed), which gets it ready to be added to the other networks.
                //tempArray2[1] = tempArray2[1];  //these 2 lines make sure that the number is treated like a number and not a text string.
                //tempArray2[1] = tempArray2[1];
                 addNets = addNets + int.Parse(tempArray2[1]);   //this adds the current extracted number to the previous extracted numbers and saves it in the addNets variable.
            }
            int x = 2;
           var cidrNum = cidrmask;  //creates a variable with the same value as the CIDR mask.
            cidrNum = 32 - cidrNum;  //subtracts the decimal mask # from 32 to find out how many bits are in the host portion of the Address Block.
            /*cidrNum = Math.Pow(x, cidrNum);*/  //takes the 2 to the power of the result of the above calculation to find out the absolute maximum number of host addresses the Address Block can support.
            cidrNum = cidrNum - 2;

            var stopexec = 0;  //creates a variable that will tell select future statements not to execute.
            if (addNets >= cidrNum)
            {  //if the required # of hosts is larger than the maximum hosts available, it displays an error message and sends them back to the index.htm page.
                Console.WriteLine
                ("Your Address Block is not large enough to handle this many host addresses.\n\nYour network requires " + addNets + " addresses, but your Address Block only has " + cidrNum + " usable addresses");
                stopexec = 1;
                
            }

            var gosamenetadd = cidradd;
            var gosamenetmask = cidrmask;

            double percentUsed = addNets / cidrNum;
            percentUsed = percentUsed * 100;
            percentUsed = Math.Round(percentUsed);

            


            if (stopexec != 1)
            {  //stops the execution if your networking topology requires too many addresses for your entered block.

                //next is the loop that actually calculates the addresses and creates the table rows.
                for (var count = 2; count < querynum; count++)
                {

                    //the next 3 if statements make sure that the Address Block is large enough for the required networks, but in a different way than above. It in effect makes sure that after you take all the addresses wasted with network and broadcast addresses and after the left over addresses not used in some of the networks, that there are still enough addresses left to accomodate all of the networks.
                    //even if there are enough addresses before you begin doesn't mean that there will be enough addresses after some are wasted in the addressing process. The next three statements effectively test for that. Note that this check takes place on each iteration of the loop, not just the first time. In this way, it continually monitors the addresses to make sure that they haven't used up more than the available addresses.
                    
                    var compare1 = net4 + (Math.Pow(2, (32 - cidrmask)) - 1);
                    var compare2 = net3 + (Math.Pow(2, (24 - cidrmask)) - 1);
                    var compare3 = net2 + (Math.Pow(2, (16 - cidrmask)) - 1);
                    var stopcheck = 0;  //performs a similar function as the stopexec variable.
                    if (stopcheck == 0)
                    {
                        if (cidrmask > 24)
                        {
                            if (num4 > compare1)
                            {
                                stopcheck = 1;
                                alert("Your Address Block is not large enough to handle this many host addresses.");
                                location.href = "index.htm";
                                break;
                            }
                        }
                    } //end stopcheck if statement.

                    if (stopcheck == 0)
                    {
                        if (cidrmask > 16 && cidrmask < 25)
                        {
                            if (num3 > compare2)
                            {
                                stopcheck = 1;
                                alert("Your Address Block is not large enough to handle this many host addresses.");
                                location.href = "index.htm";
                                break;
                            }
                        }
                    } //end stopcheck if statement.

                    if (stopcheck == 0)
                    {
                        if (cidrmask > 8 && cidrmask < 17)
                        {
                            if (num2 > compare3)
                            {
                                stopcheck = 1;
                                alert("Your Address Block is not large enough to handle this many host addresses.");
                                location.href = "index.htm";
                                break;
                            }
                        }
                    } //end stopcheck if statement.
                    var addnum, n, mask, netadd;  //creates needed variables.
                    var tempArray = queryArray[count].Split("=");  //splits the "networkx=value" statements from the query string to just get the number of hosts needed and removes the "networkx=" portion
                    n = tempArray[1];  //assigns the above extracted value to the n variable.

                    //the next for loop figures out what the mask should be based on the number of addresses needed and figures out what the next address to use should be.
                    var maskVar = 30;  //sets a variable to be used as the mask value.
                    for (var count3 = 1; count3 < 28; count3++)
                    {
                        if (n > Math.pow(2, count3) - 2)
                        {  //checks to see if the current mask value is sufficient to meet the current network's requirements.
                            mask = maskVar;
                            addnum = Math.pow(2, (count3 + 1));  //figures out how much to add to the address to get the next network address.
                        }
                        maskVar = maskVar - 1;  //drops the mask value by one for the next time through the loop.
                    }

                    document.write("<tr><td align='center' style='border-collapse=collapse;border:1px solid #33CCFF;color:green'>" + n + "</td><td align='center' style='border-collapse=collapse;border:1px solid #33CCFF;color:blue'>" + cidradd + "/" + mask + "</td></tr>");  //this line writes the row to the table with the correct values.
                    num4 = num4 + addnum;  //adds the value of the addnum variable to the fourth (decimal) octet of the IP address.

                    //these next 3 while loops will "carry the 1" so to speak if an octet grows larger than 255.
                    while (num4 > 255)
                    {
                        num3 = num3 + 1;
                        num4 = num4 - 256;
                    }
                    while (num3 > 255)
                    {
                        num2 = num2 + 1;
                        num3 = num3 - 256;
                    }
                    while (num2 > 255)
                    {
                        num1 = num1 + 1;
                        num2 = num2 - 256;
                    }

                    //this next if statment just provides protection against the first octet of the IP address going over 255. This situation is very unlikely to ever happen, but I put the statement in just in case.
                    if (num1 > 255)
                    {
                        alert("Fatal Error: IP address is too large.\n\nIt may be because your Address Block is too small to handle the number of addresses required.");
                        history.back();
                    }
                    cidradd = num1 + "." + num2 + "." + num3 + "." + num4;  //puts the IP address into the cidradd variable.
                }  //end of the calculation loop
            }
    }
}
