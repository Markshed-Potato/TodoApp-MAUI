using System;
using System.Collections.Generic;
using System.Text;

namespace MauiTodoApp.Models
{
    public class TodoItem
    {
        public int Id{get; set;}
        public string Title{get; set;} = string.Empty;
        public bool IsCompleted{get; set;}
    }
}
