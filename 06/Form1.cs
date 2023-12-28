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

            string[] words = input.Split(' ');// ��������� ������ �� �����, ��������� ������ ��� �����������


            Regex regex = new Regex("[^a-zA-Z ]"); // ���������� ��������� ��� ���������� �������� �� ��������������� ���������� ������

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1) // ���� ����� ����� ������ 1
                {
                    words[i] = words[i].Substring(1); // ������� ������ ����� � �����
                }
                else // ���� ����� ����� ������ ��� ����� 1
                {
                    words[i] = ""; // ����������� ������ ������
                }

                words[i] = regex.Replace(words[i], ""); // ���������� �������� �� ��������������� ���������� ������
            }

            string output = string.Join(" ", words); // ��������� ����� ������� � ������, ��������� ������ ��� �����������
            label1.Text = output;
        }
    }
}