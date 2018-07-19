
using System;

namespace TodoApp2.API.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
    }
}