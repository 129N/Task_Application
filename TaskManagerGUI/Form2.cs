using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerGUI
{
    public partial class Form2 : Form
    {
        public TaskItem CreatedTask { get; private set; }

        public int CompletedStatus { get; set; }


        //通常のコンストラクタ
        public Form2()
        {
            InitializeComponent();
        }

        //編集用のコンストラクタの追加　新規と既存をここで分ける。
        public Form2(TaskItem existingTask) : this()
        {
            // 既存のタスクの情報を入力欄に反映させる
            titleTextBox.Text = existingTask.Title;
            DescTextBox.Text = existingTask.Description;
            priorityComboBox.SelectedIndex = existingTask.Priority - 1;
            dateTimePicker1.Value = existingTask.Duedate ?? DateTime.Now;

            switch (existingTask.CompletedStatus)
            {
                case 1:
                    CompletedButton.Checked = true;
                    break;
                case 2:
                    NYButton.Checked = true;
                    break;
                case 3:
                    NullButton.Checked = true;
                    break;
            }

            // 編集対象タスクの ID を保持したいなら TaskItem にプロパティを残しておいてもOK
            CreatedTask = existingTask.clone();


        }

       


        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            //各入力欄からデータを取得
            string title = titleTextBox.Text;
            string description = DescTextBox.Text;
            int priority = priorityComboBox.SelectedIndex + 1; // 1-5
            DateTime? duedate = dateTimePicker1.Value;


            //booleanの完了、未完了、Nullのボタン
            int status = 0;
            if (CompletedButton.Checked) status = 1;
            else if (NYButton.Checked) status = 2;
            else if (NullButton.Checked) status = 3;


             CreatedTask = new TaskItem(title, description, priority, duedate)
            {
                    CompletedStatus = status,
            };

             

        
            this.DialogResult = DialogResult.OK;

            this.Close(); //form close action
        }
    }
}
