namespace PracticeC
{
    [System.Serializable] public class ProjectObj
    {
        public Project project { get; set; }

        public ProjectObj() { }

        public ProjectObj(Project PRoject)
        {
            this.project = PRoject;
        }

    }

    [System.Serializable] public class Project
    {
        public string name { get; set; }
        public string deadline { get; set; }
        public List<Task> tasks { get; set; }
        public List<string> team { get; set; }

        public Project() { }

        public Project(string Name, string Deadline, List<Task> Tasks, List<string> Team)
        {
            this.name = Name;
            this.deadline = Deadline;
            this.tasks = Tasks;
            this.team = Team;
        }
    }

    [System.Serializable] public class Task
    {
        public int id { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string assignee { get; set; }
        public List<Subtask> subtasks { get; set; }

        public Task() { }

        public Task(int Id, string Description, string Status, string Assignee, List<Subtask> Subtasks)
        {
            this.id = Id;
            this.description = Description;
            this.status = Status;
            this.assignee = Assignee;
            this.subtasks = Subtasks;
        }
    }
    [System.Serializable] public class Subtask
    {
        public int id { get; set; }
        public string description { get; set; }
        public string status { get; set; }

        public Subtask() { }

        public Subtask(int Id, string Description, string Status)
        {
            this.id = Id;
            this.description = Description;
            this.status = Status;
        }
    }
}