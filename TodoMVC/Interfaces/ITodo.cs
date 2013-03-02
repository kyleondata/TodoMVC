using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Interfaces
{
    public interface ITodo
    {
        List<Models.Todo> All = new List<Models.Todo>();
        Models.Todo Add(Models.Todo todo);
        bool Remove();
    }
}
