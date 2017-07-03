using System;
namespace EUDED.Entidad
{
public class Dados
	{
		private int valor;
		private static Random aleatorio;

		public Dados()
		{
			aleatorio = new Random();
		}
		public void Lanzar()
		{
			valor = aleatorio.Next(1, 7);
		}
		public void Imprimir()
		{
			Console.WriteLine("El valor del dado es: " + valor);
		}
		public int RetornarValor()
		{
			return valor;
		}
	}
}
