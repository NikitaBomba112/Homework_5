using System;

namespace Homework_5
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Passport passport = new Passport();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(passport);

            try
            {

                Console.Write("Write id passport: ");
                passport.IdPassport = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex) 
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            }

            try
            {
                Console.Write("Write name: ");
                passport.Name = Console.ReadLine();
            }
            catch (Exception ex) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            }

            try
            {
                Console.Write("Write surname: ");
                passport.Surname = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            }

            try
            {
                Console.Write("Write second surname: ");
                passport.SecondSurname = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            }

            try
            {
                Console.Write("Write year of issue: ");
                passport.DateOfYear = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            }

            try
            {
                Console.Write("Write month of issue: ");
                passport.DateOfMonth = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            }

            try
            {
                Console.Write("Write day of issue: ");
                passport.DateOfDay = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine();

            Console.WriteLine(passport);
            Console.ResetColor();

            Menu menu = new Menu();

            menu.Simulation();
        }
    }
}