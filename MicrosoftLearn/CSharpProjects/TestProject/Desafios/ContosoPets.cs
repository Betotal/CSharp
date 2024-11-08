using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml;

namespace TestProject.Desafios
{
    public class ContosoPetsDesafio
    {
        public static void ContostoPetsD()
        {
            // the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";

            // variables that support data entry
            int maxPets = 8;
            string readResult;
            string menuSelection = "";

            // array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 6];

            int petCount = 0;
            int newAge;
            string? newFeature;

            // TODO: Convert the if-elseif-else construct to a switch statement

            // create some initial ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "loki";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "Puss";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "?";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;

                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;
                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

            }

            // display the top-level menu options
            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. Listar todas as informações atuais sobre animais de estimação.");
                Console.WriteLine(" 2. Atribuir valores aos campos da matriz ourAnimals.");
                Console.WriteLine(" 3. Verificar se os dados de idade e descrição física dos animais estão completos.");
                Console.WriteLine(" 4. Verificar se os dados de apelido e descrição de personalidade dos animais estão completos.");
                Console.WriteLine(" 5. Editar a idade do animal.");
                Console.WriteLine(" 6. Editar a descrição de personalidade do animal.");
                Console.WriteLine(" 7. Exibir todos os gatos com uma característica especificada.");
                Console.WriteLine(" 8. Exibir todos os cães com uma característica especificada.");
                Console.WriteLine();
                Console.WriteLine("Entre na seleção de item de menu ou digite 'Sair' para sair do programa");

                readResult = Console.ReadLine();
                if (readResult != null){
                    for (int i = 0; i < maxPets; i++){
                        if (ourAnimals[i, 0] != "ID #: "){
                            petCount += 1;
                        }
                    }

                    menuSelection = readResult.ToLower();
                }

                //    Console.WriteLine($"You selected menu option {menuSelection}.");
                //    Console.WriteLine("Press the Enter key to continue");

                //    // pause code execution
                //    readResult = Console.ReadLine();

                switch (menuSelection)
                {
                    case "1": // List all of our current pet information
                        for (int k = 0; k < maxPets; k++)
                        {
                            if (ourAnimals[k, 0] != "ID #: ")
                            {
                                //    Console.WriteLine(ourAnimals[i,0]);
                                Console.WriteLine();
                                for (int j = 0; j < 6; j++)
                                {
                                    Console.WriteLine(ourAnimals[k, j]);
                                }
                            }
                        }
                        //    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "2": // Add a new animal friend to the ourAnimals array
                        string anotherPet = "y";
                        if (petCount < maxPets)
                        {
                            Console.WriteLine($"Atualmente temos {petCount} pets que precisam de casa. Nós podemos administrar mais {(maxPets - petCount)}.");
                        }
                        while ((anotherPet == "y" || anotherPet == "Y") && petCount < maxPets)
                        {
                            bool validEntry = false;
                            do
                            {    // get species (cat or dog) - string animalSpecies is a required field 
                                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalSpecies = readResult.ToLower();
                                }
                                if (animalSpecies != "dog" && animalSpecies != "cat")
                                {
                                    validEntry = false;
                                }
                                else
                                {
                                    validEntry = true;
                                }

                            } while (validEntry == false);
                            // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                            animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
                            do
                            {
                                int petAge;
                                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalAge = readResult;
                                    if (animalAge != "?")
                                    {
                                        validEntry = int.TryParse(animalAge, out petAge);
                                    }
                                    else
                                    {
                                        validEntry = true;
                                    }
                                }
                            } while (validEntry == false);

                            // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                            do
                            {
                                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalPhysicalDescription = readResult.ToLower();
                                    if (animalPhysicalDescription == "")
                                    {
                                        animalPhysicalDescription = "tbd";
                                    }
                                }
                            } while (animalPhysicalDescription == "");

