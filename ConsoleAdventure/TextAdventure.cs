namespace Adventure
{
    internal class TextAdventure
    {
        private string playerName;
        private bool isRunning = true;
        private int path = 0;
        private List<HandleScenario> scenarioList = null;

        public TextAdventure(string playerName)
        {
            this.playerName = playerName;

            PrepareAdventure();
        }

        private void PrepareAdventure()
        {
            scenarioList = new List<HandleScenario>{ new FindADragon(), new ABridgeTroll(), new Nothing(), new FolwerField(), new SleepingBandits(),
                    new TheBlackKnight(playerName), new StrangeMist(), new AHidingWolf(playerName), new BrokenCart(), new SomethingWillFollowYou()};

            scenarioList.Shuffle();
        }

        internal void Play()
        {
            while (isRunning)
            {
                SelectPath();
                HandlePathEvent();
                Console.WriteLine("Möchtest du weiter spielen?(Ja/Nein)");
                string? keepOnPlaying = Console.ReadLine();
                if (keepOnPlaying == null || keepOnPlaying.ToLower().Equals("nein"))
                    isRunning = false;
            }
        }

        private void SelectPath()
        {
            Console.WriteLine("Welchen Pfad möchtest du gehen?");
            path = InputHelper.GetValidInt("1-10", 1, 10);
        }

        private void HandlePathEvent()
        {
            HandleScenario current = scenarioList[path - 1];
            Console.WriteLine($"-------------------------------- {current.ScenarioName} --------------------------------");
            current.Enter();
            current.Overcome();
            current.Exit();
            Console.WriteLine("-------------------------------- Ende des Weges --------------------------------");
        }
    }
}
