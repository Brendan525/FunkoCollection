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
        MarvelCollectorsCore,
        SDCC,
        NYCC,
        PX,
        GalacticToys

    }

    public enum Series
    {
        Marvel,
        MarvelBlackLight,
        Marvel80Years,
        DragonBallSuper,
        DragonBallZ,
        BlackPanther,
        IronMan3,
        Preacher,
        DC,
        Venom,

    }

    public enum PopLine
    {
        Pop,
        PopMovies,
        PopHeroes,
        PopAnimation,
        PopRocks,
        Marvel
    }

    public enum Chrome
    {
        Red,
        Blue,
        Purple,
        Orange,
        Green,
        Yellow,
        None
    }

    public class Funko
    {
        private string name;
        private Exclusive store;
        private Series series;
        private PopLine line;
        private bool glowInTheDark;
        private Chrome color;
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

        public Series SeriesName
        {
            get
            {
                return series;
            }
            set
            {
                series = value;
            }
        }

        public PopLine LineName
        {
            get
            {
                return line;
            }
            set
            {
                line = value;
            }
        }

        public bool GlowInTheDark
        {
            get
            {
                return glowInTheDark;
            }
            set
            {
                glowInTheDark = value;
            }
        }

        public Chrome Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
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


        public Funko(string characterName, Series seriesTitle, PopLine lineTitle, Exclusive storeExclusive, bool GITD, Chrome color)
        {
            Name = characterName;
            SeriesName = seriesTitle;
            LineName = lineTitle;
            Store = storeExclusive;
            GlowInTheDark = GITD;
            Color = color;

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

        public static void Search()
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
        }

        //public override string ToString()
        //{
        //    return string.Format("{0,-36}{1,6}", $"{Name}", $"{Store}");
        //}


        public static void AddPopsToList()
        {

            funkoPopList.Add(new Funko("Super Saiyan Rose", Series.DragonBallSuper, PopLine.PopAnimation, Exclusive.HotTopic, false, Chrome.None));
            funkoPopList.Add(new Funko("Super Saiyan Vegeta (Red Chrome)", Series.DragonBallZ, PopLine.PopAnimation, Exclusive.HotTopic, false, Chrome.Red));
            funkoPopList.Add(new Funko("Super Saiyan Vegeta (Blue Chrome)", Series.DragonBallZ, PopLine.PopAnimation, Exclusive.ToyTokyo, false, Chrome.Blue));
            funkoPopList.Add(new Funko("Carnage", Series.Venom, PopLine.Pop, Exclusive.FYE, false, Chrome.None));
            funkoPopList.Add(new Funko("Carnage", Series.Venom, PopLine.Pop, Exclusive.Common, false, Chrome.None));
            funkoPopList.Add(new Funko("Carnage", Series.Venom, PopLine.Pop, Exclusive.NYCC, false, Chrome.None));
            funkoPopList.Add(new Funko("Carnage",Series.Marvel, PopLine.Marvel, Exclusive.HotTopic, false, Chrome.None));
            funkoPopList.Add(new Funko("Anti-Venom", Series.Marvel, PopLine.Marvel, Exclusive.HotTopic, false, Chrome.None));
            funkoPopList.Add(new Funko("Anti-Venom", Series.Marvel, PopLine.Marvel, Exclusive.BoxLunch, true, Chrome.None));
            funkoPopList.Add(new Funko("Iron Man", Series.Marvel, PopLine.Marvel, Exclusive.Common, false, Chrome.None));
            funkoPopList.Add(new Funko("Iron Man", Series.Marvel, PopLine.Marvel, Exclusive.Common, false, Chrome.Red));
            funkoPopList.Add(new Funko("Iron Man", Series.Marvel, PopLine.Marvel, Exclusive.Common, false, Chrome.None));
            funkoPopList.Add(new Funko("Iron Man", Series.Marvel, PopLine.Marvel, Exclusive.Common, false, Chrome.None));
            funkoPopList.Add(new Funko("Iron Man", Series.Marvel, PopLine.Marvel, Exclusive.Common, false, Chrome.None));

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
            funkoPopList.Add(new Funko("Spider-Man (I Love Pi Shirt)", Exclusive.BoxLunch));
            funkoPopList.Add(new Funko("Notorious B.I.G with Crown", Exclusive.FunkoStore));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.)); 
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));
            funkoPopList.Add(new Funko("", Exclusive.));




        }


    }
}