using System;
using EUDED.Entidad;

namespace EUDED.Negocio
{
	public class JuegoDados
	{
		private Dados dado1, dado2;
		private int[,] matriz;
		private int[] total;
		private int iter, result;
		private double suma, media, desvEst, div, desv, desvTot, cuadrado;
		private string linea;

		public JuegoDados()
		{
			dado1 = new Dados();
			dado2 = new Dados();
		}

		public void Jugar()
		{
			total = new int[7];
			Console.Write("Ingrese la cantidad de iteraciones: ");
			linea = Console.ReadLine();
			iter = int.Parse(linea);
			Console.WriteLine("");
			matriz = new int[iter, 1];

			for (int fila = 0; fila < iter; fila++)
			{
				dado1.Lanzar();
				dado2.Lanzar();

				if (dado1.RetornarValor() == dado2.RetornarValor())
				{
					result = (dado1.RetornarValor() * dado2.RetornarValor()) * 100;

					switch (dado1.RetornarValor())
					{
						case 1:
							total[1] = total[1] + result;
							break;
						case 2:
							total[2] = total[2] + result;
							break;
						case 3:
							total[3] = total[3] + result;
							break;
						case 4:
							total[4] = total[4] + result;
							break;
						case 5:
							total[5] = total[5] + result;
							break;
						case 6:
							total[6] = total[6] + result;
							break;
						default:
							Console.WriteLine("Default case");
							break;
					}
				}
				else
				{
					result = -200;
					total[0] = total[0] + result;
				}

				matriz[fila, 0] = result;
			}
			suma = total[0] + total[1] + total[2] + total[3] + total[4] + total[5] + total[6];
			media = suma / iter;

			for (int fila = 0; fila < iter; fila++)
			{
				desv = 0;
				desv = (matriz[fila, 0] - media);
				cuadrado = desv * desv;
				desvTot = desvTot + cuadrado;
			}
			div = desvTot / iter;
			desvEst = Math.Sqrt(div);

			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("--------------------     RESULTADOS     --------------------");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("    Gana                        Monto Total    ");
            Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("    -200                        " + total[0]);
			Console.WriteLine("     100                        " + total[1]);
			Console.WriteLine("     400                        " + total[2]);
			Console.WriteLine("     900                        " + total[3]);
			Console.WriteLine("    1600                        " + total[4]);
			Console.WriteLine("    2500                        " + total[5]);
			Console.WriteLine("    3600                        " + total[6]);
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("    Total General               " + suma);
			Console.WriteLine("    Media                       " + media);
			Console.WriteLine("    Desviación Estandar         " + desvEst);
			Console.WriteLine("------------------------------------------------------------");
			Console.ReadKey();
		}
	}
}
