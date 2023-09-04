using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

// Программа,которая поможет создать личный тренировочный календарь в зависимости от опыта пользователя.

namespace Sport_Time_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var beginner = new Beginner();

            beginner.Welcome_Athlete();
            beginner.Who_Are_You();
            beginner.Choose_Exersice();
            beginner.Setting_Calendar();
            beginner.Creation_Calendar();
            beginner.Completion();
            Console.ReadLine();
            Console.Clear();


            //var expirenced = new Expirenced();

            //expirenced.Welcome_Athlete();
            //expirenced.Who_Are_You();
            //expirenced.Choose_Exersice();
            //expirenced.Setting_Calendar();
            //expirenced.Creation_Calendar();
            //expirenced.Completion();

            //Console.ReadLine();


        }
    }
}