using System;

namespace Homework_2
{
    class Program
    {
        /// <summary>
        /// Класс, представляющий человека.
        /// </summary>
        class Person
        {
            /// <summary>
            /// Создает экземпляр класса <see cref="Person"/>.
            /// </summary>
            /// <param name="name">Имя человека.</param>
            /// <param name="city">Город проживания.</param>
            /// <param name="age">Возраст.</param>
            /// <param name="pin">ПИН-код.</param>
            public Person(string name, string city, int age, int pin)
            {
                Name = name;
                City = city;
                Age = age;
                PIN = pin;
            }

            /// <summary>
            /// Имя человека.
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Город проживания.
            /// </summary>
            public string City { get; set; }

            /// <summary>
            /// Возраст человека.
            /// </summary>
            public int Age { get; set; }

            /// <summary>
            /// ПИН-код.
            /// </summary>
            public int PIN { get; set; }
        }

        /// <summary>
        /// Структура для представления студента.
        /// </summary>
        struct Student
        {
            /// <summary>
            /// Фамилия студента.
            /// </summary>
            public string LastName;

            /// <summary>
            /// Имя студента.
            /// </summary>
            public string FirstName;

            /// <summary>
            /// Идентификатор студента.
            /// </summary>
            public int Id;

            /// <summary>
            /// Дата рождения студента.
            /// </summary>
            public DateTime BirthDate;

            /// <summary>
            /// Категория потребления алкоголя.
            /// </summary>
            public char AlcoholCategory;

            /// <summary>
            /// Объем выпитой жидкости в миллилитрах.
            /// </summary>
            public int Volume;
            /// <summary>
            /// Название напитка.
            /// </summary>
            public string AlcoholName;
        }

        /// <summary>
        /// Структура для представления алкогольного напитка.
        /// </summary>
        struct Alcohol
        {
            /// <summary>
            /// Название напитка.
            /// </summary>
            public string Name;

            /// <summary>
            /// Процент содержания алкоголя.
            /// </summary>
            public int AlcoholPercentage;

