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

        public int TotalLines()
        {
            return File.ReadAllLines(this.Path).Length;
        }

    }
}
