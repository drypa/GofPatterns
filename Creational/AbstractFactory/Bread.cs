namespace AbstractFactory
{
    public class Bread
    {
        public double Weight { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Carbohydrates { get; set; }
    }

    public abstract class WhiteBread : Bread
    {
    }
    public abstract class BlackBread : Bread
    {
    }
    /// <summary>
    /// Батон Нарезной
    /// </summary>
    public class WhiteRifledBread : WhiteBread
    {
        public WhiteRifledBread()
        {
            Weight = 300;
        }
    }
    /// <summary>
    /// Батон украинский
    /// </summary>
    public class WhiteUkrainianBread : WhiteBread
    {
        public WhiteUkrainianBread()
        {
            Weight = 280;
        }
    }
    /// <summary>
    /// Хлеб чёрный Столичный
    /// </summary>
    public class BlackСapitalBread : BlackBread
    {
        public BlackСapitalBread()
        {
            Weight = 500;
        }
    }

    /// <summary>
    /// Хлеб чёрный ржаной
    /// </summary>
    public class BlackRyeBread : BlackBread
    {
        public BlackRyeBread()
        {
            Weight = 520;
        }
    }
}
