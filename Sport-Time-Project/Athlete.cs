using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Time_Project
{
    class Beginner
    {

        private int start_quantity1_beginner; // Эти переменные созданы для того,чтобы задать начальное количество раз
        private int start_quantity2_beginner;// с какого начинающий пользователь сам захочет начать свои первые тренировки.

        private byte check_experience; // Эта переменная помогает проверить опыт пользователя с помощью переменной switch.

        protected byte selects_number; // Эта переменная помогает сделать валидацию упражнений для пользователя.

        private byte rate; // Эта переменная создана для того чтобы оценить оценку пользователя.


        public void Welcome_Athlete()
        {
            Console.WriteLine("Hello :)");
            Console.WriteLine();
            Console.WriteLine("We are glad to see you of our 'Sport Time project'!");
            Console.WriteLine();
            Console.WriteLine("Here,we can help you to do your Training Calendar for 3 months!");
            Console.WriteLine("Or,if you already have experiance,you could self to do your Training Calendar!");
            Console.ReadLine();

        }

        public void Who_Are_You()
        {
            Console.WriteLine("Select,who are you(Beginner or Experienced)? ");
            Console.WriteLine("If beginner,select '0'  If experienced,select '1'.");
            Console.WriteLine();

            check_experience = byte.Parse(Console.ReadLine());

            switch (check_experience)
            {
                case 0:
                    Console.WriteLine();
                    Console.WriteLine("Good,we can help you to do your calendar!");
                    Console.ReadLine();
                    break;
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Good,you can self to do you calendar!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Sorry,but we can`t nothing do with it (:");
                    Console.ReadLine();
                    Welcome_Athlete();
                    break;
            }
        }

        public void Choose_Exersice()
        {
            Console.WriteLine("But firstly,you should to choose the exersise,which you want to do. ");
            Console.ReadLine();
            Console.WriteLine("So far,we have only two exersises:");
            Console.WriteLine("There are pull-ups and push-ups\n");
            Console.WriteLine("If you want to choose the pull up,so press the number 1.");
            Console.WriteLine("If you want to choose the push up,so press the number 2.");
            Console.WriteLine("If you want all together,so press the number 3.");
            Console.WriteLine();

            Console.Write("Choice: ");
            selects_number = byte.Parse(Console.ReadLine());
            switch (selects_number)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("OK.You chose the pull-up and we are starting!");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("OK.You chose the push-up and we are starting!");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Good.You chose all together and we are starting!");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Sorry.Maybe this command be available in the future (:");
                    Console.ReadLine();
                    Console.Clear();
                    Welcome_Athlete();
                    break;
            }
            Console.WriteLine();
        }

        public virtual void Setting_Calendar()
        {
            if (selects_number == 1 || selects_number == 2)
            {
                Console.Write("Select initial quantity of times,which with you want to start your first training: ");

                start_quantity1_beginner = int.Parse(Console.ReadLine());
            }

            if (selects_number == 3)
            {
                Console.Write("Select initial quantity of times,which with you want to start your first training - Pull-Up: ");
                start_quantity1_beginner = int.Parse(Console.ReadLine());

                Console.Write("And - Push-up: ");
                start_quantity2_beginner = int.Parse(Console.ReadLine());
            }
        }

        public virtual void Creation_Calendar()
        {
            if (selects_number == 1)
            {
                Console.WriteLine();
                Sport_Formuls.Calculation_Pull_Up(start_quantity1_beginner);
            }

            if (selects_number == 2)
            {
                Console.WriteLine();
                Sport_Formuls.Calculation_Push_Up(start_quantity1_beginner);
            }

            if (selects_number == 3)
            {
                Console.WriteLine();
                Sport_Formuls.Calculation_All_Together(start_quantity1_beginner, start_quantity2_beginner);
            }
        }

        public void Completion()
        {
            Console.WriteLine();
            Console.WriteLine("So,it's your personal training list!");
            Console.WriteLine();
            Console.WriteLine("We hope,that we have can helped you.");
            Console.WriteLine("If that so,please rate our app from 0 to 5");
            Console.WriteLine();
            Console.Write("Choice:");
            rate = byte.Parse(Console.ReadLine());

            switch (rate)
            {
                case 0:
                    Console.WriteLine();
                    Console.WriteLine("Thank you for your appreciation.We hope that next time you will like our app!");
                    break;
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Thank you for your appreciation.We hope that next time you will like our app!");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Thank you for your appreciation.We hope that next time you will like our app!");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Thank you for your appreciation.We hope that next time you will like our app!");
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Thank you for your appreciation.We are glad,that you have liked our app!");
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Thank you for your appreciation.We are excited,that you have liked our app!");
                    break;
                default:
                    Console.WriteLine("Ok");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Visit us again!!!");
        }

    }
    class Expirenced : Beginner
    {
        private int start_quantity1_experience;// Эти переменные созданы для того,чтобы задать параметры первой тренирововки,                                        // 
        private int start_quantity2_experience;// увелечение количества раз в подходе и период на который делается этот каледарь.
        private int increase_approach1;
        private int increase_approach2;
        private int period_in_days;

        public override void Setting_Calendar()
        {
            if (selects_number == 1 || selects_number == 2)
            {
                Console.Write("Select initial quantity of times,which with you want to start your first training: ");

                start_quantity1_experience = int.Parse(Console.ReadLine());

                Console.Write("How many times,do you want countinuously icrease your progression of approaches: ");

                increase_approach1 = int.Parse(Console.ReadLine());

                Console.Write("For what perion,do you want to make your calendar(select in days): ");

                period_in_days = int.Parse(Console.ReadLine());
            }

            if (selects_number == 3)
            {
                Console.Write("Select initial quantity of times,which with you want to start your first training - Pull-Up: ");
                start_quantity1_experience = int.Parse(Console.ReadLine());

                Console.Write("And - Push-up: ");
                start_quantity2_experience = int.Parse(Console.ReadLine());

                Console.Write("How many times,do you want countinuously icrease your progression of approaches,Pull Up: ");

                increase_approach1 = int.Parse(Console.ReadLine());

                Console.Write("And Push Up: ");

                increase_approach2 = int.Parse(Console.ReadLine());

                Console.Write("For what perion,do you want to make your calendar(select in days): ");

                period_in_days = int.Parse(Console.ReadLine());
            }
        }

        public override void Creation_Calendar()
        {
            if (selects_number == 1)
            {
                Console.WriteLine();
                Sport_Formuls.SelfCalculation_Pull_Up(start_quantity1_experience, increase_approach1, period_in_days);
            }

            if (selects_number == 2)
            {
                Console.WriteLine();
                Sport_Formuls.SelfCalculation_Push_Up(start_quantity1_experience, increase_approach1, period_in_days);
            }

            if (selects_number == 3)
            {
                Console.WriteLine();
                Sport_Formuls.SelfCalculation_All_Together(start_quantity1_experience, start_quantity2_experience, increase_approach1, increase_approach2, period_in_days);
            }
        }
    }
}
