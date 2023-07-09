using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using MultipleTextEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace MultipleTextEditor
{
    public partial class Form1 : Form
    {
        private List<Item> itemList = new List<Item>();
        private bool isListMode = false;

        private bool textChangedFlag = false;

        private void text_memo_TextChanged(object sender, EventArgs e)
        {
            textChangedFlag = true;
        }

        public class Item
        {
            public string Name { get; set; }
            public int X { get; set; }
            public int Y { get; set; }

            public Item(string name,int x, int y)
            {
                Name = name;
                X = x;
                Y = y;
            }


            public override string ToString()
            {
                return $"{Name}[{X}/{Y}] ";
            }
        }

        private void list_CheckedChanged(object sender, EventArgs e)
        {
            isListMode = list.Checked;
            text_memo.SelectionBullet = list.Checked;               
        }
        
        private void text_memo_KeyDown(object sender,KeyEventArgs e)
        {
                
                if (e.KeyCode == Keys.Enter && textChangedFlag && isListMode)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;



                    int selectionStart = text_memo.SelectionStart-1;
                    int lineIndex = text_memo.GetLineFromCharIndex(selectionStart);
                    int lineStart = text_memo.GetFirstCharIndexFromLine(lineIndex);
                    if (lineIndex >= 0 && lineIndex < text_memo.Lines.Length)
                    {
                        int cursorPosition = selectionStart - lineStart;
                    
                    string input = text_memo.Lines[lineIndex].Trim();

                    if (!string.IsNullOrEmpty(input))
                    {
                        if (input.Contains("["))
                        {
                            string[] parts = input.Split('[','/', ']');

                            string name = parts[0];
                            int x = int.Parse(parts[1]); 
                            int y = int.Parse(parts[2]);


                            // itemListを更新
                            // itemListにnameが存在するかチェックし、存在すれば対応するItemを更新する
                            bool itemExists = false;
                            foreach (var item in itemList)
                            {
                                if (item.Name == name)
                                {
                                    item.X = x;
                                    item.Y = y;
                                    itemExists = true;
                                    break;
                                }
                            }
                            if (!itemExists)
                            {
                                itemList.Add(new Item(name, x, y));
                            }
                        }
                        else
                        {
                            string[] parts = input.Split(' ');
                            string name = parts[0];
                            int y = 0;
                            int x = 0;
                            if (parts.Length > 1)
                            {
                                y = int.Parse(parts[1]);
                            }
                            itemList.Add(new Item(name,x, y));



                            string newText = $"{name}[{x}/{y}]";

                            // 特定の行を置換
                            text_memo.SelectionStart = lineStart;
                            text_memo.SelectionLength = text_memo.Lines[lineIndex].Length;
                            text_memo.SelectedText = newText;


                            text_memo.AppendText(Environment.NewLine);
                            textChangedFlag = false;

                            System.Windows.Forms.Button plusButton = new System.Windows.Forms.Button();
                            plusButton.Text = "+";
                            plusButton.Size = new Size(30, text_memo.Font.Height+5);
                            //plusButton.Font = new Font(text_memo.Font.FontFamily, text_memo.Font.Size);
                            var charIndex = text_memo.GetFirstCharIndexFromLine(lineIndex) + text_memo.Lines[lineIndex].Length;
                            var charPosition = text_memo.GetPositionFromCharIndex(charIndex);
                            plusButton.Location = new Point(text_memo.Left+charPosition.X + 15, text_memo.Top+charPosition.Y);

                            plusButton.Click += (s, ev) => IncrementX(itemList.Last()); // ボタンのクリックイベントにIncrementXメソッドを関連付ける
                            this.Controls.Add(plusButton);
                            plusButton.BringToFront();

                            System.Windows.Forms.Button minusButton = new System.Windows.Forms.Button();
                            minusButton.Text = "-";
                            minusButton.Size = new Size(30, text_memo.Font.Height + 5);
                            
                            var minuscharIndex = text_memo.GetFirstCharIndexFromLine(lineIndex) + text_memo.Lines[lineIndex].Length;
                            var minuscharPosition = text_memo.GetPositionFromCharIndex(charIndex);
                            minusButton.Location = new Point(text_memo.Left + minuscharPosition.X + 45, text_memo.Top + minuscharPosition.Y);

                            minusButton.Click += (s, ev) => DecrementX(itemList.Last()); // ボタンのクリックイベントにIncrementXメソッドを関連付ける
                            this.Controls.Add(minusButton);
                            minusButton.BringToFront();
                        }
                    }
                }
            }
        }

        private void IncrementX(Item item)
        {
            if (item.X < item.Y)
            {
                item.X++;

                int selectionStart = text_memo.SelectionStart - 1;
                int lineIndex = text_memo.GetLineFromCharIndex(selectionStart);
                int lineStart = text_memo.GetFirstCharIndexFromLine(lineIndex);
                text_memo.SelectionStart = lineStart;
                text_memo.SelectionLength = text_memo.Lines[lineIndex].Length;
                text_memo.SelectedText = $"{item.Name}[{item.X}/{item.Y}]";
            }
        }

        private void DecrementX(Item item)
        {
            if (item.X > 0)
            {
                item.X--;

                int selectionStart = text_memo.SelectionStart - 1;
                int lineIndex = text_memo.GetLineFromCharIndex(selectionStart);
                int lineStart = text_memo.GetFirstCharIndexFromLine(lineIndex);
                text_memo.SelectionStart = lineStart;
                text_memo.SelectionLength = text_memo.Lines[lineIndex].Length;
                text_memo.SelectedText = $"{item.Name}[{item.X}/{item.Y}]";
            }
        }
    }
}


