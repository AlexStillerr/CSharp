using Adventure;

class Programm
{
    /*
    Entwickle ein C#-Programm, das ein einfaches Textabenteuerspiel simuliert. 
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Willkommen zu einem neuen Abenteuer! Zu erst brauche ich deinen Namen:");
        string? playerName = Console.ReadLine();
        Console.WriteLine($"Hallo {playerName}. Dann kann das Abenteuer beginnen");

        TextAdventure adventure = new TextAdventure(playerName);
        adventure.Play();
    }
}