using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data; // Для более простого обращения.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Библиотека MySql.

namespace Kursovaya2
{
    public partial class Form1 : Form
    {

        public string connect = "Server=localhost;Database=librarydatabase;Uid=root;password=Тут был мой пароль);charset=utf8"; // данные для коннекта
        public MySqlConnection MyConn; // Коннектор к БД
        public MySqlCommand MyComm; // Для отправки запроса
        public MySqlDataAdapter adapter; // Предоставляет выборку из запроса.
        public SD.DataSet ds; // Показывает, что находится в памяти сейчас.
        private BindingSource bindingSource;
        SD.DataTable dt;

        public Form1()
        {
            InitializeComponent();
            MyConn = new MySqlConnection(connect);
            MyConn.Open();
        }
        ~Form1()
        {
            MyConn.Close();
        }

        private void fillTableInRequest(string querry) // Метод для отправки запроса в MYSQL и заполнения таблицы.
        {
            adapter = new MySqlDataAdapter(querry, connect); // Предоставляет выборку из запроса.
            SD.DataTable table = new SD.DataTable(); // Временная таблица для заполнения нашей.
            adapter.Fill(table); // Заполнение временной таблицы.
            bindingSource = new BindingSource();
            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource; // Перенесение временной таблицы в основную.
        }
        private void button1_Click(object sender, EventArgs e) // Метод для ввода запроса напрямую из textBox1
        {
            try
            {
                string script = textBox1.Text; // Ввод запроса напрямую.
                fillTableInRequest(script);
                //adapter = new MySqlDataAdapter(script, connect); // Предоставляет выборку из запроса.
                //SD.DataTable table = new SD.DataTable(); // Временная таблица для заполнения нашей.

                //adapter.Fill(table); // Заполнение временной таблицы.
                //dataGridView1.DataSource = table; // Перенесение временной таблицы в основную.

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void fillTableWithChanges(string querry)
        {
            try
            {
                adapter = new MySqlDataAdapter(querry, connect); // Предоставляет выборку из запроса.
                MySqlCommandBuilder myCommandBuilder = new MySqlCommandBuilder(adapter as MySqlDataAdapter);
                adapter.InsertCommand = myCommandBuilder.GetInsertCommand();
                adapter.UpdateCommand = myCommandBuilder.GetUpdateCommand();
                adapter.DeleteCommand = myCommandBuilder.GetDeleteCommand();
                dt = new SD.DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ReadersBtn_Click(object sender, EventArgs e) // Показывает список читателей
        {
            fillTableWithChanges("select * from readers");
        }

        private void BookBtn_Click(object sender, EventArgs e) // Показывает список книг
        {
            fillTableWithChanges("select * from books");
        }

        private void BookStorageBtn_Click(object sender, EventArgs e) // Показывает место хранения книги
        {
            try
            {
                fillTableInRequest("select * from books b, filial f where Filial_idFilial = idFilial;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FilialBtn_Click(object sender, EventArgs e) // Показывает филиалы.
        {
            fillTableWithChanges("select * from filial");
        }

        private void KeywordsBtn_Click(object sender, EventArgs e) // Показывает ключевые слова.
        {
            fillTableWithChanges("select * from keywords");
        }

        private void IssuingBooksBtn_Click(object sender, EventArgs e) // Показывает забранные книги.
        {
            try
            {
                fillTableInRequest("select * from issuingbook;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e) // Кнопка показывает количество книг в филиалах
        {
            try
            {
                if (booksCountTextBox.Text != "")
                {
                    fillTableInRequest("with cte as (select * from books b, issuingbook i where" +
                        " idBooks = Books_idBooks and Filial_idFilial =" + booksCountTextBox.Text + ")" +
                        " select * from (select count(*) as NominalCount from cte as Nom) Nom," +
                        " (select count(*) as FactCount from cte as Fact where ReturnDate is not NULL) Fact;");
                }
                else
                    MessageBox.Show("Введите id филиала по которому осуществляется поиск");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void addBookBtn_Click(object sender, EventArgs e) // Сохранить изменения.
        {
            if (MessageBox.Show("Вы действительно хотите сохранить изменения?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    adapter.Update(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
                    
        }



        private void searchTextBox_TextChanged(object sender, EventArgs e) // Поиск книг
        {
            try
            {
                //string script = "select * from temp_table where concat(" + richTextBox1.Text + ") like '%" + searchTextBox.Text + "%'";
                string script = "with books_keywords as" +
                    " (select * from Books b left join Keywords_has_books kb on kb.Books_idBooks = b.idBooks" +
                    " left join Keywords k on kb.Books_idBooks = k.idKeywords), books_info as" +
                    " (select * from books, bookinfo where idbookinfo = bookinfo_idbookinfo), book_word" +
                    " as (select bk.idBooks, Name, Author, YearPublishing, Genre, Word from books_keywords bk, books_info bi" +
                    " where bk.idBooks = bi.idBooks order by bk.idBooks) select * from book_word where" +
                    " concat(idBooks, Name, Author, YearPublishing, Genre, Word) like '%" +searchTextBox.Text +"%';";
                //MySqlDataAdapter adapter = new MySqlDataAdapter(script, connect);
                //SD.DataTable table = new SD.DataTable();
                //adapter.Fill(table);
                //dataGridView1.DataSource = table;
                fillTableInRequest(script);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e) // Удаления текста Search при нажатии на textBox
        {
            searchTextBox.Text = "";
            searchTextBox.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        }

        private void searchTextBox_Leave(object sender, EventArgs e) // Добавление текста Search при переключении с textBox
        {
            searchTextBox.Text = "Search";
            searchTextBox.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }

        private void delayingBooksBtn_Click(object sender, EventArgs e) // Выводить читателей задерживающие книги на вводимео количество дней
        {
            try
            {
                if (daysDelayTextBox.Text != "")
                {
                    fillTableInRequest("select idissuingbook, idReaders, FIO,dateIssue, Books_idBooks, (datediff(current_date, dateIssue))" +
                        " as DaysOfDelay from issuingbook, Readers where" +
                        " (datediff(current_date, dateIssue)) > " + daysDelayTextBox.Text + " and Readers_idReaders = idReaders and ReturnDate is NULL;");
                }
                else
                    MessageBox.Show("Введите минимальное количество дней задержки книги");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void daysDelayTextBox_KeyPress(object sender, KeyPressEventArgs e) // Проеврка на ввод цифр
        {
            if ((Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) || (!string.IsNullOrEmpty(textBox1.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void readerBooksBtn_Click(object sender, EventArgs e) // Показывает список книг у данного читателя сейчас
        {
            try
            {
                if (readersBooksTextBox.Text != "")
                {
                    fillTableInRequest("select idBooks, Name, idReaders, FIO, dateIssue from books b, issuingbook i, Readers r, bookinfo bi" +
                        " where b.idBooks = i.Books_idBooks and i.Readers_idReaders = r.idReaders and r.idReaders ="+ readersBooksTextBox.Text +" and" +
                        " b.bookinfo_idBookinfo = bi.idBookinfo and ReturnDate is NULL;");
                }
                else
                    MessageBox.Show("Введите id читателя");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void readersBooksTextBox_KeyPress(object sender, KeyPressEventArgs e) // Проеврка на ввод цифр
        {
            if ((Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) || (!string.IsNullOrEmpty(textBox1.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void categoriesReadersBtn_Click(object sender, EventArgs e) // Выборка читателей по лню рождения
        {
            try
            {
                fillTableInRequest("select idReaders, FIO, Sex, Profession, Birth," +
                    " (YEAR(CURRENT_DATE)-YEAR(birth))-(RIGHT(CURRENT_DATE,5)<RIGHT(birth,5)) AS Age from Readers;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void daysDelayTextBox_MouseClick(object sender, MouseEventArgs e) // Удаление текста при переключении с textBox
        {
            daysDelayTextBox.Text = "";
            daysDelayTextBox.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        }

        private void readersBooksTextBox_MouseClick(object sender, MouseEventArgs e) // Удаление текста при переключении с textBox
        {
            readersBooksTextBox.Text = "";
            readersBooksTextBox.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        }

        private void readFilBtn_Click(object sender, EventArgs e)
        {
            fillTableWithChanges("select * from filial_has_readers");
        }

        private void keyBksBtn_Click(object sender, EventArgs e)
        {
            fillTableWithChanges("select * from keywords_has_books");
        }

        private void deleteBtn_Click(object sender, EventArgs e) // Удаление строки
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    adapter.Update(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // Выдать книгу
        {
            try
            {
                MyConn = new MySqlConnection(connect);
                MyConn.Open();
                MySqlCommand cmd = new MySqlCommand("select exists(select idBooks from books where idBooks =" + textBox4.Text +") and (select not exists(select * from issuingbook where returnDate is Null and Books_idBooks =" + textBox4.Text + "));", MyConn);
                bool isReturned = System.Convert.ToBoolean(cmd.ExecuteScalar());
                DateTime dateTime = DateTime.UtcNow.Date;

                if (isReturned && textBox3.Text != "" && textBox4.Text != "")
                {
                    MySqlCommand comm = new MySqlCommand("insert into issuingbook (DateIssue, Readers_idReaders, Books_idBooks) values (" + dateTime.ToString("yyyyMMdd") + ", " + textBox3.Text +
                        ", " + textBox4.Text + ") ", MyConn);
                    comm.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("Нельзя выдать книгу так как ее сейчас нет либо проверьте правильность полей");
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e) // Вернуть книгу
        {
            MyConn = new MySqlConnection(connect);
            MyConn.Open();
            MySqlCommand cmd = new MySqlCommand("select exists (select * from issuingbook where idIssuingBook =" +textBox5.Text +" and ReturnDate is NULL and Books_idBooks =" + textBox2.Text +");", MyConn);
            bool isNotReturned = System.Convert.ToBoolean(cmd.ExecuteScalar());
            DateTime dateTime = DateTime.UtcNow.Date;
            if (isNotReturned)
            {
                MySqlCommand comm = new MySqlCommand("UPDATE `librarydatabase`.`issuingbook` SET" +
                    " `ReturnDate` = " + dateTime.ToString("yyyyMMdd") + " WHERE (`idIssuingBook` = "+ textBox5.Text + ");", MyConn);
                comm.ExecuteNonQuery();
            }
            else
                MessageBox.Show("Нельзя вернуть книгу так как ее уже вернули либо проверьте правильность полей");
        }

        private void booksCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) || (!string.IsNullOrEmpty(booksCountTextBox.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) || (!string.IsNullOrEmpty(textBox3.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) || (!string.IsNullOrEmpty(textBox4.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) || (!string.IsNullOrEmpty(textBox5.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) || (!string.IsNullOrEmpty(textBox2.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void bookCatalogBtn_Click(object sender, EventArgs e) // Показывает каталог книг.
        {
            fillTableWithChanges("select * from bookinfo");
        }
    }
}
