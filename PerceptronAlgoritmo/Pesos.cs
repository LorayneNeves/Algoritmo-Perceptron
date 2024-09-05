using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronAlgoritmo
{
	public class Pesos
	{
		public Pesos()
		{
			GerarAleatorio();
		}

		public double W1 { get; private set; }
		public double W2 { get; private set; }

		private void GerarAleatorio()
		{
			Random rand = new Random();
			W1 = rand.NextDouble() * 2 - 1;
			W2 = rand.NextDouble() * 2 - 1;
		}

		public void AtualizarPesos(double deltaW1, double deltaW2)
		{
			W1 += deltaW1;
			W2 += deltaW2;
		}
	}
}
