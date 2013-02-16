using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Interfaces
{
    public interface ITodo
    {
        Models.Todo Add(Models.Todo todo);
        bool Remove();
    }
}
