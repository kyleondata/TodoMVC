using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Todo.Repository
{
    public class Todo : Interfaces.ITodo
    {
        Interfaces.ITodo _ITodo;
        Models.TodoContext context = new Models.TodoContext();
  
        public Todo(Interfaces.ITodo ITodo)
        {
            _ITodo = ITodo;
        }

        public List<Models.Todo> All()
        {
            try
            {
                return context.Todos.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public Models.Todo Add(Models.Todo todo)
        {
            try
            {
                // Add and commit
                context.Todos.Add(todo);
                context.SaveChanges();
                return todo;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }

        public bool Remove(Models.Todo todo)
        {
            try
            {
                // remove and commit
                context.Todos.Remove(todo);
                var results = context.SaveChanges();
                // Check to see if we have proper results
                // and return a corresponding value
                if (results > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
    }
}