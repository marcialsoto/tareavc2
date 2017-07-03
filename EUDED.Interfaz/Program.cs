using System;
using EUDED.Negocio;

namespace EUDED.Interfaz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("--------------------   JUEGO DE DADOS   --------------------");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("");
			Console.WriteLine("");
			JuegoDados objJuegoDados = new JuegoDados();
			objJuegoDados.Jugar();
			Console.ReadKey();
        }
    }
}
