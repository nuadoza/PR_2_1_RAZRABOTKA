using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод для превращения символов расположенные на четных позициях строка, а затем, в обратном порядке, все символы, расположенные на нечетных позициях.
        /// </summary>
        public async void Encryption()
        {
            try
            {              
                string inputText = tb_String.Text;
                ErrorProvider errorProvider = new ErrorProvider();
                if (!String.IsNullOrEmpty(tb_String.Text))
                {
                    List<char> evenChars = new List<char>();
                    List<char> oddChars = new List<char>();
                    for (int position = 0; position < inputText.Length; position++)
                    {
                        if (position % 2 == 0)
                        {
                            evenChars.Add(inputText[position]); // Четные символы
                        }
                        else
                        {
                            oddChars.Add(inputText[position]); // Нечетные символы
                        }
                    }
                    oddChars.Reverse();
                    evenChars.AddRange(oddChars);
                    evenChars.Reverse();
                    // создаем строку из символов и устанавливаем ее в элемент tb_Sentence
                    string encryptedText = new string(evenChars.ToArray());//преобразование списка в массив
                    tb_Sentence.Text = encryptedText;
                }
                else
                {
                    errorProvider.SetError(tb_String, "Поле не должно быть пустым");
                    await Task.Delay(2000);
                    errorProvider.SetError(tb_String, "");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Sentence.Clear();
                tb_String.Clear(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Sentence.Clear(); 
                tb_String.Clear(); 
            }
        }
        private void программаРасчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encryption();
        }
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_String.Clear();
            tb_Sentence.Clear();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Encryption();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}