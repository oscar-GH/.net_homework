using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyClock myClock = new MyClock();
            myClock.alarmClock.Run();
        }


        public delegate void Handler(object sender, DateTime dataTime);

        public class AlarmClock
        {
            public event Handler Tick;
            public event Handler Alarm;
            private DateTime alarmTime;
            public DateTime AlarmTime
            {
                get => alarmTime;
                set => alarmTime = value;
            }
            public void Run()
            {
                Console.WriteLine("开始运行！");
                while (true)
                {
                    Tick(this, DateTime.Now);
                    if (DateTime.Now.ToString() == AlarmTime.ToString())
                    {
                        Alarm(this, DateTime.Now);
                    }
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        public class MyClock
        {
            public AlarmClock alarmClock;
            public MyClock()
            {
                alarmClock = new AlarmClock();
                alarmClock.AlarmTime = new DateTime(2020, 9, 20, 16, 38, 0);
                alarmClock.Tick += Alarm_tick;
                alarmClock.Alarm += Alarm_alarm;
            }
            void Alarm_tick(object sender, DateTime dateTime)
            {
                Console.WriteLine($"滴答......滴答......  现在时间：{dateTime.ToString()}");
            }
            void Alarm_alarm(object sender, DateTime dateTime)
            {
                Console.WriteLine($"叮铃铃......叮铃铃......  现在时间：{dateTime.ToString()}");
            }
        }
    }


}

