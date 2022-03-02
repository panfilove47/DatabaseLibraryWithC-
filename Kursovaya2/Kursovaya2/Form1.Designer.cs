namespace Kursovaya2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReadersBtn = new System.Windows.Forms.Button();
            this.BookBtn = new System.Windows.Forms.Button();
            this.BookStorageBtn = new System.Windows.Forms.Button();
            this.FilialBtn = new System.Windows.Forms.Button();
            this.KeywordsBtn = new System.Windows.Forms.Button();
            this.IssuingBooksBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoriesReadersBtn = new System.Windows.Forms.Button();
            this.readerBooksBtn = new System.Windows.Forms.Button();
            this.readersBooksTextBox = new System.Windows.Forms.TextBox();
            this.daysDelayTextBox = new System.Windows.Forms.TextBox();
            this.delayingBooksBtn = new System.Windows.Forms.Button();
            this.booksCountTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.readFilBtn = new System.Windows.Forms.Button();
            this.keyBksBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bookCatalogBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(994, 301);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1176, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send querry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(804, 366);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 58);
            this.textBox1.TabIndex = 3;
            // 
            // ReadersBtn
            // 
            this.ReadersBtn.Location = new System.Drawing.Point(20, 47);
            this.ReadersBtn.Name = "ReadersBtn";
            this.ReadersBtn.Size = new System.Drawing.Size(123, 23);
            this.ReadersBtn.TabIndex = 4;
            this.ReadersBtn.Text = "Show readers";
            this.ReadersBtn.UseVisualStyleBackColor = true;
            this.ReadersBtn.Click += new System.EventHandler(this.ReadersBtn_Click);
            // 
            // BookBtn
            // 
            this.BookBtn.Location = new System.Drawing.Point(20, 137);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(123, 23);
            this.BookBtn.TabIndex = 5;
            this.BookBtn.Text = "Show books ";
            this.BookBtn.UseVisualStyleBackColor = true;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // BookStorageBtn
            // 
            this.BookStorageBtn.Location = new System.Drawing.Point(20, 227);
            this.BookStorageBtn.Name = "BookStorageBtn";
            this.BookStorageBtn.Size = new System.Drawing.Size(123, 23);
            this.BookStorageBtn.TabIndex = 6;
            this.BookStorageBtn.Text = "Show book storages";
            this.BookStorageBtn.UseVisualStyleBackColor = true;
            this.BookStorageBtn.Click += new System.EventHandler(this.BookStorageBtn_Click);
            // 
            // FilialBtn
            // 
            this.FilialBtn.Location = new System.Drawing.Point(20, 272);
            this.FilialBtn.Name = "FilialBtn";
            this.FilialBtn.Size = new System.Drawing.Size(123, 23);
            this.FilialBtn.TabIndex = 7;
            this.FilialBtn.Text = "Show filials";
            this.FilialBtn.UseVisualStyleBackColor = true;
            this.FilialBtn.Click += new System.EventHandler(this.FilialBtn_Click);
            // 
            // KeywordsBtn
            // 
            this.KeywordsBtn.Location = new System.Drawing.Point(20, 317);
            this.KeywordsBtn.Name = "KeywordsBtn";
            this.KeywordsBtn.Size = new System.Drawing.Size(123, 23);
            this.KeywordsBtn.TabIndex = 8;
            this.KeywordsBtn.Text = "Show keywords";
            this.KeywordsBtn.UseVisualStyleBackColor = true;
            this.KeywordsBtn.Click += new System.EventHandler(this.KeywordsBtn_Click);
            // 
            // IssuingBooksBtn
            // 
            this.IssuingBooksBtn.Location = new System.Drawing.Point(20, 362);
            this.IssuingBooksBtn.Name = "IssuingBooksBtn";
            this.IssuingBooksBtn.Size = new System.Drawing.Size(123, 23);
            this.IssuingBooksBtn.TabIndex = 9;
            this.IssuingBooksBtn.Text = "Show issuing books";
            this.IssuingBooksBtn.UseVisualStyleBackColor = true;
            this.IssuingBooksBtn.Click += new System.EventHandler(this.IssuingBooksBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Catalog";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1107, 578);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Вернуть книгу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1107, 552);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1107, 493);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 16;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(1104, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Books\'s id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(1104, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Issue\'s id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1103, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "BOOK RETURN";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(818, 577);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Выдать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(818, 542);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(818, 492);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(815, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Books\'s id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(818, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reader\'s id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(812, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "GIVE OUT THE BOOK";
            // 
            // categoriesReadersBtn
            // 
            this.categoriesReadersBtn.Location = new System.Drawing.Point(20, 92);
            this.categoriesReadersBtn.Name = "categoriesReadersBtn";
            this.categoriesReadersBtn.Size = new System.Drawing.Size(123, 23);
            this.categoriesReadersBtn.TabIndex = 4;
            this.categoriesReadersBtn.Text = "Categories of readers";
            this.categoriesReadersBtn.UseVisualStyleBackColor = true;
            this.categoriesReadersBtn.Click += new System.EventHandler(this.categoriesReadersBtn_Click);
            // 
            // readerBooksBtn
            // 
            this.readerBooksBtn.Location = new System.Drawing.Point(551, 537);
            this.readerBooksBtn.Name = "readerBooksBtn";
            this.readerBooksBtn.Size = new System.Drawing.Size(106, 23);
            this.readerBooksBtn.TabIndex = 3;
            this.readerBooksBtn.Text = "Readers\'s books";
            this.readerBooksBtn.UseVisualStyleBackColor = true;
            this.readerBooksBtn.Click += new System.EventHandler(this.readerBooksBtn_Click);
            // 
            // readersBooksTextBox
            // 
            this.readersBooksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readersBooksTextBox.Location = new System.Drawing.Point(551, 510);
            this.readersBooksTextBox.Name = "readersBooksTextBox";
            this.readersBooksTextBox.Size = new System.Drawing.Size(119, 21);
            this.readersBooksTextBox.TabIndex = 2;
            this.readersBooksTextBox.Text = "Enter reader\'s id";
            this.readersBooksTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.readersBooksTextBox_MouseClick);
            this.readersBooksTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.readersBooksTextBox_KeyPress);
            // 
            // daysDelayTextBox
            // 
            this.daysDelayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daysDelayTextBox.Location = new System.Drawing.Point(551, 428);
            this.daysDelayTextBox.Name = "daysDelayTextBox";
            this.daysDelayTextBox.Size = new System.Drawing.Size(157, 21);
            this.daysDelayTextBox.TabIndex = 1;
            this.daysDelayTextBox.Text = "Enter number of days";
            this.daysDelayTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.daysDelayTextBox_MouseClick);
            this.daysDelayTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.daysDelayTextBox_KeyPress);
            // 
            // delayingBooksBtn
            // 
            this.delayingBooksBtn.Location = new System.Drawing.Point(551, 455);
            this.delayingBooksBtn.Name = "delayingBooksBtn";
            this.delayingBooksBtn.Size = new System.Drawing.Size(108, 35);
            this.delayingBooksBtn.TabIndex = 0;
            this.delayingBooksBtn.Text = "Show readers delaying books";
            this.delayingBooksBtn.UseVisualStyleBackColor = true;
            this.delayingBooksBtn.Click += new System.EventHandler(this.delayingBooksBtn_Click);
            // 
            // booksCountTextBox
            // 
            this.booksCountTextBox.Location = new System.Drawing.Point(292, 594);
            this.booksCountTextBox.Name = "booksCountTextBox";
            this.booksCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.booksCountTextBox.TabIndex = 5;
            this.booksCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.booksCountTextBox_KeyPress);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(1041, 12);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(210, 34);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Text = "Search";
            this.searchTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTextBox_MouseClick);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(398, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Show number books";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addBookBtn
            // 
            this.addBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBookBtn.Location = new System.Drawing.Point(257, 366);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(105, 58);
            this.addBookBtn.TabIndex = 3;
            this.addBookBtn.Text = "Save changes";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // readFilBtn
            // 
            this.readFilBtn.Location = new System.Drawing.Point(20, 407);
            this.readFilBtn.Name = "readFilBtn";
            this.readFilBtn.Size = new System.Drawing.Size(123, 23);
            this.readFilBtn.TabIndex = 12;
            this.readFilBtn.Text = "Filials-Readers";
            this.readFilBtn.UseVisualStyleBackColor = true;
            this.readFilBtn.Click += new System.EventHandler(this.readFilBtn_Click);
            // 
            // keyBksBtn
            // 
            this.keyBksBtn.Location = new System.Drawing.Point(20, 452);
            this.keyBksBtn.Name = "keyBksBtn";
            this.keyBksBtn.Size = new System.Drawing.Size(123, 23);
            this.keyBksBtn.TabIndex = 13;
            this.keyBksBtn.Text = "Keywords-Books";
            this.keyBksBtn.UseVisualStyleBackColor = true;
            this.keyBksBtn.Click += new System.EventHandler(this.keyBksBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(368, 366);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(105, 58);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete row";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.Location = new System.Drawing.Point(759, 440);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox2.Location = new System.Drawing.Point(539, 409);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 215);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Orchid;
            this.pictureBox3.Location = new System.Drawing.Point(278, 539);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(241, 85);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Orchid;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(289, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Number of books in the library";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Orchid;
            this.label9.Location = new System.Drawing.Point(289, 577);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Filial\'s id";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox4.Location = new System.Drawing.Point(12, 37);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(144, 454);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // bookCatalogBtn
            // 
            this.bookCatalogBtn.Location = new System.Drawing.Point(20, 182);
            this.bookCatalogBtn.Name = "bookCatalogBtn";
            this.bookCatalogBtn.Size = new System.Drawing.Size(123, 23);
            this.bookCatalogBtn.TabIndex = 25;
            this.bookCatalogBtn.Text = "Show book\'s Catalog";
            this.bookCatalogBtn.UseVisualStyleBackColor = true;
            this.bookCatalogBtn.Click += new System.EventHandler(this.bookCatalogBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 648);
            this.Controls.Add(this.bookCatalogBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.booksCountTextBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.keyBksBtn);
            this.Controls.Add(this.readFilBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IssuingBooksBtn);
            this.Controls.Add(this.KeywordsBtn);
            this.Controls.Add(this.FilialBtn);
            this.Controls.Add(this.categoriesReadersBtn);
            this.Controls.Add(this.BookStorageBtn);
            this.Controls.Add(this.readerBooksBtn);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.readersBooksTextBox);
            this.Controls.Add(this.ReadersBtn);
            this.Controls.Add(this.daysDelayTextBox);
            this.Controls.Add(this.delayingBooksBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ReadersBtn;
        private System.Windows.Forms.Button BookBtn;
        private System.Windows.Forms.Button BookStorageBtn;
        private System.Windows.Forms.Button FilialBtn;
        private System.Windows.Forms.Button KeywordsBtn;
        private System.Windows.Forms.Button IssuingBooksBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.TextBox booksCountTextBox;
        private System.Windows.Forms.TextBox daysDelayTextBox;
        private System.Windows.Forms.Button delayingBooksBtn;
        private System.Windows.Forms.TextBox readersBooksTextBox;
        private System.Windows.Forms.Button readerBooksBtn;
        private System.Windows.Forms.Button categoriesReadersBtn;
        private System.Windows.Forms.Button readFilBtn;
        private System.Windows.Forms.Button keyBksBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button bookCatalogBtn;
    }
}

