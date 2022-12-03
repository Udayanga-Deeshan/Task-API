using FirstAPI.Models;

namespace FirstAPI.Services
{
    public class TodoService
    {
        // get todos

        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get Books For school",
                Description = "Get text Books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get Vagetables",
                Description = "Get Vegetables for the week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.InProgress
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Water the Plants",
                Description = "Water all the plants immediately",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(4),
                Status = TodoStatus.New
            };
            todos.Add(todo3);

            return todos;
        }
    }
}
