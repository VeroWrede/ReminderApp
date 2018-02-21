<Query Kind="Program">
  <Namespace>System</Namespace>
</Query>

// this creates an instance of a ToDoList, populates it and prints out all items in it
Public Class CreateToDoList 
{
    Public Static void  Main()
    {
	
        ToDoList myToDoList = New ToDoList(New List<ToDoItem>() {
			new ToDoItem("play with mina", Importance.Most)
		});
		
        Console.WriteLine(myToDoList.ShowTopThreeTasks());
        Console.WriteLine(myToDoList.ListRemainingTasks());
    }
}

// not a class nor in one?
Public Enum Importance {
    Most = 1,
    Second = 2,
    Third = 3,
    NonTrivial = 4,
}

Public Class ToDoItem { 
    Public ToDoItem(String description, Importance importance) {
        this.Description = description; 
        this.Importance = importance; 
    }

    Public string Description {get; private set;}
    Public Importance Importance {get; private set;}
}

Public Class ToDoList
{
    // constructor for the ToDoList - input strings graded by importance or pairs of item:rank? 
    Public ToDoList(IList<ToDoItem> todos)
    {
        this.ToDos = todos.OrderBy(t => t.Importance).ToList();
    }

    Public IList<ToDoItem> ToDos {get; private set;}
    
    Public string ShowTopThreeTasks()
    {
        var topThreeTasks = ToDos.Take(3).ToList();
        Return $@"You really want to do {String.Join("\n", topThreeTasks.Select(todo => todo.Description))}";
    }

    Public string ListRemainingTasks()
    { // how do i 'Take()' the last x emlements / elements after index x?
        var nonTrivialTasks = ToDos.Skip(3);
       Return $@"You also need to do {String.Join(", ", nonTrivialTasks.Select(todo => todo.Description))}";
    }
}