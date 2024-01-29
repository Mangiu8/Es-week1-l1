using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Atleta
    {
        private string _nome;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public string kmOrari(int attuale)
        {
            if(attuale > 100) 
            {
                return "corre forte";
            }
            else 
            { 
                return "fai cacare";
            }
        }
    }
}
