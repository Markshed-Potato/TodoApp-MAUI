# MauiTodoApp

A clean, lightweight To-Do list desktop application built with **.NET 11 MAUI** following the **MVVM (Model-View-ViewModel)** architectural pattern and built-in Dependency Injection.

## Features
- **Add Tasks:** Type a task into the input bar and add it to the live list (automatically ignores blank/whitespace inputs and clears the input box).
- **Complete Tasks:** Toggle task completion status via interactive checkboxes.
- **Delete Tasks:** Remove individual tasks directly from the list using row-level command binding (`RelativeSource`).
- **MVVM Architecture:** Clean separation between UI markup (`Views`), state/commands (`ViewModels`), and data structures (`Models`).

## Tech Stack
- **Framework:** .NET 11 MAUI (`net11.0-windows10.0.19041.0`)
- **Language:** C# & XAML
- **Architecture:** MVVM with `INotifyPropertyChanged`, `ObservableCollection<T>`, `ICommand`, and Constructor Dependency Injection

## Project Structure
```text
MauiTodoApp/
├── Models/
│   └── TodoItem.cs           # Task data model (Id, Title, IsCompleted)
├── ViewModels/
│   └── TodoViewModels.cs     # App state, ObservableCollection, and Add/Delete commands
├── Views/
│   ├── TodoPage.xaml         # XAML UI layout (Input bar + CollectionView task list)
│   └── TodoPage.xaml.cs      # Code-behind wiring Dependency Injection to BindingContext
├── AppShell.xaml             # App navigation route configuration
└── MauiProgram.cs            # Dependency Injection container registration
