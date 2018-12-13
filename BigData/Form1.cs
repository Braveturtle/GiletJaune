using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Orient.Client;
using OrientDB_Net.binary.Innov8tive.API;

namespace BigData
{
    public partial class Form1 : Form
    {
        public static DateTime date;

        public Form1()
        {
            InitializeComponent();
            this.btnReadFile.Click += Count;
        }

        public void Connect(object sender,EventArgs e)
        {
            ConnectionOptions test = new ConnectionOptions();
            test.DatabaseName = "demodb";
            test.HostName = "10.5.51.31";
            test.Port = 2480;
            test.UserName = "admin";
            test.Password = "admin";
            Application.Exit();
        }

        public void Count(object sender,EventArgs e)
        {
            BigFile bf = new BigFile(@"C:\Users\Administrateur\Desktop\crackstation.txt");

            date = DateTime.Now;
            Console.WriteLine(date);
            var T = new Thread(new ThreadStart(() => bf.TotalOfLines()));
            T.Start();
        }
        


    }
}
