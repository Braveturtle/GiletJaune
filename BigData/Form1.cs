﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Orient.Client;
//using OrientDB_Net.binary.Innov8tive.API;

namespace BigData
{
    public partial class Form1 : Form
    {
        private static BigFile bf = new BigFile(@"C:\Users\Administrateur\Desktop\crackstation.txt");
        private Thread T;
        public Form1()
        {
            InitializeComponent();
            this.btnReadFile.Click += RunCalcLine;
            this.btnConnect.Click += Connect;
        }

        public void Connect(object sender,EventArgs e)
        {
            /*ConnectionOptions test = new ConnectionOptions();
            test.DatabaseName = "demodb";
            test.HostName = "10.5.51.31";
            test.Port = 2480;
            test.UserName = "admin";
            test.Password = "admin";
            Application.Exit();*/
            Console.WriteLine("paul");
            Database.Connect();
            //Database.Db.DatabaseProperties;
        }

        public void RunCalcLine(object sender,EventArgs e)
        {
            if (T == null)
            {
                T= new Thread(bf.Count);
                T.Start();
            }
        }


        
        


    }
}
