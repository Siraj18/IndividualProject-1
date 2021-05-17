using IndividualProject.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualProject
{
	public partial class userForm : Form
	{

		Book[] books; // Массив с "книгами"
		public userForm()
		{
			InitializeComponent();
			labelUser.Text = User.last_name + " " + User.first_name;
			labelFIO.Text = "Имя:" + User.first_name + "\n" + "Фамилия:" + User.last_name + "\n" + "Возраст:" + User.age;

			CatalogCreate(); // Создание панелей и загрузка данных из бд
			// Назначение обработчиков событий на элементы
			buCatalog.Click += BuCatalog_Click;
			buBron.Click += BuBron_Click;
			buProfile.Click += BuProfile_Click;
			buBronLoad.Click += BuBronLoad_Click;
			buLoadComplete.Click += BuLoadComplete_Click;
		}

		private void BuLoadComplete_Click(object sender, EventArgs e)
		{
			DBManager serverDB = new DBManager();
			string result = serverDB.LoadGiveBooks(User.userId);
			labelGivenBooks.Text = result;
		}

		private void BuBronLoad_Click(object sender, EventArgs e)
		{
			DBManager serverDb = new DBManager();
			string result = serverDb.LoadBookings(User.userId);
			labelBronResult.Text = result;
		}

		private void BuProfile_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabControl1.TabPages[2]; // Переключение вкладки
			labelPageName.Text = "Профиль";
		}

		private void BuBron_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabControl1.TabPages[1]; // Переключение вкладки
			labelPageName.Text = "Бронь";
		}

		private void BuCatalog_Click(object sender, EventArgs e)
		{
			
			tabControl1.SelectedTab = tabControl1.TabPages[0]; // Переключение вкладки
			labelPageName.Text = "Каталог";
		}

	
		// Функция для загрузки каталога книг из бд
		private void CatalogLoad()
		{
			DBManager serverDb = new DBManager();
			string result = serverDb.LoadBooks();
			
			string[] rows = result.Split('\n');
			books = new Book[rows.Length - 1];
			for (int i = 0; i < rows.Length - 1; i++)
			{
				string[] bookInfo = rows[i].Split(';');
				books[i] = new Book(bookInfo[0], bookInfo[1], bookInfo[2], bookInfo[3], bookInfo[4]);
			}
			
		}
		private void BronBookClick(string bookId)
		{
			DBManager serverDb = new DBManager();
			Random x = new Random();
			int s = x.Next(5000, 100000);
			serverDb.BronBook(bookId, s.ToString(), User.userId, User.first_name + " " + User.last_name);
			MessageBox.Show("Книга успешно забронирована, чтобы получить детали перейдите в раздел бронь");
		}

		// Функция для создания макета каталога
		
		private void CatalogCreate()
		{
			CatalogLoad(); // Загрузка каталога из базы
			Panel[] panels = new Panel[12];
			int width  = tabControl1.TabPages[0].Width / 3 - 10;
			int height = 300; // Высота панели
			// Переменные для задания отступа
			int tekX = 0;
			int tekY = 0;
			int count = 0; 
			for (int i = 0; count < books.Length; i++)
			{
				for (int j = 0; j < 3 && count < books.Length; j++)
				{
					// Создание панелей
					panels[count] = new Panel();
					panels[count].Location = new Point(tekX, tekY);
					panels[count].Width = width;
					panels[count].Height = height;
					panels[count].BackgroundImage = Resources.newrect;
					panels[count].BackgroundImageLayout = ImageLayout.Stretch;
					// Добавление текста

					Label lb = new Label(); // Создаем надпись для названия книги
					lb.Text = books[count].name;
					lb.Width = 150;
					lb.Height = 70;
					lb.Location = new Point(70, 90);
					lb.Font = new Font(labelPageName.Font.Name, 14);
					panels[count].Controls.Add(lb);

					Label lb2 = new Label(); // Создаем надпись для автора книги
					lb2.Text = books[count].author;
					lb2.Width = 150;
					lb2.Height = 20;
				
					lb2.Location = new Point(70, 170);
					lb2.TextAlign = ContentAlignment.TopLeft;
					lb2.Font = new Font(labelPageName.Font.Name, 12);
					panels[count].Controls.Add(lb2);
					// Добавление кнопки
					Button bu = new Button();
					bu.Width = 150;
					bu.Height = 50;
					bu.Text = "Бронь";
					bu.FlatStyle = FlatStyle.Flat;
					bu.BackColor = Color.FromArgb(227, 60, 91);
					bu.Location = new Point(width / 4 - 10, 200);
					bu.FlatAppearance.BorderSize = 0;
					bu.Font = new Font(labelPageName.Font.Name, 14);
					bu.ForeColor = Color.White;
					string buid = books[count].bookId;
					bu.Click += (o,e) => BronBookClick(buid);
					
					panels[count].Controls.Add(bu);
					

					tabControl1.TabPages[0].Controls.Add(panels[count]);
					count += 1;
					tekX += width;

				}
				tekX = 0;
				tekY += height;
			}

		
		}
		
	}
}
