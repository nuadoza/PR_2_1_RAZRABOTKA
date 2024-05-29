namespace PR_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            Рассчитать = new Label();
            toolTip1 = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            вычислитьToolStripMenuItem = new ToolStripMenuItem();
            программаРасчётыToolStripMenuItem = new ToolStripMenuItem();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            tb_String = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            tb_Sentence = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(Рассчитать);
            groupBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(0, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(930, 63);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "В данной программе вы пожете поместив вначале все символы, расположенные на четных позициях строки, а затем, в обратном порядке, все символы, расположенные на нечетных позициях.";
            // 
            // Рассчитать
            // 
            Рассчитать.AutoSize = true;
            Рассчитать.BackColor = SystemColors.Info;
            Рассчитать.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Рассчитать.Location = new Point(35, 29);
            Рассчитать.Name = "Рассчитать";
            Рассчитать.Size = new Size(0, 15);
            Рассчитать.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(927, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вычислитьToolStripMenuItem, очиститьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // вычислитьToolStripMenuItem
            // 
            вычислитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { программаРасчётыToolStripMenuItem });
            вычислитьToolStripMenuItem.Name = "вычислитьToolStripMenuItem";
            вычислитьToolStripMenuItem.Size = new Size(135, 22);
            вычислитьToolStripMenuItem.Text = "Вычислить";
            // 
            // программаРасчётыToolStripMenuItem
            // 
            программаРасчётыToolStripMenuItem.Name = "программаРасчётыToolStripMenuItem";
            программаРасчётыToolStripMenuItem.Size = new Size(198, 22);
            программаРасчётыToolStripMenuItem.Text = "Программа \"Расчёты\"";
            программаРасчётыToolStripMenuItem.Click += программаРасчётыToolStripMenuItem_Click;
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(135, 22);
            очиститьToolStripMenuItem.Text = "Очистить";
            очиститьToolStripMenuItem.Click += очиститьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(135, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(tb_String);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(0, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 99);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Исходные данные:";
            // 
            // tb_String
            // 
            tb_String.Location = new Point(173, 45);
            tb_String.Name = "tb_String";
            tb_String.Size = new Size(191, 27);
            tb_String.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(161, 18);
            label2.TabIndex = 5;
            label2.Text = "Введите символы:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Info;
            groupBox3.Controls.Add(tb_Sentence);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(392, 143);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(538, 99);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Результат:";
            // 
            // tb_Sentence
            // 
            tb_Sentence.Location = new Point(142, 48);
            tb_Sentence.Name = "tb_Sentence";
            tb_Sentence.ReadOnly = true;
            tb_Sentence.Size = new Size(325, 27);
            tb_Sentence.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 52);
            label4.Name = "label4";
            label4.Size = new Size(130, 18);
            label4.TabIndex = 4;
            label4.Text = "Предложение:";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(649, 285);
            button1.Name = "button1";
            button1.Size = new Size(108, 34);
            button1.TabIndex = 5;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(191, 285);
            button2.Name = "button2";
            button2.Size = new Size(135, 34);
            button2.TabIndex = 6;
            button2.Text = "Зашифровать";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(927, 320);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мое приложение";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem вычислитьToolStripMenuItem;
        private ToolStripMenuItem программаРасчётыToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private Label Рассчитать;
        private GroupBox groupBox2;
        private TextBox tb_String;
        private GroupBox groupBox3;
        private TextBox tb_Sentence;
        private Label label4;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}
