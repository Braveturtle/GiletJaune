using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orient.Client;

namespace BigData
{
    public static class Database
    {


        private static ODatabase _db = null;
        private static string _databaseName = "crack";
        private static string _hostName = "127.0.0.1";
        private static int _port = 2424;
        private static string _userName = "admin";
        private static string _passWord = "Super";
        private static string _path = @"C:\Users\Administrateur\Desktop\crackstation.txt";

        public static ODatabase Db { get => _db; set => _db = value; }
        public static string DatabaseName { get => _databaseName; set => _databaseName = value; }
        public static string HostName { get => _hostName; set => _hostName = value; }
        public static int Port { get => _port; set => _port = value; }
        public static string UserName { get => _userName; set => _userName = value; }
        public static string PassWord { get => _passWord; set => _passWord = value; }
        public static string Path { get => _path; set => _path = value; }

        public static ODatabase Connect()
        {
            /*Db.DatabaseName = NameDatabase;
            Db.HostName = HostName;
            Db.Port = Port;
            Db.UserName = UserName;
            Db.Password = PassWord;*/
            Db = new ODatabase(HostName, Port, DatabaseName, ODatabaseType.Document ,UserName, PassWord);
            Console.WriteLine(Db.Query("select * from Password"));
            //InsertWord();

            //OServer serv = new OServer(HostName, Port, UserName, PassWord);
            //serv.Dispose();


            // opts = new ConnectionOptions();

            //opts.HostName = HostName;
            //opts.UserName = UserName;
            //opts.Password = PassWord;
            //opts.Port = Port;
            //opts.DatabaseName = DatabaseName;
            //opts.DatabaseType = ODatabaseType.Document;

            //Db = new ODatabase(opts);

            //Console.Write(Db.Select().From("password").ToString());
            Db.Close();
            return null;

            /*
            OServer s = new OServer("localhost", Port, UserName, PassWord);
            Dictionary<string,Orient.Client.API.Types.ODatabaseInfo> tempkon = s.Databases();

            using (Db= new ODatabase(HostName, Port, DatabaseName, ODatabaseType.Document, UserName, PassWord))
            {
                OVertex v1 = Db.Query<OVertex>($"select * from password")[0];
                var myfield = v1.GetField<string>("words");
            }

            List<ODocument> tmp = Db.Select().From("password").ToList();
            Console.WriteLine(Db.DatabaseProperties);

            return Db;
            */


            //var database = new ODatabase(Db);
            //Connection connection = new Connection(Hostname, Port, databaseName, databaseType, userName, userPassword, alias, true);

        }


        private static void InsertWord()
        {
            int len = 0;
            using (StreamReader oReader = new StreamReader(Path))
            {
                string strLine;
                while ((strLine = oReader.ReadLine()) != null)
                {
                    if (strLine.Length > 0)
                    {
                        len = strLine.Length;
                        if (strLine.IndexOf("\\") != -1)
                        {
                            strLine = strLine.Replace(@"\", @"\\");
                        }
                        string com = $"insert into Password(Words, Length) values(\"{strLine}\", {len})";
                        Db.Command(com);
                    }
                    
                }
            }

        }

        public static void InsertPassword(string password)
        {
            //ODatabase db = new ODatabase(HostName, Port, DatabaseName, ODatabaseType.Graph, UserName, PassWord);
            List<ODocument> insert = Db.Query("Insert ");
        }

    }
}
