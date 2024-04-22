namespace Inheritance_BarnettLandon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assigns apex and rating
            FPS myFPS = new FPS("T", "Apex Legends");
            //Prints description of the game
            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();

        }
    }
}