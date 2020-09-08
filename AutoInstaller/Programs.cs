using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInstaller
{
    public class Programs
    {
        public List<Software> programas { get; set; }
    }

    public class Software
    {
        public string nome { get; set; }
        public string caminhoweb { get; set; }
        public string nomearquivo { get; set; }
        public string formasileciosa { get; set; }
    }
}
