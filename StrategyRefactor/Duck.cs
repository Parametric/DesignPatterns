namespace StrategyRefactor
{
    public abstract class Duck
    {
        public abstract string SayHello();
    }

    public class Duckling : Duck
    {
        public override string SayHello()
        {
            return "tweet";
        }
    }

    public class GrownUp : Duck
    {
        public override string SayHello()
        {
            return "quack";
        }
    }

    public class DuckCall : Duck
    {
        public override string SayHello()
        {
            return "quack";
        }
    }

    public class Decoy : Duck
    {
        public override string SayHello()
        {
            return "< silence >";
        }
    }
}