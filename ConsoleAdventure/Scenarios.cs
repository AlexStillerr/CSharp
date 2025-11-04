namespace Adventure
{
    public interface HandleScenario
    {
        string ScenarioName { get; }
        void Enter();
        void Overcome();
        void Exit();
    }

    public class FindADragon : HandleScenario
    {
        public string ScenarioName => "Der Drache";

        public void Enter()
        {
            Console.WriteLine("Du begegnest einem freundlichen Drachen. Es ist noch ein junger Drache und er sieht dich fragend an");
        }

        public void Exit()
        {
            Console.WriteLine("Der Drache fliegt zufrieden davon");
        }

        public void Overcome()
        {
            Console.WriteLine("Du hörst eine Stimme in deinem Kopf. 'Was glaubst du wohl wie alt ich bin? Ich gebe dir einen Tipp: es ist eine Zahl zwischen 1 und 100'");
            Random rnd = new Random();
            int dragonAge = rnd.Next(1, 100);
            int guess = 0;
            do
            {
                guess = InputHelper.GetValidInt("1 - 100:",1 ,100);
                if (guess < dragonAge)
                    Console.WriteLine("Er schüttelt den Kopf. 'Zu niedrig'");
                else if (guess > dragonAge)
                    Console.WriteLine("Er schau dich grimmig an. 'Zu hoch'");
            } while (guess != dragonAge);
            Console.WriteLine("Er nickt zu frieden. 'Bingo'");
        }
    }

    public class ABridgeTroll : HandleScenario
    {
        public string ScenarioName => "Der Troll";

        private bool paidEnough = true;
        public void Enter()
        {
            Console.WriteLine("In der Ferne entdeckst du ein Troll der die Brücke blockiert.");
        }

        public void Exit()
        {
            if (paidEnough)
                Console.WriteLine("Der Troll winkt dir zum Abschied hinterher");
            else
                Console.WriteLine("Du hörst noch länger seine Verwünschungen durch den Wald hallen.");
        }

        public void Overcome()
        {
            Console.WriteLine("Troll: 'Halt! Ich verlange Maut für meine Brücke!'");
            Console.WriteLine("Troll: 'Maut ist Maut und Kraut ist Kraut. Ohne Maut kein Kraut und flux den Magen versaut'");
            Console.WriteLine("Troll: 'Hab ich selbst gereimt'");

            Console.WriteLine("Wieviel Gold willst du ihm geben?");
            int gold = InputHelper.GetValidInt("0-200",1 ,200);
            const int valueLow = 50, valueMid = 100, valueHigh = 150;
            switch(gold)
            {
                case 0: Console.WriteLine("Troll: 'Du bist gemein'");
                    paidEnough = false;
                    break;
                case > 0 and <=valueLow: Console.WriteLine("Der Troll nickt stum.");
                    break;
                case > valueLow and <= valueMid:
                    Console.WriteLine("Troll: 'Danke und beehren sie mich bald wieder.'");
                    break;
                case > valueMid and <= valueHigh:
                    Console.WriteLine($"Troll: 'Das ist zuviel. Hier!' Er gibt dir {gold-10} Gold zurück.");
                    break;
                case > valueHigh:
                    Console.WriteLine("Troll: 'Du scheinst ja Gold im Überfluss zu haben.'");
                    break;
            }
        }
    }

    public class Nothing : HandleScenario
    {
        public string ScenarioName => "Das <Name hier einfügen>";

        public void Enter()
        {
            Console.WriteLine("Du gehst voller Erwartungen den Weg entlang.");
        }

        public void Exit()
        {
            Console.WriteLine("Du fühlst dich entspannter");
        }

        public void Overcome()
        {
            Console.WriteLine("Hier scheint nichts zu sein...");
            Console.WriteLine("Ist das Öde.");
            int count = InputHelper.GetValidInt("Hey was ist deine Lieblingszahl?",0 ,int.MaxValue);
            string printOut = "";
            for (int i = 0; i < Math.Min(count, 20); i++)
                printOut += "Öde ";
            Console.WriteLine(printOut);
            Console.WriteLine("Oh ein Eichhörnchen");
        }
    }

    public class FolwerField : HandleScenario
    {
        public string ScenarioName => "Die Wiese";

        private Dictionary<string, int> flowerPrices = new Dictionary<string, int>{
                    { "Rot", 2 },
                    { "Lila", 3 },
                    { "Weiß", 4 },
                    { "Gelb", 5 }};

        private bool isSolved = false;
        public void Enter()
        {
            Console.WriteLine("Vor dir erstreckt sich eine große Blumenwiese.");
            Console.WriteLine("Du entdeckst eine Frau mir Preistafel");
        }

        public void Exit()
        {
            if (isSolved)
                Console.WriteLine("Glücklich gehst du mit deinem Blumenstrauß von dannen?");
            else
                Console.WriteLine("Ach wer braucht schon Blumen. Traurig gehst du deiner Wege.");
        }

        public void Overcome()
        {
            Random rnd = new Random();
            int goal = rnd.Next(10, 25);
            Console.WriteLine($"Pflücke genau 5 Blumen auf den Betrag von {goal} Gold zu kommen.");
            foreach(var pair in flowerPrices)
                Console.WriteLine($"{pair.Key}:{pair.Value} Gold");
            
            CollectFlowers(goal);
        }

        private void CollectFlowers(int goal)
        {
            bool isRunning = true;
            do
            {
                int totalFlower = 0, totalPrice = 0;
                foreach (var pair in flowerPrices)
                {
                    Console.WriteLine($"Wieviele Blumen in {pair.Key} willst du)");
                    int count = InputHelper.GetValidInt($"0-{5 - totalFlower}",0 , 5 - totalFlower);
                    totalFlower += count;
                    totalPrice += count * pair.Value;

                    if (totalFlower >= 5)
                        break;
                }

                if(totalPrice == goal)
                {
                    isRunning = false;
                    isSolved = true;
                }
                else
                {
                    Console.WriteLine($"Das war leider nicht richtig. Du hast {totalFlower} Blumen für {totalPrice} Gold gepflückt.");
                    Console.WriteLine("Willst du es nochmal versuchen? (Ja/Nein)");
                    string? option = Console.ReadLine();
                    if(option ==  null || option == "Nein")
                        isRunning = false;
                }
            } while (isRunning);
        }
    }

    public class SleepingBandits : HandleScenario
    {
        public string ScenarioName => "Das Lager";

        private int totalGold;
        private bool stillSleeping;

        private Dictionary<int,int> wakeupPossibility = new Dictionary<int, int>() { {1, 20}, {2, 40}, {3, 60} };

        public void Enter()
        {
            Console.WriteLine("Du riechst Feuer. Vorsichtig näherst du dich einem Lager.");
            Console.WriteLine("Es scheint ein Räuberlager zu sein. Alle schlafen, war wohl ne harte Nacht");
        }

        public void Exit()
        {
            if (stillSleeping)
                Console.WriteLine($"Na das hat sich doch gelohnt und so entspannt {totalGold} Gold eingesammelt.");
            else
            {
                if(totalGold == 0)
                    Console.WriteLine($"Ok das war mal nichts. Die hatten wohl ein leichten Schlaf. Aber Momentmal, wo ist den deine Goldbörse...");
                else
                    Console.WriteLine($"Du bist ausser Atem, aber in Sicherheit und um {totalGold / 2} Gold reicher.");
            }
        }

        public void Overcome()
        {
            totalGold = 0;
            stillSleeping = true;
            Random rnd = new Random();
            Console.WriteLine("Eine gute Gelegenheit sich etwas zu holen was anderen gestohlen wurde.");
            Console.WriteLine("Du kannst solange sammeln wie du willst. Je Größer desto wertvoller, aber auch wahscheinlicher jemanden zu wecken.");
            while (stillSleeping)
            {
                Console.WriteLine("Was willst du einsammeln Klein(1), Mittel(2), Groß(3)");
                int size = InputHelper.GetValidInt("1-3", 1, 3);

                int number = rnd.Next(100);
                stillSleeping = wakeupPossibility[size] < number;

                if (stillSleeping)
                {
                    totalGold += rnd.Next(size * 10, wakeupPossibility[size]);

                    Console.WriteLine("Das ging gut. Willst du weiter machen? (Ja/Nein)");
                    string? option = Console.ReadLine();
                    if (option == null || option.ToLower() == "nein")
                        break;
                }
                else 
                    Console.WriteLine($"Oh Oh. Du wurdest entdeckt. {number} < {wakeupPossibility[size]}");
            }
        }
    }

    public class AHidingWolf : HandleScenario
    {
        public string ScenarioName => "Der Wolf";

        private string name;

        public AHidingWolf(string playerName)
        {
            name = playerName;
        }

        public void Enter()
        {
            Console.WriteLine("In einem Gebüsch siehst du einen Wolf, der auf etwas wartet.");
        }

        public void Exit()
        {
            Console.WriteLine("Diese Waffeln sind wirklich lecker");
        }

        public void Overcome()
        {
            Console.WriteLine("Du schaust in die Richtugn in die der Wolf schaut siehst wie sich jemand mit rotem Kopftuch nähert.");
            Console.WriteLine("Willst du den Wolf ansprechen(1) oder beobachten was passiert(2)?");
            int option = InputHelper.GetValidInt("1 oder 2", 1, 2);
            if (option == 1)
                TalkToTheWolf();
            else
                EnjoyTheShow();
        }

        private void EnjoyTheShow()
        {
            Console.WriteLine("Du willst wirklich nur zusehen?");
            Console.WriteLine("Es könnte schrecklich werden!");
            Console.WriteLine("Nope. So nicht!");
            Console.WriteLine("Du gehst zum Wolf.");
        }

        private void TalkToTheWolf()
        {
            List<string> goodStuff = new() { "zucker", "sirup", "marzipan", "apfel", "obst" };
            Console.WriteLine("Wolf: 'Hey was soll das? Du lässt meine Tarnung auffliegen.'");
            Console.WriteLine($"{name}: 'Aber man kann dich gut sehen. Du bist viel zu groß um dich zu verstecken.'");
            Console.WriteLine("Wolf: 'Ich will doch nur die super lecken Waffeln haben. Immer vergesse ich was bei dem Rezept.'");
            Console.WriteLine("Du siehst ein einem Korb die Zutaten liegen: Eier, Mehl, Milch, Rum. Ja da fehlt eindeutig etwas.");

            Console.WriteLine("Was würdest du dazu tun?");
            string incredient = InputHelper.GetValidString();
            Console.WriteLine($"{name}: 'Wie wäre es mit {incredient}?'");
            if( goodStuff.Contains( incredient.ToLower()))
            {
                Console.WriteLine("Wolf: 'Ja genau. Vielen dank.' Er stürmt davon");
                Console.WriteLine("Kurze Zeit später kommt er zurück und gibt dir eine Waffel ab.");
            }
            else
            {
                Console.WriteLine("Wolf: 'Bist du dir sicher?' Er macht sich nachdenklich ans Werk.");
                Console.WriteLine("Das Resultat ist.... sagen wir mal interessant.....");
                Console.WriteLine("Die Person mit dem roten Kopftuch kommt zu euch und bietet euch eine Waffel an.");
            }
        }
    }

    public class TheBlackKnight : HandleScenario
    {
        public string ScenarioName => "Der Ritter";

        private string[] fightActions = {"Stich", "Hieb", "Parade" };
        private string name;

        public TheBlackKnight(string playerName)
        {
            name = playerName;
        }

        public void Enter()
        {
            Console.WriteLine("Du hörst Kampfgeräusche. Als du näher kommst siehst du den Schwarzen Ritter. Sein Gegner fällt gerade zu Boden");
        }

        public void Exit()
        {
            Console.WriteLine("'Feigling' Seine Rufen hinter dir werden immer leiser");
        }

        private void Fight()
        {
            Random rnd = new Random();
            Console.WriteLine("Du bist bereit zum kämpfen");
            bool wasHit = false;
            while (!wasHit)
            {
                Console.WriteLine("Stich(1), Hieb(2) oder Parade(3)?");
                int option = InputHelper.GetValidInt("1-3", 1, 3);
                int blackKnight = rnd.Next(3)+1;
                // Stich besiegt Hieb -> Hieb besiegt Parade -> Parade besiegt Stich
                if (GetConter(option) == blackKnight)
                    wasHit = true;
                else
                    Console.WriteLine($"Der Ritter kontert mit {fightActions[blackKnight-1]}");
            }

            int GetConter(int value) => (value) % 3 +1;
        }

        public void Overcome()
        {
            Console.WriteLine("Willst du Kämpfer(1) oder vorbei gehen(2)?");
            int option = InputHelper.GetValidInt("1 oder 2", 1, 2);

            if (option == 2)
                Console.WriteLine("Der Ritter spricht: 'An mir kommt niemand vorbei'");

            Console.WriteLine("Gut dann muss es sein!");
            Fight();
            Console.WriteLine();
            Console.WriteLine($"{name}: 'Ihr habt tapfer gekämpft'");
            Console.WriteLine("Schwarzer Ritter: 'Ach das ist nur ein Kratzer'");
            Console.WriteLine($"{name}: 'Euer Arm ist ab'");
            Console.WriteLine("Schwarzer Ritter: 'Ist er nicht!'");
            Console.WriteLine($"{name}: 'Und was ist das?' du deutest auf den Arm am Boden");
            Console.WriteLine("Schwarzer Ritter: 'Oh. Macht nix, es gibt schlimmeres.'");
            Console.WriteLine();
            Fight();
            Console.WriteLine();
            Console.WriteLine("Schwarzer Ritter: 'Los es geht weiter'");
            Console.WriteLine($"{name}: 'Du hast keine Arme mehr'");
            Console.WriteLine("Schwarzer Ritter: 'Wer sagt das?'");
            Console.WriteLine($"{name}: 'Na kratz dich mal'");
            Console.WriteLine("Schwarzer Ritter: 'Ach nur eine Fleischwunde'");
            Console.WriteLine();
            Fight();
            Console.WriteLine();
            Console.WriteLine("Der Schwarze Ritter hüpft auf einem Bein auf dich zu");
            Console.WriteLine("Schwarzer Ritter: 'Ich spuck dir ins Auge und blende dich'");
            Console.WriteLine($"{name}: 'Was machst du?'");
            Console.WriteLine("Schwarzer Ritter: 'Der Schwarze Ritter gewinnt immer!'");
            Console.WriteLine("Schwarzer Ritter: 'Ich schlag dich zusammen'");
            Console.WriteLine();
            Fight();
            Console.WriteLine();
            Console.WriteLine("Schwarzer Ritter: 'Ok, einigen wir uns auf unentschieden'");
            Console.WriteLine("Du gehst Kopfschüttelnd weiter");
        }
    }

    public class StrangeMist : HandleScenario
    {
        public string ScenarioName => "Der Nebel";

        private enum GameState
        {
            Running,
            PlayerOneWin,
            PlayerTwoWin,
            Draw,
            Flee
        }

        private GameState gameState;
        private Random random;
        private int[,] field = new int[3,3];
        private const int PLAYER1 = 100, PLAYER2 = 200;
        private List<List<(int,int)>> winConditions = new() { 
            new List<(int, int)> { (0,0), (0,1), (0,2) },
            new List<(int, int)> { (1,0), (1,1), (1,2) },
            new List<(int, int)> { (2,0), (2,1), (2,2) },
            new List<(int, int)> { (0,0), (1,0), (2,0) },
            new List<(int, int)> { (0,1), (1,1), (2,1) },
            new List<(int, int)> { (0,2), (1,2), (2,2) },
            new List<(int, int)> { (0,0), (1,1), (2,2) },
            new List<(int, int)> { (0,2), (1,1), (2,0) }
        };

        public void Enter()
        {
            ResetField();

            gameState = GameState.Running;
            random = new Random();

            Console.WriteLine("Du kannst kaum noch die Hand vor Augen sehen. Wo bist du nur und wo geht es hier raus?");
            Console.WriteLine("Es hilft nichts, du musst dir notieren wo du schon warst.");
        }

        private void ResetField()
        {
            for (int i = 0; i < 9; ++i)
                field[i % 3, i / 3] = i + 1;
        }

        public void Exit()
        {
            switch (gameState)
            {
                case GameState.PlayerOneWin:
                    Console.WriteLine("Du besiegst den Nebel und findest einen kleinen Schatz in seiner Mitte. Als du die Truhe öffnest lichtet sich der Neben und du stehst auf einer kleinen Lichtung");
                    break;
                case GameState.PlayerTwoWin:
                    Console.WriteLine("Der Nebel wird dichter und dichter, er verschlingt dich. Ziellos läufst du durch den Wald und direkt gegen einen Baum");
                    Console.WriteLine("Als du aufwachst hast du eine dicke Beule am Kopf, aber immerhin ist der Nebel weg und irgendwann gehen auch die Kopfschmerzen weg");
                    break;
                case GameState.Flee:
                    Console.WriteLine("Das ist zuviel und du hast auch einfach kein Bock. Du legst dich ins weiche Moos und machst ein Nickerchen");
                    Console.WriteLine("Kurze Zeit später öffnest du die Augen und der Nebel ist weg");
                    break;
            }
        }

        public void Overcome()
        {
            Random rnd = new Random();
            int player = PLAYER1;
            int turns = 0;
            do
            {
                if(player == PLAYER1)
                    PrintField();
                PlayerTurn(player);
                CheckWin();
                turns++;
                player = player == PLAYER1 ? PLAYER2 : PLAYER1;

                if(turns == 9)
                    AskForReset(ref turns, ref player);

            } while (gameState == GameState.Running);

        }

        private void CheckWin()
        {
            foreach(var condition in winConditions)
            {
                int sum = GetValue(condition[0]) + GetValue(condition[1]) + GetValue(condition[2]);
                if (sum == PLAYER1*3)
                {
                    gameState = GameState.PlayerOneWin;
                    break;
                }
                else if (sum == PLAYER2*3)
                {
                    gameState = GameState.PlayerTwoWin;
                    break;
                }
            }

            int GetValue((int x, int y) con) => field[con.x, con.y];
        }

        private void PlayerTurn(int player)
        {
            do
            {
                int x = 0, y = 0;
                if (player == PLAYER1)
                {
                    Console.WriteLine("Wo willst du hin?");
                    int index = InputHelper.GetValidInt("1-9", 1, 9) - 1;
                    x = index % 3;
                    y = index / 3;
                }
                else // AI Turn
                {
                    x = random.Next(3);
                    y = random.Next(3);
                }

                if (IsFieldFree(x, y))
                {
                    SetField(x, y, player);
                    break;
                }
                else if( player == PLAYER1)
                    Console.WriteLine("Das Feld ist schon belegt");

            } while (true);
        }

        private void AskForReset(ref int turns, ref int player)
        {
            Console.WriteLine("Das war wohl nicht der richtige Weg. Willst du es nochmal versuchen(1) oder eine dich eine Runde hinlegen(2)?");
            int option = InputHelper.GetValidInt("1 oder 2", 1, 2);
            if (option == 1)
            {
                turns = 0;
                player = PLAYER1;
                ResetField();
            }
            else
                gameState = GameState.Flee;
        }

        private bool IsFieldFree(int x, int y) => field[x, y] < 10;

        private void SetField(int x, int y, int player) => field[x,y] = player;

        private void PrintField()
        {
            Console.WriteLine($"   |   |  ");
            Console.WriteLine($" {GetFieldValue(0,0)} | {GetFieldValue(1, 0)} | {GetFieldValue(2, 0)}");
            Console.WriteLine($"   |   |  ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($"   |   |  ");
            Console.WriteLine($" {GetFieldValue(0, 1)} | {GetFieldValue(1, 1)} | {GetFieldValue(2, 1)}");
            Console.WriteLine($"   |   |  ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($"   |   |  ");
            Console.WriteLine($" {GetFieldValue(0, 2)} | {GetFieldValue(1, 2)} | {GetFieldValue(2, 2)}");
            Console.WriteLine($"   |   |  ");

            string GetFieldValue(int x, int y)
            {
                if (field[x, y] < 10)
                    return field[x, y].ToString();

                return field[x, y] == PLAYER1 ? "X" : "~";
            }
        }
    }

    public class SomethingWillFollowYou : HandleScenario
    {
        public string ScenarioName => "Die Angst";

        private List<string> actions = new(){"gehen", "rennen", "verstecken", "rufen", "aufgeben" };
        public void Enter()
        {
            Console.WriteLine("Du glaubst aufeinmal Schritte hinter dir zu hören. Du drehst dích um, aber siehst niemanden,");
            Console.WriteLine("Als du weiter gehst hörst du wieder Schritte.");
        }

        public void Exit()
        {
            Console.WriteLine("Hier könnte wirklich was interessanteres passieren");
        }

        public void Overcome()
        {
            //Console.WriteLine();
            int option = 0;
            do
            {
                PrintActions();
                option = InputHelper.GetValidInt("was willst du tun? (1-5)", 1, 5) - 1;
                switch(option)
                {
                    case 0:
                        Console.WriteLine($"{actions[option]}: Du gehst weiter und hörst die Schritte. Sobald du stehen bleibst hörst du nur noch die geräusche im Wald");
                        break;
                    case 1:
                        Console.WriteLine($"{actions[option]}: Du rennst voller Panik los. Du glaubst sogar das die Schritte näher kommen.");
                        Console.WriteLine("Nach einigen Metern kannst du nicht mehr und sackst am rand zusammen. Du merkst wie sich jemand nähert.");
                        Console.WriteLine("Elfe: 'Endlcih habe ich dich eingeholt. Du hast dein Goldbeutel verloren. Hier'");
                        Console.WriteLine("Du nickst dankbar und bist leider viel zu fertig um sprechen zu können.");
                        break;
                    case 2:
                        Console.WriteLine($"{actions[option]}: Du hechtest in das nächste Gebüsch und wartest was passiert. Die Angst in dir kriecht hoch.");
                        Console.WriteLine("Die Schritte kommen näher..... nur noch ein paar Meter....");
                        Console.WriteLine("Ein kleines Häschen läuft an dem Gebüsch vorbei....");
                        Console.WriteLine("Verlegen kommst du aus dem Gebüsch. Die Akkustik hier scheint sehr gut zu sein...");
                        break;
                    case 3:
                        Console.WriteLine($"{actions[option]}: Du rufst laut 'Komm raus!! Was willst du von mir?'");
                        Console.WriteLine("Druide: 'Alta, was soll der radau. Kann man hier nicht mal in Ruhe Misteln schneiden?'");
                        Console.WriteLine("Du schaust verwunder nach oben und siehst einen alten Druiden im Baum sitzen.");
                        Console.WriteLine("Und dank seiner weiten Robe kannst du von unten mehr sehen als dir lieb ist. Die Bilder bekommst du bestimmt lange nicht aus dem Kopf.");
                        break;
                    case 4:
                        Console.WriteLine($"{actions[option]}: Trotzig bleibst du stehen und wartest. Soll was auch immer doch kommen, wie schlimm soll es schon werden");
                        Console.WriteLine("Du spürst ein Schlag auf den Kopf....");
                        Console.WriteLine(".....");
                        Console.WriteLine("Nach einiger Zeit wachst du wieder auf und greifst sofort nach deinem Gold... Es ist noch da.");
                        Console.WriteLine("Aber du merkst schnell das du wohl dem geschicktestem Dieb der Welt begegnet, denn die fehlen deine Socken und dein Unterhemd...");
                        break;
                }
            }while(option == 0);
        }

        private void PrintActions()
        {
            for (int i = 0; i < actions.Count; i++)
            {
                Console.Write($"({i + 1}) {actions[i]}");
                if (i != actions.Count - 1)
                    Console.Write(", ");
                else
                    Console.Write("\n");
            }
        }

    }

    public class BrokenCart : HandleScenario
    {
        public string ScenarioName => "Der Händler";

        private Dictionary<int, int> containers;
        private List<int> inputMapping = new() {-1, 5, 3, 2 };

        public void Enter()
        {
            containers = new() { { 5, 5 }, { 3, 0 }, { 2, 0 } };
            Console.WriteLine("An der nächsten Kurve entdeckst du ein Wagen der gegen einen Baum gefahren ist. Davor steht eine Person mit einem prächtigen Hut.");
            Console.WriteLine("Händler: 'Ah halllloooo sie. Darf ich sie mal an die Theke bitten?'");
        }

        public void Exit()
        {
            Console.WriteLine();
            if (containers[5] == 4)
            {
                Console.WriteLine("Der Hädler ist sehr dankebar für deine Hilfe und gibt den Traubensaft seinem Pferd.");
                Console.WriteLine("Dir überreicht er ein kleines Säckchen mit klimperndem Inhalt.");
            }
            else
            {
                Console.WriteLine("Du gehst ohne ein Wort an ihm vorbei.");
                Console.WriteLine("Händler: 'So eine Frechheit! Ja, ja, die Jugend von heute. Sowas hätte es damals nicht gegeben!'");
            }
        }
        
        public void Overcome()
        {
            Console.WriteLine("Händler: 'Ich habe ein riesen Problem. Meine gute und treue Isolde bekommt immer genau 4 Liter Traubensaft, aber mein 4 Liter Behälter ist zerbrochen.'");
            Console.WriteLine("Händler: 'Kannst du mir mit diesen Behältern helfen genau 4 Liter zu erhalten?'");
            PrintGalons();
            Console.WriteLine("Willst du helfen(1) oder gehen(2)?");
            int option = InputHelper.GetValidInt("1 oder 2", 1, 2);

            if (option == 2)
                return;
            
            do
            {
                Console.WriteLine("Wähle einen Behälter zum schütten?");
                int outContainer = InputHelper.GetValidInt("1 - 3", 1, 3);
                Console.WriteLine("Und in welchen Behälter willst du schütten?");
                int inContainer = InputHelper.GetValidInt("1 - 3", 1, 3);
                if (outContainer == inContainer)
                    Console.WriteLine("Lass den unfug!");
                else
                {
                    HandleTipInto(inputMapping[outContainer], inputMapping[inContainer]);
                    PrintGalons();
                }
            } while (containers[5] != 4); 
        }

        private void HandleTipInto(int outContainer, int inContainer)
        {
            int diff = Math.Min(containers[outContainer], inContainer - containers[inContainer]);
            containers[outContainer] -= diff;
            containers[inContainer] += diff;
        }

        private void PrintGalons()
        {
            string filled = "_____", empty = "     ";
            string[] visualContainer5 = { empty, empty, empty, empty, empty };
            string[] visualContainer3 = { empty, empty, empty};
            string[] visualContainer2 = { empty, empty};
            if (containers[5] != 0)
                visualContainer5[containers[5]-1] = filled;
            if (containers[3] != 0)
                visualContainer3[containers[3] - 1] = filled;
            if (containers[2] != 0)
                visualContainer2[containers[2] - 1] = filled;
            Console.WriteLine();
            Console.WriteLine($"   1       2       3   ");
            Console.WriteLine($" {visualContainer5[4]}                 ");
            Console.WriteLine($"|{visualContainer5[3]}|                ");
            Console.WriteLine($"|{visualContainer5[2]}|  {visualContainer3[2]}         ");
            Console.WriteLine($"|{visualContainer5[1]}| |{visualContainer3[1]}|  {visualContainer2[1]} ");
            Console.WriteLine($"|{visualContainer5[0]}| |{visualContainer3[0]}| |{visualContainer2[0]}|");
            Console.WriteLine($"| {containers[5]}/5 | | {containers[3]}/3 | | {containers[2]}/2 |");
        }
    }
}
