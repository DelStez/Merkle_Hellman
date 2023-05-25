using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merkle_Hellman
{
    public partial class Form1 : Form
    {
        public OpenFileDialog openDialog = new OpenFileDialog();
        public delegate void UpdateTextBoxDelegate(string textBoxString, Color color); // тип делегата 
        public UpdateTextBoxDelegate UpdateTextBox; // объект делегата
        public MyMerkleHellman MyMerkleHellmanClass;

        private void UpdateTextBoxMethod(string str, Color color = default(Color))
        {
            LogsBox.SelectionStart = LogsBox.TextLength;
            LogsBox.SelectionLength = 0;
            LogsBox.SelectionColor = color;
            LogsBox.AppendText(str + Environment.NewLine);
            LogsBox.SelectionColor = LogsBox.ForeColor;

        } // этот метод вызывается

        public Form1()
        {
            InitializeComponent();
            UpdateTextBox = UpdateTextBoxMethod; // инициализировать объект делегата
            MyMerkleHellmanClass = new MyMerkleHellman(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var s = textBox1.Text.TrimEnd(',').Split(',').ToList().Select(z => Convert.ToInt32(z)).ToList();
                var w = Convert.ToInt32(textBox2.Text);
                var n = Convert.ToInt32(textBox3.Text);

                var h = MyMerkleHellmanClass.CalculateHardknapsacks(s, w, n);

                textBox5.Text = string.Join(",", h);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = textBox1.Text.TrimEnd(',').Split(',').ToList().Select(z => Convert.ToInt32(z)).ToList().Count.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateTextBoxMethod("**************************************", Color.Red);
                UpdateTextBoxMethod("******** Запуск шифрования ************", Color.Red);
                UpdateTextBoxMethod("**************************************", Color.Red);

                List<int> h;
                if (string.IsNullOrEmpty(textBox5.Text))
                {
                    var s = textBox1.Text.TrimEnd(',').Split(',').ToList().Select(z => Convert.ToInt32(z)).ToList();
                    var w = Convert.ToInt32(textBox2.Text);
                    var n = Convert.ToInt32(textBox3.Text);

                    h = MyMerkleHellmanClass.CalculateHardknapsacks(s, w, n);

                    textBox5.Text = string.Join(",", h);
                }
                else
                {
                    h = textBox5.Text.TrimEnd(',').Split(',').ToList().Select(z => Convert.ToInt32(z)).ToList();
                }
                byte[] byteArray = Encoding.UTF8.GetBytes(textBox6.Text);
                string bitString = string.Join("", byteArray.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')).ToArray());
                var enc = MyMerkleHellmanClass.EncryptMessage(h, bitString.Replace(" ", ""));
                EBox.Text = string.Join(",", enc);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateTextBoxMethod("**************************************", Color.Red);
                UpdateTextBoxMethod("******** Начать расшифровку ************", Color.Red);
                UpdateTextBoxMethod("**************************************", Color.Red);

                var msg = EBox.Text.TrimEnd(',').Split(',').ToList().Select(z => Convert.ToInt32(z)).ToList();
                var w = Convert.ToInt32(textBox2.Text);
                var n = Convert.ToInt32(textBox3.Text);
                int wi;
                if (string.IsNullOrEmpty(textBox8.Text))
                {
                    wi = MyMerkleHellmanClass.CalculateWinvers(w, n);
                }
                else
                {
                    wi = Convert.ToInt32(textBox8.Text);
                }
                textBox8.Text = wi.ToString();
                var s = textBox1.Text.TrimEnd(',').Split(',').ToList().Select(z => Convert.ToInt32(z)).ToList();

                var messge = MyMerkleHellmanClass.DecryptMessage(msg, wi, n, s);
                var str = "";
                foreach (var list in messge)
                {
                    str += string.Join("", list);

                }
                // преобразование битовой строки в байтовый массив
                byte[] byteArray = new byte[str.Length / 8];
                for (int i = 0; i < byteArray.Length; i++)
                {
                    byteArray[i] = Convert.ToByte(str.Substring(i * 8, 8), 2);
                }

// преобразование байтового массива в строку с помощью кодировки UTF-8
                string result = Encoding.UTF8.GetString(byteArray);
                PBox.Text = result;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var w = Convert.ToInt32(textBox2.Text);
                var n = Convert.ToInt32(textBox3.Text);
                var wi = MyMerkleHellmanClass.CalculateWinvers(w, n);
                textBox8.Text = wi.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            EBox.Clear();
            textBox8.Clear();
            PBox.Clear();
            LogsBox.Clear();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openDialog.FileName = string.Empty;
            openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openDialog.FilterIndex = 2;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openDialog.FileName))
                {
                    textBox6.Text = reader.ReadToEnd();
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openDialog.FileName = string.Empty;
            openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openDialog.FilterIndex = 2;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openDialog.FileName))
                {
                    PBox.Text = reader.ReadToEnd();
                }
            }
        }
    }
}