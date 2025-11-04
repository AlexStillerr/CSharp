namespace Adventure
{
    /*
     * Force the player to type a valid input in the Consol
     */
    public static class InputHelper
    {
        public static int GetValidInt(string text, int min, int max)
        {
            do
            {
                Console.WriteLine(text);
                try
                {
                    string input = Console.ReadLine();
                    int number = int.Parse(input);

                    if (number >= min && number <= max)
                        return number;
                    Console.WriteLine($"Deine Eingabe {input} liegt ausserhalb der Reichweite");
                }
                catch
                {
                    Console.WriteLine("Ungültige Eingabe");
                }
            } while (true);

        }

        internal static string GetValidString()
        {
            do
            {
                string? input = Console.ReadLine();
                if (input == null)
                    Console.WriteLine("Ungültige Eingabe");
                else
                    return input;
            } while (true);
        }
    }
}