                            // get a description of the pet's personality - animalPersonalityDescription can be blank.
                            do
                            {
                                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalPersonalityDescription = readResult.ToLower();
                                    if (animalPersonalityDescription == "")
                                    {
                                        animalPersonalityDescription = "tbd";
                                    }
                                }
                            } while (animalPersonalityDescription == "");

                            // get the pet's nickname. animalNickname can be blank.
                            do
                            {
                                Console.WriteLine("Enter a nickname for the pet");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalNickname = readResult.ToLower();
                                    if (animalNickname == "")
                                    {
                                        animalNickname = "tbd";
                                    }
                                }
                            } while (animalNickname == "");

                            // store the pet information in the ourAnimals array (zero based)
                            ourAnimals[petCount, 0] = "ID #: " + animalID;
                            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                            ourAnimals[petCount, 2] = "Age: " + animalAge;
                            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                            petCount++; // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                            if (petCount < maxPets)
                            { // check maxPet limit
                                // another pet?
                                Console.WriteLine("Do you want to enter info for another pet (y/n)");
                                do
                                {
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        anotherPet = readResult.ToLower();
                                    }
                                } while (anotherPet != "y" && anotherPet != "n");
                            }

                        }
                        if (petCount >= maxPets)
                        {
                            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                        }
                        break;

                    case "3": // Ensure animal ages and physical descriptions are complete
                    //    Console.WriteLine("Challenge Project - please check back soon to see progress.");
                        for (int k = 0; k < petCount; k++){
                            int.TryParse(ourAnimals[k, 2].Substring(5).ToString(), out newAge);
                            if (newAge == 0){
                                do
                                {
                                    Console.Write($"Por favor informar a Idade do Animal {ourAnimals[k,0]}: ");
                                    int.TryParse(Console.ReadLine(), out newAge);
                                    if (newAge != 0){
                                        Console.Write($"Confirma alteração da idade para {newAge} (S/N): ");
                                        readResult = ValidaResposta();

                                        if (readResult == "s"){
                                            ourAnimals[k, 2] = "Age: " + newAge;
                                        } else {
                                            newAge = 0;
                                        }
                                    } 
                                    else{
                                        Console.WriteLine("Valor inválido para Idade.");
                                        newAge = 0;
                                    }
                                    
                                } while (newAge == 0);
                            }
                            if (ourAnimals[k, 4] == "Physical description: "){
                                do
                                {
                                    Console.Write($"Por favor informar as caracteristicas do Animal {ourAnimals[k,0]}: ");
                                    animalPhysicalDescription = Console.ReadLine();
                                    Console.Write($"Confirma alteração das caracteristicas para \"{animalPhysicalDescription}\" (S/N): ");
                                    readResult = ValidaResposta();

                                    if (readResult == "s"){
                                        ourAnimals[k, 4] = "Physical description: " + animalPhysicalDescription;
                                    }
                               } while (ourAnimals[k, 4] == "Physical description: ");
                            }
                        }
                        Console.WriteLine("Idade e\\ou caracteristiscas forma alteradas completadas para todos os animais.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "4":
                //        Console.WriteLine("Challenge Project - please check back soon to see progress.");
                        for (int k = 0; k < petCount; k++){
                            if (ourAnimals[k, 3] == "Nickname: "){
                                do
                                {
                                    Console.Write($"Por favor informar o apelido do Animal {ourAnimals[k,0]}: ");
                                    animalNickname = Console.ReadLine();
                                    Console.Write($"Confirma alteração do Apelido para \"{animalNickname}\" (S/N): ");
                                    readResult = ValidaResposta();

                                    if (readResult == "s"){
                                        ourAnimals[k, 3] = "Nickname: " + animalNickname;

                                    }
                               } while (ourAnimals[k, 3] == "Nickname: ");
                            }

                            if (ourAnimals[k, 5] == "Personality: "){
                                do
                                {
                                    Console.Write($"Por favor informar o Personalidade do Animal {ourAnimals[k,0]}: ");
                                    animalPersonalityDescription = Console.ReadLine();
                                    Console.Write($"Confirma alteração da personalidade para \"{animalPersonalityDescription}\" (S/N): ");
                                    readResult = ValidaResposta();

                                    if (readResult == "s"){
                                        ourAnimals[k, 5] = "Personality: " + animalPersonalityDescription;

                                    }
                               } while (ourAnimals[k, 5] == "Personality: ");
                            }

                        }
                        Console.WriteLine("Apelido e Personalidade de todos os animais preenchidas.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "5":
                    //    Console.WriteLine("UNDER CONSTRUCTION - please check back next monthto see progress.");
                        for (int k = 0; k < petCount; k++)
                        {
                            if (ourAnimals[k, 0] != "ID #: ")
                            {
                                Console.WriteLine($"Animal disponível para Alteração: {ourAnimals[k, 0]} - {ourAnimals[k, 1]}");
                            }
                        }
                        int i = 0;
                        do
                        { 
                            Console.Write("Por favor informe o ID #: ");
                            readResult = "ID #: " + Console.ReadLine();
                            while ((readResult != ourAnimals[i, 0]) || i > petCount){
                                i++;
                            }
                            newAge = 0;
                            if ((i + 1) <= petCount)
                            {
                                Console.WriteLine($"Idade atual: {ourAnimals[i, 2]}");
                                Console.Write("Informe a idade correta: ");
                                newAge = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"Confirma alteração da idade para {newAge} (S/N? ");
                                readResult = ValidaResposta();

                                if (readResult == "s")
                                {
                                    ourAnimals[i, 2] = "Age: " + newAge;
                                    Console.WriteLine("Dados gravados com sucesso.");
                                    Console.WriteLine();
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.WriteLine(ourAnimals[i, j]);
                                    }
                                }
                            }
                        } while (ourAnimals[i, 0] == "ID #: ");

                        Console.WriteLine();
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "6":
                    //    Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        petCount = 0;
                        for (i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                petCount += 1;
                            }
                        }
                        for (i = 0; i < petCount; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                Console.WriteLine($"Animal disponível para Alteração: {ourAnimals[i, 0]} - {ourAnimals[i, 1]}");
                            }
                        }
                        do
                        {
                            i = 0;
                            Console.Write("Por favor informe o ID #: ");
                            readResult = "ID #: " + Console.ReadLine();
                            while ((readResult != ourAnimals[i, 0]) || i > petCount)
                            {
                                i++;
                            }
                            if ((i + 1) <= petCount)
                            {
                                Console.WriteLine($"Caracteristicas atuais: {ourAnimals[i, 3]}");
                                do{
                                    Console.Write("Digite as novas caracteristicas: ");
                                    animalPhysicalDescription = Console.ReadLine();
                                }while(animalPhysicalDescription == "" || animalPhysicalDescription.Length < 3);

                                Console.Write($"Confirma alteração das carasteristicas para {animalPhysicalDescription} (S/N? ");
                                readResult = ValidaResposta();
 
                                if (readResult == "s")
                                {
                                    ourAnimals[i,3] = "Physical description: " + animalPhysicalDescription;
                                    Console.WriteLine("Dados gravados com sucesso.");
                                    Console.WriteLine();
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.WriteLine(ourAnimals[i, j]);
                                    }
                                }
                            }
                        } while (ourAnimals[i, 0] == "ID #: ");

                        Console.WriteLine();
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "7":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "8":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    default:
                        break;

                }


            } while (menuSelection != "exit");

        }
        public static string ValidaResposta(){
            string readResult;
            do{
                readResult = Console.ReadLine();
                if (readResult != null){
                    readResult = readResult.ToLower();
                }
            } while (readResult != "s" && readResult != "n");
            return readResult;
                
        }

    }
}