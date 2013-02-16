using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Todo.Repository
{
    public class Todo : Interfaces.ITodo
    {
        Interfaces.ITodo _ITodo;
        public Todo(Interfaces.ITodo ITodo)
        {
            _ITodo = ITodo;
        }

        public Models.Todo Add(Models.Todo todo)
        {
            throw new NotImplementedException();
        }

        public bool Remove()
        {
            throw new NotImplementedException();
        }
    }
}