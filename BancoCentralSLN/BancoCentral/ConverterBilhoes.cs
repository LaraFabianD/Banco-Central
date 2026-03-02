using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral
{
  
		public class ConversorBilhoes : IConversorGrandeza
		{
			public decimal Converter(decimal valor) => 1250000000000 / 1_000_000_000m;

			public string ObterSimbolo() => "Bi";
		}
	
}
