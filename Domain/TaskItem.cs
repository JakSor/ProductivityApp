
using static Common.TaskEnums;

namespace Domain
{
    public class TaskItem

    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime PlannedDate { get; set; } 

        public string Description { get; set; }
        public TaskTypes TaskType { get; set; }

        public int TaskTypeId
        {
            get { return TaskTypeId; }
            set { TaskType  =(TaskTypes)value; }
        }
        public TaskStates TaskState { get; set; } //ToDo: Auto implement testen =TaskState.New

        public int TaskStateId
        {
            get { return TaskStateId; }
            set { TaskState = (TaskStates)value; }
        } 
        //public List<TaskItem> ChildTasks { get; set;}
    }
}