
using static Common.TaskEnums;

namespace Domain.Entities

{
    public class TaskItem

    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; } 

        public string Description { get; set; }
        public TaskTypes TaskType { get; set; }

        public int TaskTypeId
        {
            get { return (int)TaskType; }
            set { TaskType  =(TaskTypes)value; }
        }
        public TaskStates TaskState { get; set; } //ToDo: Auto implement testen =TaskState.New

        public int TaskStateId
        {
            get { return (int)TaskState; }
            set { TaskState = (TaskStates)value; }
        } 
        //public List<TaskItem> ChildTasks { get; set;}
    }
}