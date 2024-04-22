using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BarnettLandon
{
    //Abstract class for GAME
    abstract internal class Game
    {
        //get and set for rating
        public string Esrb { get; set; }
        //get and set for title
        public string Title { get; set; }
        
        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }
        //Prints thta title is starting
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is  starting");
        }

        public abstract string Describe();
    }
}
