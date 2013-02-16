using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class Todo
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime? DateCompleted { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
    }
}