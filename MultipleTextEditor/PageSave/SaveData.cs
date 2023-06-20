using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace MultipleTextEditor.PageSave
{
    class SaveData
    {
        private Dictionary<int, string> pageData = new Dictionary<int, string>();
        public void SavePage(int page,string memo)
        {
            StreamWriter sw = new StreamWriter("resources/PageData.txt");
            pageData.Add(page, memo);
            Console.WriteLine("hello");

            foreach(var entry in pageData)
            {
                sw.WriteLine(entry.Key + " " + entry.Value);
            }
            sw.Close();
        }

        public String LoadPage(int page)
        {
            StreamReader sr = new StreamReader("resources/PageData.txt");
            List<String> pageData = new List<String>;
            while (sr.Peek() != -1)
            {
                tmp = sr.ReadLine();
            }

        }
    }
}
