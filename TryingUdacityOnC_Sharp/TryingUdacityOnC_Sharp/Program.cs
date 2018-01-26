using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace TryingUdacityOnC_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            string targetPath = path + @"\Jsons\final_project_dataset_unix.json";
            Dictionary<string, Dictionary<string, string>> items = new Dictionary<string, Dictionary<string, string>>();
            using (StreamReader r = new StreamReader(targetPath))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
            }

            foreach (var item in items)
            {
                Console.WriteLine(item.Key);
            }

            Console.ReadKey();
        }
    }
}
