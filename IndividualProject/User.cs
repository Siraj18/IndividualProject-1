using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
	public static class User
	{
		public static string login;                    // Логин
		public static string first_name;               // Имя
		public static string last_name;				   // Фамилия
		public static string age;					   // Возраст
		public static string userId;				   // Id пользователя в базе
		public static string ramCapacity = "unknown";  // оперативная память пользователя
		public static string cpuName = "unknown";      // процессор пользователя

		// Функция для получения информации о PC пользователя
		public static void loadUserPCInformation()
		{
			// Получение инфы о процессоре и запись в переменную
			ManagementObjectSearcher searcher8 =
			new ManagementObjectSearcher("root\\CIMV2",
			"SELECT * FROM Win32_Processor");

			foreach (ManagementObject queryObj in searcher8.Get())
			{
				User.cpuName = queryObj["Name"].ToString();
			}

			// Получение информации о оперативной памяти и запись в переменную
			ManagementObjectSearcher searcher12 =
			new ManagementObjectSearcher("root\\CIMV2",
			"SELECT * FROM Win32_PhysicalMemory");
			foreach (ManagementObject queryObj in searcher12.Get())
			{
				User.ramCapacity = Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024).ToString();
			}
			User.ramCapacity = "RAM:" + User.ramCapacity + " Gb";
		}
	}
}
