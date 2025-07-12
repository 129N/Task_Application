using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskApplication;

namespace TaskManagerGUI
{
    public partial class Form1 : Form
    {

        ITaskService taskService = new TaskAdmin();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initial activation 
            sortComboBox.Items.AddRange(new string[] { "期限昇順", "期限降順", "優先度昇順", "優先度降順" });
            sortComboBox.SelectedIndex = 0;

            FilterComboBox.Items.AddRange(new string[] { "すべて表示", "完了", "未完了", "未設定" });
            FilterComboBox.SelectedIndex = 0;

            //開いたら　JSON Load メソッドが動く 
            var loaded = JsonStorage.Load();
            foreach (var task in loaded)
            {
                taskService.AddTask(task);
            }


            RefreshTaskList();
        }

        private void AddButtonForm1(object sender, EventArgs e)
        {

            //Form2.cs call

            using (Form2 form2 = new Form2()) {

                //var result = form2.ShowDialog(); && form2.CreatedTask != nul

                if (form2.ShowDialog() == DialogResult.OK )
                {
                    //Interfaceより、AddTaskを追加。CreatedTaskはPublicのオブジェクトとして存在
                    taskService.AddTask(form2.CreatedTask);

                    RefreshTaskList();//GUIの表示処理 で更新をする

                    JsonStorage.Save(taskService.GetAllTasks());
                }
            }

        }



        private void RefreshTaskList() 
        {

            //listviewは、
            //listView1_SelectedIndexChangedのイベントハンドラーメソッド
            listView1.Items.Clear(); //clear all

            
            //以下はcomboBoxを使ったコード
            //Filter適用
            var tasks = taskService.GetAllTasks();

            switch (FilterComboBox.SelectedItem?.ToString() )
            {
                case "完了":
                    tasks = tasks.Where(t => t.CompletedStatus == 1).ToList();    
                break;
                case "未完了":
                    tasks = tasks.Where(t => t.CompletedStatus == 2).ToList();
                    break;
                case "未設定":
                    tasks = tasks.Where(t => t.CompletedStatus == 3).ToList();
                    break;
            }


            //Sort 適用

            switch (sortComboBox.SelectedItem?.ToString())
            {
                case "期限昇順":
                    tasks = tasks.OrderBy(t => t.Duedate).ToList();
                    break;
                  
                case "期限降順":
                    tasks = tasks.OrderByDescending(t => t.Duedate).ToList();
                    break;
                case "優先度昇順":
                    tasks = tasks.OrderBy(t => t.Priority).ToList();
                    break;

                case "優先度降順":
                    tasks = tasks.OrderBy(t=> t.Priority).ToList();
                    break;
            }

            // ここで（tasksにFilter & Sort後のデータを使用）
            //foreach (var task in taskService.GetAllTasks())
            foreach (var task in tasks)
            {//ITaskServiceのListを呼び出す
                ListViewItem item = new ListViewItem(task.Title);
                //新たなリストを作成し、
                //各columnをitemのリストに追加
                item.SubItems.Add(task.Description);
                item.SubItems.Add(task.Priority.ToString());
                item.SubItems.Add(task.Duedate.HasValue ? task.Duedate.Value.ToShortDateString() : "");
                item.SubItems.Add(GetStatusText(task.CompletedStatus)); // 状態を表示
                item.SubItems.Add("編集");
                item.SubItems.Add("削除");

                item.Tag = task;

                listView1.Items.Add(item);
            }


        }


        private string GetStatusText(int status)
        {
            switch (status)
            {
                case 1: return "完了";
                case 2: return "未完了";
                case 3: return "未設定";
                default: return "不明";
            }
        }


        //Hand-made EventHandler
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            var selectedItem = info.Item;
            var subItem = info.SubItem;

            if(selectedItem != null && subItem != null)
            {
                int columnIndex = selectedItem.SubItems.IndexOf(subItem);

                if (columnIndex == 5) // 編集
                {
                    var task = (TaskItem)selectedItem.Tag;
                    EditTask(task);
                    RefreshTaskList(); 
                }
                else if (columnIndex == 6) // 削除
                {
                    var task = (TaskItem)selectedItem.Tag;
                    DeleteTask(task);
                    RefreshTaskList(); 
                }
            }

        }



        //task を渡して Form2 を開く
        public void EditTask(TaskItem task) //なぜここにTaskItemを入れる必要が？？
        {
            Form2 editForm = new Form2(task); // ← 編集用コンストラクタを呼ぶ
            if (editForm.ShowDialog() == DialogResult.OK)
                {

                //CreatedTaskは、TaskItemのインスタンス
                //taskService、UpdateTaskはInterfaceの呼び出し
                taskService.UpdateTask(task.Id, editForm.CreatedTask);
                //Update後もきちんとSaveする。
                JsonStorage.Save(taskService.GetAllTasks());
                }
        }

        public void DeleteTask(TaskItem task)
        {
            var result = MessageBox.Show("このタスクを削除しますか？", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                taskService.RemoveTask(task.Id);
                RefreshTaskList();
                //Delete後もきちんとSaveする。
                JsonStorage.Save(taskService.GetAllTasks());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Close Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close(); //form close action
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { //sortComboBox
            RefreshTaskList();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTaskList();
        }




        //private void richTextBox1_TextChanged(object sender, EventArgs e)
        //{

        //}



    }


}
