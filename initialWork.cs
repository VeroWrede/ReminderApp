using System;

// this creates an instance of a ToDoList, populates it and prints out all items in it
public class CreateToDoList 
{
    public static void  Main()
    {
        ToDoList myToDoList = new ToDoList(IList<ToDoItem> todos);
        Console.WriteLine(ToDoList.ShowTopThreeTasks());
        Console.WriteLine(ToDoList.ListRemainingTasks());
    }
}

// not a class nor in one?
public Enum Importance {
    Most = 1,
    Second = 2,
    Third = 3,
    NonTrivial = 4,
}

public class ToDoItem { 
    public ToDoItem(string description, Importance importance) { // why capital I here 
        this.description = description; 
        this.importance = importance; // but lower case i here? 
    }

    public string description {get; private set;}
    public Importance importance {get; private set;}
}

public class ToDoList
{
    // constructor for the ToDoList - input strings graded by importance or pairs of item:rank? 
    public ToDoList(IList<ToDoItem> todos)
    {
        this.ToDos = todos.OrderBy(t => t.importance);
    }

    public IList<ToDoItem> ToDos {get; private set;}
    
    public string ShowTopThreeTasks()
    {
        var topThreeTasks = ToDos.Take(3);
        return "You really want to do " + Environment.NewLine +  topThreeTasks[0] + Environment.NewLine + topThreeTasks[1] + Environment.NewLine + topThreeTasks[2] + " today!!"
    }

    public string ListRemainingTasks()
    { 
        var nonTrivialTasks = ToDos.Skip(3)
        return "You also need to do " + TaskFour + ", " + TaskFive + ", " + TaskSix + ", " + TaskSeven 
    }

    
}

