using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orient.Client;
using OrientDB_Net.binary.Innov8tive.API;

namespace BigData
{
    public static class Database
    {


        private static ODatabase _db = null;
        private static string _databaseName = "demodb";
        private static string _hostName = "10.5.51.31";
        private static int _port = 2480;
        private static string _userName = "admin";
        private static string _passWord = "admin";

        public static ODatabase Db { get => _db; set => _db = value; }
        public static string DatabaseName { get => _databaseName; set => _databaseName = value; }
        public static string HostName { get => _hostName; set => _hostName = value; }
        public static int Port { get => _port; set => _port = value; }
        public static string UserName { get => _userName; set => _userName = value; }
        public static string PassWord { get => _passWord; set => _passWord = value; }

        public static ODatabase Connect()
        {
            /*Db.DatabaseName = NameDatabase;
            Db.HostName = HostName;
            Db.Port = Port;
            Db.UserName = UserName;
            Db.Password = PassWord;*/
            //ODatabase Db = new ODatabase(HostName, Port, DatabaseName, ODatabaseType.Document ,UserName, PassWord);

            

            ConnectionOptions opts = new ConnectionOptions();

            opts.HostName = HostName;
            opts.UserName = UserName;
            opts.Password = PassWord;
            opts.Port = Port;
            opts.DatabaseName = DatabaseName;
            opts.DatabaseType = ODatabaseType.Document;

            Db = new ODatabase(opts);

            Console.Write(Db.Select().From("password").ToString());
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

        public static void InsertPassword(string password)
        {
            //ODatabase db = new ODatabase(HostName, Port, DatabaseName, ODatabaseType.Graph, UserName, PassWord);
            List<ODocument> insert = Db.Query("Insert ");
        }

    }
}
