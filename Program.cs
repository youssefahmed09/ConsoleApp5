using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using static project_league.st;

namespace project_league
{
    abstract public class human
    {
        protected string name;
        protected float weight;
        protected float height;
        public human()
        {
            name = "";
            weight = 0;
            height = 0;


        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Height
        {
            get { return height; }
            set
            {

                if (value > 0)
                    height = value;
            }
        }
        public float Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;

            }
        }

    }

    public interface idisplay
    {

        void display();

    }







    public class player : human
    {
        protected string position;
        protected float rate;
        public player()
        : base()
        {
            position = "";
            rate = 0;



        }
        public string Position { get { return position; } set { position = value; } }
        virtual public float avgrating()
        {
            return 0;



        }
    }
    public class goalkeeper : player
    {

        int successaves;
        int totalsave;

        public goalkeeper() : base()
        {
            successaves = 0;
            totalsave = 1;
            position = "goal keeper ";

        }
        public int Successsaves
        {
            get { return successaves; }
            set
            {
                if (value > 0)
                    successaves = value;
            }
        }
        public int Totalsaves
        {
            get { return totalsave; }
            set
            {
                if (value > successaves)
                    totalsave = value;
            }

        }

        public override float avgrating()
        {
            rate = ((float)successaves / totalsave);
            rate = rate * 10;
            return rate;
        }


    }
    public class defender : player
    {



        int successtackles;
        int totaltackles;

        public defender() : base()
        {
            successtackles = 0;
            totaltackles = 1;
            position = "defender ";

        }
        public int Successtackles
        {
            get { return successtackles; }
            set
            {
                if (value > 0)
                    successtackles = value;
            }
        }
        public int Totaltackles
        {
            get { return totaltackles; }
            set
            {
                if (value > successtackles)
                    totaltackles = value;
            }

        }

        public override float avgrating()
        {
            rate = ((float)successtackles / totaltackles);
            rate = rate * 10;
            return rate;
        }



    }
    public class back : player
    {
        int successcrosses;
        int totalcrosses;

        public back() : base()
        {
            successcrosses = 0;
            totalcrosses = 1;
            position = "back ";

        }
        public int Successcrosses
        {
            get { return successcrosses; }
            set
            {
                if (value > 0)
                    successcrosses = value;
            }
        }
        public int Totalcrosses
        {
            get { return totalcrosses; }
            set
            {
                if (value > successcrosses)
                    totalcrosses = value;
            }

        }

        public override float avgrating()
        {
            rate = ((float)successcrosses / totalcrosses);
            rate = rate * 10;
            return rate;
        }
    }
    public class mid : player
    {
        int successpasses;
        int totalpasses;

        public mid() : base()
        {
            successpasses = 0;
            totalpasses = 1;
            position = "midfileder ";

        }
        public int Successpasses
        {
            get { return successpasses; }
            set
            {
                if (value > 0)
                    successpasses = value;
            }
        }
        public int Totalpasses
        {
            get { return totalpasses; }
            set
            {
                if (value > successpasses)
                    totalpasses = value;
            }

        }

        public override float avgrating()
        {
            rate = ((float)successpasses / totalpasses);
            rate = rate * 10;
            return rate;
        }
    }
    public class wing : player
    {
        int successdribbles;
        int totaldribbles;

        public wing() : base()
        {
            successdribbles = 0;
            totaldribbles = 1;
            position = "winger ";

        }
        public int Successdribbles
        {
            get { return successdribbles; }
            set
            {
                if (value > 0)
                    successdribbles = value;
            }
        }
        public int Totaldribbles
        {
            get { return totaldribbles; }
            set
            {
                if (value > successdribbles)
                    totaldribbles = value;
            }

        }

        public override float avgrating()
        {
            rate = ((float)successdribbles / totaldribbles);
            rate = rate * 10;
            return rate;
        }
    }
    public class st : player
    {
        int successshoots;
        int totalshoots;

        public st() : base()
        {
            successshoots = 0;
            totalshoots = 1;
            position = "striker ";

        }
        public int Successshoots
        {
            get { return successshoots; }
            set
            {
                if (value > 0)
                    successshoots = value;
            }
        }
        public int Totalshoots
        {
            get { return totalshoots; }
            set
            {
                if (value > successshoots)
                    totalshoots = value;
            }

        }

        public override float avgrating()
        {
            rate = ((float)successshoots / totalshoots);
            rate = rate * 10;
            return rate;
        }
        public class Match : idisplay
        {
            string team1;
            string team2;
            string date;
            string refree;
            public Match()
            {
                team1 = "";
                team2 = "";
                date = "";
                refree = "";

            }
            public void display()
            {
                Console.WriteLine($"{team1}vs{team2}at{date}ref{refree}");
                throw new NotImplementedException();



            }
            public string Refree
            {
                get { return refree; }
                set { refree = value; }
            }
            public string Team1
            {
                get { return team1; }
                set { team1 = value; }
            }
            public string Team2
            {
                get { return team2; }
                set { team2 = value; }
            }
            public string Date
            {
                get { return date; }
                set { date = value; }
            }

        }

        public class Stadium
        {
            protected string name;
            protected string location;
            protected int seatcapacity;
            public List<Match> matchesD;

            public Stadium()
            {
                this.name = "";
                this.location = "";
                this.seatcapacity = 0;
                matchesD = new List<Match>();
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Location
            {
                get { return location; }
                set { location = value; }
            }
            public int SeatCapacity
            {
                get { return seatcapacity; }
                set
                {
                    if (value > 0)
                        seatcapacity = value;
                }
            }





            public void AddMatchd(Match Match)
            {
                matchesD.Add(Match);
            }
            public void removeMatchd(Match Match)
            {
                matchesD.Remove(Match);
            }


            public void DisplayMatches()
            {
                Console.WriteLine($"Matches at {Name}:");
                foreach (Match i in matchesD)
                {
                    Console.WriteLine($"{i.Date}: {i.Team1}vs{i.Team2}");
                }
            }
        }

        class Refree : human, idisplay
        {

            protected List<Match> matchesR;

            public Refree() : base()
            {

                this.matchesR = new List<Match>();

            }

            public void display()
            {
                Console.WriteLine($"{name} weight is{weight}heightis {height}");
                foreach (Match r in matchesR)
                {
                    Console.WriteLine($"{r.Team1}vs{r.Team2}");
                    
                }
                



            }

            public void Addmatchr(Match matche)
            {
                matchesR.Add(matche);
            }
            public void removematchr(Match matche)
            {
                matchesR.Remove(matche);
            }





            public class Team
            {
                public List<Match> matchesT;
                public List<player> playersT;
                string name;
                public string Name
                {
                    get { return name; }
                    set { name = value; }
                }
                public Team()
                {
                    name = "";
                    matchesT = new List<Match>();
                    playersT = new List<player>();

                }
                public void AddMatchT(Match Match)
                {
                    matchesT.Add(Match);
                }
                public void removeMatchT(Match Match)
                {
                    matchesT.Remove(Match);
                }
                public void AddplayersT(player player)
                {
                    playersT.Add(player);
                }
                public void removeplayerT(player player)
                {
                    playersT.Remove(player);
                }



            }
            public class League
            {
                string startingDate;
                string endingDate;
                public List<Match> Matches;
                public List<Team> Teams;
              
                public League()
                {
                    this.startingDate = "";
                    this.endingDate = "";
                    Matches = new List<Match>();
                    Teams = new List<Team>();
                 
                }
                public string StartingDate
                {
                    get { return startingDate; }
                    set { startingDate = value; }
                }
                public string EndingDate
                {
                    get { return endingDate; }
                    set { endingDate = value; }
                }

                public void AddMatchL(Match match)
                {
                    Matches.Add(match);
                }
                public void removeMatchL(Match match)
                {
                    Matches.Remove(match);
                }



                public void AddTeamL(Team TeamL)
                {
                    Teams.Add(TeamL);
                }
                public void removeTeamL(Team TeamL)
                {
                    Teams.Remove(TeamL);
                }






             



            }




            internal class Program
            {
                static void Main(string[] args)
                {
                    Match zamalek = new Match();
                    zamalek.Date = "19.10.2020";
                    zamalek.Refree = "nour eldin";
                    zamalek.Team1 = "zamalek";
                    zamalek.Team2 = "ahly";
                    Match cerm=new Match();
                    cerm.Team1 = "cermica";
                    cerm.Team2 = "pyramids";
                    cerm.Date = "20.10.2020";
                    cerm.Refree = "nour eliden";

              
                    Team ahwe = new Team();
                    ahwe.AddMatchT(zamalek);
                    ahwe.Name = "ahly";
                    Team zamalk = new Team();
                    zamalk.AddMatchT(zamalek);
                    zamalk.Name = "zamalek";
                    Team pyr=new Team();
                    pyr.AddMatchT(cerm);
                    pyr.Name = "pyramids";
                    Team ceramic = new Team();
                    ceramic.Name = "ceramic";
                    ceramic.AddMatchT(cerm);
                    Stadium DEF3AGW = new Stadium();
                    DEF3AGW.Name = "def3a gawe";
                    DEF3AGW.Location = " el salam";
                    DEF3AGW.SeatCapacity = 50000;
                    DEF3AGW.AddMatchd(zamalek);
                    DEF3AGW.AddMatchd(cerm);
                    Refree nour=new Refree();
                    nour.Name = "nour eldin";
                    nour.Weight = 70;
                    nour.Height = 109;
                    nour.Addmatchr(zamalek);
                    nour.Addmatchr(cerm);
                    nour.display();    
                    League leauge = new League();
                    leauge.StartingDate = "8 of december";
                    leauge.EndingDate = "25 of december";
                    leauge.AddMatchL(zamalek);
                    leauge.AddMatchL(cerm);
                    leauge.AddTeamL(ahwe);
                    leauge.AddTeamL(zamalk);
                    leauge.AddTeamL(pyr);

                    leauge.AddTeamL(ceramic);



                  
                    goalkeeper moahmed = new goalkeeper();
                    moahmed.Name = "mohamed elshenawy  ";
                    moahmed.Height = 198;
                    moahmed.Weight = 100;
                    moahmed.Totalsaves = 90;
                    moahmed.Successsaves = 75;
                    moahmed.avgrating();
                    ahwe.AddplayersT(moahmed);
                    defender rabea = new defender();

                    rabea.Name = "rami rabea";
                    rabea.Height = 185;
                    rabea.Weight = 90;
                    rabea.Totaltackles = 40;
                    rabea.Successtackles = 20;
                    rabea.avgrating();
                    ahwe.AddplayersT(rabea);
                    defender momem = new defender();
                    momem.Name = "mohamed abdel momem";
                    momem.Height = 185;
                    momem.Weight = 90;
                    momem.Totaltackles = 40;
                    momem.Successtackles = 30;
                    momem.avgrating();
                    ahwe.AddplayersT(momem);

                    back ali = new back();

                    ali.Name = "ali maloul ";
                    ali.Height = 198;
                    ali.Weight = 80;
                    ali.Totalcrosses = 27;
                    ali.Successcrosses = 25;

                    ali.avgrating();
                    ahwe.AddplayersT(ali);

                    back hany = new back();

                    hany.Name = "hany ";
                    hany.Height = 198;
                    hany.Weight = 80;
                    hany.Totalcrosses = 30;
                    hany.Successcrosses = 10;

                    hany.avgrating();
                    ahwe.AddplayersT(hany);
                    mid attia = new mid();

                    attia.Name = "attia ";
                    attia.Height = 198;
                    attia.Weight = 80;
                    attia.Totalpasses = 50;
                    attia.Successpasses = 30;
                    attia.avgrating();
                    ahwe.AddplayersT(attia);
                    mid koka = new mid();

                    koka.Name = "koka ";
                    koka.Height = 198;
                    koka.Weight = 80;
                    koka.Totalpasses = 50;
                    koka.Successpasses = 25;
                    koka.avgrating();
                    ahwe.AddplayersT(koka);
                    mid emam = new mid();

                    emam.Name = "emam ashour ";
                    emam.Height = 198;
                    emam.Weight = 80;
                    emam.Totalpasses = 50;
                    emam.Successpasses = 40;
                    emam.avgrating();
                    ahwe.AddplayersT(emam);
                    wing tamer = new wing();

                    tamer.Name = " tamer ";
                    tamer.Height = 198;
                    tamer.Weight = 80;
                    tamer.Totaldribbles = 30;
                    tamer.Successdribbles = 15;
                    tamer.avgrating();
                    ahwe.AddplayersT(tamer);
                    wing taw = new wing();

                    taw.Name = " taw ";
                    taw.Height = 198;
                    taw.Weight = 80;
                    taw.Totaldribbles = 30;
                    taw.Successdribbles = 10;
                    taw.avgrating();
                    ahwe.AddplayersT(taw);
                    st maged = new st();
                    maged.Name = " maged ";
                    maged.Height = 198;
                    maged.Weight = 80;
                    maged.Totalshoots = 40;
                    maged.Successshoots = 35;
                    maged.avgrating();
                    ahwe.AddplayersT(maged);
                    player[] topplayers = new player[10];
                    List<player> allplayers = new List<player>();
                    allplayers.Add(moahmed);
                    allplayers.Add(rabea);
                    allplayers.Add((momem));
                    allplayers.Add(ali);
                    allplayers.Add(hany);
                    allplayers.Add(koka);
                    allplayers.Add(attia);
                    allplayers.Add(emam);
                    allplayers.Add(tamer);
                    allplayers.Add(taw);
                    allplayers.Add(maged);



                    goalkeeper awad = new goalkeeper();
                    awad.Name = "mohamed awad  ";
                    awad.Height = 182;
                    awad.Weight = 75;
                    awad.Totalsaves = 100;
                    awad.Successsaves = 40;
                    awad.avgrating();
                    allplayers.Add(awad);
                    zamalk.AddplayersT(awad);
                    defender mathlouthi = new defender();

                    mathlouthi.Name = "mathlouthi";
                    mathlouthi.Height = 185;
                    mathlouthi.Weight = 90;
                    mathlouthi.Totaltackles = 40;
                    mathlouthi.Successtackles = 39;
                    mathlouthi.avgrating();
                    allplayers.Add(mathlouthi);
                    zamalk.AddplayersT(mathlouthi);
                    defender abdekmaged = new defender();

                    abdekmaged.Name = "abdekmaged";
                    abdekmaged.Height = 185;
                    abdekmaged.Weight = 90;
                    abdekmaged.Totaltackles = 40;
                    abdekmaged.Successtackles = 39;
                    abdekmaged.avgrating();
                    allplayers.Add(abdekmaged);
                    zamalk.AddplayersT(abdekmaged);
                    back fotouh = new back();

                    fotouh.Name = "fotouh ";
                    fotouh.Height = 198;
                    fotouh.Weight = 80;
                    fotouh.Totalcrosses = 30;
                    fotouh.Successcrosses = 25;

                    fotouh.avgrating();
                    allplayers.Add(fotouh);
                    zamalk.AddplayersT(fotouh);

                    back mm = new back();

                    mm.Name = "mm ";
                    mm.Height = 198;
                    mm.Weight = 80;
                    mm.Totalcrosses = 30;
                    mm.Successcrosses = 24;

                    mm.avgrating();
                    allplayers.Add(mm);
                    zamalk.AddplayersT(mm);

                    mid emad = new mid();

                    emad.Name = "emad ";
                    emad.Height = 198;
                    emad.Weight = 80;
                    emad.Totalpasses = 50;
                    emad.Successpasses = 23;
                    emad.avgrating();
                    allplayers.Add(emad);
                    zamalk.AddplayersT(emad);

                    mid gaafar = new mid();

                    gaafar.Name = "gafaar ";
                    gaafar.Height = 198;
                    gaafar.Weight = 80;
                    gaafar.Totalpasses = 60;
                    gaafar.Successpasses = 29;
                    gaafar.avgrating();
                    allplayers.Add(gaafar);
                    zamalk.AddplayersT(gaafar);
                    mid said = new mid();

                    said.Name = "said ";
                    said.Height = 198;
                    said.Weight = 80;
                    said.Totalpasses = 80;
                    said.Successpasses = 79;
                    said.avgrating();
                    allplayers.Add(said);
                    zamalk.AddplayersT(said);
                    wing zizo = new wing();

                    zizo.Name = " zizo ";
                    zizo.Height = 198;
                    zizo.Weight = 80;
                    zizo.Totaldribbles = 30;
                    zizo.Successdribbles = 27;
                    zizo.avgrating();
                    allplayers.Add(zizo);
                    zamalk.AddplayersT(zizo);
                    wing maher = new wing();

                    maher.Name = " msher ";
                    maher.Height = 198;
                    maher.Weight = 80;
                    maher.Totaldribbles = 30;
                    maher.Successdribbles = 28;
                    maher.avgrating();
                    allplayers.Add(maher);
                    zamalk.AddplayersT(maher);


                    st mansy = new st();
                    mansy.Name = " mansy ";
                    mansy.Height = 198;
                    mansy.Weight = 80;
                    mansy.Totalshoots = 40;
                    mansy.Successshoots = 21;
                    mansy.avgrating();
                    allplayers.Add(mansy);
                    zamalk.AddplayersT(mansy);




                    




                    goalkeeper ahmed = new goalkeeper();
                    ahmed.Name = "ahmed   ";
                    ahmed.Height = 198;
                    ahmed.Weight = 100;
                    ahmed.Totalsaves = 100;
                    ahmed.Successsaves = 50;
                    ahmed.avgrating();
                    allplayers.Add(ahmed);
                    pyr.AddplayersT(ahmed);
                    defender samy = new defender();

                    samy.Name = "samy";
                    samy.Height = 185;
                    samy.Weight = 90;
                    samy.Totaltackles = 40;
                    samy.Successtackles = 20;
                    samy.avgrating();
                    allplayers.Add(samy);
                    pyr.AddplayersT(samy);
                    defender nabil = new defender();

                    nabil.Name = "nabil";
                    nabil.Height = 185;
                    nabil.Weight = 90;
                    nabil.Totaltackles = 50;
                    nabil.Successtackles = 49;
                    nabil.avgrating();
                    allplayers.Add(nabil);
                    pyr.AddplayersT(nabil);

                    back ramadan = new back();

                    ramadan.Name = "ramadan ";
                    ramadan.Height = 198;
                    ramadan.Weight = 80;
                    ramadan.Totalcrosses = 27;
                    ramadan.Successcrosses = 20;
                    
                    ramadan.avgrating();
                    allplayers.Add(ramadan);
                    pyr.AddplayersT(ramadan);

                    back shokry = new back();

                    shokry.Name = "shokry ";
                    shokry.Height = 198;
                    shokry.Weight = 80;
                    shokry.Totalcrosses = 35;
                    shokry.Successcrosses = 34;

                    shokry.avgrating();
                    allplayers.Add(shokry);
                    pyr.AddplayersT(shokry);

                    mid ma = new mid();

                    ma.Name = "ma ";
                    ma.Height = 198;
                    ma.Weight = 80;
                    ma.Totalpasses = 60;
                    ma.Successpasses = 55;
                    ma.avgrating();
                    allplayers.Add(ma);
                    pyr.AddplayersT(ma);

                    mid ibrahim = new mid();

                    ibrahim.Name = "ibrahim ";
                    ibrahim.Height = 198;
                    ibrahim.Weight = 80;
                    ibrahim.Totalpasses = 26;
                    ibrahim.Successpasses = 25;
                    ibrahim.avgrating();
                    allplayers.Add(ibrahim);
                    pyr.AddplayersT(ibrahim);
                    mid kendouci = new mid();

                    kendouci.Name = "kedoucci ";
                    kendouci.Height = 198;
                    kendouci.Weight = 80;
                    kendouci.Totalpasses = 55;
                    kendouci.Successpasses = 45;
                    kendouci.avgrating();
                    allplayers.Add(kendouci);
                    pyr.AddplayersT(kendouci);

                    wing ougola = new wing();

                    ougola.Name = " ougola ";
                    ougola.Height = 198;
                    ougola.Weight = 80;
                    ougola.Totaldribbles = 31;
                    ougola.Successdribbles = 30;
                    ougola.avgrating();
                    allplayers.Add(ougola);
                    pyr.AddplayersT(ougola);
                    wing okoye = new wing();

                    okoye.Name = " okoye ";
                    okoye.Height = 198;
                    okoye.Weight = 80;
                    okoye.Totaldribbles = 30;
                    okoye.Successdribbles = 29;
                    okoye.avgrating();
                    allplayers.Add(okoye);
                    pyr.AddplayersT(okoye);


                    st shamy = new st();
                    shamy.Name = " shamy ";
                    shamy.Height = 198;
                    shamy.Weight = 80;
                    shamy.Totalshoots = 40;
                    shamy.Successshoots = 38;
                    shamy.avgrating();
                    allplayers.Add(shamy);
                    pyr.AddplayersT(shamy);
                    



                    goalkeeper bassem = new goalkeeper();
                    bassem.Name = "bassam  ";
                    bassem.Height = 198;
                    bassem.Weight = 100;
                    bassem.Totalsaves = 100;
                    bassem.Successsaves = 50;
                    bassem.avgrating();
                    allplayers.Add(bassem);
                    ceramic.AddplayersT(bassem);
                    defender samir = new defender();

                    samir.Name = "samir";
                    samir.Height = 185;
                    samir.Weight = 90;
                    samir.Totaltackles = 40;
                    samir.Successtackles = 30;
                    samir.avgrating();
                    allplayers.Add(samir);
                    ceramic.AddplayersT(samir);
                    defender ramy = new defender();

                    ramy.Name = "ramy";
                    ramy.Height = 185;
                    ramy.Weight = 90;
                    ramy.Totaltackles = 30;
                    ramy.Successtackles = 24;
                    ramy.avgrating();
                    allplayers.Add(ramy);
                    ceramic.AddplayersT(ramy);

                    back chibi = new back();

                    chibi.Name = "chibi ";
                    chibi.Height = 198;
                    chibi.Weight = 80;
                    chibi.Totalcrosses = 27;
                    chibi.Successcrosses = 26;
                    allplayers.Add(chibi);
                    ceramic.AddplayersT(chibi);
                    fotouh.avgrating();

                    back hamdy = new back();

                    hamdy.Name = "hamdy ";
                    hamdy.Height = 198;
                    hamdy.Weight = 80;
                    hamdy.Totalcrosses = 29;
                    hamdy.Successcrosses = 23;
                    
                    hamdy.avgrating();
                    allplayers.Add(fotouh);
                    ceramic.AddplayersT(fotouh);

                    mid karti = new mid();

                    karti.Name = "karti ";
                    karti.Height = 198;
                    karti.Weight = 80;
                    karti.Totalpasses = 20;
                    karti.Successpasses = 15;
                    karti.avgrating();
                    allplayers.Add(karti);
                    ceramic.AddplayersT(karti);

                    mid sobhi = new mid();

                    sobhi.Name = "sobhi ";
                    sobhi.Height = 198;
                    sobhi.Weight = 80;
                    sobhi.Totalpasses = 50;
                    sobhi.Successpasses = 45;
                    sobhi.avgrating();
                    allplayers.Add(sobhi);
                    ceramic.AddplayersT(sobhi);
                    mid toure = new mid();

                    toure.Name = "toure ";
                    toure.Height = 198;
                    toure.Weight = 80;
                    toure.Totalpasses = 50;
                    toure.Successpasses = 46;
                    toure.avgrating();
                    allplayers.Add(toure);
                    ceramic.AddplayersT(toure);

                    wing adel = new wing();

                    adel.Name = " adel ";
                    adel.Height = 198;
                    adel.Weight = 80;
                    adel.Totaldribbles = 60;
                    adel.Successdribbles = 45;
                    adel.avgrating();
                    allplayers.Add(adel);
                    ceramic.AddplayersT(adel);
                    wing fathi = new wing();

                    fathi.Name = " fathi ";
                    fathi.Height = 198;
                    fathi.Weight = 80;
                    fathi.Totaldribbles = 50;
                    fathi.Successdribbles = 48;
                    fathi.avgrating();
                    allplayers.Add(fathi);
                    ceramic.AddplayersT(fathi);


                    st mayele = new st();
                    mayele.Name = " mayele ";
                    mayele.Height = 198;
                    mayele.Weight = 80;
                    mayele.Totalshoots = 41;
                    mayele.Successshoots = 38;
                    mayele.avgrating();
                    allplayers.Add(mayele);
                    ceramic.AddplayersT(mayele);

                    allplayers.Add(awad);
                    allplayers.Add(ahmed);
                    player[] topgoalkeeper = new player[2];

                    for (int g = 0; g < 2; g++)
                    {
                        foreach (player m in allplayers)
                        {
                            if (m.Position != "goal keeper ")
                                continue;





                            bool playerintopplayer = false;
                            foreach (player exisiting in topgoalkeeper)
                            {
                                if (exisiting == m)
                                {
                                    playerintopplayer = true;

                                    break;
                                }

                            }
                            if (playerintopplayer == true)
                            {
                                continue;
                            }
                            if (playerintopplayer == true)
                            {
                                continue;
                            }

                            if (topgoalkeeper[g] == null)
                            {
                                topgoalkeeper[g] = m;

                                continue;

                            }




                            if (topgoalkeeper[g].avgrating() < m.avgrating())
                            {

                                topgoalkeeper[g] = m;


                            }


                        }
                    }
                    foreach (player item in topgoalkeeper)
                    {
                        Console.WriteLine($"name {item.Name} rating{item.avgrating()}");

                    }


                    for (int i = 0; i < 10; i++)
                    {
                        foreach (player j in allplayers)
                        {
                            bool playerintopplayer = false;
                            foreach (player exisiting in topplayers)
                            {
                                if (exisiting == j)
                                {
                                    playerintopplayer = true;

                                    break;
                                }

                            }
                            if (playerintopplayer == true)
                            {
                                continue;
                            }
                           

                            if (topplayers[i] == null)
                            {
                                topplayers[i] = j;

                                continue;

                            }




                            if (topplayers[i].avgrating() < j.avgrating())
                            {

                                topplayers[i] = j;


                            }
                           

                            }



                       
                    }
                    foreach (player ai in topplayers)
                    {
                        try
                        {
                            if (ai != null)
                                Console.WriteLine($"name {ai.Name} rating {ai.avgrating()}");
                            else
                                throw new Exception();

                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            continue;
                        }
                    }
                }

            }



            }
        }
    }

