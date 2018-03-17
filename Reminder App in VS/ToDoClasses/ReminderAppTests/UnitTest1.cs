using NUnit.Framework;
using System;
using ToDoClasses;

namespace ReminderAppTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.True(true);
        }

        [Test]
        public void TestToDoItemHasTaskAndImportance()
        {
            var toDoItem = new ToDoItem
            {
                Importance = 42,
                Task = "Eat bacon"
            };

            Assert.AreEqual(42, toDoItem.Importance);
            Assert.AreEqual("Eat bacon", toDoItem.Task);
        }
    }
}
