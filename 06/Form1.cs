using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = "";
            foreach (var item in listBox1.Items)
            {
                input += item.ToString() + " ";
            }

            string[] words = input.Split(' ');// Разбиваем строку на слова, используя пробел как разделитель


            Regex regex = new Regex("[^a-zA-Z ]"); // Регулярное выражение для исключения символов не соответствующих английским буквам

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1) // Если длина слова больше 1
                {
                    words[i] = words[i].Substring(1); // Удаляем первую букву в слове
                }
                else // Если длина слова меньше или равна 1
                {
                    words[i] = ""; // Присваиваем пустую строку
                }

                words[i] = regex.Replace(words[i], ""); // Исключение символов не соответствующих английским буквам
            }

            string output = string.Join(" ", words); // Соединяем слова обратно в строку, используя пробел как разделитель
            label1.Text = output;
        }
    }
}