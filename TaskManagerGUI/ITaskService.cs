using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerGUI;

namespace TaskApplication
{
    public interface ITaskService
    { //メソッドを追加
      // 設計図がある。
      //add, delete, priority,completed,getAll(一覧表示) 

         void AddTask(TaskItem taskItem);
         void RemoveTask(int Id);
         //void priorityCheck(int priority);
         void MarkCompleted(int Id);
        void UpdateTask(int id, TaskItem updatedTask);

        //List で一覧を表示
         List<TaskItem> GetAllTasks();

    }




    public class TaskAdmin : ITaskService　//interfaceのimplementation（実装）
    {

        private List<TaskItem> tasklist = new List<TaskItem>();

        public void AddTask(TaskItem taskItem)
        {
            tasklist.Add(taskItem);　//Interfaceにデータを渡している。
        }
        public void RemoveTask(int id) 
        {
            //Idを自動生成
            var task = tasklist.FirstOrDefault(t =>t.Id == id);
            if (task != null)
            {
                tasklist.Remove(task);
            }
        }


        //public void priorityCheck(int priority)
        //{
        //    switch (priority)
        //    {
        //        case 1:
        //            Console.WriteLine(1 + "is low priority");
        //            break;
        //        case 2:
        //            Console.WriteLine(2 + "is med-low priority");
        //            break;
        //        case 3:
        //            Console.WriteLine(3 + "is normal priority");
        //            break;
        //        case 4:
        //            Console.WriteLine(4 + "is med-high priority");
        //            break;
        //        case 5:
        //            Console.WriteLine(5 + "is high priority");
        //            break;

        //        default:
        //            Console.WriteLine(1 + "is low priority");
        //            break;
        //    }
        //}

        public void MarkCompleted(int id)
        {
            var task = tasklist.FirstOrDefault(t => t.Id == id);

            if( task != null)
            {
                task.CompletedStatus = 1;
            }

        }

        public void UpdateTask(int id, TaskItem updatedTask)
        {
            //id は TaskItem のプロパティであり、List のインデックスとは 一致しない場合がある。
            var index = tasklist.FindIndex(t => t.Id == id);

            if(index != -1)
            {
                tasklist[index] = updatedTask;
            }
        }


        public  List<TaskItem> GetAllTasks()
        {
            return tasklist;//void なので　return なし。
        }

    }
}
