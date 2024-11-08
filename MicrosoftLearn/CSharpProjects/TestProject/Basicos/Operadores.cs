// See https://aka.ms/new-console-template for more information

/*
**********    OPERADOR DE IGUALDADE **********

Console.WriteLine("Hello, C#!");
Console.WriteLine();

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
Console.WriteLine();

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
Console.WriteLine();

// **********    OPERADOR DE DESIGUALDADE **********
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

// **********    OPERADOR DE COMPARAÇÃO **********
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

// **********    OPERADOR DE COMPARAÇÃO (contains)  **********
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
Console.WriteLine();

// **********    OPERADOR DE negação (contains)  **********
pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

// **********    OPERADOR CONDICIONAL  **********
Console.WriteLine();
Console.WriteLine ("Valor de Venda: $1001. Se > 1000, desconto de $100. Se não $50");
Console.WriteLine("OPERADOR CONDICIONAL");
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
Console.WriteLine();Console.WriteLine();
// **********    OPERADOR CONDICIONAL IMBUTIDO  **********
Console.WriteLine("OPERADOR CONDICIONAL IMBUTIDO");
//int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Console.WriteLine();
Console.WriteLine("Lançar a Moeda e determinar se foi Cara ou Coroa");
Random moedaR = new Random();
int moeda = moedaR.Next();
Console.WriteLine($"Moeda: {moeda} : {(moeda % 2 == 1 ? "Cara" : "Coroa")}");

/*

int moeda = 0;
int cara = 0;
int coroa = 0;
var resposta = "";
do while(resposta != "Y"){
    Console.Write("Deseja fazer o lançamento da moeda?");
    resposta = Console.ReadLine().ToUpper();
    if(resposta == resposta.ToUpper()){`
       moeda = Random()
       Console.ReadLine($ "Moeda: {(moeda == 1?  )}" console moeda == 1 ? )
       moeda = Random();
    }




           }
};
*/