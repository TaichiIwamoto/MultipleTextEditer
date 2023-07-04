using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using MultipleTextEditor;

namespace MultipleTextEditor.PageSave
{
    class SaveData
    {
        public void SavePage(int page, string memo, string path, Dictionary<int, string> pageData)
        {
            IOrderedEnumerable<KeyValuePair<int, string>> sortedPageData = pageData.OrderBy(selector => {
                return selector.Key;
            });

            foreach (var entry in sortedPageData)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
            if (System.IO.Directory.Exists(path))
            {
                StreamWriter sw = new StreamWriter(path + "/PageData.txt");
                foreach (var entry in sortedPageData)
                {
                    sw.WriteLine(entry.Key + " " + entry.Value);
                }
                sw.Close();
            }
        }
    }
}

