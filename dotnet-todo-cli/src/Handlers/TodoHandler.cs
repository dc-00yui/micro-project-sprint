using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace TodoCLI.Handlers
{
    public class TodoHandler
    {
        private const string FilePath = "src/Data/todos.json";

        public List<TodoItem> ReadTodos()
        {
            if (!File.Exists(FilePath))
            {
                return new List<TodoItem>();
            }

            var jsonData = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<TodoItem>>(jsonData) ?? new List<TodoItem>();
        }

        public void CreateTodo(TodoItem todo)
        {
            var todos = ReadTodos();
            todos.Add(todo);
            SaveTodos(todos);
        }

        public void UpdateTodo(TodoItem updatedTodo)
        {
            var todos = ReadTodos();
            var todo = todos.FirstOrDefault(t => t.Id == updatedTodo.Id);
            if (todo != null)
            {
                todo.Category = updatedTodo.Category;
                todo.Type = updatedTodo.Type;
                todo.Title = updatedTodo.Title;
                todo.Description = updatedTodo.Description;
                todo.Status = updatedTodo.Status;
                SaveTodos(todos);
            }
        }

        public void DeleteTodo(int id)
        {
            var todos = ReadTodos();
            var todoToRemove = todos.FirstOrDefault(t => t.Id == id);
            if (todoToRemove != null)
            {
                todos.Remove(todoToRemove);
                SaveTodos(todos);
            }
        }

        private void SaveTodos(List<TodoItem> todos)
        {
            var jsonData = JsonConvert.SerializeObject(todos, Formatting.Indented);
            File.WriteAllText(FilePath, jsonData);
        }
    }
}