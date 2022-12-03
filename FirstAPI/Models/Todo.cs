namespace FirstAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }

        public DateTime Created { get; set; }

        public DateTime Due { get; set; }

        public TodoStatus Status { get; set; } // inprogress,new,completed
    }
}
