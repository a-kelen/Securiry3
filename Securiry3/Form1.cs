using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Securiry3
{
    public partial class Form1 : Form
    {
        List<char> list = new List<char>();
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog2.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            dataGrid.Columns.Clear();
            dataGrid.RowHeadersVisible = false;
            for(int i=0; i < Symbols.en.Length; i++)
            {
                dataGrid.Columns.Add(Symbols.en[i].ToString(), Symbols.en[i].ToString());
                dataGrid.Columns[i].Width = 26;
            }

            RefreshMap();
        }
        int a = 3;
        int b = 5;

        private void encryptLeftText_TextChanged(object sender, EventArgs e)
        {
            if(encryptLeftText.Text == "")
            {
                encrypt.Enabled = false;
                saveEncrypt.Enabled = false;
            }
            else
            {
                encrypt.Enabled = true;
                saveEncrypt.Enabled = true;
            }
        }
        static int GetGCD(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 = num1 - num2;
                if (num2 > num1)
                    num2 = num2 - num1;
            }
            return num1;
        }

        public char Encode(char c)
        {
            if (" \n-\t.,?!1234567890'\"`’".Contains(c))
                return c;
            int t = Symbols.en.Select((x, i) => new { Value = x, Index = i }).First(x => x.Value == char.ToLower(c)).Index;
            int newIndex = (a * t + b) % Symbols.en.Length;
            var res = Symbols.en[newIndex];
            if (char.IsUpper(c))
                res = char.ToUpper(res);
            return res;
        }
        public char Decode(char c)
        {
            if (" \n-\t.,?!1234567890'\"`’".Contains(c))
                return c;
            int t = Symbols.en.Select((x, i) => new { Value = x, Index = i }).First(x => x.Value == char.ToLower(c)).Index;
            int newIndex = (int)( calcAinv(a) * (t + Symbols.en.Length - b)) % Symbols.en.Length;
            var res = Symbols.en[newIndex];
            if (char.IsUpper(c))
                res = char.ToUpper(res);
            return res;
        }
        int calcAinv(int a)
        {
            int i = 1;
            while (a * i % Symbols.Length()!= 1)
            {
                i++;
            }
            return i;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (GetGCD(Convert.ToInt32(numericUpDown1.Value), Symbols.en.Length) != 1) {
                if (numericUpDown1.Value > a)
                    numericUpDown1.Value++;
                else if (numericUpDown1.Value < a && numericUpDown1.Value > 1)
                    numericUpDown1.Value--;

            }
            a = Convert.ToInt32(numericUpDown1.Value);
            RefreshMap();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown2.Value > Symbols.en.Length)
            {
                numericUpDown2.Value = Symbols.en.Length;
            }
            b = Convert.ToInt32(numericUpDown2.Value);
            RefreshMap();
        }
        void RefreshMap()
        {
            list.Clear();
           foreach(var c in Symbols.en)
            {
                list.Add(Encode(c));
            }
            RefreshGrid();
        }
        void RefreshGrid()
        {
            dataGrid.Rows.Clear();
            dataGrid.Rows.Add(list.Select(x => (object)x).ToArray());
            dataGrid.Update();
        }

        private void openFree_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            encryptLeftText.Text = fileText;
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            encryptRightText.Text = EncryptText(encryptLeftText.Text);
        }
        private string EncryptText(string text)
        {
            string res = "";
            foreach(var c in text)
            {
                res += Encode(c);
            }
            return res;
        }
        private string DecryptText(string text)
        {
            string res = "";
            foreach (var c in text)
            {
                res += Decode(c);
            }
            return res;
        }

        private void saveEncrypt_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, encryptRightText.Text);
        }

        private void decryptLeftText_TextChanged(object sender, EventArgs e)
        {
            decrypt.Enabled = decryptLeftText.Text == "" ? false : true;
        }

        private void openEncrypt_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog2.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            decryptLeftText.Text = fileText;
        }

        private void import_Click(object sender, EventArgs e)
        {
            decryptLeftText.Text = encryptRightText.Text;
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            decryptRightText.Text = DecryptText(decryptLeftText.Text);
        }
    }
}
