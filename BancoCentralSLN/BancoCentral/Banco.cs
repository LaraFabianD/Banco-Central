using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral
{
    internal class Banco
    {
        public string Nome { get; set;}
        private int _codigoBACEN;
        public int CodigoBACEN2 
        {
            get { return _codigoBACEN; }
            set
            {
                if ( value > 0)
                    throw new ArgumentException("CódigoBACEN não pode ser negativo.");
                _codigoBACEN = value;
            }
        }
    }
}