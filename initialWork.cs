using System;

// this creates an instance of a ToDoList, populates it and prints out all items in it
public class CreateToDoList 
{
    public static void  Main()
    {
        ToDoList myToDoList = new ToDoList("play wth mina", "code", "eat", "cook", "gym", "shower", "sleep");
        Console.WriteLine(ToDoList.ShowTopThreeTasks());
        Console.WriteLine(ToDoList.ListRemainingTasks());
    }
}

public Enum Importance {
    Critical = 1,
    PrettyImportant = 2,
    Meh = 3,
}

public class ToDo {
    public ToDo(string description, Importance importance) {
        this.description = description;
        this.importance = importance;
    }

    public string description {get; private set;}
    public Importance importance {get; private set;}
}

public class ToDoList
{
    // constructor for rhe ToDoList - input strings graded by importance or pairs of item:rank? 
    public ToDoList(IList<ToDo> todos)
    {
        this.ToDos = todos.OrderBy(t => t.importance);
    }

    public IList<ToDo> ToDos {get; private set;}
    
    public string ShowTopThreeTasks()
    {
        var topThreeTasks = ToDos.Take(3);
        return "You really want to do " + Environment.NewLine +  topThreeTasks[0] + Environment.NewLine + topThreeTasks[1] + Environment.NewLine + topThreeTasks[2] + " today!!"
    }

    public string ListRemainingTasks()
    {
        return "You also need to do " + TaskFour + ", " + TaskFive + ", " + TaskSix + ", " + TaskSeven 
    }

    
}

