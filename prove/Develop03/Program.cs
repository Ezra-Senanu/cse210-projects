public class Program{
       static void Main(string[] args)
    {
        string userInput = "";
        Reference set = new Reference("John", 3, 16);
        string text = "For God so loved the world that He gave His only Begotten Son...";
        Scripture theScripture = new Scripture(set, text);

        string refer = set.GetReferenceText();
        string script = theScripture.GetDisplaySet();
        Console.WriteLine($"{refer}: {script}");

        while (userInput != "quit")
        {
            OpenMessage();
            userInput = Console.ReadLine();
            Console.Clear();
        }

        static void OpenMessage()
        {
            Console.Write("\nWelcome to the scripture Memorizer game, press enter to hide words, or type 'quit' to end the game. ");
        }
    }
    }