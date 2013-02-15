using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TodoMVC.Test
{
    [TestClass]
    public class TestTodo
    {
        [TestMethod]
        public void ItShouldReturnTrueWhenAddingTodos()
        {
            //TODO: Not quite sure if this is how you use moq properly.
            //If I say it is going to return the value true and I assert
            //that the values match this test should always pass which does
            //not seem correct. Do some research.

            //Setup the mock
            var todo = new Mock<Todo.Interfaces.ITodo>();
            var newTodo = new Todo.Models.Todo();

            //Set some dumb values
            newTodo.Title = "test";
            newTodo.IsComplete = false;
            newTodo.Description = "testing";

            //Map behavior
            todo.Setup(t => t.Add(It.IsAny<Todo.Models.Todo>())).Returns(true);

            //Assert
            var result = todo.Object.Add(newTodo);
            Assert.AreEqual(true, result);
        }
    }
}
