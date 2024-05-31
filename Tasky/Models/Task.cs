namespace Tasky.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime Updated { get; set; }   

        public User CreatedBy { get; set; }

        public  List<User> AssignedTo { get; set; }

        public STATUS Status {  get; set; }

        public int Rating { get; set; }

    }
}

public enum STATUS { 
    TODO,
    IN_PROGRESS,
    COMPLETED
}


