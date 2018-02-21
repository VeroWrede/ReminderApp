using System;

class ToDoDict 
{
    IDictionary<int, string> toDoList = new IDictionary<int, string>();

    public string GetMostImportantTask()
    {
        Console.WriteLine("What is the Most important task you need to do tomorrow?");
        string Most = Console.ReadLine();
        toDoList.Add(1, Most);
    }

    public void GetSecondMostImportantTask()
    {
        Console.WriteLine("Secondly");
        string Second = Console.ReadLine();
        toDoList.Add(2, Second);
    }

    public string GetThirdMostImportantTask()
    {
        Console.WriteLine("Third");
        string Most = Console.ReadLine();
        toDoList.Add(3, Third);
    }

    public void GetNontrivialTasks()
    {
        Console.WriteLine("What else would you like to get done?");
        string Other = Console.ReadLine(); // "a,b,c

        IList<string> nontrivials = new IList<string>();
        for(i=0; i < Other.Length; i++ ) // a, b, c
        {
            nontrivials.Add(Other[i]);
        }

        toDoList.Add(4, nontrivials);

    }
}