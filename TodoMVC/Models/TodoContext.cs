using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Todo.Models
{
    public class TodoContext :DbContext
    {
        public DbSet<Todo> Todos { get; set; }
    }
}