namespace StrategyRefactor
{
    public class Duck
    {
        public Duck(int ageInDays, bool isBird, int utilityScore)
        {
            AgeInDays = ageInDays;
            IsBird = isBird;
            UtilityScore = utilityScore;
        }

        public int AgeInDays { get; set; }
        public bool IsBird { get; set; }
        public int UtilityScore { get; set; }

        public string SayHello()
        {
            string greeting;
            if (IsBird)
            {
                if (AgeInDays < 60)
                {
                    greeting = "tweet";
                }
                else
                {
                    greeting = "quack";
                }
            }
            else
            {
                if (UtilityScore == 0)
                {
                    greeting = "squeak";
                }
                else
                {
                    greeting = "quack";
                }
            }

            return greeting;
        }
    }
}