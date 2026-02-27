using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BancoCentral.ConverterGrandezas;

namespace BancoCentral
{
    internal class ConverterMilhoes
    {
		public class ConversorMilhoes : IConversorGrandeza
		{
			public decimal Converter(decimal valor)
				=> valor / 1_000_000m;

			public string ObterSimbolo()
				=> "Mi";
		}
	}
}
