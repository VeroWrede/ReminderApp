using System; 

namespace CreateToDoList
{
    public class CreateToDoList()
    {
        public TopThreeToDoItems(string most, string second, string third)
        {
            this.Most = most;
            this.Second = second;
            this.Third = things;
        }

        public string Most {get; set;}
        public string Second {get; set;}
        public string Third {get; set;}

        public string GetMostImportantTask()
        {
            Console.WriteLine("What is the Most important task you need to do tomorrow?");
            string Most = Console.ReadLine();
            int value = 1;
            return Most, value;
        }

        public string GetSecondMostImportantTask()
        {
            Console.WriteLine("What is the Second most important task you need to do tomorrow?");
            string Second = Console.ReadLine();
            int value = 2;
            return Second;
        }

        public string GetThirdMostImportantTask()
        {
            Console.WriteLine("What is the Third most important task you need to do tomorrow?");
            string Third = Console.ReadLine();
            int value = 3;
            return Third;
        }

        
        Console.WriteLine("You need to do " + most + ", " + second + ", and " + third);
    }

}