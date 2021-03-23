using System;

namespace Laba5
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time()
        {
        }

        public Time(int hour, int minute, int second)
        {
            while ((hour < 0 || minute < 0 || second < 0)
                   || (hour > 23 || minute > 59 || second > 59))
            {
                Console.WriteLine("Невірно заданий час! Введіть нові дані: ");
                Console.WriteLine("Година: ");
                hour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Хвилини: ");
                minute = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Секунди: ");
                second = Convert.ToInt32(Console.ReadLine());
            }

            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public int Hour
        {
            get => hour;
            set
            {
                while (value < 0 || value > 23)
                {
                    Console.WriteLine(
                        "Невірно задана година! Введіть інші дані:");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                hour = value;
            }
        }

        public int Minute
        {
            get => minute;
            set
            {
                while (value < 0 || value > 59)
                {
                    Console.WriteLine(
                        "Невірно задані хвилини! Введіть інші дані:");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                minute = value;
            }
        }

        public int Second
        {
            get => second;
            set
            {
                while (value < 0 || value > 59)
                {
                    Console.WriteLine(
                        "Невірно задані секунди! Введіть інші дані:");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                second = value;
            }
        }

        public void AddHours(int hours)
        {
            if (this.hour + hours >= 24)
            {
                for (int i = 0; i < hours; i++)
                {
                    this.hour += 1;
                    if (this.hour == 24) this.hour = 0;
                }
            }
            else
            {
                this.hour += hours;
            }
        }

        public void AddMinutes(int minutes)
        {
            if (minutes >= 60 || this.minute + minutes >= 60 )
            {
                int hours = Convert.ToInt32(Math.Floor((double) minutes / 60));
                minutes = minutes % 60;
                this.AddHours(hours);
                if (this.minute + minutes >= 60)
                {
                    for (int i = 0; i < minutes; i++)
                    {
                        this.minute += 1;
                        if (this.minute == 60)
                        {
                            this.AddHours(1);
                            this.minute = 0;
                        }
                    }
                }
                else
                {
                    this.minute += minutes;
                }
            }
            else if (this.minute + minutes < 60)
            {
                this.minute += minutes;
            }
        }

        public void AddSeconds(int seconds)
        {
            int secondsInDay = 86400;
            if (seconds >= secondsInDay)
            {
                int minutes = 
                    Convert.ToInt32(Math.Floor((double) seconds / 60));
                int hours = 
                    Convert.ToInt32(Math.Floor((double) minutes / 60));
                seconds = seconds % 60;
                this.AddHours(hours);
                this.AddMinutes(minutes);
                this.AddSeconds(seconds);
            } 
            else if (seconds >= 60)
            {
                int minutes = 
                    Convert.ToInt32(Math.Floor((double) seconds / 60));
                seconds = seconds % 60;
                this.AddMinutes(minutes);
                this.AddSeconds(seconds);
            }
            else if (this.second + seconds >= 60)
            {
                for (int i = 0; i < seconds; i++)
                {
                    this.second += 1;
                    if (this.second == 60)
                    {
                        this.AddMinutes(1);
                        this.second = 0;
                    }
                }
            }
            else
            {
                this.second += seconds;
            }
        }


        public override string ToString()
        {
            string time = "";
            time += hour < 10 ? "0" + hour + ":" : hour + ":";
            time += minute < 10 ? "0" + minute + ":" : minute + ":";
            time += second < 10 ? "0" + second : second;
            return time;
        }
    }
}