using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dipendente
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
        private string _cognome; 
        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value; 
            }
        }
        public string messaggio(string cognome) { if( cognome == "Roseti") { return ",il migliore di tutti"; }
        else { return ",uno qualsiasi"; }
        }
    }
}

