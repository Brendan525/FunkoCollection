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
        GalacticToys,
        AAA,
        Over9000,
        RICC,

    }

    public enum Series
    {
        Marvel,
        MarvelBlackLight,
        Marvel80Years,
        MarvelStudiosTheFirstTenYears,
        DragonBallSuper,
        DragonBallZ,
        BlackPanther,
        IronMan3,
        Preacher,
        DC,
        Venom,
        AvengersInfinityWar,
        AvengersEndGame,
        CaptainAmericaCivilWar,
        AvengersAgeOfUltron,
        DragonBallZResurrectionF,
        AvengersAssemble,
        Bioshock,
        BioshockInfinite,
        SpiderManIntoTheSpiderverse,
        TheAmazingSpiderMan,
        TheAmazingSpiderMan2,
        SpiderMan,


    }

    public enum PopLine
    {
        Pop,
        PopMovies,
        PopHeroes,
        PopAnimation,
        PopRocks,
        Marvel,
        Games,
    }

    public enum Chrome
    {
        Red,
        Blue,
        Gold,
        Purple,
        Orange,
        Green,
        Yellow,
        None
    }

    public enum MomentType
    {
        ComicMoment,
        MovieMoment,
        None
    }

    //public enum Variant
    //{
    //    GlowInTheDark,
    //    Metallic,
    //    Flocked,
    //    MovieMoment,
    //    Sepia,
    //    Inch6,
    //    Inch10,
    //    BlackAndWhite,
    //    Scented,
    //    Rides,
    //    Translucent,
        
    //}

    public class Funko
    {
        private string name;
        private Exclusive store;
        private Series series;
        private PopLine line;
        //private Variant variant;
        private int popLineNumber;
        private bool glowInTheDark;
        private Chrome color;
        private bool metallic;
        private bool chase;
        private  MomentType moment;
        private int quantity;
        private bool flocked;
        private int year;
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

        public int PopLineNumber
        {
            get
            {
                return popLineNumber;
            }
            set
            {
                popLineNumber = value;
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

        public bool Chase
        {
            get
            {
                return chase;
            }
            set
            {
                chase = value;
            }
        }

        public MomentType Moment
        {
            get
            {
                return moment;
            }
            set
            {
                moment = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public bool Metallic
        {
            get
            {
                return metallic;
            }
            set
            {
                metallic = value;
            }
        }

        public bool Flocked
        {
            get
            {
                return flocked;
            }
            set
            {
                flocked = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        //public Variant Variant
        //{
        //    get
        //    {
        //        return Variant;
        //    }
        //    set
        //    {
        //        variant =
        //    }
        //}
          

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


        public Funko(string characterName, Series seriesTitle, PopLine lineTitle, int thePopLineNumber, Exclusive storeExclusive, MomentType theMoment, bool GITD, Chrome theColor, bool isMetallic, bool isFlocked, bool isChase, int theQuantity, int releaseYear)
        {
            Name = characterName;
            SeriesName = seriesTitle;
            LineName = lineTitle;
            PopLineNumber = thePopLineNumber;
            Store = storeExclusive;
            Moment = theMoment;
            GlowInTheDark = GITD;
            Color = theColor;
            Metallic = isMetallic;
            Flocked = isFlocked;
            Chase = isChase;
            Moment = theMoment;
            Quantity = theQuantity;
            Year = releaseYear;
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
                Console.WriteLine();

                Console.WriteLine($"{i + 1 + ".",-4 } Character: {funkoPopList[i].Name}, Series: {funkoPopList[i].SeriesName}, PopLine: {funkoPopList[i].LineName}, Number: {funkoPopList[i].PopLineNumber}, Exclusive to {funkoPopList[i].Store}");

                Console.WriteLine();
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

            funkoPopList.Add(new Funko("Super Saiyan Rose", Series.DragonBallSuper, PopLine.PopAnimation, 260, Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 1, 2017));
            funkoPopList.Add(new Funko("Super Saiyan Vegeta", Series.DragonBallZ, PopLine.PopAnimation, 154, Exclusive.HotTopic, MomentType.None, false, Chrome.Red, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Super Saiyan Vegeta", Series.DragonBallZ, PopLine.PopAnimation, 154, Exclusive.ToyTokyo, MomentType.None, false, Chrome.Blue, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Super Saiyan Vegeta", Series.DragonBallZ, PopLine.PopAnimation, 154, Exclusive.AAA, MomentType.None, false, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Super Saiyan 2 Vegeta", Series.DragonBallZ, PopLine.PopAnimation, 702, Exclusive.PX, MomentType.None, false, Chrome.None, false,  false, false, 1, 2019));
            funkoPopList.Add(new Funko("Vegeta Powering Up", Series.DragonBallSuper, PopLine.PopAnimation, 713, Exclusive.ChaliesCollectibles, MomentType.None, true, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Beerus", Series.DragonBallSuper, PopLine.PopAnimation, 514, Exclusive.GalacticToys, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Whis", Series.DragonBallSuper, PopLine.PopAnimation, 317, Exclusive.Funimantion, MomentType.None, true, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Zamasu", Series.DragonBallSuper, PopLine.PopAnimation, 316, Exclusive.Walmart, MomentType.None, true, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Fused Zamasu (Enlargement)", Series.DragonBallSuper, PopLine.PopAnimation, 714, Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("SSG Goku", Series.DragonBallSuper, PopLine.PopAnimation, 827, Exclusive.SDCC, MomentType.None, false, Chrome.None,false, false, false, 4, 2020));
            funkoPopList.Add(new Funko("SSGSS Vegito", Series.DragonBallSuper, PopLine.PopAnimation, 515, Exclusive.HotTopic, MomentType.None, false, Chrome.None, true, false, false, 2, 2018));
            funkoPopList.Add(new Funko("Super Saiyan Vegito", Series.DragonBallZ, PopLine.PopAnimation, 491, Exclusive.AAA, MomentType.None, false, Chrome.None, false , false, false, 1, 2018));
            funkoPopList.Add(new Funko("Legendary Super Saiyan Broly", Series.DragonBallZ, PopLine.PopAnimation, 623, Exclusive.GalacticToys, MomentType.None, true, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Goku", Series.DragonBallZ, PopLine.PopAnimation, 9, Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 2, 2014));
            funkoPopList.Add(new Funko("Majin Vegeta", Series.DragonBallZ, PopLine.PopAnimation, 445, Exclusive.Over9000, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Vegeta", Series.DragonBallZ, PopLine.PopAnimation, 669, Exclusive.NYCC, MomentType.None, false, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Vegeta", Series.DragonBallZ, PopLine.PopAnimation, 10, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Vegeta", Series.DragonBallZ, PopLine.PopAnimation, 614, Exclusive.BoxLunch, MomentType.None, false, Chrome.None, true, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Piccolo", Series.DragonBallZ, PopLine.PopAnimation, 11, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Piccolo", Series.DragonBallZ, PopLine.PopAnimation, 704, Exclusive.FYE, MomentType.None, false, Chrome.None, true, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Piccolo", Series.DragonBallZ, PopLine.PopAnimation, 670, Exclusive.NYCC, MomentType.None, false, Chrome.None, false, false, false, 2, 2019));
            funkoPopList.Add(new Funko("Frieza (Final Form)", Series.DragonBallZ, PopLine.PopAnimation, 12, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Golden Frieza", Series.DragonBallZResurrectionF, PopLine.PopAnimation, 47, Exclusive.SDCC, MomentType.None, false, Chrome.None, true, false, false, 1, 2015));
            funkoPopList.Add(new Funko("Carnage", Series.Venom, PopLine.Pop, 372, Exclusive.FYE, MomentType.None, false, Chrome.None, false, false, false, 2, 2018));
            funkoPopList.Add(new Funko("Carnage", Series.Venom, PopLine.Pop, 367, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Carnage", Series.Venom, PopLine.Pop, 371, Exclusive.NYCC, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Carnage", Series.Marvel, PopLine.Marvel, 99,Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 2, 2015));
            funkoPopList.Add(new Funko("Anti-Venom", Series.Marvel, PopLine.Marvel, 2015, Exclusive.HotTopic, MomentType.None, false,Chrome.None, false, false, false, 1, 2015));
            funkoPopList.Add(new Funko("Anti-Venom", Series.Marvel, PopLine.Marvel, 100, Exclusive.BoxLunch, MomentType.None, true, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Anti-Venom", Series.Venom, PopLine.Pop, 401, Exclusive.BoxLunch, MomentType.None, true, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Iron Man", Series.Marvel, PopLine.Marvel, 04, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2011));
            funkoPopList.Add(new Funko("Blue Stealth Iron Man", Series.Marvel, PopLine.Marvel, 04, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Whiplash vs Iron Man", Series.MarvelStudiosTheFirstTenYears, PopLine.Pop, 361, Exclusive.MarvelCollectorsCore, MomentType.MovieMoment, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Captain America vs Thanos", Series.AvengersInfinityWar, PopLine.Pop, 698, Exclusive.HotTopic, MomentType.MovieMoment, false, Chrome.None, false,  false, false, 1, 2018));
            funkoPopList.Add(new Funko("Hulk vs Hulkbuster", Series.MarvelStudiosTheFirstTenYears, PopLine.Pop, 361, Exclusive.MarvelCollectorsCore, MomentType.MovieMoment, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Iron Man", Series.AvengersInfinityWar, PopLine.Pop, 285, Exclusive.Target, MomentType.None, false, Chrome.Red, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Iron Man", Series.AvengersEndGame, PopLine.Pop,529, Exclusive.NYCC, MomentType.None, false, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Iron Man (I Am Iron Man)", Series.AvengersEndGame, PopLine.Pop, 580, Exclusive.PX, MomentType.None, true, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Iron Man", Series.Marvel, PopLine.Pop, 649, Exclusive.Target, MomentType.None, true, Chrome.None, false, false, false, 1, 2020));
            //funkoPopList.Add(new Funko("Iron Man (Unmasked)", Series.CaptainAmericaCivilWar, PopLine.Pop, 126, Exclusive.HotTopic, false, Chrome.None, false, false, false, 1, 2016));
            //funkoPopList.Add(new Funko("HulkBuster", Series.AvengersAgeOfUltron, PopLine.Marvel, 73, Exclusive.MarvelCollectorsCore, false, Chrome.None, false, false, false, 1, 2015));
            funkoPopList.Add(new Funko("Iron Man", Series.AvengersAssemble, PopLine.Pop, 584, Exclusive.Amazon, MomentType.None, false, Chrome.None, false, false, false, 2, 2020));
            //funkoPopList.Add(new Funko("Iron Man", Series.MarvelBlackLight, PopLine.Pop, Exclusive.Target, true, Chrome.None, false, 1));
            //funkoPopList.Add(new Funko("War Machine", Series.CaptainAmericaCivilWar, PopLine.Pop, Exclusive.Common, false, Chrome.None, false, 1));
            //funkoPopList.Add(new Funko("Captain America / Iron Man / Hawkeye / Spider-Man", Series.CaptainAmericaCivilWar, PopLine.Pop, Exclusive.Common, false, Chrome.None, false, 1, 2016));
            funkoPopList.Add(new Funko("Goku (Super Saiyan God)", Series.DragonBallZ, PopLine.PopAnimation, 24, Exclusive.Funimantion, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Super Saiyan God Super Saiyan Goku", Series.DragonBallZResurrectionF, PopLine.PopAnimation, 121, Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 2, 2016));
            //funkoPopList.Add(new Funko("Killmonger", Series.BlackPanther, PopLine.Pop, Exclusive.Common, false, Chrome.None, false, 1));
            //funkoPopList.Add(new Funko("Killmonger", Series.BlackPanther, PopLine.Pop, Exclusive.Common, false, Chrome.None, true, 1)); // chase
            //funkoPopList.Add(new Funko("Black Panther", Series.BlackPanther, PopLine.Pop, Exclusive.Target, true, Chrome.None, false, 1));
            //funkoPopList.Add(new Funko("Black Panther", Series.BlackPanther, PopLine.Pop, Exclusive.MarvelCollectorsCore, true, Chrome.None, false,1));
            //funkoPopList.Add(new Funko("Black Panther", Series.CaptainAmericaCivilWar, PopLine.Pop, Exclusive.Common, false, Chrome.None, false, 1));
            //funkoPopList.Add(new Funko("Black Panther", Series.Marvel, PopLine.Pop, Exclusive.Target, false, Chrome.None, false, 1));
            //funkoPopList.Add(new Funko("Black Panther", Series.MarvelStudiosTheFirstTenYears, PopLine.Pop, Exclusive.Common, false, Chrome.Gold, false, 1));
            //funkoPopList.Add(new Funko("Venomized Black Panther", Series.Marvel, PopLine.Pop, Exclusive.Gamestop, false, Chrome.None, false, 1));
            //funkoPopList.Add(new Funko("Moon Knight", Series.Marvel, PopLine.Pop, Exclusive.LAComicCon, false, Chrome.None, false, 2));
            //funkoPopList.Add(new Funko("Moon Knight", Series.Marvel, PopLine.Pop, Exclusive.Walgreens, false, Chrome.None, false, 1));
            ////funkoPopList.Remove("Moon Knight");
            //funkoPopList.Add(new Funko("Big Daddy", Series.Bioshock, PopLine.Games, 65, Exclusive.Common, false, Chrome.None, false, 2));
            //funkoPopList.Add(new Funko("Little Sister", Series.Bioshock, PopLine.Games, 66, Exclusive.Common, false, Chrome.None, false, 1));
            //funkoPopList.Add(new Funko("Booker DeWitt",Series.BioshockInfinite, PopLine.Games, 62, Exclusive.Common, false, Chrome.None, false, 1));
            //funkoPopList.Add(new Funko("Elizabeth", Series.BioshockInfinite, PopLine.Games, 63, Exclusive.Common, false, Chrome.None, false, 1));
            //funkoPopList.Add(new Funko("Booker DeWitt (Skyhook)", Series.BioshockInfinite, PopLine.Games, 64, Exclusive.Common, false, Chrome.None, false, 1));
            //funkoPopList.Add(new Funko("SongBird",Series.BioshockInfinite, PopLine.Games, 68, Exclusive.Common, false, Chrome.None, false, 2));
            funkoPopList.Add(new Funko("Miles Morales", Series.SpiderManIntoTheSpiderverse, PopLine.Pop, 402, Exclusive.Common, false, Chrome.None, false, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Miles Morales", Series.SpiderManIntoTheSpiderverse, PopLine.Pop, 403, Exclusive.Common, false, Chrome.None, false, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Spider-Man Noir", Series.SpiderManIntoTheSpiderverse, PopLine.Pop, 406, Exclusive.Common, false, Chrome.None, false, false, false, false, 2, 2018));
            funkoPopList.Add(new Funko("Iron Spider", Series.AvengersEndGame, PopLine.Pop, 574, Exclusive.Common, false, Chrome.None, false, false, false, false, 1, 2019));
            //funkoPopList.Add(new Funko("Black Bolt", Exclusive.Common));
            //funkoPopList.Add(new Funko("The Joker (The Dark Knight Trilogy)", Exclusive.Common));
            //funkoPopList.Add(new Funko("Thanos on Throne", Exclusive.HotTopic));
            //funkoPopList.Add(new Funko("Joker (Banker Robber)", Exclusive.Common));
            //funkoPopList.Add(new Funko("Tulip", Exclusive.Common));
            //funkoPopList.Add(new Funko("Cassidy (Bloody)", Exclusive.HotTopic));
            //funkoPopList.Add(new Funko("Thanos (Red Chrome)", Exclusive.Walmart));
            //funkoPopList.Add(new Funko("Thanos (Blue Chrome)", Exclusive.Walmart));
            //funkoPopList.Add(new Funko("Thanos (Yellow Chrome)", Exclusive.Walmart));
            //funkoPopList.Add(new Funko("Thanos (Green Chrome)", Exclusive.Walmart));
            //funkoPopList.Add(new Funko("Thanos (Purple Chrome)", Exclusive.Walmart));
            //funkoPopList.Add(new Funko("Thanos (Orange Chrome)", Exclusive.Walmart));
            //funkoPopList.Add(new Funko("Joker (Death of the Family)", Exclusive.HotTopic));
            //funkoPopList.Add(new Funko("Joker (Death of the Family GITD)", Exclusive.HotTopic));
            //funkoPopList.Add(new Funko("Super Vegeta", Exclusive.Target));
            //funkoPopList.Add(new Funko("Super Saiyan Future Trunks", Exclusive.HotTopic));
            //funkoPopList.Add(new Funko("Arseface", Exclusive.Common));
            //funkoPopList.Add(new Funko("Jessie Custer (Arms Out)", Exclusive.Gamestop));
            //funkoPopList.Add(new Funko("Jessie Custer", Exclusive.Common));
            //funkoPopList.Add(new Funko("Elizabeth", Exclusive.Common));
            //funkoPopList.Add(new Funko("Ice Man (Flocked)", Exclusive.FunkoStore));
            funkoPopList.Add(new Funko("Goku Ultra Instinst", Series.DragonBallSuper, PopLine.PopAnimation, 386, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("SSGSS Goku",Series.DragonBallSuper, PopLine.PopAnimation, 668, Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 1 ,2019));
            funkoPopList.Add(new Funko("SSGSS Goku (Kamehameha)", Series.DragonBallSuper, PopLine.PopAnimation, 563, Exclusive.ChaliesCollectibles, MomentType.None, false, Chrome.None, true, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Super Saiyan 3 Goku", Series.DragonBallZ, PopLine.PopAnimation, 492, Exclusive.Gamestop, MomentType.None, false, Chrome.None, false, false, false, 2, 2018));
            funkoPopList.Add(new Funko("Super Saiyan Goku", Series.DragonBallZ, PopLine.PopAnimation, 14, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Super Saiyan Goku", Series.DragonBallZ, PopLine.PopAnimation, 14, Exclusive.EntertainmentEarth, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("SSG Goku", Series.DragonBallSuper, PopLine.PopAnimation, 827, Exclusive.SDCC, MomentType.None, false, Chrome.None, false, false, false, 4, 2020));
            //funkoPopList.Add(new Funko("Logan", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("Great Ape Goku", Series.DragonBallZ, PopLine.PopAnimation, 624, Exclusive.EntertainmentEarth, MomentType.None, false, Chrome.None, false,  false, false, 1, 2019));
            //funkoPopList.Add(new Funko("Hulk vs HulkBuster", Exclusive.Walgreens));
            //funkoPopList.Add(new Funko("Iron Man vs Whiplash", Exclusive.MarvelCollectorsCore));
            //funkoPopList.Add(new Funko("Venom", Exclusive.Common));
            //funkoPopList.Add(new Funko("Venom (Leathal Protector)", Exclusive.MarvelCollectorsCore));
            funkoPopList.Add(new Funko("Spider-Man", Series.TheAmazingSpiderMan, PopLine.Marvel, 15,Exclusive.Common, MomentType.None, false, Chrome.None, false, false,  false, 1 , 2012));
            funkoPopList.Add(new Funko("Spider-Man", Series.TheAmazingSpiderMan2, PopLine.Marvel, 45, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Electro", Series.TheAmazingSpiderMan2, PopLine.Marvel, 46, Exclusive.Common, MomentType.None, true, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Black Suit Spider-Man", Series.SpiderMan, PopLine.Marvel, 79, Exclusive.Walgreens, MomentType.None, false, Chrome.None, false, false, false, 1, 2015));
            funkoPopList.Add(new Funko("Scarlet Spider", Series.Marvel, PopLine.Pop, 187, Exclusive.Walgreens, MomentType.None, false, Chrome.None,  false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Spider-Man (Stealth Suit)", Series.Marvel, PopLine.Marvel, 195, Exclusive.HotTopic, MomentType.None, true, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Six Arm Spider-Man", Series.Marvel, PopLine.Pop, 313, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Venom vs. Spider-Man", Series.Marvel, PopLine.Pop, 438, Exclusive.PX, MomentType.ComicMoment, false, Chrome.None, true, false, false, 1, 2018));
            //funkoPopList.Add(new Funko("Iron Spiderman", Exclusive.Walgreens));
            //funkoPopList.Add(new Funko("Spider-Man (I Love Pi Shirt)", Exclusive.BoxLunch));
            //funkoPopList.Add(new Funko("Notorious B.I.G with Crown", Exclusive.FunkoStore));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.)); 
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));




        }


    }
}