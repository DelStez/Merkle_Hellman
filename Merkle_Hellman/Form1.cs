using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merkle_Hellman
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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> bitsList = new List<int>();
            if (!string.IsNullOrEmpty(textBox7.Text))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(textBox7.Text);
                foreach (byte b in bytes)
                {
                    // Получаем биты каждого байта в виде строки
                    string bits = Convert.ToString(b, 2).PadLeft(8, '0');
    
                    // Добавляем каждый бит в список
                    foreach (char bit in bits)
                    {
                        bitsList.Add(int.Parse(bit.ToString()));
                    }
                }
            }
            else
            {
                MessageBox.Show("Пустое окно сообщения");
            }
        }
        static int[] GetPublicKey(int[] w, int q, int r)
        {
            int[] beta = new int[w.Length];
            for(int i = 0; i < w.Length; i++) beta[i] = w[i] * r % q;
            return beta;
        }
    }
}