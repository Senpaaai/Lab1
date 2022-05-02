namespace Lab1
{
    /// <summary>
    /// Creating IHuman DLL
    /// </summary>
    public interface IHuman
    {
        int Age { get; set; }
        string Sex { get; set; }
        int Height { get; set; }
        int Weight { get; set; }
        string Nationality { get; set; }
        string Creed { get; set; }
        DateTime Birth { get; set; }
        double PassportNum { get; set; }

        /// <summary>
        /// Calculating body mass index
        /// </summary>
        /// <returns>Human body mass index</returns>
        string calcBMI();
        /// <summary>
        /// Calculating estimate number of calories a person needs to consume each day
        /// </summary>
        /// <returns>Estimate number of calories</returns>
        double calcCalories();
    }
}