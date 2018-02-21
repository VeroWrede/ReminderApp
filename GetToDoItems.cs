public void GetMostImportantTasks()
{
    Console.WriteLine("First");
    string Most = Console.ReadLine();
    int Importance = 1;
    return Importance, Most;
}

public void GetSecondMostImportantTask()
{
    Console.WriteLine("Secondly");
    string Second = Console.ReadLine();
    int Importance = 2;
    toDoList.Add(Importance, Second);
}

public string GetThirdMostImportantTask()
{
    Console.WriteLine("Third");
    string Most = Console.ReadLine();
    int Importance = 3;
    toDoList.Add(Importance, Third);
}
public void GetNontrivialTasks()
{
    Console.WriteLine("What else would you like to get done?");
    string Other = Console.ReadLine();
    int Importance = 4;
    IList<string> Nontrivials = new IList<string>();
    for(i=0; i < OtherTasks.Length; i++ ) // a, b, c
    {
        Nontrivials.Add(Other[i]);

    }
    toDoList.Add(Importance, Nontrivials);
}
public class CreateToDoList 
{
    IList<ToDoItem> toDoList = new IList<ToDoItem>();
    toDoList.Add(GetMostImportantTasks());
    GetSecondMostImportantTask();
}

// and then same or similar for other items on list


