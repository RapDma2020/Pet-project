using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Time_Project
{
        static partial class Sport_Formuls
        {
            private static int start_limit = 90;
            private static int increase_pull_up = 2;
            private static int increase_push_up = 3;

            /// <summary>
            /// Формула для занятия на турнике.Formula for practice Pull-Up.
            /// </summary>
            /// <param name="start_pull_up"></param>
            public static void Calculation_Pull_Up(int pull_up)
            {
                for (int i = 1; i <= start_limit; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i} Day - Relax");
                    }
                    else
                    {
                        Console.WriteLine($"{i} Day - Pull_Up = {pull_up}");
                        pull_up += increase_pull_up;
                    }
                }
            }

            /// <summary>
            /// Формула для занятия на брусьях.Formula for practice Push-Up.
            /// </summary>
            /// <param name="push_up"></param>
            public static void Calculation_Push_Up(int push_up)
            {
                for (int i = 1; i <= start_limit; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i} Day - Relax");
                    }
                    else
                    {
                        Console.WriteLine($"{i} Day - Push-up = {push_up}");
                        push_up += increase_push_up;
                    }
                }


            }

            /// <summary>
            /// Формула для занятия на турниках и брусьях.Formula for practice Pull-Up and Push-Up.
            /// </summary>
            public static void Calculation_All_Together(int pull_up, int push_up)
            {
                for (int i = 1; i <= start_limit; i++)
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
