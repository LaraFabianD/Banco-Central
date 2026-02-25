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
        //public class transacaoTed : transacao {public override bool Validar(){return _valor > 500;}
      
        // public class Transacaoted : Transacao {   
        public string Finalidade { get; set; }

        public override bool Validar()
        {
            //Regra de exemplo: TED deve ser maior que R$5.000 para fiscalização
            return _valor > 0;
        }
        //}
    }
}
