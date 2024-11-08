using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace TestProject
{
    public class Parte3_Logica
    {
        
        public static void Project1(){
            
#region Arrays (Matriz)
            /*
            //string[] fraudulentOrderIDs = new string[3];
            //fraudulentOrderIDs[0] = "A123";
            //fraudulentOrderIDs[1] = "B456";
            //fraudulentOrderIDs[2] = "C789";

            string [] fraudulentOrderIDs = {"A123", "B456", "C789"};

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";
            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
            */
            #endregion

#region foreach
            /*
            //int[] inventory = { 200, 450, 700, 175, 250 };
            //int sum = 0;
            //int bin = 0;
            //foreach (int itens in inventory){
            //    sum += itens;
            //    bin ++;
            //    Console.WriteLine($"Bin {bin} = {itens} items (Running total: {sum})");
            //}
            //Console.WriteLine($"We have {sum} items in inventory.");

            string [] FraudesId = {"B123", "C234", "A345", "C15", "B177","G3003","C235","B179"};
            foreach (var item in FraudesId){
                if(item.StartsWith("B")){
                    Console.WriteLine(item);
                }
                
            }
            */
#endregion

#region Comentarios em espaços
            /* 
            // The following code creates five random OrderIDs
            // to test the fraud detection process.  OrderIDs 
            // consist of a letter from A to E, and a three
            // digit number. Ex. A123.
            
            Random random = new Random();   
            string[] orderIDs = new string[5];
            for (int i = 0; i < orderIDs.Length; i++){
                int prefixValue = random.Next(65, 70); // ASCII A to E
                string prefix = Convert.ToChar(prefixValue).ToString();
                string suffix = random.Next(1, 1000).ToString("000"); // 3 digit number
                orderIDs[i] = prefix + suffix;
            }
            foreach (var orderID in orderIDs){
                Console.WriteLine(orderID);
            }

            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
                if ((roll1 == roll2) && (roll2 == roll3)) {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6; 
            } 
                else {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }
            }
            //  desafio melhorar o entendimento do código
            
            //   O código abaixo pega uma mensagem, transnforma em array de caracteres para inver a mensagem
            //   Ai final exibe a mensagem invertida e a quantidade de vezes que o caracter escolhido aparece 
            
            Console.WriteLine("\n\n");

            string str = "The quick brown fox jumps over the lazy dog.";

            char[] charMessage = str.ToCharArray();
            Array.Reverse(charMessage);

            int x = 0;

            foreach (char i in charMessage) {
                if (i == 'o') {
                    x++; 
                }
            }

            string new_message = new String(charMessage);

            Console.WriteLine(new_message);
            Console.WriteLine($"'o' appears {x} times.");


            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");
            */
#endregion

#region Condicional IF
            /*
                        string permission = "Admin|Manager";
                        Random random1 = new Random();

                        int level = 0;

                        for (int i = 0; i < 5; i++ ){
                            level = random1.Next(1,100);

                            if (permission.Contains("Admin")){
                                if (level > 55){
                                    Console.WriteLine("Welcome, Super Admin user.");
                                }else {
                                    Console.WriteLine("Welcome, Admin user.");
                                }
                            }else if (permission.Contains("Manager")){
                                if (level >= 20){
                                    Console.WriteLine("Contact an Admin for access.");
                                }else {
                                    Console.WriteLine("You do not have sufficient privileges.");
                                }
                            }else{
                                Console.WriteLine("You do not have sufficient privileges.");
                            }
                        }

                    */
#endregion

#region bloco código
            /*
                        bool flag = true;
                        int value = 5;
                        if (flag){
                            int value1 = 6;
                            value += value1;
            //                Console.WriteLine($"Inside of code block: {value}");
                        }
                        Console.WriteLine($"Outside of code block: {value}");
            */
            //  ifr sem chaves (somente condição verdadeira)
            /*            

                        Console.WriteLine();
                        Console.WriteLine();

                        string name = "steve";
                        if (name == "bob") Console.WriteLine("Found Bob");
                        else if (name == "steve") Console.WriteLine("Found Steve");
                        else Console.WriteLine("Found Chuck");
            */
#endregion

#region desafio
            /*
                        int[] numbers = { 4, 8, 15, 16, 23, 42 };

                        int total = 0;
                        bool found = true;

                        foreach (int number in numbers){
            //                int total;
                            total += number;

                            if (number == 42){
            //                    bool found = true;
                                found = true;
                            }
                        }

                        if (found){
                            Console.WriteLine("Set contains 42");
                        }
                        Console.WriteLine($"Total: {total}");
            */
#endregion

#region switch exemplo
            /*
                        int employeeLevel = 201;
                        string employeeName = "John Smith";

                        string title = "";

                        switch (employeeLevel){
                            case 100:
                                title = "Junior Associate";
                                break;
                            case 200:
                                title = "Senior Associate";
                                break;
                            case 300:
                                title = "Manager";
                                break;
                            case 400:
                                title = "Senior Manager";
                                break;
                            default:
                                title = "Associate";
                                break;
                        }

                        Console.WriteLine($"{employeeName}, {title}");
            */
#endregion

#region desafio switch
            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>
            /*
                        string sku = "01-MN-L";

                        string[] product = sku.Split('-');

                        string type = "";
                        string color = "";
                        string size = "";

                        switch (product[0]){
                            case "01":
                                type = "Sweat shirt";
                                break;
                            case "02":
                                type = "T-Shirt";
                                break;
                            case "03":
                                type = "Sweat pants";
                                break;
                            default:
                                type = "Other";
                                break;
                        }
                        switch (product[1]){
                            case "BL":
                                color = "Black";
                                break;
                            case "MN":
                                color = "Maroon";
                                break;
                            default:
                                color = "White";
                                break;
                        }
                        switch (product[2]){
                            case "S":
                                size = "Small";
                                break;
                            case "M":
                                size = "Medium";
                                break;
                            case "L":
                                size = "Large";
                                break;
                            default:
                                size = "One Size Fits All";
                                break;
                        }
                        Console.WriteLine($"Product: {size} {color} {type}");
            */
#endregion

#region Uso for
            /*
                        string[] names = { "Alex", "Eddie", "David", "Michael" };
                        for (int i = names.Length - 1; i >= 0; i--)
                        {
                            if (names[i] == "David") names[i] = "Pedro Bó";
                            Console.WriteLine(names[i]);
                        }

                        Console.WriteLine();
                        for (int i = 1; i <= 100; i++){
                            if ((i % 3 == 0) && (i % 5 == 0)) Console.WriteLine($"{i} - FizzBuzz");
                            else if (i % 3 == 0) Console.WriteLine($"{i} - Fizz");
                                else if (i % 5 == 0) Console.WriteLine($"{i} - Buzz");
                                else    Console.WriteLine(i);
                                
                        } 
            */
#endregion

#region Uso do-While
            Random random = new Random();
            int current = 0;
            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);

            System.Console.WriteLine();
            current = random.Next(1,11);

            while (current > 3)
            {
                Console.WriteLine(current);
                current = random.Next(1,11);
            }
            System.Console.WriteLine($"Ultimo número: {current}");

            System.Console.WriteLine();
            current = random.Next(1,11);
            do
            {
                current = random.Next(1, 11);
                if (current >= 8) continue; 
                System.Console.WriteLine(current);
            } while (current != 7);


#endregion


        }
    }
}
