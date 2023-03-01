using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace WPU221_lesson1
{
    class Program
    {
        static void startQuiz()
        {
            string[] questions =
            {
                "Самая высокая гора? эверест или эльбрус? - ",
                "Самая длинная река? амазонка или волга? - ",
                "Самая большая страна? россия или китай? - "
            };
            string[] answers =
            {
                "эверест", "амазонка", "россия"
            };
            int countOfRightAnswers = 0;
            string userAnswer;

            for (int i = 0; i < questions.Length; i++)
            {
                Write(questions[i]);
                userAnswer = ReadLine();
                if (userAnswer.ToLower() == answers[i])
                {
                    countOfRightAnswers++;
                    WriteLine("Ответ верный!");
                }
                else
                {
                    WriteLine("Ответ неверный!");
                }
            }

            WriteLine("Правильных ответов: " + countOfRightAnswers);
            if (countOfRightAnswers == 3)
            {
                WriteLine("5баллов");
            }
            if (countOfRightAnswers == 2)
            {
                WriteLine("4баллa");
            }
            if (countOfRightAnswers == 1)
            {
                WriteLine("3баллa");
            }
            else if (countOfRightAnswers == 0)
            {
                WriteLine("2баллa");
            }
            WriteLine("Нажми 1 для перезапуска игры\'Викторина\'");
            WriteLine("Нажми 0 для выхода");
            int userChoice = Int32.Parse(ReadLine());
            switch (userChoice)
            {

                case 1:
                    startQuiz();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
        static void guessNumber()
        {
            WriteLine("*****Угадай число от 0 до 100!*****");
            Random rand = new Random();
            int magicNumber = rand.Next(0, 100);
            int userNumber = 0;
            int count = 0;
            WriteLine("Количество попыток: 7");
            do
            {
                WriteLine("Введи число: ");
                userNumber = Int32.Parse(ReadLine());
                count++;

                if (userNumber < magicNumber)
                {
                    WriteLine("Введенное число меньше загаданного!");
                }
                else if (userNumber > magicNumber)
                {
                    WriteLine("Введенное число больше загаданного!");
                }
                else if (userNumber == magicNumber)
                {
                    WriteLine("Верно! Загаданное число " + magicNumber);
                    WriteLine($"Тебе понадобилось {count} попыток");
                    break;
                }
                WriteLine($"Осталось попыток: {7 - count}");
                if ((7 - count) <= 0)
                {
                    WriteLine("Игра закончена, Вы проиграли, попробуйте ещё раз.");
                    Environment.Exit(0);
                }
            } while (userNumber != magicNumber);

        }
        static void Main(string[] args)
        {
            do
            {
                WriteLine("**********МЕНЮ**********");
                WriteLine("Нажми 1 для запуска игры \'Викторина\'");
                WriteLine("Нажми 2 для запуска игры \'Угодай число\'");
                WriteLine("Нажми любую цифру для выхода");
                int userChoice = Int32.Parse(ReadLine());

                switch (userChoice)
                {
                    case 1:
                        startQuiz();
                        break;
                    case 2:
                        guessNumber();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}
