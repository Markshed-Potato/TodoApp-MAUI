using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MauiTodoApp.Models;

namespace MauiTodoApp.ViewModels
{
    public class TodoViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ObservableCollection<TodoItem> Items {get;} = new();
        protected void OnPropertychanged([CallerMemberName] string? propertyName = null){
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string _newTaskTitle = string.Empty;
        public string NewTaskTitle
        {
            get=>_newTaskTitle;
            set
            {
                if(_newTaskTitle == value) return;
                _newTaskTitle = value;
                OnPropertychanged();
            }
        }
        public ICommand AddTodoCommand {get;}
        public ICommand DeleteTodoCommand {get; }

        public TodoViewModels()
        {
            AddTodoCommand = new Command(AddTodo);
            DeleteTodoCommand = new Command<TodoItem>(DeleteTodo);
        }
        private void AddTodo()
        {
            if(string.IsNullOrWhiteSpace(NewTaskTitle)) return;

            Items.Add(new TodoItem
            {
               Title = NewTaskTitle.Trim(),
               IsCompleted = false
            });
            NewTaskTitle = string.Empty;
        }
        private void DeleteTodo(TodoItem? tasktoDelete)
        {
            if(tasktoDelete is null) return;
            Items.Remove(tasktoDelete);
        }
    }
}
