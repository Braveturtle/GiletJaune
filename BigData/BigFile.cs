using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BigData
{
    class BigFile
    {

        string _path = string.Empty;

        public string Path { get => _path; private set => _path = value; }

        public BigFile(string path)
        {
            this.Path = path;
        }

        public async void TotalOfLines()
        {
            ulong val = 1;
            using (StreamReader oReader = new StreamReader(this.Path))
            {
                string strLine;
                while ((strLine = oReader.ReadLine()) != null || (strLine = oReader.ReadLine()) != "")
                {
                    val++;
                }
            }

            Console.WriteLine($"{(DateTime.Now - Form1.date).Minutes},{(DateTime.Now - Form1.date).Seconds},{(DateTime.Now - Form1.date).Milliseconds}\nligne : {val}");
        }

        public int TotalLines()
        {
            return File.ReadAllLines(this.Path).Length;
        }

    }
}
