using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject
{
    public class Matriz
    {

//  Arrays (Matriz)
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
// foreach
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
// Comentarios em espaços
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
*/       

    }
}