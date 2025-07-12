using System;

namespace TaskManagerGUI
{
    public class TaskItem
    {
        //プロパティ
        public static int idCounter = 0;
        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public DateTime? Duedate { get; set; }
        public int CompletedStatus { get; set; }

        //コンストラクタ
        public TaskItem( string title, string description, int priority, DateTime? duedate)
        {
            Id = idCounter++;
            this.Title = title;
            this.Description = description;
            this.Priority = priority;
            this.Duedate = duedate;
      
        }

        
    }
}