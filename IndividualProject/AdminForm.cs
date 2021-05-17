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
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();

			// Назначение событий на кнопки
			buAddChange.Click += (s, e) => tabControl1.SelectedTab = tabControl1.TabPages[0];
			buDeleteChange.Click += (s, e) => tabControl1.SelectedTab = tabControl1.TabPages[1];
			buReg.Click += BuReg_Click;
			buDelete.Click += BuDelete_Click;
		}

		private void BuDelete_Click(object sender, EventArgs e)
		{
			string login = textBoxDelete.Text;
			DBManager serverDb = new DBManager();
			string result = serverDb.DeleteUser(login);
			labelResult2.Text = result;
		}

		

		// Функция изменения данных работника
		private void BuChange_Click(object sender, EventArgs e)
		{
			
			
		}


		// Функция удаления работника из базы


		private void BuReg_Click(object sender, EventArgs e)
		{
			// Проверка на пустоту
			string login = textBoxLogin.Text;
			string pass = textBoxPass.Text;
			string fName = textBoxfName.Text;
			string lName = textBoxlName.Text;
			string age = textBoxAge.Text;

			if (login == "" || pass == "" || fName == "" || lName == "" || age == "")
			{
				labelResult.Text = "Введите все данные";
				return;
			}

			DBManager serverDb = new DBManager(); //  Создание подключения
			string result = serverDb.RegistrationUser(login, pass, fName, lName, age, "libriary", "s");
			labelResult.Text = result;
		}


	}
}
