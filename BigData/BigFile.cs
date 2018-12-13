using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public async void Count()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            ulong val = 0;
            Thread T = new Thread(new ThreadStart(() => { val = TotalOfLines(); }));
            T.Start();
            T.Join();
            Console.WriteLine($"{(DateTime.Now - date).Minutes},{(DateTime.Now - date).Seconds},{(DateTime.Now - date).Milliseconds}\nligne : {val}");
        }

        private ulong TotalOfLines()
        {
            ulong val = 1;
            using (StreamReader oReader = new StreamReader(this.Path))
            {
                string strLine;
                while ((strLine = oReader.ReadLine()) != null)
                {
                    val++;
                }
            }

            return val;
            //Console.WriteLine($"{(DateTime.Now - Form1.date).Minutes},{(DateTime.Now - Form1.date).Seconds},{(DateTime.Now - Form1.date).Milliseconds}\nligne : {val}");
        }

        public async Task<ulong> TotalLines()
        {
            ulong val = 1;
            using (StreamReader oReader = new StreamReader(this.Path))
            {
                string strLine;
                while ((strLine = await oReader.ReadLineAsync()) != null)
                {
                    val++;
                }
            }

            return val;
        }

    }
}
