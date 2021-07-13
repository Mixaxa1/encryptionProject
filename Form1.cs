using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryptionProject
{
    public partial class Form1 : Form
    {
        const string _alfavet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private string _letters = _alfavet + _alfavet.ToLower();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSHIFR_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Шифр Виженера (Русский язык)")
                EncryptionVizhener();
            else if (comboBox1.Text == "Шифр XOR (Английский язык)")
                EncryptionVerman();
            else
                MessageBox.Show("Выбранный тип шифрования не найден.");
        }
        private void buttonRASSHIFR_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Шифр Виженера (Русский язык)")
                DecryptionVizhener();
            else if (comboBox1.Text == "Шифр XOR (Английский язык)")
                DecryptionVerman();
            else
                MessageBox.Show("Выбранный тип шифрования не найден.");
        }
        private void copy_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(text_out.Text);
        }

        private void EncryptionVizhener()
        {
            string input = text_in.Text;
            string output = "";
            bool space;
            int shift, l = 0;
            int[] keys = new int[10];

            for (int i = 0; i < key.Text.Length; i++)
            {
                for (int j = 0; j < _letters.Length; j++)
                {
                    if (key.Text[i] == _letters[j])
                        keys[i] = j + 1;
                }
            }

            for (int i = 0; i < text_in.Text.Length; i++)
            {
                space = true;
                shift = keys[l];

                for (int j = 0; j < _letters.Length; j++)
                {
                    if (input[i] == _letters[j])
                    {
                        space = false;
                        if ((j + shift) >= _letters.Length)
                        {
                            output += _letters[(j + shift - _letters.Length)];
                            continue;
                        }
                        output += _letters[j + shift];
                    }
                }

                l++;

                if (space)
                    output += " ";
                if (l >= key.Text.Length)
                    l = 0;
            }

            text_out.Text = output;
        }
        private void DecryptionVizhener()
        {
            string input = text_in.Text;
            string output = "";
            bool space;
            int shift, l = 0;
            int[] keys = new int[10];

            for (int i = 0; i < key.Text.Length; i++)
            {
                for (int j = 0; j < _letters.Length; j++)
                {
                    if (key.Text[i] == _letters[j])
                        keys[i] = j + 1;
                }
            }

            for (int i = 0; i < text_in.Text.Length; i++)
            {
                space = true;
                shift = keys[l];

                for (int j = 0; j < _letters.Length; j++)
                {
                    if (input[i] == _letters[j])
                    {
                        space = false;
                        if ((j - shift) < 0)
                        {
                            output += _letters[(j - shift + _letters.Length)];
                            continue;
                        }
                        output += _letters[j - shift];
                    }
                }

                l++;

                if (space)
                    output += " ";
                if (l >= key.Text.Length)
                    l = 0;
            }

            text_out.Text = output;
        }

        private void EncryptionVerman()
        {
            text_out.Text = null;

            byte[] bytes_numbers = Encoding.UTF8.GetBytes(text_in.Text);
            string[] binary_numbers = new string[text_in.Text.Length];

            byte[] bytes_key = Encoding.UTF8.GetBytes(key.Text);
            string[] binary_key = new string[key.Text.Length];
            for (int i = 0; i < text_in.Text.Length; i++)
            {
                binary_numbers[i] = Convert.ToString(bytes_numbers[i], 2);

                if (i < key.Text.Length)
                {
                    binary_key[i] = Convert.ToString(bytes_key[i], 2);
                }
            }

            string[] output = new string[binary_numbers.Length];

            for (int j = 0, j_key = 0; j < binary_numbers.Length; j++, j_key++)
            {
                if (j_key >= binary_key.Length)
                {
                    j_key = 0;
                }

                for (int i = 0; i < binary_numbers[j].Length; i++)
                {
                    if (int.Parse(Convert.ToString(binary_numbers[j][i])) > 0 ^ int.Parse(Convert.ToString(binary_key[j_key][i])) > 0)
                        output[j] += "1";
                    else
                        output[j] += "0";
                }
            }

            for (int i = 0; i < output.Length; i++)
            {
                text_out.Text += Convert.ToInt32(output[i], 2);
                if (output.Length != i + 1)
                {
                    text_out.Text += " ";
                }
            }

        }
        private void DecryptionVerman()
        {
            text_out.Text = null;
            string[] words = text_in.Text.Split(' ');

            string[] binary_numbers = new string[words.Length];

            byte[] bytes_key = Encoding.UTF8.GetBytes(key.Text);
            string[] binary_key = new string[key.Text.Length];

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < 8 - Convert.ToString(int.Parse(words[i]), 2).Length; j++)
                {
                    binary_numbers[i] += "0";
                }

                binary_numbers[i] += Convert.ToString(int.Parse(words[i]), 2);

                if (i < key.Text.Length)
                {
                    int key_length = Convert.ToString(bytes_key[i], 2).Length;

                    for (int j = 0; j < 8 - key_length; j++)
                    {
                        binary_key[i] += "0";
                    }

                    binary_key[i] += Convert.ToString(bytes_key[i], 2);
                }
            }

            string[] output = new string[binary_numbers.Length];
            byte[] numbers_out = new byte[binary_numbers.Length];

            for (int j = 0, j_key = 0; j < binary_numbers.Length; j++, j_key++)
            {
                if (j_key >= binary_key.Length)
                {
                    j_key = 0;
                }

                for (int i = 0; i < binary_numbers[j].Length; i++)
                {
                    if (int.Parse(Convert.ToString(binary_numbers[j][i])) > 0 ^ int.Parse(Convert.ToString(binary_key[j_key][i])) > 0)
                        output[j] += "1";
                    else
                        output[j] += "0";
                }

                numbers_out[j] = Convert.ToByte(Convert.ToInt32(output[j], 2));
            }

            text_out.Text += Encoding.UTF8.GetString(numbers_out);
        }
    }
}
