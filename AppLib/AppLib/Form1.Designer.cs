namespace AppLib
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewBooks = new System.Windows.Forms.ListView();
            this.columnHeader_IdCard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DateOfIssue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DateReturn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_NameBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_YearOfPublishing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_PublishingHouse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_Find = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Filter4 = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewBooks
            // 
            this.listViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_IdCard,
            this.columnHeader_LastName,
            this.columnHeader_DateOfIssue,
            this.columnHeader_DateReturn,
            this.columnHeader_Author,
            this.columnHeader_NameBook,
            this.columnHeader_YearOfPublishing,
            this.columnHeader_PublishingHouse,
            this.columnHeader_Price});
            this.listViewBooks.FullRowSelect = true;
            this.listViewBooks.GridLines = true;
            this.listViewBooks.HideSelection = false;
            this.listViewBooks.Location = new System.Drawing.Point(12, 12);
            this.listViewBooks.Name = "listViewBooks";
            this.listViewBooks.Size = new System.Drawing.Size(955, 425);
            this.listViewBooks.TabIndex = 0;
            this.listViewBooks.UseCompatibleStateImageBehavior = false;
            this.listViewBooks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_IdCard
            // 
            this.columnHeader_IdCard.Text = "Ид";
            this.columnHeader_IdCard.Width = 42;
            // 
            // columnHeader_LastName
            // 
            this.columnHeader_LastName.Text = "Фамилия";
            this.columnHeader_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_LastName.Width = 99;
            // 
            // columnHeader_DateOfIssue
            // 
            this.columnHeader_DateOfIssue.Text = "Дата выдачи";
            this.columnHeader_DateOfIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_DateOfIssue.Width = 84;
            // 
            // columnHeader_DateReturn
            // 
            this.columnHeader_DateReturn.Text = "Дата возврата";
            this.columnHeader_DateReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_DateReturn.Width = 107;
            // 
            // columnHeader_Author
            // 
            this.columnHeader_Author.Text = "Автор";
            this.columnHeader_Author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Author.Width = 135;
            // 
            // columnHeader_NameBook
            // 
            this.columnHeader_NameBook.Text = "Название книги";
            this.columnHeader_NameBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_NameBook.Width = 119;
            // 
            // columnHeader_YearOfPublishing
            // 
            this.columnHeader_YearOfPublishing.Text = "Год издания";
            this.columnHeader_YearOfPublishing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_YearOfPublishing.Width = 88;
            // 
            // columnHeader_PublishingHouse
            // 
            this.columnHeader_PublishingHouse.Text = "Издательство";
            this.columnHeader_PublishingHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_PublishingHouse.Width = 214;
            // 
            // columnHeader_Price
            // 
            this.columnHeader_Price.Text = "Цена";
            this.columnHeader_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Номер билета",
            "Автор",
            "Издательство"});
            this.comboBox1.Location = new System.Drawing.Point(12, 492);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // button_Find
            // 
            this.button_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Find.Location = new System.Drawing.Point(751, 490);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(105, 23);
            this.button_Find.TabIndex = 2;
            this.button_Find.Text = "Поиск";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(139, 492);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(606, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Clear.Location = new System.Drawing.Point(862, 489);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(105, 23);
            this.button_Clear.TabIndex = 4;
            this.button_Clear.Text = "Сбросить";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Filter4
            // 
            this.button_Filter4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Filter4.Location = new System.Drawing.Point(1024, 37);
            this.button_Filter4.Name = "button_Filter4";
            this.button_Filter4.Size = new System.Drawing.Size(105, 23);
            this.button_Filter4.TabIndex = 5;
            this.button_Filter4.Text = "Просроченные";
            this.button_Filter4.UseVisualStyleBackColor = true;
            this.button_Filter4.Click += new System.EventHandler(this.button_Filter4_Click);
            // 
            // button_Add
            // 
            this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Add.Location = new System.Drawing.Point(1024, 188);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(105, 23);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delete.Location = new System.Drawing.Point(1024, 217);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(105, 23);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Filter4);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Find);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listViewBooks);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "MainForm";
            this.Text = "AppLibrary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewBooks;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Filter4;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ColumnHeader columnHeader_IdCard;
        private System.Windows.Forms.ColumnHeader columnHeader_LastName;
        private System.Windows.Forms.ColumnHeader columnHeader_DateOfIssue;
        private System.Windows.Forms.ColumnHeader columnHeader_DateReturn;
        private System.Windows.Forms.ColumnHeader columnHeader_Author;
        private System.Windows.Forms.ColumnHeader columnHeader_NameBook;
        private System.Windows.Forms.ColumnHeader columnHeader_YearOfPublishing;
        private System.Windows.Forms.ColumnHeader columnHeader_PublishingHouse;
        private System.Windows.Forms.ColumnHeader columnHeader_Price;
    }
}