            /// <summary>
            /// Создает экземпляр структуры <see cref="Alcohol"/>.
            /// </summary>
            /// <param name="name">Название напитка.</param>
            /// <param name="alcoholPercentage">Процент содержания алкоголя.</param>
            public Alcohol(string name, int alcoholPercentage)
            {
                Name = name;
                AlcoholPercentage = alcoholPercentage;
            }
        }
        static void Main()
        {
            Console.WriteLine("№1");
            /*1. Выведите на экран информацию о каждом типе данных в виде:
            Тип данных – максимальное значение – минимальное значение*/

            Console.WriteLine("sbyte – Max: {0} – Min: {1}", sbyte.MaxValue, sbyte.MinValue);
            Console.WriteLine("byte – Max: {0} – Min: {1}", byte.MaxValue, byte.MinValue);
            Console.WriteLine("short – Max: {0} – Min: {1}", short.MaxValue, short.MinValue);
            Console.WriteLine("ushort – Max: {0} – Min: {1}", ushort.MaxValue, ushort.MinValue);
            Console.WriteLine("int – Max: {0} – Min: {1}", int.MaxValue, int.MinValue);
            Console.WriteLine("uint – Max: {0} – Min: {1}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("long – Max: {0} – Min: {1}", long.MaxValue, long.MinValue);
            Console.WriteLine("ulong – Max: {0} – Min: {1}", ulong.MaxValue, ulong.MinValue);
            Console.WriteLine("float – Max: {0} – Min: {1}", float.MaxValue, float.MinValue);
            Console.WriteLine("double – Max: {0} – Min: {1}", double.MaxValue, double.MinValue);
            Console.WriteLine("decimal – Max: {0} – Min: {1}", decimal.MaxValue, decimal.MinValue);

            Console.WriteLine("№2");
            /*2. Напишите программу, в которой принимаются данные пользователя в виде имени,
            города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
            переменной, а затем распечатайте всю информацию в правильном формате.*/

            Console.Write("Введите имя: ");
            try
            {
                string name = Console.ReadLine();
                Console.Write("Введите город: ");
                string CityName = Console.ReadLine();
                Console.Write("Введите возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите PIN: ");
                int pin = Convert.ToInt32(Console.ReadLine());
                Person persona = new Person(name, CityName, age, pin);
                Console.WriteLine($"Persone: \n\tName: {persona.Name} \n\tAge: {persona.Age} \n\tPIN: {persona.PIN} \n\tSity Name: {persona.City}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы допустили ошибку при вводе данных");
            }

            Console.WriteLine("№3");
            /*3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
            строчные.*/

            Console.Write("Введите строку: ");
            string inputLine = Console.ReadLine();
            string result = "";
            foreach (char ch in inputLine)
            {
                if (char.IsLetter(ch) && char.IsLower(ch))
                {
                    result += char.ToUpper(ch);
                }
                else
                {
                    result += char.ToLower(ch);
                }
            }
            Console.WriteLine(result);

            Console.WriteLine("№4");
            /*4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
            на экран.*/
            Console.Write("Введите строку: ");
            string mainString = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string targetString = Console.ReadLine();

            int countString = mainString.Split(targetString).Length - 1;
            Console.WriteLine($"Количество вхождений строки '{targetString}': {countString}");


            Console.WriteLine("№5");
            /*5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
            нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
            покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
            скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка
            обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы
            сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов
            стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут
            целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.*/

            Console.Write("Введите стандартную цену бутылки виски: ");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите скидку в Duty Free: ");
            int salePrice = Convert.ToInt32(Console.ReadLine());
            if (salePrice <= 0 || salePrice > 100)
            {
                Console.WriteLine("Скидка должна быть от 1% до 100%");
            }
            else
            {
                Console.Write("Введите стоимость отпуска: ");
                int holidayPrice = Convert.ToInt32(Console.ReadLine());
                double dutyFreePrice = (double)((double)normPrice * (double)salePrice / 100);
                int whiskeyBottlesCount = (int)Math.Round(holidayPrice / dutyFreePrice);
                Console.WriteLine(whiskeyBottlesCount);
            }


            Console.WriteLine("№6");
            /*6. Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
            рождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель
            выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
            студента есть Объем выпитой жидкости конкретного напитка. Создать 5 студентов с
            различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
            (процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
            выпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде
            структуры: наименование типа напитка и процент спирта.*/


            Alcohol beer = new Alcohol("Пиво", 5);
            Alcohol wine = new Alcohol("Вино", 12);
            Alcohol vodka = new Alcohol("Водка", 40);

            Student[] students = new Student[5]
            {
                new Student { LastName = "Иванов", FirstName = "Иван", Id = 1, BirthDate = new DateTime(2000, 1, 1), AlcoholCategory = 'a', Volume = 1000, AlcoholName = "Пиво" },
                new Student { LastName = "Петров", FirstName = "Петр", Id = 2, BirthDate = new DateTime(1999, 5, 15), AlcoholCategory = 'b', Volume = 800, AlcoholName = "Вино" },
                new Student { LastName = "Алексеев", FirstName = "Алексей", Id = 3, BirthDate = new DateTime(2001, 12, 20), AlcoholCategory = 'c', Volume = 300, AlcoholName = "Пиво" },
                new Student { LastName = "Сергеев", FirstName = "Сергей", Id = 4, BirthDate = new DateTime(1998, 7, 10), AlcoholCategory = 'd', Volume = 0, AlcoholName = "Водка" },
                new Student { LastName = "Федоров", FirstName = "Федор", Id = 5, BirthDate = new DateTime(2002, 3, 5), AlcoholCategory = 'a', Volume = 1200, AlcoholName = "Водка" }
            };
            double totalVolume = 0;
            double totalAlcoholVolume = 0;

            foreach (var student in students)
            {
                int percentage = 0;
                if (student.AlcoholName == beer.Name) percentage = beer.AlcoholPercentage;
                else if (student.AlcoholName == wine.Name) percentage = wine.AlcoholPercentage;
                else if (student.AlcoholName == vodka.Name) percentage = vodka.AlcoholPercentage;

                double alcoholVolume = student.Volume * (percentage / 100.0);
                totalVolume += student.Volume;
                totalAlcoholVolume += alcoholVolume;
            }

            Console.WriteLine($"Общий объем выпитой жидкости: {totalVolume} мл");
            Console.WriteLine($"Общий объем алкоголя: {totalAlcoholVolume} мл");

            foreach (var student in students)
            {
                int percentage = 0;
                if (student.AlcoholName == beer.Name) percentage = beer.AlcoholPercentage;
                else if (student.AlcoholName == wine.Name) percentage = wine.AlcoholPercentage;
                else if (student.AlcoholName == vodka.Name) percentage = vodka.AlcoholPercentage;

                double alcoholVolume = student.Volume * (percentage / 100.0);
                double liquidPercentage = (student.Volume / totalVolume) * 100;
                double alcoholPercentage = (alcoholVolume / totalAlcoholVolume) * 100;

                Console.WriteLine($"Студент {student.LastName} {student.FirstName}: {liquidPercentage:F2}% жидкости, {alcoholPercentage:F2}% алкоголя");
            }
        }
    }
}