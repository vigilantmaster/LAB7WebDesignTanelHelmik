using System.Collections.Generic;
using LAB7WebDesignTanelHelmik.Models;

namespace LAB7WebDesignTanelHelmik.Services
{
    public interface ITodoService
    {
        TodoViewModel GetTodo(int id);

        IEnumerable<TodoViewModel> GetTodosForUser(int userId);

        void SaveTodo(TodoViewModel todo);

        void UpdateTodo(TodoViewModel user);

        void DeleteTodo(int id);
    }
}