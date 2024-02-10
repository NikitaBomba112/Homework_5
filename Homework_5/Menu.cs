using System;
using System.Runtime.CompilerServices;

namespace Homework_5
{
    internal class Menu
    {
        Calculator calculator;

        public Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tMENU");
            Console.ResetColor();
            calculator = new Calculator();
        }

        public void Simulation()
        {
            bool isExit = false;
            while (!isExit) 
            {
                string str;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1 - Convert");
                Console.WriteLine("0 - Exit\n");
                Console.Write("Input: ");
                str = Console.ReadLine();
                Console.ResetColor();

                switch(Convert.ToInt32(str))
                {
                    case 1:
                        int number = ChooseConvert();
                        Console.WriteLine();

                        if (number == 1)
                        {
                            Console.WriteLine(ConvertFromBinaryToDecimal());
                        }
                        else if (number == 2)
                        {
                            Console.WriteLine(ConvertFromDecimalToBinary());
                        }
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Bye!");
                        Console.ResetColor();

                        isExit = true;
                        break;
                }
            }
        }

        public int ChooseConvert()
        {
            string str;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose convert: 1 - from binary to decimal \n" +
                "\t\t2 - from decimal to binary");
            Console.Write("Input: ");
            do
            {
                str = Console.ReadLine();
            }
            while (str != "1" && str != "2");
            Console.ResetColor();

            return Convert.ToInt32(str);
        }

        public int ConvertFromBinaryToDecimal()
        {
            InputNumber();
            string resultStirng = Convert.ToString(calculator.Number);
            string result = "";
            int number = 2;

            for (int i = resultStirng.Length - 1; i >= 0; i--)
            {
                if (resultStirng[i] == '1')
                {
                    if (i == resultStirng.Length - 1)
                    {
                        result += "1";
                    }
                    else
                    {
                        for (int j = resultStirng.Length - 2; j > i; j--)
                        {
                            number *= 2;
                        }

                        number += Convert.ToInt32(result);
                        result = "";
                        result += Convert.ToString(number);
                    }
                }

                number = 2;
            }

            if (Convert.ToInt32(result) > 2147483647 || Convert.ToInt32(result) < - 2147483648)
            {
                throw new Exception("Number is out of range int");
            }
            return Convert.ToInt32(result);
        }

        public int ConvertFromDecimalToBinary() 
        {
            string resultStirng = "";
            string tmp = "";
            InputNumber();
            int result = calculator.Number;

            while (result / 2 != 0)
            {
                resultStirng += Convert.ToString(result % 2);
                result = result / 2;
            }
            resultStirng += Convert.ToString(result % 2);

            for (int i = resultStirng.Length - 1; i >= 0; i--)
            {
                tmp += resultStirng[i];
            }
            resultStirng = tmp;

            if (Convert.ToInt32(result) > 2147483647 || Convert.ToInt32(result) < -2147483648)
            {
                throw new Exception("Number is out of range int");
            }

            return Convert.ToInt32(resultStirng);
        }

        public void InputNumber() 
        {
            int value = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Input number: ");
            value = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            try
            {
                calculator.Number = value;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }
}
