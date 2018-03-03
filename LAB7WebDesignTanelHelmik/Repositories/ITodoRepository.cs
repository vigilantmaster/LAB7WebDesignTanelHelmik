using System.Collections.Generic;
using LAB7WebDesignTanelHelmik.Data.Entities;
using LAB7WebDesignTanelHelmik.Models;

namespace LAB7WebDesignTanelHelmik.Repositories
{
    public interface ITodoRepository
    {
        Todo GetTodo(int TodoId);
        ICollection<TodoViewModel> GetTodosForUser(int userId);
        void Save(TodoViewModel TodoViewModel);
        void DeleteTodo(int id);
        void UpdateTodo(TodoViewModel todoViewModel);
        void SaveTodo(Todo todo);
    }
}