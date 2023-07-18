/*********************************************
担当者:Iwamoto Taichi

ページの内容を保存する
*********************************************/
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
        public void SavePage(string path, Dictionary<int, string> pageData)
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
                int page = 0;
                StreamWriter sw = new StreamWriter(path + "/PageData.txt");
                foreach (var entry in sortedPageData)
                {
                    sw.WriteLine(entry.Key + " " + entry.Value);
                    page = entry.Key;
                }
                sw.Write((page+1).ToString()," 仮データ","\n ");
                sw.Close();
            }
        }

        public void SaveFont(string path, string font)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path + "/FontData.txt");
                Console.WriteLine(font);
                sw.WriteLine(font);
                sw.Close();
            }catch (UnauthorizedAccessException)
            {
                return;
            }
        }
    }
}

