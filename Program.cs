using System;

public class CreateToDOList
{
    public static void Main()
    {
        var toDoList = new IList(Third = GetThirdMostImportantTask(), Other = GetNontrivialTasks());
        this.toDoList.Most = GetMostImportantTask();
        this.toDoList.Second = GetSecondMostImportantTask();
    }
}