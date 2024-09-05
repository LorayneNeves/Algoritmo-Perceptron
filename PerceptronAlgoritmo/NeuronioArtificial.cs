using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronAlgoritmo
{
	public class NeuronioArtificial
	{
		public Pesos pesos { get; private set; }
		public double taxaAprendizado { get; private set; }
		private bool pesosInicializados;
		public NeuronioArtificial(double pTaxaAprendizado)
		{
			taxaAprendizado = pTaxaAprendizado;
			pesos = new Pesos();
			pesosInicializados = false;
		}

		public void Treinar(List<Entradas> listaEntradas)
		{
			foreach (var item in listaEntradas)
			{
				double lo = item.Entrada1 * pesos.W1 + item.Entrada2 * pesos.W2;

				int y = FuncaoClassificacao(lo);

				double erro = item.ResultadoEsperado - y;

				if (!pesosInicializados)
				{
					pesosInicializados = true;
				}
				else
				{
					double deltaW1 = taxaAprendizado * erro * item.Entrada1;
					double deltaW2 = taxaAprendizado * erro * item.Entrada2;
					pesos.AtualizarPesos(deltaW1, deltaW2);
				}

				Console.WriteLine($"Entrada1: {item.Entrada1}, Entrada2: {item.Entrada2}");
				Console.WriteLine($"W1: {pesos.W1}, W2: {pesos.W2}");
				Console.WriteLine($"l(o): {lo}, y: {y}");
				Console.WriteLine($"Taxa de Aprendizado (n): {taxaAprendizado}, Erro: {erro}");
				Console.WriteLine("=====================================");
			}
		}

		private int FuncaoClassificacao(double o)
		{
			return o >= 0 ? 1 : 0;
		}

		public int Perguntar(double X1, double X2)
		{
			double lo = X1 * pesos.W1 + X2 * pesos.W2;
			return FuncaoClassificacao(lo);
		}

	}
}
