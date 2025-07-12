using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TaskManagerGUI
{

    // Newtonsoft.Json を使う
    //ソリューションエクスプローラーで
    //「NuGet パッケージの管理」→「参照」タブで Newtonsoft.Json を検索
    public static class JsonStorage
    {
        private static readonly string FilePath = "task.json";


        //Saveメソッド
        public static void Save(List<TaskItem> tasks)
        {
            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);

            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string json = JsonSerializer.Serialize(tasks, options);
          
            File.WriteAllText(FilePath, json);

        }


        //Load メソッド
        public static List<TaskItem> Load()
        {
            if (!File.Exists(FilePath))
                return new List<TaskItem>();

            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<TaskItem>>(json);
        }

    }
}
