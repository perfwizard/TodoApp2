using System;

namespace TodoApp2.API.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }
}