using System;
using System.Collections.Generic;

namespace FunkoCollection
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Funko.AddPopsToList();

            Console.WriteLine("My list of Funko Pops");

            Console.WriteLine("Print or search?");

            string input = Console.ReadLine().ToLower();

            if (input == "print" || input == "p")
            {
                Funko.PrintNumberedList();
            }
            else if (input == "search" || input == "s")
            {
                Console.WriteLine("What Pop are you searching for?");

                string character = Console.ReadLine();

                int index = Funko.funkoPopList.FindIndex(f => f.Name == character);

                if (index > 0 && index < Funko.funkoPopList.Count)
                {
                    Console.WriteLine($"You already have {character}");
                }
                else
                {
                    Console.WriteLine($"You don't have {character}");
                }

                //for (int i = 0; i < Funko.funkoPopList.Count; i++)
                //{
                //    if (character == Funko.funkoPopList[i].Name)
                //    {
                //        Console.WriteLine($"You already have {character}");
                //    }
                //    else if (character != Funko.funkoPopList[i].Name)
                //    {
                //        Console.WriteLine($"You don't have {character}");
                //        break;                       
                //    }
                //}

                //if (character != Funko.funkoPopList.Name)
                //{
                //    Console.WriteLine("You do not have");
                //}



                //}
            }

            //string index = funkoPopList.IndexOf("Iron Man");
            //if (index == -1)
            //{
            //    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            //}
            //else
            //{
            //    Console.WriteLine($"The pop {listOfFunkos[9]} is at index {index}");
            //}






            //public static void WorkingWithFunkos()
            //{
            //    Console.WriteLine("List of Funko Pops");

            //     var listOfFunkos = new List<string> {"Goku", "Vegeta", "Broly", "Dr. Manhattan" };
            //    foreach (var pop in listOfFunkos)
            //    {
            //        Console.WriteLine($"{pop.ToUpper()}"); // Prints list in upper case

            //    }
            //    listOfFunkos.Sort();
            //    listOfFunkos.Add("Super Saiyan Rosè");
            //    listOfFunkos.Add("Super Saiyan Vegeta (Red Chrome)");
            //    listOfFunkos.Add("Super Saiyan Vegeta (Blue Chrome)");
            //    listOfFunkos.Add("Carnage (FYE)");
            //    listOfFunkos.Add("Carnage");
            //    listOfFunkos.Add("Iron Man");
            //    listOfFunkos.Add("Super Saiyan God Super Saiyan Goku");
            //    listOfFunkos.Add("Super Saiyan God Goku");
            //    listOfFunkos.Add("Killmonger");
            //    listOfFunkos.Add("Black Panther (Target GITD)");
            //    listOfFunkos.Add("Moon Knight (LA Comic Con)");
            //    listOfFunkos.Add("Moon Knight");
            //    //listOfFunkos.Remove("Moon Knight");
            //    listOfFunkos.Add("Big Daddy");
            //    listOfFunkos.Add("Miles Morales");
            //    listOfFunkos.Add("Black Bolt");
            //    listOfFunkos.Add("SongBird");
            //    listOfFunkos.Add("The Joker (The Dark Knight Trilogy)");
            //    listOfFunkos.Add("Joker (Banker Robber)");
            //    listOfFunkos.Add("Thanos on Throne (Hot Topic)");
            //    listOfFunkos.Add("Tulip");
            //    listOfFunkos.Add("Cassidy (Hot Topic Bloody");
            //    listOfFunkos.Add("Thanos (Red Chrome Walmart) ");
            //    listOfFunkos.Add("Thanos (Blue Chrome Walmart)");
            //    listOfFunkos.Add("Thanos (Yellow Chrome Walmart)");
            //    listOfFunkos.Add("Thanos (Green Chrome Walmart)");
            //    listOfFunkos.Add("Thanos (Purple Chrome Walmart)");
            //    listOfFunkos.Add("Thanos (Orange Chrome Walmart)");
            //    listOfFunkos.Add("Joker (Death of the Family Hot Topic)");
            //    listOfFunkos.Add("Super Vegeta (Hot Topic");
            //    listOfFunkos.Add("Super Saiyn Future Trunks (Hot Topic)");
            //    listOfFunkos.Add("Arseface");
            //    listOfFunkos.Add("Jessie Custer (GameStop)");
            //    listOfFunkos.Add("Jessie Custer");
            //    listOfFunkos.Add("Elizabeth");
            //    listOfFunkos.Add("Ice Man (Flocked Funko Store");
            //    listOfFunkos.Add("Goku Ultra Instinst");
            //    listOfFunkos.Add("SSGSS Goku (Hot Topic");
            //    listOfFunkos.Add("SSGSS Kamehameha Goku (Chalies Collectibles)");
            //    listOfFunkos.Add("Super Saiyan 3 Goku");
            //    listOfFunkos.Add("Super Saiyan Goku");
            //    listOfFunkos.Add("Super Saiyan Goku (Entertainment Earth GITD)");
            //    listOfFunkos.Add("Great Ape Goku");
            //    listOfFunkos.Add("Logan");
            //    listOfFunkos.Add("Hulk vs HulkBuster (Walgreens");
            //    listOfFunkos.Add("Iron Man vs Whiplash (Marvel Collectors Core)");
            //    listOfFunkos.Add("Venom");
            //    listOfFunkos.Add("Venom (Leathal Protector (Marvel Collectors Core)");
            //    listOfFunkos.Add("Iron Spider with Nano Gaunlet");
            //    listOfFunkos.Add("Iron Spiderman");
            //    listOfFunkos.Add("");
            //    listOfFunkos.Add("");
            //    listOfFunkos.Add("");
            //    listOfFunkos.Add("");
            //    listOfFunkos.Add("");
            //    listOfFunkos.Add("");
            //    listOfFunkos.Add("");
            //    listOfFunkos.Add("");
            //    listOfFunkos.Add("");
            //    listOfFunkos.Add("");
            //    listOfFunkos.Add("");
            //    listOfFunkos.Add("");
            //    listOfFunkos.Add("");

            //    foreach (var pop in listOfFunkos)

            //        Console.WriteLine($"{pop}");

            //    Console.WriteLine($"{listOfFunkos[2]}"); // Reference element in list
            //    Console.WriteLine($"{listOfFunkos[3]}"); // Reference element in list
            //    Console.WriteLine($"{listOfFunkos[13]}"); // Reference element in list

            //    Console.WriteLine($"{listOfFunkos.Count}"); // Counts number of elements in list




            //    // The IndexOf method searches for an item and returns the index of the item. 

            //    //var index = listOfFunkos.IndexOf("Iron Man");
            //    //if (index == -1)
            //    //{
            //    //    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine($"The pop {listOfFunkos[9]} is at index {index}");
            //    //}

            //    //index = listOfFunkos.IndexOf("Not Found");
            //    //if (index == -1)
            //    //{
            //    //    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine($"The pop {listOfFunkos[9]} is at index {index}");
            //    //}

            //    // The Sort method sorts all the items in the list in their normal order (alphabetically in the case of strings). 

            //    listOfFunkos.Sort();
            //    foreach (var pop in listOfFunkos)
            //    {
            //        Console.WriteLine($"{pop.ToUpper()}");
            //    }


            //}
        }
    }
}
