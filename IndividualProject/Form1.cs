using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualProject
{
	
	public partial class LoginFm : Form
	{
		
		public LoginFm()
		{
			InitializeComponent();
			// Проверка есть ли интернет соединение
			if (!CheckInternet())
			{
				OfflineForm oForm = new OfflineForm();
				oForm.Show();
			}
			else
			{
				User.loadUserPCInformation();
				// Назначение обработчиков событий на кнопки
				buLogin.Click += BuLogin_Click;
				buReg.Click += BuReg_Click;
				//buClose.Click += BuClose_Click;
			}

		}

		private void BuClose_Click(object sender, EventArgs e)
		{
			// Закрытие формы
			this.Close();
		}
		// Функция на кнопку "Регистрация"
		private void BuReg_Click(object sender, EventArgs e)
		{
			RegFm regForm = new RegFm();
			regForm.Show();
			regForm.frm = this;
			regForm._result = labelResult;
		}

		private bool CheckInternet()
		{
			IPStatus status = IPStatus.Unknown;
			try
			{
				status = new Ping().Send("yandex.ru").Status;
			}
			catch { }

			if (status == IPStatus.Success)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		// Функция на кнопку "Войти"
		private void BuLogin_Click(object sender, EventArgs e)
		{
			String userLogin = textBoxLogin.Text; // Логин 
			String userPass = textBoxPass.Text;   // Пароль
			DBManager serverDB = new DBManager(); // Создание подключения
			string result = serverDB.LoginUser(userLogin, userPass); // Обращение к методу класса DBManager для выполнения авторизации. 
			if (result != "None" && result != "not activated" && result != "blocked")
			{
				// Получение данных о пользователе и добавление их в статический класс User
				string[] splitData = result.Split(';'); // Делим полученную строку по разделителю
				User.login = splitData[0];
				User.first_name = splitData[1];
				User.last_name = splitData[2];
				User.age = splitData[3];
				User.userId = splitData[4];
				labelResult.Text = ".";
				if (splitData[5] == "libriary")
				{
					// Если тип пользователя это библиотекарь, то открываем форму библиотекаря
					LibrarianForm lbForm = new LibrarianForm();
					lbForm.Show();
				}
				else if(splitData[5] == "user")
				{
					// Если тип пользователя это пользователь, то открываем форму пользователя
					userForm uForm = new userForm();
					uForm.Show();
				}
				else if(splitData[5] == "admin")
				{
					// Если тип пользователя это админ, то открываем форму тех.поддержки
					AdminForm aForm = new AdminForm();
					aForm.Show();
				}

			}
			else if (result == "not activated")
			{
				labelResult.Text = "Учетная запись заблокирована или неактивирована";
			}
			else if (result == "blocked")
			{
				labelResult.Text = "Учетная запись заблокирована или неактивирована";
			}
			else
			{
				labelResult.Text = "Неверные данные";
			}

		}
		
	}
}
