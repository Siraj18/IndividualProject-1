using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualProject
{
	public partial class RegFm : Form
	{
		private string _login = "";
		private bool flag = false;
		public Form frm;
		public Label _result;
		public RegFm()
		{
			InitializeComponent();

			// Назначение обработчиков событий на кнопки
			buReg.Click += BuReg_Click;
			//buClose.Click += BuClose_Click;
		}

		private void BuClose_Click(object sender, EventArgs e)
		{
			// закрытие формы
			this.Close();
		}

		private void BuReg_Click(object sender, EventArgs e)
		{
			// Проверка на пустоту
			string login = textBoxLogin.Text;
			string pass = textBoxPass.Text;
			string fName = textBoxfName.Text;
			string lName = textBoxlName.Text;
			string age = textBoxAge.Text;
			string email = textBoxEmail.Text;

			if (login == "" || pass == "" || fName == "" || lName == "" || age == "" || email == "")
			{
				labelResult.Text = "Введите все данные";
				return;
			}

			DBManager serverDb = new DBManager(); //  Создание подключения
			string result = serverDb.RegistrationUser(login, pass, fName, lName, age, "user", email);
			
			if (result == "BOOKED")
			{
				labelResult.Text = "Такой логин уже занят";
			}
			else
			{
				labelResult.Text = "Ожидается подтверждение учетной записи";
				serverDb.ActivateUser(login, fName, lName, email);
				_login = login;
				timer1.Start();
			}
			


	
		}

		private void buRandom_Click(object sender, EventArgs e)
		{
			string lWords = "abcdefghijklmnopqrstuvwxyz"; // строчные буквы
			string uWords = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // прописные
			string numbers = "0123456789"; // цифры
			string symbols = "@!№#%^,.;:)(?/]["; // символы

			Random rnd = new Random();
			int len = rnd.Next(9, 21);  // Длина пароля

			string[] pass = new string[len]; // Итоговый пароль
			// Генерация пароля
			for (int i = 0; i < len; i++)
			{
				int r = rnd.Next(0, lWords.Length);
				pass[i] = lWords[r].ToString();
	
			}


			// Генерация буквы в верхнем регистре
			len = rnd.Next(3, len / 2);
			for (int i = 0; i <= len; i++)
			{
				int r = rnd.Next(0, uWords.Length);
				int r2 = rnd.Next(0, pass.Length);
				pass[r2] = uWords[r].ToString();
			}
			// Генерация цифры
			len = rnd.Next(2, 3);
			for (int i = 0; i <= len; i++)
			{
				int r = rnd.Next(0, numbers.Length);
				int r2 = rnd.Next(0, pass.Length);
				pass[r2] = numbers[r].ToString();
			}
			// Генерация символов
			
				int r1 = rnd.Next(0, symbols.Length);
				int r3 = rnd.Next(0, pass.Length);
				pass[r3] = symbols[r1].ToString();

			// Итоговый пароль
			string result = "";
			for (int i = 0; i < pass.Length; i++)
			{
				result += pass[i];
			}
			textBoxPass.Text = result;
	
		}

		private void textBoxlName_TextChanged(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			DBManager _manager = new DBManager();
			string result = _manager.CheckUserActivate(_login);
			if (result == "Yes" && !flag)
			{
				flag = true;
				timer1.Stop();
				frm.BringToFront();
				_result.Text = "Учетная запись подтверждена";
				labelResult.Text = "Учетная запись подтверждена";
				MessageBox.Show("Учетная запись подтверждена");
			}
				
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			
		}
	}
}
