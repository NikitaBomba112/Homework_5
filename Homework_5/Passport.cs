using System;

namespace Homework_5
{
    internal class Passport
    {
        private int idPassport;
        private string name;
        private string surname;
        private string secondSurname;
        private int dateOfYear;
        private int dateOfMonth;
        private int dateOfDay;

        public Passport() : this(0, "Null", "Null", "Null", 0, 0, 0)
        {

        }

        public Passport(int idPassport, string name, string surname, string secondSurname, int dateOfYear, int dateOfMonth, int dateOfDay)
        {
            this.idPassport = idPassport;
            this.name = name;
            this.surname = surname;
            this.secondSurname = secondSurname;
            this.dateOfYear = dateOfYear;
            this.dateOfMonth = dateOfMonth;
            this.dateOfDay = dateOfDay;
        }

        public int IdPassport
        {
            get { return idPassport; }

            set
            {
                if (value > 10000)
                {
                    idPassport = value;
                }
                else
                {
                    throw new Exception("Passport ID can only be more than 10000");
                }
            }
        }

        public string Name
        {
            get { return name; }

            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name cannot be an empty string");
                }
            }
        }

        public string Surname
        {
            get { return surname; }

            set
            {
                if (value != "")
                {
                    surname = value;
                }
                else
                {
                    throw new Exception("Surname cannot be an empty string");
                }
            }
        }

        public string SecondSurname
        {
            get { return secondSurname; }

            set
            {
                if (value != "")
                {
                    secondSurname = value;
                }
                else
                {
                    throw new Exception("SecondSurname cannot be an empty string");
                }
            }
        }

        public int DateOfYear
        {
            get { return dateOfYear; }

            set
            {
                if (value > 1950)
                {
                    dateOfYear = value;
                }
                else
                {
                    throw new Exception("Incorrect year number");
                }
            }
        }

        public int DateOfMonth
        {
            get { return dateOfMonth; }

            set
            {
                if (value > 1 && value <= 12)
                {
                    dateOfMonth = value;
                }
                else
                {
                    throw new Exception("Incorrect month number");
                }
            }
        }

        public int DateOfDay
        {
            get { return dateOfDay; }

            set
            {
                if (value > 1 && value <= 31)
                {
                    dateOfDay = value;
                }
                else
                {
                    throw new Exception("Incorrect day number");
                }
            }
        }

        public override string ToString()
        {
            return String.Format($"Id passport = {idPassport}\n" +
                $"Name = {name}\n" +
                $"Surname = {surname}\n" +
                $"SecondSurname = {secondSurname}\n" +
                $"Year of issue = {dateOfYear}\n" +
                $"Month of issue = {dateOfMonth}\n" +
                $"Day of issue = {dateOfDay}\n");
        }
    }
}
