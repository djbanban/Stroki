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
            FindSubStrBTN = new Button();
            Out = new RichTextBox();
            InsertSubStrBTN = new Button();
            DeleteSubStrBTN = new Button();
            ReplaceSubStrBTN = new Button();
            TransformTypeBTN = new Button();
            TypeCheckBTN = new Button();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            NumberBTN = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(330, 5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(317, 37);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Проект «Строки»";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(38, 30);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(135, 22);
            textBox2.TabIndex = 1;
            textBox2.Text = "Входная строка:";
            // 
            // StrInput
            // 
            StrInput.Cursor = Cursors.IBeam;
            StrInput.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            StrInput.Location = new Point(38, 49);
            StrInput.Name = "StrInput";
            StrInput.Size = new Size(864, 29);
            StrInput.TabIndex = 2;
            // 
            // SubStrInput
            // 
            SubStrInput.Cursor = Cursors.IBeam;
            SubStrInput.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SubStrInput.Location = new Point(38, 104);
            SubStrInput.Name = "SubStrInput";
            SubStrInput.Size = new Size(659, 29);
            SubStrInput.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Enabled = false;
            textBox4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(38, 84);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(93, 22);
            textBox4.TabIndex = 3;
            textBox4.Text = "Подстрока:";
            // 
            // FindSubStrBTN
            // 
            FindSubStrBTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FindSubStrBTN.Location = new Point(38, 170);
            FindSubStrBTN.Name = "FindSubStrBTN";
            FindSubStrBTN.Size = new Size(149, 41);
            FindSubStrBTN.TabIndex = 5;
            FindSubStrBTN.Text = "Найти подстроки";
            FindSubStrBTN.UseVisualStyleBackColor = true;
            FindSubStrBTN.Click += FindSubStrBTN_Click;
            // 
            // Out
            // 
            Out.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Out.Location = new Point(38, 291);
            Out.Name = "Out";
            Out.Size = new Size(864, 171);
            Out.TabIndex = 6;
            Out.Text = "";
            // 
            // InsertSubStrBTN
            // 
            InsertSubStrBTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            InsertSubStrBTN.Location = new Point(38, 217);
            InsertSubStrBTN.Name = "InsertSubStrBTN";
            InsertSubStrBTN.Size = new Size(149, 35);
            InsertSubStrBTN.TabIndex = 7;
            InsertSubStrBTN.Text = "Вставка подстроки";
            InsertSubStrBTN.UseVisualStyleBackColor = true;
            // 
            // DeleteSubStrBTN
            // 
            DeleteSubStrBTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteSubStrBTN.Location = new Point(193, 217);
            DeleteSubStrBTN.Name = "DeleteSubStrBTN";
            DeleteSubStrBTN.Size = new Size(149, 36);
            DeleteSubStrBTN.TabIndex = 8;
            DeleteSubStrBTN.Text = "Удаление подстроки";
            DeleteSubStrBTN.UseVisualStyleBackColor = true;
            // 
            // ReplaceSubStrBTN
            // 
            ReplaceSubStrBTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ReplaceSubStrBTN.Location = new Point(193, 170);
            ReplaceSubStrBTN.Name = "ReplaceSubStrBTN";
            ReplaceSubStrBTN.Size = new Size(146, 41);
            ReplaceSubStrBTN.TabIndex = 9;
            ReplaceSubStrBTN.Text = "Заменить подстроку";
            ReplaceSubStrBTN.UseVisualStyleBackColor = true;
            // 
            // TransformTypeBTN
            // 
            TransformTypeBTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TransformTypeBTN.Location = new Point(625, 170);
            TransformTypeBTN.Name = "TransformTypeBTN";
            TransformTypeBTN.Size = new Size(266, 41);
            TransformTypeBTN.TabIndex = 11;
            TransformTypeBTN.Text = "Преобразование к нужному типу";
            TransformTypeBTN.UseVisualStyleBackColor = true;
            TransformTypeBTN.Click += TransformTypeBTN_Click;
            // 
            // TypeCheckBTN
            // 
            TypeCheckBTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TypeCheckBTN.Location = new Point(625, 244);
            TypeCheckBTN.Name = "TypeCheckBTN";
            TypeCheckBTN.Size = new Size(266, 41);
            TypeCheckBTN.TabIndex = 12;
            TypeCheckBTN.Text = "Определить тип строки";
            TypeCheckBTN.UseVisualStyleBackColor = true;
            TypeCheckBTN.Click += CheckTypeBTN_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Enabled = false;
            textBox3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(38, 139);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(221, 28);
            textBox3.TabIndex = 13;
            textBox3.Text = "Работа со строками";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Enabled = false;
            textBox5.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(625, 212);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(277, 28);
            textBox5.TabIndex = 14;
            textBox5.Text = "Парсинг (разбор) строк";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Enabled = false;
            textBox6.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ImeMode = ImeMode.NoControl;
            textBox6.Location = new Point(620, 139);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.ShortcutsEnabled = false;
            textBox6.Size = new Size(282, 28);
            textBox6.TabIndex = 15;
            textBox6.Text = "Преобразование текста";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // NumberBTN
            // 
            NumberBTN.Cursor = Cursors.IBeam;
            NumberBTN.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NumberBTN.Location = new Point(703, 104);
            NumberBTN.Name = "NumberBTN";
            NumberBTN.Size = new Size(199, 29);
            NumberBTN.TabIndex = 18;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Enabled = false;
            textBox8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(703, 84);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(199, 22);
            textBox8.TabIndex = 17;
            textBox8.Text = "Количество вхождений:";
            // 
            // textBox7
            // 
            textBox7.Cursor = Cursors.IBeam;
            textBox7.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(345, 170);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(266, 39);
            textBox7.TabIndex = 19;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Enabled = false;
            textBox9.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(345, 145);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(146, 22);
            textBox9.TabIndex = 20;
            textBox9.Text = "Новая подстрока:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 483);
            Controls.Add(textBox9);
            Controls.Add(textBox7);
            Controls.Add(NumberBTN);
            Controls.Add(textBox8);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(TypeCheckBTN);
            Controls.Add(TransformTypeBTN);
            Controls.Add(ReplaceSubStrBTN);
            Controls.Add(DeleteSubStrBTN);
            Controls.Add(InsertSubStrBTN);
            Controls.Add(Out);
            Controls.Add(FindSubStrBTN);
            Controls.Add(SubStrInput);
            Controls.Add(textBox4);
            Controls.Add(StrInput);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Project \"Strings\"";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox StrInput;
        private TextBox SubStrInput;
        private TextBox textBox4;
        private Button FindSubStrBTN;
        private RichTextBox Out;
        private Button InsertSubStrBTN;
        private Button DeleteSubStrBTN;
        private Button ReplaceSubStrBTN;
        private Button TransformTypeBTN;
        private Button TypeCheckBTN;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox1;
        private TextBox NumberBTN;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox9;
    }
}
