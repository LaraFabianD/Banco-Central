// See https://aka.ms/new-console-template for more information
using BancoCentral;
using static BancoCentral.Converterbilhoes;
using static BancoCentral.ConverterGrandezas;
using static BancoCentral.ConverterMilhoes;
using static BancoCentral.ConverterTrilhoes;
using static BancoCentral.Transacao;
class Program
{
	static void Main(string[] args)
	{
		TransacaoPix meuPix = new TransacaoPix();
		meuPix.Valor = 15000;
		meuPix.ChavePix = "contato@gmail.com";

		TransacaoTed meuTed = new TransacaoTed();
		meuTed.Valor = 6000;

		decimal valor = 15_750_000_000m;

		ExibirRelatorio(valor, new ConversorBilhoes());
		ExibirRelatorio(valor, new ConversorMilhoes());
		ExibirRelatorio(valor, new ConversorTrilhoes());
		Console.WriteLine($"Pix de R$ {meuPix.Valor} é válido? {meuPix.Validar()}");
		Console.WriteLine($"TED de R$ {meuTed.Valor} é válido? {meuTed.Validar()}");
	}

		  public static void ExibirRelatorio(decimal valorBruto, IConversorGrandeza conversor)
	{
		decimal valorConvertido = conversor.Converter(valorBruto);

		Console.WriteLine(
			$"Valor convertido: {valorConvertido:N2} {conversor.ObterSimbolo()}");

	   Console.ReadLine() ;
    }
}

	
			
