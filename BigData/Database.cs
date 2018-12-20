using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orient.Client;

namespace BigData
{
    public static class Database
    {


        private static ODatabase _db = null;
        private static string _nameDatabase = "demodb";
        private static string _hostName = "10.5.51.31";
        private static int _port = 2480;
        private static string _userName = "admin";
        private static string _passWord = "admin";

        public static ODatabase Db { get => _db; set => _db = value; }
        public static string NameDatabase { get => _nameDatabase; set => _nameDatabase = value; }
        public static string HostName { get => _hostName; set => _hostName = value; }
        public static int Port { get => _port; set => _port = value; }
        public static string UserName { get => _userName; set => _userName = value; }
        public static string PassWord { get => _passWord; set => _passWord = value; }

        public static void Connect()
        {
            Db.DatabaseName = NameDatabase;
            Db.HostName = HostName;
            Db.Port = Port;
            Db.UserName = UserName;
            Db.Password = PassWord;

            var database = new ODatabase(Db); 
        }

        public static void InsertPassword(string password)
        {
            ODatabase db = new ODatabase(HostName,Port,NameDatabase,ODatabaseType.Graph,UserName,PassWord);
            OVertex insert = Db.
        }

    }
}
