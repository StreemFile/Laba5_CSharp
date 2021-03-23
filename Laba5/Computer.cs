using System;

namespace Laba5
{
    public class Computer
    {
        private double screenWidth;
        private int ramSize;
        private int runningProgramsNumber;
        private int romSize;
        private int romUsedSize;
        private string operatingSystem;
        private bool isTurnedOn;
        private bool hasPassword;
        private string password;

        public Computer()
        {
        }

        public Computer(double screenWidth, int ramSize, int romSize,
            int romUsedSize, string operatingSystem, bool hasPassword, string password)
        {
            this.screenWidth = screenWidth;
            this.ramSize = ramSize;
            this.romSize = romSize;
            this.romUsedSize = romUsedSize;
            this.runningProgramsNumber = 0;
            this.operatingSystem = operatingSystem;
            this.isTurnedOn = false;
            this.hasPassword = hasPassword;
            this.password = password;
        }
        
        

        public double ScreenWidth
        {
            get => screenWidth;
            set => screenWidth = value;
        }

        public int RamSize
        {
            get => ramSize;
            set => ramSize = value;
        }

        public int RomSize
        {
            get => romSize;
            set => romSize = value;
        }

        public int RunningProgramsNumber
        {
            get => runningProgramsNumber;
            set => runningProgramsNumber = value;
        }

        public string OperatingSystem
        {
            get => operatingSystem;
            set => operatingSystem = value;
        }

        public bool IsTurnedOn
        {
            get => isTurnedOn;
            set => isTurnedOn = value;
        }

        public bool HasPassword
        {
            get => hasPassword;
            set => hasPassword = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public void TurnOn()
        {
            if (this.isTurnedOn)
            {
                Console.WriteLine("Ком'ютер вже включений");
            }
            else
            {
                if (this.hasPassword)
                {
                    Console.WriteLine("Введіть пароль: ");
                    string password = Convert.ToString(Console.ReadLine());
                    if (this.password == password)
                    {
                        Console.WriteLine("Ком'ютер включено");
                        this.isTurnedOn = true;
                    }
                    else
                    {
                        Console.WriteLine("Невірний пароль!");
                    }
                }
            }
        }

        public void TurnOff()
        {
            Console.WriteLine("Комп'ютер виключено");
            this.runningProgramsNumber = 0;
            this.isTurnedOn = false;
        }

        public void runProgram()
        {
            if (this.ramSize <= 4)
            {
                if (this.runningProgramsNumber + 1 >= 5)
                {
                    this.runningProgramsNumber++;
                    Console.WriteLine("Some program is runned. " +
                                      "\nToo much programs are runned, " +
                                      "computer is lagging");
                }
                else
                {
                    this.runningProgramsNumber++;
                    Console.WriteLine("Some program is runned");
                }
            } 
            else if (this.ramSize > 4 && this.ramSize <=8)
            {
                if (this.runningProgramsNumber + 1 >= 10)
                {
                    this.runningProgramsNumber++;
                    Console.WriteLine("Some program is runned. " +
                                      "\nToo much programs are runned, " +
                                      "computer is lagging");
                }
                else
                {
                    this.runningProgramsNumber++;
                    Console.WriteLine("Some program is runned");
                }
            }
            else
            {
                this.runningProgramsNumber++;
                Console.WriteLine("Some program is runned");
            }
        }

        public void stopProgram()
        {
            this.runningProgramsNumber--;
            Console.WriteLine("Some program is stopped");
        }

        public void downloadFile(int fileSize)
        {
            if (this.romUsedSize + fileSize <= this.romSize)
            {
                this.romUsedSize += fileSize;
                Console.WriteLine("Some file is downloaded");
            }
            else
            {
                Console.WriteLine("Not enough memory");
            }
        }

        public void deleteFile(int fileSize)
        {
            if (fileSize > this.romUsedSize)
            {
                Console.WriteLine("File is not found");
            }
            else
            {
                this.romUsedSize -= fileSize;
                Console.WriteLine("File is deleted");
            }
        }

        public override string ToString()
        {
            return "\nscreenWidth:" + this.screenWidth
                   + "\nramSize: " + this.ramSize
                   + "\nromSize: " + this.romSize
                   + "\nromUsedSize: " + this.romUsedSize
                   + "\noperatingSystem: " + this.operatingSystem
                   + "\nhasPassword: " + this.hasPassword
                   + "\npassword: " + this.password
                   + "\nisTurnedOn: " + this.isTurnedOn
                   + "\nrunningProgramsNumber: " + this.runningProgramsNumber;
        }
    }
}