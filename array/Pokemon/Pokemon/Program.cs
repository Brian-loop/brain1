using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pokemon = { "Pikachu", "Charizard", "Ivysaur", };
            string[] tipo = { "ele", "fogo", "plantas", };
            double[] altura = { 0.4 , 1.70 , 1.0 , };
            double[] peso = { 6.0, 90.5, 13.0, };                  
            for (int i = 0; i < pokemon.Length; i++)
            {
                Console.WriteLine("ID: " + (i + 1));
                Console.WriteLine("Nome: " + pokemon[i]);
                Console.WriteLine("Tipo: "+ tipo[i]);
                Console.WriteLine("Altura: " + altura[i]+ "m");
                Console.WriteLine("Peso: " + peso[i]+"kg");
                Console.WriteLine("--------------------------------------------------------------------");
                
            }










        }
    }
}
