using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace TestProject.Desafios
{
    public class Codigo3While
    {
        public static void Codigo3_While(){

            Console.Clear();

            Console.WriteLine("Laço com validação de dados de entrada - Código 3");
            Console.WriteLine();

            int localParada = 0; 
            string subFrase;

            string[] myStrings = new string[4] {
                "I like pizza. I like roast chicken. I like salad.",
                "I like all three of the menu choices. I Like a movie",
                "I Like a move, move! ",
                "Fim do exemplo 3"
                 };

            foreach (string frase in myStrings)
            {
                subFrase = frase;
                localParada = 0;
                if (subFrase.IndexOf(".") < 0){
                    System.Console.WriteLine(subFrase);
                }
                else {
                    while (localParada <= subFrase.Length && subFrase.Length > 0 ){
                        if (subFrase.IndexOf(".") < 0){
                            System.Console.WriteLine(subFrase);
                            subFrase = subFrase.Remove(0,subFrase.Length).Trim();  
                        } else if (subFrase.Substring(localParada, 1) != "."){
                            localParada +=1;
                        }
                        else{
                            System.Console.WriteLine(subFrase.Substring(0, localParada));
                            subFrase = (subFrase.Length > localParada) ? subFrase.Remove(0, localParada + 1).Trim() 
                                                                       : subFrase.Remove(0, localParada).Trim();  
                            localParada = 0;
                        }        
                    }
                    if (localParada > 0)
                        System.Console.WriteLine(subFrase.Substring(0, localParada));
                }
            }
        }
    }
}
