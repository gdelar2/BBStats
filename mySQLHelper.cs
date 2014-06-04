using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BBStats
{
    class mySQLHelper
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        

        public mySQLHelper()
        {
            server = "192.168.56.101";
            database = "BBStats";
            // uid = "gus";

            //password = "******";


            string connectionString = "Server=" + server + ";" + "Database=" + database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";
            connection = new MySqlConnection(connectionString);

            Console.WriteLine(connectionString);

            
        }
        public mySQLHelper(string userName, string userPassword)
        {
            server = "192.168.56.101";
            database = "BBStats";
            uid = userName;
            password = userPassword;

            string connectionString = "Server=" + server + ";" + "Database=" + database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";
            connection = new MySqlConnection(connectionString);

            Console.WriteLine(connectionString);

        }



      


        private bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch{

                //TODO swtich statement with possible error here.

                return false;
                }

            

        }

        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch
            {

                //TODO swtich statement with possible error here.

                return false;
            }



        }

        public void insertGame(int gameID, string opponent, int runsfor, int runsAgainst)
        {


            string query = "INSERT INTO Games VALUES(" + gameID + "," + opponent + "'," + runsfor + "," + runsAgainst +")";

            if (this.openConnection()==true){

                
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                this.closeConnection();

            }

        }

        public void insertPlayer(int firstName, string lastName, string PID)
        {


            string query = "INSERT INTO Players VALUES(" + firstName + "," + lastName + "," + PID + ")";

            if (this.openConnection() == true)
            {


                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                this.closeConnection();

            }

        }



        public void deleteGame(int gameCode)
        {
            string query = "DELETE FROM GamesPlayed WHERE GameCode=" + gameCode;


            if (this.openConnection() == true)
            {

                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                this.closeConnection();
            }
        }

        public List<string>[] selectGames()//WIP
        {

            string query = "SELECT * FROM GamesPlayed";
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();//gamevode
            list[1] = new List<string>();//date
            list[3] = new List<string>();//oppponetn
            list[2] = new List<string>();//ptsfor
            list[4] = new List<string>();//ptsagainst

            if (this.openConnection() == true)
            {
                
                MySqlCommand cmd = new MySqlCommand(query, connection);
             
                MySqlDataReader dataReader = cmd.ExecuteReader();

              
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["GameCode"] + "");
                    //list[1].Add(dataReader["Date"] + "");
                    list[2].Add(dataReader["vsTeam"] + "");
                    list[3].Add(dataReader["Runsfor"] + "");
                    list[4].Add(dataReader["RunsAgainst"] + "");
                }

     
                dataReader.Close();

                this.closeConnection();


                return list;
            }
            else
            {
                return list;
            }
        }

        public void setUser(string userName)
        {
            this.uid = userName;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }
       

    }
}
