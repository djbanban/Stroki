namespace StrokiClient
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            StrInput = new TextBox();
            SubStrInput = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            Out = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            button5 = new Button();
            TypeCheckBTN = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(334, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(317, 32);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Обработка строк";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(38, 50);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Входная строка:";
            // 
            // StrInput
            // 
            StrInput.Cursor = Cursors.IBeam;
            StrInput.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            StrInput.Location = new Point(38, 79);
            StrInput.Name = "StrInput";
            StrInput.Size = new Size(465, 29);
            StrInput.TabIndex = 2;
            // 
            // SubStrInput
            // 
            SubStrInput.Cursor = Cursors.IBeam;
            SubStrInput.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SubStrInput.Location = new Point(38, 146);
            SubStrInput.Name = "SubStrInput";
            SubStrInput.Size = new Size(465, 29);
            SubStrInput.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Enabled = false;
            textBox4.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(38, 117);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(230, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "Подстрока:";
            // 
            // button1
            // 
            button1.Location = new Point(38, 209);
            button1.Name = "button1";
            button1.Size = new Size(130, 41);
            button1.TabIndex = 5;
            button1.Text = "Найти подстроки";
            button1.UseVisualStyleBackColor = true;
            // 
            // Out
            // 
            Out.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Out.Location = new Point(64, 289);
            Out.Name = "Out";
            Out.Size = new Size(818, 131);
            Out.TabIndex = 6;
            Out.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(212, 209);
            button2.Name = "button2";
            button2.Size = new Size(130, 22);
            button2.TabIndex = 7;
            button2.Text = "Вставка";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(212, 228);
            button3.Name = "button3";
            button3.Size = new Size(130, 22);
            button3.TabIndex = 8;
            button3.Text = "Удаление";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(373, 209);
            button4.Name = "button4";
            button4.Size = new Size(130, 41);
            button4.TabIndex = 9;
            button4.Text = "Заменить подстроку";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Идентификатор", "Целое", "Вещественное", "Логическое" });
            comboBox1.Location = new Point(528, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 28);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Выберите тип преобразования";
            // 
            // button5
            // 
            button5.Location = new Point(528, 117);
            button5.Name = "button5";
            button5.Size = new Size(130, 41);
            button5.TabIndex = 11;
            button5.Text = "Преобразовать";
            button5.UseVisualStyleBackColor = true;
            // 
            // TypeCheckBTN
            // 
            TypeCheckBTN.Location = new Point(772, 80);
            TypeCheckBTN.Name = "TypeCheckBTN";
            TypeCheckBTN.Size = new Size(130, 41);
            TypeCheckBTN.TabIndex = 12;
            TypeCheckBTN.Text = "Определить тип";
            TypeCheckBTN.UseVisualStyleBackColor = true;
            TypeCheckBTN.Click += CheckTypeBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 483);
            Controls.Add(TypeCheckBTN);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Out);
            Controls.Add(button1);
            Controls.Add(SubStrInput);
            Controls.Add(textBox4);
            Controls.Add(StrInput);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox StrInput;
        private TextBox SubStrInput;
        private TextBox textBox4;
        private Button button1;
        private RichTextBox Out;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
        private Button button5;
        private Button TypeCheckBTN;
    }
}