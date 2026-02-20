using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral
{
    public class Banco
    {
        public string Nome {  get; set; }
        public string CodigoBACEN { get; set; }

        private decimal _valor;
        public decimal valor
        {
            get { return _valor; }
            set
            {
                if (value > 0)
                    _valor = value;
                else
                    Console.WriteLine("Erro: Ovalor da transação deve ser positivo.");
            }
        }

    }
}
