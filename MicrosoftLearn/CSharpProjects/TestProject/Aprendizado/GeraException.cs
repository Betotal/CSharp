using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Aprendizado
{
    public class GeraException{
        public static void GeraExcecao(){      
            string resposta = "S";
            do {  
                Console.Clear();
                // Prompt the user for the lower and upper bounds
                Console.Write("Enter the lower bound: ");
                int lowerBound = int.Parse(Console.ReadLine());

                Console.Write("Enter the upper bound: ");
                int upperBound = int.Parse(Console.ReadLine());

                if (lowerBound >= upperBound){
                    throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
                }

                float averageValue = 0;

                try{
                    // Calculate the sum of the even numbers between the bounds
                    averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

                    // Display the result to the user
                    Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");
                }
                catch(ArgumentOutOfRangeException ex){

                }

                // Wait for user input
                Console.Write("Deseja executar novamente (S/N): ");
                resposta = Console.ReadLine().ToUpper();
            } while (resposta != "N");
        }
        
        public static float AverageOfEvenNumbers(int lowerBound, int upperBound){
            int sum = 0;
            int count = 0;

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    count++;
                }
            }

            return (float)sum / count;
        }        
    }
}