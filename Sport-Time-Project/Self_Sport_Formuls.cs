using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Time_Project
{
    static partial class Sport_Formuls
    {
        // Набор для самостоятельного создания тренировочного календаря.Packed for self creation calendar for training.

        /// <summary>
        /// Самостоятельная формула для занятия на турнике.Self Formula for practice Pull-up.
        /// </summary>
        /// <param name="pull_up"></param>
        /// <param name="increase"></param>
        /// <param name="limit"></param>
        public static void SelfCalculation_Pull_Up(int pull_up, int increase, int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} Day - Relax");
                }
                else
                {
                    Console.WriteLine($"{i} Day - Pull_Up = {pull_up}");
                    pull_up += increase;
                }
            }
        }

        /// <summary>
        /// Самостоятельная формула для занятия на брусьях.Self Formula for practice Push-Up.
        /// </summary>
        /// <param name="push_up"></param>
        /// <param name="increase"></param>
        /// <param name="limit"></param>
        public static void SelfCalculation_Push_Up(int push_up, int increase, int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} Day - Relax");
                }
                else
                {
                    Console.WriteLine($"{i} Day - Push_Up = {push_up}");
                    push_up += increase;
                }
            }
        }

        /// <summary>
        /// Самостоятельная формула для занятия на турнике и брусьях.Self-Formula for practice Pull-ups and Push-ups.
        /// </summary>
        /// <param name="pull_up"></param>
        /// <param name="push_up"></param>
        /// <param name="increase"></param>
        /// <param name="limit"></param>
        public static void SelfCalculation_All_Together(int pull_up, int push_up, int increase_pull_up, int increase_push_up, int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} Day - Relax");
                }
                else
                {
                    Console.WriteLine($"{i} Day - Pull-up = {pull_up} and Push-up = {push_up}");
                    pull_up += increase_pull_up;
                    push_up += increase_push_up;
                }
            }
        }

    }
}
