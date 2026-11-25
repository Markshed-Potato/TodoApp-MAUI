using MauiTodoApp.ViewModels;

namespace MauiTodoApp.Views
{
    public partial class TodoPage : ContentPage
    {
        public TodoPage(TodoViewModels viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}