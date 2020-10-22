using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//use yes/no loop to go to birthplace and food
namespace Lab8
{
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput = GetUserInput("Welcome to our class of world leaders. Which leader would you like to learn more about? Press any key to continue.");

            //int[] numbersOfLeaders = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            string[] namesOfLeaders = new string[] { "Napoleon Bonaparte", "Julius Caesar", "Mikhail Gorbachev", "Constantine The Great", "Attila The Hun", "Xerxes I", "John F. Kennedy", "Agamemnon", "Hannibal", "King David", "Charlemagne", "Trent Reznor", "Ian MacKaye", "Sir William Wallace" };
            namesOfLeaders[0] = "Napoleon Bonaparte";
            namesOfLeaders[1] = "Julius Caesar";
            namesOfLeaders[2] = "Mikhail Gorbachev";
            namesOfLeaders[3] = "Constantine the Great";
            namesOfLeaders[4] = "Attila the Hun";
            namesOfLeaders[5] = "Xerxes I";
            namesOfLeaders[6] = "John F Kennedy";
            namesOfLeaders[7] = "Agamemnon";
            namesOfLeaders[8] = "Hannibal";
            namesOfLeaders[9] = "King David";
            namesOfLeaders[10] = "Charlemagne";
            namesOfLeaders[11] = "Trent Reznor";
            namesOfLeaders[12] = "Ian MacKaye";
            namesOfLeaders[13] = "William Wallace";

            string[] locations = new string[] { "Ajaccio, France", "Rome, Italy", "Privolnoye, Russia", "Naissus, Dacia Mediterranea (now Niš, Serbia)", "Pannonia, Hungary", "Persia", "Brookline, Massachussetts", "Mykene - Hellas, Greece", "Carthage, Tunisia", "Bethlehem, Israel", "Aachen, Germany", "New Castle, Pennsylvania", "Washington D.C.", "Eldersie, Scotland" };
            locations[0] = "Ajaccio, France";
            locations[1] = "Rome, Italy";
            locations[2] = "Privolnoye, Russia";
            locations[3] = "Naissus, Dacia Mediterranea (now Niš, Serbia)";
            locations[4] = "Pannonia, Hungary";
            locations[5] = "Persia";
            locations[6] = "Brookline, Massachussetts";
            locations[7] = "Mykene - Hellas, Greece";
            locations[8] = "Carthage, Tunisia";
            locations[9] = "Bethlehem, Israel";
            locations[10] = "Aachen, Germany";
            locations[11] = "New Castle, Pennsylvania";
            locations[12] = "Washington D.C.";
            locations[13] = "Eldersie, Scotland";

            string[] knownFor = new string[] { "Emperor of France", "Emperor of Rome", "President of the Soviet Union", "Holy Roman Emperor", "Flagellum Dei", "Emperor of Persia", "35th President of the USA", "King of Mycenae", "General of Carthage", "King of Israel", "Holy Roman Emperor", "Nine Inch Nails", "Fugazi", "Knight of Scotland" };
            knownFor[0] = "Emperor of France";
            knownFor[1] = "Emperor of Rome";
            knownFor[2] = "President of the Soviet Union";
            knownFor[3] = "Holy Roman Emperor";
            knownFor[4] = "Flagellum Dei";
            knownFor[5] = "Emperor of Persia";
            knownFor[6] = "35th President of the USA";
            knownFor[7] = "King of Mycenae";
            knownFor[8] = "General of Carthage";
            knownFor[9] = "King of Israel";
            knownFor[10] = "Holy Roman Emperor";
            knownFor[11] = "Nine Inch Nails";
            knownFor[12] = "Fugazi";
            knownFor[13] = "Knight of Scotland";


            for (int i = 0; i < namesOfLeaders.Length; i++)
            {
                string element = namesOfLeaders[i];
                Console.WriteLine("{0} {1}", Convert.ToString(i), element);

            }
            Console.WriteLine();

            //index for world leader ID 
            bool isValid = false;
            while (true)
            {
                while (true)
                {
                    int index=-1;

                    while (isValid == false)
                    {
                        try
                        {
                            index = int.Parse(GetUserInput("Which leader would you like to learn about today? Enter their requisite number."));

                            Console.WriteLine($"Thank you. {index} is {namesOfLeaders[index - 1]}");

                            isValid = true;
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid Number. Try again!");
                            isValid = false;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Not in the range. Please select a number between 1-14");
                            isValid = false;
                        }
                    }              

                    for (int i = 0; i < namesOfLeaders.Length; i++)
                    {
                        /*  if namesofLeaders[i] == userNumber;
                          {
                              return i
                          } */
                    }

                    /* if (userNumber <= 13)
                     { 
                     } */
                    //for (int i=0; i<14; i++ )

                    bool validNumber = ValidateIndex(Convert.ToString(index));
                    if (validNumber == true)
                    {

                        string yesNo = GetUserInput("Would you like to know their birthplace? y/n");
                        if (yesNo == "y")
                        {
                            Console.WriteLine($"Thank you. {index} is {locations[index - 1]}");
                        }
                        else
                        {
                            break;
                        }

                        string yesNo1 = GetUserInput("Would you like to know what they are known for? y/n");
                        if (yesNo1 == "y")
                        {
                            Console.WriteLine($"Thank you. {index} is {knownFor[index - 1]}");

                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }

                string yesNo3 = GetUserInput("Would you like to learn about someone else? y/n");
                if (yesNo3 != "y")
                {
                    Console.WriteLine("Have a nice day.");
                    break;
                }     
            }
        }
        public static bool ValidateIndex(string index)
        {
            Regex d = new Regex(@"([1-9]{1,2})$");
            if (d.IsMatch(index))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Something()
        {
            int index = -1;

            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("Enter Number:");
                isValid = !int.TryParse(Console.ReadLine(), out index);

                if(isValid == true)
                {
                    if(index < 0)
                    {
                        isValid = false;
                    }
                }

                if (isValid == false)
                {
                    Console.WriteLine("You suck");                   
                }
            }

            return index;
        }





        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();
            return response;
        }

    }
}


