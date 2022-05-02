
namespace Lab1
{
    public class Human : IHuman
    {
        public int Age { get; set; }
        public string Sex { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Nationality { get; set; }
        public string Creed { get; set; }
        public DateTime Birth { get; set; }
        public double PassportNum { get; set; }

        /// <summary>
        /// Calculating body mass index
        /// </summary>
        /// <returns>Human body mass index</returns>
        public string calcBMI()
        {
            double BMI = Weight / Math.Pow(Height, 2);
            if (BMI < 0.00185)
              return "Body Mass Index is UNDERWEIGHT!";
            else if (BMI < 0.0025)
              return "Body Mass Index is NORMAL!";
            else
              return "Body Mass Index is OVERWEIGHT";
        }
        /// <summary>
        /// Calculating estimate number of calories a person needs to consume each day
        /// </summary>
        /// <returns>Estimate number of calories</returns>
        public double calcCalories()
        {
            if (Sex == "Male")
                return 13.397 * Weight + 4.799 * Height - 5.677 * Age + 88.362;
            else
                return 9.247 * Weight + 3.098 * Height - 4.330 * Age + 447.593;
        }
    }
}
