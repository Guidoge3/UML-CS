using System;
using System.Collections.Generic;
using System.Text;

namespace Database_Gods
{
    class Gods
    {
        public List<GodsSavepoint> names = new List<GodsSavepoint>();
        public GodsSavepoint newName;
        public int makeNeam;

        public string theGodname;
        public int showNames;

        public void AddGod(GodsSavepoint savepoint)
        {
            names.Add(savepoint);
        }

        public List<GodsSavepoint>GetName()
        {
            return names;
        }
        public void RunGod()
        {
            Console.WriteLine("What is the name of your god?");
            string godName = Console.ReadLine();
            Console.WriteLine("So, the name of the god is " + godName);
            newName = new GodsSavepoint("The name of the god is " + godName);
            names.Add(newName);
            Console.WriteLine("Do you want to see the name?\n1- Yes \n2-No");
            showNames = AskForInput(2);
            switch (showNames)
            {
                case 1:
                    ViewGods();
                    break;
                case 2:
                    break;
            }
        }

        public void ViewGods()
        {
            foreach(GodsSavepoint g in GetName())
            {
                Console.WriteLine("\n" + g.name);
            }
            Run();
        }

        public void Run()
        {
            Console.WriteLine("Do you want to add a name?\n1- Yes \n2- No");
            makeNeam = AskForInput(2);
            switch (makeNeam)
            {
                case 1:
                    RunGod();
                    break;
                case 2:
                    break;
            }
        }

        private int AskForInput(int maxNumber)
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input <= maxNumber && input >= 0)
                {
                    return input;
                }
                Console.WriteLine("That option is not available");
            }
            else
            {
                Console.WriteLine("Invalid input: please insert a number");
            }
            return AskForInput(maxNumber);
        }
    }
}
