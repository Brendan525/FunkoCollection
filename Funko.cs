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
        LegionOfCollections,
        FugitiveToys,
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
        MarvelZombies,
        TheDarkKnight,
        BatmanVSuperman,
        Batman,
        TheDarkKnightTrilogy,
        MyHeroAcademia,
        GuardiansOfTheGalaxy,
        Pokèmon,
        ThorRagnarok,
        DCSuperHeroes,
    }

    public enum PopLine
    {
        Pop,
        PopMovies,
        PopHeroes,
        PopAnimation,
        PopRocks,
        PopMarvel,
        Games,
        PopGames,
        PopTelevision,
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
            funkoPopList.Add(new Funko("Carnage", Series.Marvel, PopLine.PopMarvel, 99,Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 2, 2015));
            funkoPopList.Add(new Funko("Anti-Venom", Series.Marvel, PopLine.PopMarvel, 2015, Exclusive.HotTopic, MomentType.None, false,Chrome.None, false, false, false, 1, 2015));
            funkoPopList.Add(new Funko("Anti-Venom", Series.Marvel, PopLine.PopMarvel, 100, Exclusive.BoxLunch, MomentType.None, true, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Anti-Venom", Series.Venom, PopLine.Pop, 401, Exclusive.BoxLunch, MomentType.None, true, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Iron Man", Series.Marvel, PopLine.PopMarvel, 04, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2011));
            funkoPopList.Add(new Funko("Blue Stealth Iron Man", Series.Marvel, PopLine.PopMarvel, 04, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Whiplash vs Iron Man", Series.MarvelStudiosTheFirstTenYears, PopLine.Pop, 361, Exclusive.MarvelCollectorsCore, MomentType.MovieMoment, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Captain America vs Thanos", Series.AvengersInfinityWar, PopLine.Pop, 698, Exclusive.HotTopic, MomentType.MovieMoment, false, Chrome.None, false,  false, false, 1, 2018));
            funkoPopList.Add(new Funko("Hulk vs Hulkbuster", Series.MarvelStudiosTheFirstTenYears, PopLine.Pop, 361, Exclusive.MarvelCollectorsCore, MomentType.MovieMoment, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Iron Man", Series.AvengersInfinityWar, PopLine.Pop, 285, Exclusive.Target, MomentType.None, false, Chrome.Red, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Iron Man", Series.AvengersEndGame, PopLine.Pop,529, Exclusive.NYCC, MomentType.None, false, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Iron Man (I Am Iron Man)", Series.AvengersEndGame, PopLine.Pop, 580, Exclusive.PX, MomentType.None, true, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Iron Man", Series.Marvel, PopLine.Pop, 649, Exclusive.Target, MomentType.None, true, Chrome.None, false, false, false, 2, 2020));
            funkoPopList.Add(new Funko("Iron Man (Unmasked)", Series.CaptainAmericaCivilWar, PopLine.Pop, 126, Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("HulkBuster", Series.AvengersAgeOfUltron, PopLine.PopMarvel, 73, Exclusive.MarvelCollectorsCore, MomentType.None, false, Chrome.None, false, false, false, 1, 2015));
            funkoPopList.Add(new Funko("Iron Man", Series.AvengersAssemble, PopLine.Pop, 584, Exclusive.Amazon, MomentType.None, false, Chrome.None, false, false, false, 2, 2020));
            funkoPopList.Add(new Funko("War Machine", Series.CaptainAmericaCivilWar, PopLine.Pop, 128, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Captain America / Iron Man / Hawkeye / Spider-Man", Series.CaptainAmericaCivilWar, PopLine.Pop, 0, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Goku (Super Saiyan God)", Series.DragonBallZ, PopLine.PopAnimation, 24, Exclusive.Funimantion, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Super Saiyan God Super Saiyan Goku", Series.DragonBallZResurrectionF, PopLine.PopAnimation, 121, Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 2, 2016));
            funkoPopList.Add(new Funko("Killmonger", Series.BlackPanther, PopLine.Pop, 278, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Killmonger", Series.BlackPanther, PopLine.Pop, 278, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, true, 1, 2018)); // chase
            funkoPopList.Add(new Funko("Black Panther", Series.BlackPanther, PopLine.Pop, 273, Exclusive.Target, MomentType.None, true, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Black Panther", Series.BlackPanther, PopLine.Pop, 612, Exclusive.MarvelCollectorsCore, MomentType.None, true, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Black Panther", Series.CaptainAmericaCivilWar, PopLine.Pop, 130, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Black Panther", Series.Marvel, PopLine.Pop, 314, Exclusive.Target, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Black Panther", Series.MarvelStudiosTheFirstTenYears, PopLine.Pop, 383, Exclusive.Common, MomentType.None, false, Chrome.Gold, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Venomized Black Panther", Series.Marvel, PopLine.Pop, 370, Exclusive.Gamestop, MomentType.None, false, Chrome.None, false, false, false, 1,2018)); ;
            funkoPopList.Add(new Funko("Moon Knight", Series.Marvel, PopLine.Pop, 266, Exclusive.LAComicCon, MomentType.None, false, Chrome.None, false, false, false, 2, 2017));
            funkoPopList.Add(new Funko("Moon Knight", Series.Marvel, PopLine.Pop, 272, Exclusive.Walgreens, MomentType.None, false, Chrome.None, false, false, false, 1, 2017));
            ////funkoPopList.Remove("Moon Knight");
            funkoPopList.Add(new Funko("Big Daddy", Series.Bioshock, PopLine.PopGames, 65, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 2, 2015));
            funkoPopList.Add(new Funko("Little Sister", Series.Bioshock, PopLine.PopGames, 66, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2015));
            funkoPopList.Add(new Funko("Booker DeWitt", Series.BioshockInfinite, PopLine.PopGames, 62, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2015));
            funkoPopList.Add(new Funko("Elizabeth", Series.BioshockInfinite, PopLine.PopGames, 63, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2015));
            funkoPopList.Add(new Funko("Booker DeWitt (Skyhook)", Series.BioshockInfinite, PopLine.PopGames, 64, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2015));
            funkoPopList.Add(new Funko("SongBird",Series.BioshockInfinite, PopLine.PopGames, 68, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 2, 2015));
            funkoPopList.Add(new Funko("Miles Morales", Series.SpiderManIntoTheSpiderverse, PopLine.Pop, 402, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Miles Morales", Series.SpiderManIntoTheSpiderverse, PopLine.Pop, 403, Exclusive.Common, MomentType.None,  false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Spider-Man Noir", Series.SpiderManIntoTheSpiderverse, PopLine.Pop, 406, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 2, 2018));
            funkoPopList.Add(new Funko("Iron Spider", Series.AvengersEndGame, PopLine.Pop, 574, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Black Bolt (Blue)", Series.Marvel, PopLine.Pop, 191, Exclusive.PX, MomentType.None, false, Chrome.None, false, false, false, 1, 2017));
            funkoPopList.Add(new Funko("Black Bolt", Series.Marvel, PopLine.Pop, 191, Exclusive.PX, MomentType.None, false, Chrome.None, false, false, false, 1, 2017));
            funkoPopList.Add(new Funko("The Joker", Series.TheDarkKnightTrilogy, PopLine.PopHeroes, 36, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2013));
            funkoPopList.Add(new Funko("The Joker (Banker Robber)", Series.TheDarkKnightTrilogy, PopLine.PopHeroes, 37, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2013));
            funkoPopList.Add(new Funko("The Joker (Batman 1989)", Series.Batman, PopLine.PopHeroes, 337, Exclusive.Gamestop, MomentType.None, false, Chrome.None, true, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Joker (10 inch)", Series.TheDarkKnightTrilogy, PopLine.PopHeroes, 334, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Armored Batman", Series.BatmanVSuperman, PopLine.PopHeroes, 88, Exclusive.LegionOfCollections, MomentType.None, false, Chrome.None, false, false, false, 1, 2015));
            funkoPopList.Add(new Funko("Thanos With Throne", Series.MarvelStudiosTheFirstTenYears, PopLine.Pop, 331, Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Cosmic Ghost Rider", Series.Marvel, PopLine.Pop, 518, Exclusive.LAComicCon, MomentType.None, false, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Thanos", Series.AvengersInfinityWar, PopLine.Pop, 415, Exclusive.Walmart, MomentType.None, false, Chrome.Purple, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Thanos", Series.AvengersInfinityWar, PopLine.Pop, 289, Exclusive.Walmart, MomentType.None, false, Chrome.Blue, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Thanos", Series.AvengersInfinityWar, PopLine.Pop, 289, Exclusive.Walmart, MomentType.None, false, Chrome.Green, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Thanos", Series.AvengersInfinityWar, PopLine.Pop, 289, Exclusive.Walmart, MomentType.None, false, Chrome.Yellow, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Thanos", Series.AvengersInfinityWar, PopLine.Pop, 289, Exclusive.Walmart, MomentType.None, false, Chrome.Red, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Thanos", Series.AvengersInfinityWar, PopLine.Pop, 289, Exclusive.Walmart, MomentType.None, false, Chrome.Orange, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Thanos", Series.AvengersInfinityWar, PopLine.Pop, 415, Exclusive.Walmart, MomentType.None, false, Chrome.Purple, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Thanos", Series.GuardiansOfTheGalaxy, PopLine.PopMarvel, 78, Exclusive.EntertainmentEarth, MomentType.None, true, Chrome.None, false, false, false, 1, 2015));
            funkoPopList.Add(new Funko("Mewtwo", Series.Pokèmon, PopLine.PopGames, 581, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Mewtwo", Series.Pokèmon, PopLine.PopGames, 581, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Pikachu", Series.Pokèmon, PopLine.PopGames, 353, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Charmander", Series.Pokèmon, PopLine.PopGames, 455, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Thor", Series.Marvel, PopLine.Pop, 650, Exclusive.Target, MomentType.None, true, Chrome.None, false, false, false, 2, 2020));
            funkoPopList.Add(new Funko("Doctor Strange (Ghost Rider)", Series.Marvel, PopLine.Pop, 412, Exclusive.LAComicCon, MomentType.None, false, Chrome.None, false, false, false, 2, 2018));
            funkoPopList.Add(new Funko("Doctor Strange", Series.Marvel, PopLine.Pop, 651, Exclusive.Target, MomentType.None, true, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Hulk (10 inch)", Series.ThorRagnarok, PopLine.Pop, 241, Exclusive.Target, MomentType.None, false, Chrome.None, false, false, false, 1, 2017));
            funkoPopList.Add(new Funko("Tulip", Series.Preacher, PopLine.PopTelevision, 376, Exclusive.PX, MomentType.None, false, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Cassidy (Bloody)", Series.Preacher, PopLine.PopTelevision, 368, Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Cassidy", Series.Preacher, PopLine.PopTelevision, 367, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("The Joker", Series.DCSuperHeroes, PopLine.PopHeroes, 273, Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("The Joker", Series.DCSuperHeroes, PopLine.PopHeroes, 273, Exclusive.HotTopic, MomentType.None, true, Chrome.None, false, false, false, 1, 2020));
            //funkoPopList.Add(new Funko("Super Vegeta", Exclusive.Target));
            //funkoPopList.Add(new Funko("Super Saiyan Future Trunks", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("Arseface", Series.Preacher, PopLine.PopTelevision, 366, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Jessie Custer", Series.Preacher, PopLine.PopTelevision, 365, Exclusive.Gamestop, MomentType.None, false, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Jessie Custer", Series.Preacher, PopLine.PopTelevision, 364, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Ice Man", Series.Marvel80Years, PopLine.Pop, 504, Exclusive.FunkoStore, MomentType.None, false, Chrome.None, false, true, false, 1, 2019));
            funkoPopList.Add(new Funko("Goku Ultra Instinst", Series.DragonBallSuper, PopLine.PopAnimation, 386, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("SSGSS Goku",Series.DragonBallSuper, PopLine.PopAnimation, 668, Exclusive.HotTopic, MomentType.None, false, Chrome.None, false, false, false, 1 ,2019));
            funkoPopList.Add(new Funko("SSGSS Goku (Kamehameha)", Series.DragonBallSuper, PopLine.PopAnimation, 563, Exclusive.ChaliesCollectibles, MomentType.None, false, Chrome.None, true, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Super Saiyan 3 Goku", Series.DragonBallZ, PopLine.PopAnimation, 492, Exclusive.Gamestop, MomentType.None, false, Chrome.None, false, false, false, 2, 2018));
            funkoPopList.Add(new Funko("Super Saiyan Goku", Series.DragonBallZ, PopLine.PopAnimation, 14, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Super Saiyan Goku", Series.DragonBallZ, PopLine.PopAnimation, 14, Exclusive.EntertainmentEarth, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("SSG Goku", Series.DragonBallSuper, PopLine.PopAnimation, 827, Exclusive.SDCC, MomentType.None, false, Chrome.None, false, false, false, 4, 2020));
            //funkoPopList.Add(new Funko("Logan", Exclusive.HotTopic));
            funkoPopList.Add(new Funko("Great Ape Goku", Series.DragonBallZ, PopLine.PopAnimation, 624, Exclusive.EntertainmentEarth, MomentType.None, false, Chrome.None, false,  false, false, 1, 2019));
            funkoPopList.Add(new Funko("Venom", Series.Venom, PopLine.Pop, 363, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 2, 2018));
            funkoPopList.Add(new Funko("Venom", Series.Venom, PopLine.Pop, 373, Exclusive.MarvelCollectorsCore, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Venomized Thanos", Series.Venom, PopLine.Pop, 510, Exclusive.BoxLunch, MomentType.None, true, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Zombie Venom", Series.MarvelZombies, PopLine.Pop, 664, Exclusive.Gamestop, MomentType.None, false, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Corrupted Venom", Series.Venom, PopLine.Pop, 517, Exclusive.LAComicCon, MomentType.None, false, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Spider-Man", Series.TheAmazingSpiderMan, PopLine.PopMarvel, 15,Exclusive.Common, MomentType.None, false, Chrome.None, false, false,  false, 1 , 2012));
            funkoPopList.Add(new Funko("Spider-Man", Series.TheAmazingSpiderMan2, PopLine.PopMarvel, 45, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Electro", Series.TheAmazingSpiderMan2, PopLine.PopMarvel, 46, Exclusive.Common, MomentType.None, true, Chrome.None, false, false, false, 1, 2014));
            funkoPopList.Add(new Funko("Black Suit Spider-Man", Series.SpiderMan, PopLine.PopMarvel, 79, Exclusive.Walgreens, MomentType.None, false, Chrome.None, false, false, false, 1, 2015));
            funkoPopList.Add(new Funko("Scarlet Spider", Series.Marvel, PopLine.Pop, 187, Exclusive.Walgreens, MomentType.None, false, Chrome.None,  false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Spider-Man (Stealth Suit)", Series.Marvel, PopLine.PopMarvel, 195, Exclusive.HotTopic, MomentType.None, true, Chrome.None, false, false, false, 1, 2016));
            funkoPopList.Add(new Funko("Six Arm Spider-Man", Series.Marvel, PopLine.Pop, 313, Exclusive.Common, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            funkoPopList.Add(new Funko("Venom vs. Spider-Man", Series.Marvel, PopLine.Pop, 438, Exclusive.PX, MomentType.ComicMoment, false, Chrome.None, true, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Spider-Man", Series.Marvel80Years, PopLine.Pop, 593, Exclusive.HotTopic, MomentType.None, false, Chrome.None, true, false, false, 2, 2020));
            funkoPopList.Add(new Funko("Spider-Man vs. Spider-Man (2 Pack)", Series.Marvel, PopLine.Pop, 0, Exclusive.EntertainmentEarth, MomentType.None, false, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Spider-Man", Series.Marvel, PopLine.Pop, 652, Exclusive.Target, MomentType.None, true, Chrome.None, false, false, false, 2, 2020));
            funkoPopList.Add(new Funko("Spider-Man (Captain Universe)", Series.Marvel80Years, PopLine.Pop, 593, Exclusive.HotTopic, MomentType.None, false, Chrome.None, true, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Spider-Man", Series.Marvel, PopLine.Pop, 672, Exclusive.BoxLunch, MomentType.None, false, Chrome.None, false, false, false, 1, 2020));
            //funkoPopList.Add(new Funko("Iron Spiderman", Exclusive.Walgreens));
            //funkoPopList.Add(new Funko("Spider-Man (I Love Pi Shirt)", Exclusive.BoxLunch));
            //funkoPopList.Add(new Funko("Notorious B.I.G with Crown", Exclusive.FunkoStore));
            funkoPopList.Add(new Funko("Deku", Series.MyHeroAcademia, PopLine.PopAnimation, 596, Exclusive.EntertainmentEarth, MomentType.None, true, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Katsuki Bakugo", Series.MyHeroAcademia, PopLine.PopAnimation, 803, Exclusive.SDCC, MomentType.None, false, Chrome.None, false, false, false, 2, 2020));
            funkoPopList.Add(new Funko("All For One", Series.MyHeroAcademia, PopLine.PopAnimation, 647, Exclusive.FugitiveToys, MomentType.None, false, Chrome.None, false, false, false, 1, 2020));
            funkoPopList.Add(new Funko("Dabi", Series.MyHeroAcademia, PopLine.PopAnimation, 637, Exclusive.NYCC, MomentType.None, false, Chrome.None, false, false, false, 2, 2019));
            funkoPopList.Add(new Funko("Hero Killer Stain", Series.MyHeroAcademia, PopLine.PopAnimation, 636, Exclusive.NYCC, MomentType.None, false, Chrome.None, false, false, false, 2, 2020));
            funkoPopList.Add(new Funko("Tomura Shigaraki", Series.MyHeroAcademia, PopLine.PopAnimation, 565, Exclusive.GalacticToys, MomentType.None, false, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Deku", Series.MyHeroAcademia, PopLine.PopAnimation, 596, Exclusive.EntertainmentEarth, MomentType.None, true, Chrome.None, false, false, false, 1, 2019));
            funkoPopList.Add(new Funko("Toxin", Series.Marvel, PopLine.Pop, 354, Exclusive.Walgreens, MomentType.None, false, Chrome.None, false, false, false, 2, 2018));
            funkoPopList.Add(new Funko("The Lizard", Series.Marvel, PopLine.Pop, 334, Exclusive.Walgreens, MomentType.None, false, Chrome.None, false, false, false, 1, 2018));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.)); 
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
            //funkoPopList.Add(new Funko("", Exclusive.));
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