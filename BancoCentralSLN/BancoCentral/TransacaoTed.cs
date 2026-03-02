using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BancoCentral.Transacao;

namespace BancoCentral
{
    internal class TransacaoTed : Transacao
    {
        public string Finalidade { get; set; }

        public override bool Validar()
        {
            return _valor > 5000 ;
        }
        
    }
}
