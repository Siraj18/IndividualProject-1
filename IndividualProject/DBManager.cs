using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualProject
{
	// Класс для работы с базой данных
	class DBManager
	{

       

        // Функция для отправки Post запроса на сервер
        private string POST(string Url, string Data)
        {
            // Url для post запроса
            System.Net.WebRequest req = System.Net.WebRequest.Create(Url);
            req.Method = "POST";
            req.Timeout = 100000;
            req.ContentType = "application/x-www-form-urlencoded"; 
            byte[] sentData = Encoding.UTF8.GetBytes(Data);
            req.ContentLength = sentData.Length;
            System.IO.Stream sendStream = req.GetRequestStream();
            sendStream.Write(sentData, 0, sentData.Length);
            sendStream.Close();
            System.Net.WebResponse res = req.GetResponse(); // Выполнение запроса и получение ответа
            System.IO.Stream ReceiveStream = res.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(ReceiveStream, Encoding.UTF8);
            //Кодировка указывается в зависимости от кодировки ответа сервера
            Char[] read = new Char[256];
            int count = sr.Read(read, 0, 256);
            string Out = String.Empty;
            while (count > 0)
            {
                String str = new String(read, 0, count);
                Out += str;
                count = sr.Read(read, 0, 256);
            }
            return Out; // Возвращение ответа
        }

        public string LoginUser(string login, string pass)
        {
            string data = "Login=" + login + "&Pass=" + pass; // Post данные для запроса
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/login.php", data); // Выполнение запроса
            return result;
        }
        public string RegistrationUser(string login, string pass, string fName, string lName, string age, string userType, string email)
        {
            string data = "Login=" + login + "&Pass=" + pass + "&FirstName=" + fName + "&LastName=" + lName + "&Age=" + age + "&UserType=" + userType + "&Email=" + email; // Post данные для запроса
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/registr.php", data); // Выполнение запроса
            return result;
        }
        // Функция для загрузки каталога книг из базы
        public string LoadBooks()
        {
            string data = "test=Test";
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/loadbook.php", data);
            return result;
        }
        // Функция для загрузки каталога книг из базы
        public string LoadBooksInform()
        {
            string data = "test=Test";
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/loadbookinform.php", data);
            return result;
        }
        // Функция для бронирования книги

        public string BronBook(string bookId, string bookingNumber, string userID, string FIO)
        {
            
            string data = "BookID=" + bookId + "&BookingNumber=" + bookingNumber + "&UserID=" + userID + "&FIO=" + FIO;
            
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/booking.php", data);
            return result;
        }
        // Функция для загрузки забронированных книг для пользователя
        public string LoadBookings(string userId)
        {
            string data = "UserID=" + userId;

            string result = POST("http://iptest.std-975.ist.mospolytech.ru/loadbooking.php", data);
            return result;
        }
        // Функция для получения информации о пользователе по номеру бронирования
        public string GiveBooksInformation(string bookId)
        {
            string data = "BookingNumber=" + bookId;
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/givebook.php", data);
            return result;
        }
        // Функция для выдачи книги пользователю
        public string GiveBooksUser(string bookId)
        {
            string data = "BookingNumber=" + bookId;
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/givebookuser.php", data);
            return result;
        }
        // Функция для добавления книг в базу
        public string AddBook(string name, string author, string publisher, string count, string genre, string ageLimit)
        {
            string data = "Name=" + name + "&Author=" + author + "&Publisher=" + publisher + "&Count=" + count + "&Genre=" + genre + "&AgeLimit=" + ageLimit;
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/bookadd.php", data);
            return result;
        }
        public string LoadGiveBooks(string userID)
        {
            string data = "UserID=" + userID;
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/loadorders.php", data);
            return result;
        }
        // Функция для подтверждения возврата книги
        public string ConfirmBook(string bookId)
        {
            string data = "BookingNumber=" + bookId;
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/confirm.php", data);
            return result;
        }
        //
        public string DeleteUser(string login)
        {
            string data = "Login=" + login;
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/userdelete.php", data);
            return result;
        }
        public string ActivateUser(string login, string fName, string lName, string email)
        {
            string data = "Login=" + login + "&Name=" + (fName + " " +  lName) + "&Email=" + email; // Post данные для запроса
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/activateUser.php", data); // Выполнение запроса
            return result;
        }
        public string CheckUserActivate(string login)
        {
            string data = "Login=" + login; // Post данные для запроса
            string result = POST("http://iptest.std-975.ist.mospolytech.ru/checkUserActivate.php", data); // Выполнение запроса
            return result;
        }

    }
}


