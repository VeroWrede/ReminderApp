<Query Kind="Program" />

void Main()
{
	var todo = new ToDo("Write App", Importance.Critical);
	todo.Dump();
	Console.WriteLine($"I have to {todo.Task} and it is {todo.Importance}");
}

public enum Importance {
	Critical = 1
}

// Define other methods and classes here
public class ToDo {
	public ToDo(string task, Importance importance){
		this.Task = task;
		this.Importance = importance;
	}
	
	public string Task {get; private set;}
	public Importance Importance {get; private set;}
}