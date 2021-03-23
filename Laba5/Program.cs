using System;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            // One();
            // Two();
            Three();
        }
        

        static void One()
        {
            Console.WriteLine("Введіть координату х: ");
            int coordinateX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть координату у: ");
            int coordinateY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть колір точки: ");
            string color = Convert.ToString(Console.ReadLine());

            Point point = new Point(coordinateX, coordinateY,color);
            Console.WriteLine(point.ToString());

            Console.WriteLine("Дистанція від точки до початку координат: " 
                              + point.FindDistance());
            
            Console.WriteLine("Введіть координату х другого вектору: ");
            int vectorX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть координату у другого вектору: ");
            int vectorY = Convert.ToInt32(Console.ReadLine());
            point.AddVector(vectorX,vectorY);
            Console.WriteLine(point.ToString());
        }

        static void Two()
        {
            Console.WriteLine("Година: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Хвилини: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Секунди: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Time time = new Time(hour, minute, second);
            Console.WriteLine(time.ToString());

            Console.WriteLine("Змінити годину на: ");
            int newHour = Convert.ToInt32(Console.ReadLine());
            time.Hour = newHour;
            Console.WriteLine(time.ToString());
            
            Console.WriteLine("Змінити хвилини на: ");
            int newMinute = Convert.ToInt32(Console.ReadLine());
            time.Minute = newMinute;
            Console.WriteLine(time.ToString());
            
            Console.WriteLine("Змінити секунди на: ");
            int newSecond = Convert.ToInt32(Console.ReadLine());
            time.Second = newSecond;
            Console.WriteLine(time.ToString());
            
            Console.WriteLine("Скільки годин додати? ");
            int addHours = Convert.ToInt32(Console.ReadLine());
            time.AddHours(addHours);
            Console.WriteLine(time.ToString()); 
            
            Console.WriteLine("Скільки хвилин додати? ");
            int addMinutes = Convert.ToInt32(Console.ReadLine());
            time.AddMinutes(addMinutes);
            Console.WriteLine(time.ToString());
            
            Console.WriteLine("Скільки секунд додати? ");
            int addSeconds = Convert.ToInt32(Console.ReadLine());
            time.AddSeconds(addSeconds);
            Console.WriteLine(time.ToString());
        }

        static void Three()
        {
            Console.WriteLine("Створіть комп'ютер ");
            Console.WriteLine("Ширина екрану: ");
            double screenWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("RAM: ");
            int ramSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ROM: ");
            int romSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("used ROM: ");
            int romUsedSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Оперативна система: ");
            string operatingSystem = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Щоб створити пароль введіть 1" +
                              "\nЩоб не створювати пароль введіть будь-яку іншу цифру");
            int hasPasswordCommand = Convert.ToInt32(Console.ReadLine());
            bool hasPassword = false;
            string password = "";
            if (hasPasswordCommand == 1)
            {
                Console.WriteLine("Введіть пароль: ");
                password = Convert.ToString(Console.ReadLine());
                hasPassword = true;
            }

            Computer computer = new Computer(screenWidth, ramSize, romSize,
                romUsedSize, operatingSystem, hasPassword, password);
            
            ThreeRunCommands(computer);
        }

        static void ThreeRunCommands(Computer computer)
        {
            Console.WriteLine("-------------------------------------" +
                              "\nКоманди: " +
                              "\n0 - Вивести інформацію про комютер" +
                              "\n1 - Включити комютер" +
                              "\n2 - Виключити компютер" +
                              "\n3 - Запустити програму" +
                              "\n4 - Зупинити програму" +
                              "\n5 - Скачати файл" +
                              "\n6 - Видалити файл" +
                              "\n-------------------------------------");
            Console.WriteLine("Введіть команду: ");
            int command = Convert.ToInt32(Console.ReadLine());
            if (command == 0)
            {
                Console.WriteLine(computer.ToString());
                ThreeRunCommands(computer);
            } 
            else if (command == 1)
            {
                computer.TurnOn();
                ThreeRunCommands(computer);
            }
            else if (command == 2)
            {
                computer.TurnOff();
                ThreeRunCommands(computer);
            }
            else if (command == 3)
            {
                computer.runProgram();
                ThreeRunCommands(computer);
            }
            else if (command == 4)
            {
                computer.stopProgram();
                ThreeRunCommands(computer);
            }
            else if (command == 5)
            {
                Console.WriteLine("Введіть розмір файлу: ");
                int size = Convert.ToInt32(Console.ReadLine());
                computer.downloadFile(size);
                ThreeRunCommands(computer);

            }
            else if (command == 6)
            {
                Console.WriteLine("Введіть розмір файлу: ");
                int size = Convert.ToInt32(Console.ReadLine());
                computer.deleteFile(size);
                ThreeRunCommands(computer);

            }
            else
            {
                Console.WriteLine("Невірна команда.");
                ThreeRunCommands(computer);
            }
        }
    }
}