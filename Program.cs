

using Lab1;

namespace ConsoleHumans
{
    class HumanProgram
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Age = 20;
            human.Sex = "Male";
            human.Height = 180;
            human.Weight = 66;
            human.Nationality = "Ukrainian";
            human.Creed = "None";
            DateTime HumanBirth = new DateTime (2001, 05, 15);
            human.Birth = HumanBirth;
            human.PassportNum = 00000000;
            Console.WriteLine($"Human BMI: {human.calcBMI()}. \nEvery day this human should consume {human.calcCalories()} calories to be healthy.\n");

            Student student = new Student();
            student.Age = 21;
            student.Sex = "Female";
            student.Height = 165;
            student.Weight = 50;
            student.Nationality = "Ukrainian";
            student.Creed = "Christian";
            DateTime StudentBirth = new DateTime(2000, 09, 01);
            student.Birth = HumanBirth;
            student.PassportNum = 00000001;
            student.GradebookNum = 00000000;
            student.Group = "SN-40";
            Console.WriteLine($"Student BMI: {student.calcBMI()}. \nEvery day this student should consume {student.calcCalories()} calories to be healthy.");
        }
    }
}

