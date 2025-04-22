using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Client
    {
        // Властивості клієнта
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        // Конструктор для ініціалізації клієнта
        public Client(string name, string email, string phone, int age)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Age = age;
        }

        // Метод для оновлення контактної інформації
        public void UpdateContactInfo(string email, string phone)
        {
            Email = email;
            Phone = phone;
        }

        // Метод для відображення інформації про клієнта
        public void DisplayInfo()
        {
            Console.WriteLine($"Ім'я: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Телефон: {Phone}");
            Console.WriteLine($"Вік: {Age}");
        }
    }
}
