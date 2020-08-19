using System;
using System.Collections.Generic;
using System.Collections;

namespace FunkoCollection
{
    public enum Exclusive
    {
        Common,
        HotTopic,
        BoxLunch,
        Walmart,
        ToyTokyo,
        Target,
        Walgreens,
        FYE,
        ChaliesCollectibles,
        Gamestop,
        EntertainmentEarth,
        Amazon,
        Funimantion,
        LAComicCon,
        FunkoStore,
        MarvelCollectorsCore

    }

    public class Funko
    {
        private string name;
        private Exclusive store;
        //private bool valuted;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Exclusive Store
        {
            get
            {
                return store;
            }
            set
            {
                store = value;
            }
        }

        //public bool Valuted
        //{
        //    get
        //    {
        //        return valuted;
        //    }
        //    set
        //    {
        //        valuted = value;
        //    }
        //}


        public static List<Funko> funkoPopList = new List<Funko>();


        public Funko(string characterName, Exclusive storeExclusive)
        {
            Name = characterName;
            Store = storeExclusive;
            //this.Valuted = Valuted;
        }


        public static void AddPop(Funko character)
        {
            funkoPopList.Add(character);
        }

        public static void RemovePop(Funko character)
        {
            funkoPopList.Remove(character);
        }


        public static void PrintList()
        {
            funkoPopList.Sort();

            foreach (Funko pop in funkoPopList)
            {

                if (pop.Store == Exclusive.Common)
                {
                    Console.WriteLine($"{pop.Name} is a common");
                }
                else
                {
                    Console.WriteLine($"{pop.Name} is a {pop.Store} exclusive");
                }
            }
        }


        public static void PrintNumberedList()
        {
            for (int i = 0; i < funkoPopList.Count; i++)
            {
                Console.WriteLine($"{i + 1 + ".",-4 } {funkoPopList[i].Name.ToUpper()} {funkoPopList[i].Store}");
            }
        }

        //public override string ToString()
        //{
        //    return string.Format("{0,-36}{1,6}", $"{Name}", $"{Store}");
        //}


        public static void AddPopsToList()
        {

            funkoPopList.Add(new Funko("Super Saiyan Rose", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("Super Saiyan Vegeta (Red Chrome)", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("Super Saiyan Vegeta (Blue Chrome)", Exclusive.ToyTokyo));
            funkoPopList.Add(new Funko("Carnage", Exclusive.FYE));
            funkoPopList.Add(new Funko("Carnage", Exclusive.Common));
            funkoPopList.Add(new Funko("Iron Man", Exclusive.Common));
            funkoPopList.Add(new Funko("Super Saiyan God Goku", Exclusive.Funimantion));
            funkoPopList.Add(new Funko("Super Saiyan God Super Saiyan Goku", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("Killmonger", Exclusive.Common));
            funkoPopList.Add(new Funko("Killmonger (Mask)", Exclusive.Common));
            funkoPopList.Add(new Funko("Black Panther (GITD)", Exclusive.Target));
            funkoPopList.Add(new Funko("Moon Knight (LA Comic Con)", Exclusive.LAComicCon));
            funkoPopList.Add(new Funko("Moon Knight", Exclusive.Walgreens));
            //funkoPopList.Remove("Moon Knight");
            funkoPopList.Add(new Funko("Big Daddy", Exclusive.Common));
            funkoPopList.Add(new Funko("Miles Morales", Exclusive.Common));
            funkoPopList.Add(new Funko("Black Bolt", Exclusive.Common));
            funkoPopList.Add(new Funko("SongBird", Exclusive.Common));
            funkoPopList.Add(new Funko("The Joker (The Dark Knight Trilogy)", Exclusive.Common));
            funkoPopList.Add(new Funko("Thanos on Throne", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("Joker (Banker Robber)", Exclusive.Common));
            funkoPopList.Add(new Funko("Tulip", Exclusive.Common));
            funkoPopList.Add(new Funko("Cassidy (Bloody)", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("Thanos (Red Chrome)", Exclusive.Walmart));
            funkoPopList.Add(new Funko("Thanos (Blue Chrome)", Exclusive.Walmart));
            funkoPopList.Add(new Funko("Thanos (Yellow Chrome)", Exclusive.Walmart));
            funkoPopList.Add(new Funko("Thanos (Green Chrome)", Exclusive.Walmart));
            funkoPopList.Add(new Funko("Thanos (Purple Chrome)", Exclusive.Walmart));
            funkoPopList.Add(new Funko("Thanos (Orange Chrome)", Exclusive.Walmart));
            funkoPopList.Add(new Funko("Joker (Death of the Family)", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("Joker (Death of the Family GITD)", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("Super Vegeta", Exclusive.Target));
            funkoPopList.Add(new Funko("Super Saiyan Future Trunks", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("Arseface", Exclusive.Common));
            funkoPopList.Add(new Funko("Jessie Custer (Arms Out)", Exclusive.Gamestop));
            funkoPopList.Add(new Funko("Jessie Custer", Exclusive.Common));
            funkoPopList.Add(new Funko("Elizabeth", Exclusive.Common));
            funkoPopList.Add(new Funko("Ice Man (Flocked)", Exclusive.FunkoStore));
            funkoPopList.Add(new Funko("Goku Ultra Instinst", Exclusive.Common));
            funkoPopList.Add(new Funko("SSGSS Goku", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("SSGSS Kamehameha Goku", Exclusive.ChaliesCollectibles));
            funkoPopList.Add(new Funko("Super Saiyan 3 Goku", Exclusive.Gamestop));
            funkoPopList.Add(new Funko("Super Saiyan Goku", Exclusive.Common));
            funkoPopList.Add(new Funko("Super Saiyan Goku (GITD)", Exclusive.EntertainmentEarth));
            funkoPopList.Add(new Funko("Logan", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("Great Ape Goku", Exclusive.EntertainmentEarth));
            funkoPopList.Add(new Funko("Hulk vs HulkBuster", Exclusive.Walgreens));
            funkoPopList.Add(new Funko("Iron Man vs Whiplash", Exclusive.MarvelCollectorsCore));
            funkoPopList.Add(new Funko("Venom", Exclusive.Common));
            funkoPopList.Add(new Funko("Venom (Leathal Protector)", Exclusive.MarvelCollectorsCore));
            funkoPopList.Add(new Funko("Iron Spider with Nano Gaunlet", Exclusive.Common));
            funkoPopList.Add(new Funko("Iron Spiderman", Exclusive.Walgreens));
        }

        // The IndexOf method searches for an item and returns the index of the item. 

        //string index = funkoPopList.IndexOf("Iron Man");
        //if (index == -1)
        //{
        //    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
        //}
        //else
        //{
        //    Console.WriteLine($"The pop {listOfFunkos[9]} is at index {index}");
        //}

    }
}