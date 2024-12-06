namespace PhoneBook
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            secondname = new TextBox();
            firstname = new TextBox();
            label2 = new Label();
            thrityname = new TextBox();
            label3 = new Label();
            Phones = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            addtelephone = new Button();
            telephonenumber = new TextBox();
            label6 = new Label();
            MOBILADOMA = new RadioButton();
            MOBILA = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            Adress = new TextBox();
            label8 = new Label();
            picture = new PictureBox();
            selectpicture = new Button();
            saveandclose = new Button();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            label1.Click += label1_Click;
            // 
            // secondname
            // 
            secondname.Location = new Point(80, 12);
            secondname.Name = "secondname";
            secondname.Size = new Size(204, 23);
            secondname.TabIndex = 1;
            secondname.TextChanged += textBox1_TextChanged;
            // 
            // firstname
            // 
            firstname.Location = new Point(80, 48);
            firstname.Name = "firstname";
            firstname.Size = new Size(204, 23);
            firstname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Имя";
            label2.Click += label2_Click;
            // 
            // thrityname
            // 
            thrityname.Location = new Point(80, 87);
            thrityname.Name = "thrityname";
            thrityname.Size = new Size(204, 23);
            thrityname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Отчество";
            // 
            // Phones
            // 
            Phones.ContextMenuStrip = contextMenuStrip1;
            Phones.FormattingEnabled = true;
            Phones.ItemHeight = 15;
            Phones.Location = new Point(12, 163);
            Phones.Name = "Phones";
            Phones.Size = new Size(126, 169);
            Phones.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(121, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(120, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addtelephone);
            groupBox1.Controls.Add(telephonenumber);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(MOBILADOMA);
            groupBox1.Controls.Add(MOBILA);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(144, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 169);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление телефона";
            // 
            // addtelephone
            // 
            addtelephone.Location = new Point(94, 141);
            addtelephone.Name = "addtelephone";
            addtelephone.Size = new Size(75, 23);
            addtelephone.TabIndex = 5;
            addtelephone.Text = "Добавить";
            addtelephone.UseVisualStyleBackColor = true;
            addtelephone.Click += addtelephone_Click;
            // 
            // telephonenumber
            // 
            telephonenumber.Location = new Point(10, 112);
            telephonenumber.Name = "telephonenumber";
            telephonenumber.Size = new Size(159, 23);
            telephonenumber.TabIndex = 4;
            telephonenumber.TextChanged += telephonenumber_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 94);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 3;
            label6.Text = "Номер телефона";
            // 
            // MOBILADOMA
            // 
            MOBILADOMA.AutoSize = true;
            MOBILADOMA.Location = new Point(6, 62);
            MOBILADOMA.Name = "MOBILADOMA";
            MOBILADOMA.Size = new Size(89, 19);
            MOBILADOMA.TabIndex = 2;
            MOBILADOMA.TabStop = true;
            MOBILADOMA.Text = "Домашний";
            MOBILADOMA.UseVisualStyleBackColor = true;
            // 
            // MOBILA
            // 
            MOBILA.AutoSize = true;
            MOBILA.Location = new Point(6, 37);
            MOBILA.Name = "MOBILA";
            MOBILA.Size = new Size(97, 19);
            MOBILA.TabIndex = 1;
            MOBILA.TabStop = true;
            MOBILA.Text = "Мобильный";
            MOBILA.UseVisualStyleBackColor = true;
            MOBILA.CheckedChanged += MOBILA_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 0;
            label5.Text = "Тип телефона";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 145);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 8;
            label4.Text = "Телефоны:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 335);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 10;
            label7.Text = "Адрес";
            // 
            // Adress
            // 
            Adress.Location = new Point(12, 353);
            Adress.Name = "Adress";
            Adress.Size = new Size(301, 23);
            Adress.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 388);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 11;
            label8.Text = "Изображение";
            // 
            // picture
            // 
            picture.Location = new Point(12, 406);
            picture.Name = "picture";
            picture.Size = new Size(147, 143);
            picture.TabIndex = 12;
            picture.TabStop = false;
            // 
            // selectpicture
            // 
            selectpicture.Location = new Point(179, 406);
            selectpicture.Name = "selectpicture";
            selectpicture.Size = new Size(75, 28);
            selectpicture.TabIndex = 6;
            selectpicture.Text = "Выбрать";
            selectpicture.UseVisualStyleBackColor = true;
            // 
            // saveandclose
            // 
            saveandclose.Location = new Point(248, 516);
            saveandclose.Name = "saveandclose";
            saveandclose.Size = new Size(169, 49);
            saveandclose.TabIndex = 13;
            saveandclose.Text = "Сохранить и закрыть";
            saveandclose.UseVisualStyleBackColor = true;
            saveandclose.Click += button3_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 594);
            Controls.Add(saveandclose);
            Controls.Add(selectpicture);
            Controls.Add(picture);
            Controls.Add(label8);
            Controls.Add(Adress);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(Phones);
            Controls.Add(thrityname);
            Controls.Add(label3);
            Controls.Add(firstname);
            Controls.Add(label2);
            Controls.Add(secondname);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "Редактор";
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox secondname;
        private TextBox firstname;
        private Label label2;
        private TextBox thrityname;
        private Label label3;
        private ListBox Phones;
        private GroupBox groupBox1;
        private Button addtelephone;
        private TextBox telephonenumber;
        private Label label6;
        private RadioButton MOBILADOMA;
        private RadioButton MOBILA;
        private Label label5;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private Label label7;
        private TextBox Adress;
        private Label label8;
        private PictureBox picture;
        private Button selectpicture;
        private Button saveandclose;
    }
}