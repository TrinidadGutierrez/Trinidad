using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Model
{
    public class Task
    {
        public string Name { get; set; }
        public bool Completed { get; set; }
        public DateTime fecha { get; set; }
        public int prioridad { get; set; }
    }
}
