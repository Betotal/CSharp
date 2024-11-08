using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Aprendizado
{
    public class TryCatch()
    {
        public static void Try_catch(){
            /*  primeiro try catch
            double float1 = 3000.0;
            double float2 = 0.0;
            int number1 = 3000;
            int number2 = 0;

            try{
                Console.WriteLine(float1 / float2);
                Console.WriteLine(number1 / number2);
            }
            catch{
                Console.WriteLine("Uma exceção foi capturada");
            }
            Console.WriteLine("Exit program");
            */

            try
            {
                Process1();
            }
            catch(Exception ex){
                Console.WriteLine($"An exception has occurred: {ex.GetBaseException}, {ex.Data}, {ex.InnerException}, {ex.Message} ");
            }

            Console.WriteLine("Exit program");

            static void Process1()
            {
                try{
                    WriteMessage();
                }
                catch (DivideByZeroException ex) {//   (Exception ex){
                   Console.WriteLine($"Exception caught in Process1: {ex.Message}");
                }
                

            }

            static void WriteMessage()
            {
                double float1 = 3000.0;
                double float2 = 0.0;
                int number1 = 3000;
                int number2 = 0;
                byte smallNumber;

                Console.WriteLine(float1 / float2);
                //Console.WriteLine(number1 / number2);
                checked
                {
                    smallNumber = (byte)number1;
                }
            }            
        }
    }
}