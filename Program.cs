using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Консольна програма для роботи з клієнтами кінотеатру ===");

            // Введення даних клієнта
            Console.Write("Введіть ім'я клієнта: ");
            string name = Console.ReadLine();

            Console.Write("Введіть email клієнта: ");
            string email = Console.ReadLine();

            Console.Write("Введіть телефон клієнта: ");
            string phone = Console.ReadLine();

            Console.Write("Введіть вік клієнта: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Помилка! Введіть коректний вік (число).");
            }

            // Створення об'єкта клієнта
            Client client = new Client(name, email, phone, age);

            // Меню для взаємодії
            while (true)
            {
                Console.WriteLine("\n=== Головне меню ===");
                Console.WriteLine("1. Вивести інформацію про клієнта");
                Console.WriteLine("2. Оновити контактну інформацію");
                Console.WriteLine("3. Вийти");
                Console.Write("Оберіть опцію: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        client.DisplayInfo();
                        break;

                    case "2":
                        Console.Write("Введіть новий email: ");
                        string newEmail = Console.ReadLine();

                        Console.Write("Введіть новий телефон: ");
                        string newPhone = Console.ReadLine();

                        client.UpdateContactInfo(newEmail, newPhone);
                        Console.WriteLine("Контактна інформація успішно оновлена!");
                        break;

                    case "3":
                        Console.WriteLine("Дякуємо за використання програми! До побачення!");
                        return;

                    default:
                        Console.WriteLine("Помилка! Оберіть коректну опцію.");
                        break;
                }
            }
        }
    }
}

