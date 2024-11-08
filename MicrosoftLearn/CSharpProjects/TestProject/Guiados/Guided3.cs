using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Guided
{
    public class Guided3
    {
       public static void Project1(){ 
            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int sophia1 = 90;
            int sophia2 = 86;
            int sophia3 = 87;
            int sophia4 = 98;
            int sophia5 = 100;

            int andrew1 = 92;
            int andrew2 = 89;
            int andrew3 = 81;
            int andrew4 = 96;
            int andrew5 = 90;

            int emma1 = 90;
            int emma2 = 85;
            int emma3 = 87;
            int emma4 = 98;
            int emma5 = 68;

            int logan1 = 90;
            int logan2 = 95;
            int logan3 = 87;
            int logan4 = 88;
            int logan5 = 96;

            Console.WriteLine("currentAssignments = " + currentAssignments);
            Console.WriteLine("Sophia \t Andrew \t Emma \t Logan" );
            Console.WriteLine($"{sophia1} \t {andrew1} \t {emma1} \t {logan1}" );
            Console.WriteLine($"{sophia2} \t {andrew2} \t {emma2} \t {logan2}" );
            Console.WriteLine($"{sophia3} \t {andrew3} \t {emma3} \t {logan3}" );
            Console.WriteLine($"{sophia4} \t {andrew4} \t {emma4} \t {logan4}" );
            Console.WriteLine($"{sophia5} \t {andrew5} \t {emma5} \t {logan5}" );
       }
    }
}