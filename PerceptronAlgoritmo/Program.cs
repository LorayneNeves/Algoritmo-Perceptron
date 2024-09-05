using PerceptronAlgoritmo;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			NeuronioArtificial neuronioArtificial = new NeuronioArtificial(0.5);

			var entradas = new List<Entradas>
			{
				new Entradas(113, 6.8, 1),
				new Entradas(122, 4.7, 0),
				new Entradas(107, 5.2, 1),
				new Entradas(98, 3.6, 1),
				new Entradas(115, 2.9, 0),
				new Entradas(120, 4.2, 0)
			};

			neuronioArtificial.Treinar(entradas);

			foreach (var entrada in entradas)
			{
				int resultado = neuronioArtificial.Perguntar(entrada.Entrada1, entrada.Entrada2);
				Console.WriteLine($"Entrada [{entrada.Entrada1}, {entrada.Entrada2}] => Resultado: {resultado}");
			}
		}
	}
}

//criam a lista de entrada e treinar ele com metodo abaixo
//neuronioArtificial.Treinar();
//De perguntar pra ele
//O que precisa ser feito
//Gerar os pesos aleatorios
//Funcao de calcular o erro
//Funcao de calcular os novos pesos
//Funcao de obter resposta no metodo Perguntar
//Ajustar program.cs o treinamento e testar