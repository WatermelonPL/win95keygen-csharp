using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win95keygen_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] temp = new int[6];
        int[] temp3 = new int[7];
        int temp2;

        private void button1_Click(object sender, EventArgs e)
        {
            //Inicjalizuj generator liczb losowych
            Random rnd = new Random();
            //Czyść obecną bazę kluczy
            richTextBox1.Text = "";
            progressBar1.Value = 0;
            if (checkBox1.Checked)
            {
                progressBar1.Maximum = Convert.ToInt32(numericUpDown1.Value) * 4;
                for (int i = 0; i < Convert.ToInt32(numericUpDown1.Value); i++)
                {
                    progressBar1.Value += 1;
                    if (!radioButton1.Checked)
                    {
                        label1.Text = "Generuję klucz " + i.ToString() + "...";
                    }
                    else
                    {
                        label1.Text = "Generating key no. " + i.ToString() + "...";
                    }
                    string first = rnd.Next(0, 366).ToString("000") + rnd.Next(95, 99).ToString();
                    progressBar1.Value += 1;
                    do
                    {
                        for (int b = 0; b < temp.Length; b++)
                        {
                            temp[b] = rnd.Next(0, 9);
                        }
                    }
                    while (temp.Sum() % 7 != 0 || temp[5] == 0 || temp[5] == 8 || temp[5] == 9);
                    string second = "0" + temp[0].ToString() + temp[1].ToString() + temp[2].ToString() + temp[3].ToString() + temp[4].ToString() + temp[5].ToString();
                    progressBar1.Value += 1;
                    string third = rnd.Next(0, 99999).ToString("00000");
                    progressBar1.Value += 1;
                    richTextBox1.Text += first + "-OEM-" + second + "-" + third + "\r\n";
                }
            }
            else
            {
                progressBar1.Maximum = Convert.ToInt32(numericUpDown1.Value) * 3;
                for (int i = 0; i < Convert.ToInt32(numericUpDown1.Value); i++)
                {
                    progressBar1.Value += 1;
                    if(!radioButton1.Checked)
                    {
                        label1.Text = "Generuję klucz " + i.ToString() + "...";
                    } else
                    {
                        label1.Text = "Generating key no. " + i.ToString() + "...";
                    }
                    do
                    {
                        temp2 = rnd.Next(0, 999);
                    }
                    while (temp2 == 333 || temp2 == 444 || temp2 == 555 || temp2 == 666 || temp2 == 777 || temp2 == 888 || temp2 == 999);
                    string second = temp2.ToString("000");
                    progressBar1.Value += 1;
                    do
                    {
                        for (int b = 0; b < temp3.Length; b++)
                        {
                            temp3[b] = rnd.Next(0, 9);
                        }
                    }
                    while (temp3.Sum() % 7 != 0 || temp3[6] == 0 || temp3[6] == 8 || temp3[6] == 9);
                    string third = temp3[0].ToString() + temp3[1].ToString() + temp3[2].ToString() + temp3[3].ToString() + temp3[4].ToString() + temp3[5].ToString() + temp3[6].ToString();
                    progressBar1.Value += 1;
                    richTextBox1.Text += second + "-" + third + "\r\n";
                }
            }
            if (!radioButton1.Checked)
            {
                label1.Text = "Gotowe!";
            }
            else
            {
                label1.Text = "Done!";
            }
        }

        public int Add(int addone, int addtwo)
        {
            return addone + addtwo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.lang == "en")
            {
                radioButton1.Checked = true;
            } else if (Properties.Settings.Default.lang == "pl")
            {
                radioButton2.Checked = true;
            }
            if (!radioButton1.Checked)
            {
                label1.Text = "Czekam...";
                this.Text = "Generator kluczy Windows 95 / Windows NT 4 / Office 95";
                button1.Text = "Generuj klucze";
                checkBox1.Text = "Generuj klucze OEM";
            }
            else
            {
                label1.Text = "Ready";
                this.Text = "Windows 95 / Windows NT 4 / Office 95 keygen";
                button1.Text = "Generate keys";
                checkBox1.Text = "Generate OEM keys";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                Properties.Settings.Default.lang = "en";
                Properties.Settings.Default.Save();
            }
            if (!radioButton1.Checked)
            {
                label1.Text = "Czekam...";
                this.Text = "Generator kluczy Windows 95 / Windows NT 4 / Office 95";
                button1.Text = "Generuj klucze";
                checkBox1.Text = "Generuj klucze OEM";
                label2.Text = "Liczba kluczy";
            }
            else
            {
                label1.Text = "Ready";
                this.Text = "Windows 95 / Windows NT 4 / Office 95 keygen";
                button1.Text = "Generate keys";
                checkBox1.Text = "Generate OEM keys";
                label2.Text = "Number of keys";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Properties.Settings.Default.lang = "pl";
                Properties.Settings.Default.Save();
            }
            if (!radioButton1.Checked)
            {
                label1.Text = "Czekam...";
                this.Text = "Generator kluczy Windows 95 / Windows NT 4 / Office 95";
                button1.Text = "Generuj klucze";
                checkBox1.Text = "Generuj klucze OEM";
            }
            else
            {
                label1.Text = "Ready";
                this.Text = "Windows 95 / Windows NT 4 / Office 95 keygen";
                button1.Text = "Generate keys";
                checkBox1.Text = "Generate OEM keys";
            }
        }
    }
}
