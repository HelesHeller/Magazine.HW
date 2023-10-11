using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.HW
{
    class Magazine
    {
        private string magazineName;
        private int foundingYear;
        private string description;
        private string contactPhone;
        private string email;
        private int numberOfEmployees;

        // Властивість для доступу до кількості працівників
        public int NumberOfEmployees
        {
            get { return numberOfEmployees; }
            set { numberOfEmployees = value; }
        }

        // Метод для введення даних про журнал
        public void InputData()
        {
            Console.WriteLine("Введіть назву журналу:");
            magazineName = Console.ReadLine();

            Console.WriteLine("Введіть рік заснування журналу:");
            foundingYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть опис журналу:");
            description = Console.ReadLine();

            Console.WriteLine("Введіть контактний телефон:");
            contactPhone = Console.ReadLine();

            Console.WriteLine("Введіть email:");
            email = Console.ReadLine();

            Console.WriteLine("Введіть кількість працівників:");
            numberOfEmployees = Convert.ToInt32(Console.ReadLine());
        }

        // Метод для виведення даних про журнал
        public void DisplayData()
        {
            Console.WriteLine($"Назва журналу: {magazineName}");
            Console.WriteLine($"Рік заснування: {foundingYear}");
            Console.WriteLine($"Опис журналу: {description}");
            Console.WriteLine($"Контактний телефон: {contactPhone}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Кількість працівників: {numberOfEmployees}");
        }

        // Перевантажений оператор "+" для збільшення кількості працівників на задану кількість
        public static Magazine operator +(Magazine magazine, int numberOfEmployeesToAdd)
        {
            magazine.numberOfEmployees += numberOfEmployeesToAdd;
            return magazine;
        }

        // Перевантажений оператор "-" для зменшення кількості працівників на задану кількість
        public static Magazine operator -(Magazine magazine, int numberOfEmployeesToRemove)
        {
            magazine.numberOfEmployees -= numberOfEmployeesToRemove;
            return magazine;
        }

        // Перевантажений оператор "==" для перевірки на рівність кількості працівників
        public static bool operator ==(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.numberOfEmployees == magazine2.numberOfEmployees;
        }

        // Перевантажений оператор "!=" для перевірки на нерівність кількості працівників
        public static bool operator !=(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.numberOfEmployees != magazine2.numberOfEmployees;
        }

        // Перевантажений оператор "<" для перевірки на меншу кількість працівників
        public static bool operator <(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.numberOfEmployees < magazine2.numberOfEmployees;
        }

        // Перевантажений оператор ">" для перевірки на більшу кількість працівників
        public static bool operator >(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.numberOfEmployees > magazine2.numberOfEmployees;
        }

        // Перевантажений метод Equals для порівняння об'єктів Magazine за кількістю працівників
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Magazine otherMagazine = (Magazine)obj;
            return numberOfEmployees == otherMagazine.numberOfEmployees;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Приклад використання класу "Журнал"
            Magazine magazine1 = new Magazine();
            magazine1.InputData();

            Magazine magazine2 = new Magazine();
            magazine2.InputData();

            magazine1.DisplayData();
            magazine2.DisplayData();

            // Приклад використання перевантажених операторів
            magazine1 = magazine1 + 10; // Збільшення кількості працівників на 10
            magazine1 = magazine1 - 5;  // Зменшення кількості працівників на 5

            Console.WriteLine($"Чи рівна кількість працівників у двох журналах? {magazine1 == magazine2}");

            Console.WriteLine($"Чи нерівна кількість працівників у двох журналах? {magazine1 != magazine2}");

            Console.WriteLine($"Перший журнал має більше працівників за другий? {magazine1 > magazine2}");

            Console.WriteLine($"Другий журнал має менше працівників за перший? {magazine2 < magazine1}");

            Console.WriteLine($"Об'єкти журналів рівні за кількістю працівників? {magazine1.Equals(magazine2)}");
        }
    }
}
