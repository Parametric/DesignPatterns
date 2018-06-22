using System;

namespace StrategyRefactor
{
    public interface ISayHelloStrategy
    {
        string SayHello();
    }
    public class TweetStrategy : ISayHelloStrategy
    {
        public string SayHello()
        {
            return "tweet";
        }
    }
    public class QuackStrategy : ISayHelloStrategy
    {
        public string SayHello()
        {
            return "quack";
        }
    }
    public class DecoyStrategy : ISayHelloStrategy
    {
        public string SayHello()
        {
            return "< silence >";
        }
    }


    public abstract class Duck
    {
        protected ISayHelloStrategy Strategy;
        public string InvokeGreeting()
        {
            return Strategy.SayHello();
        }
        public void UpdateQuackStrategy(ISayHelloStrategy strategy)
        {
            Strategy = strategy;
        }
    }

    public class Duckling : Duck
    {
        public Duckling()
        {
            Strategy = new TweetStrategy();
        }
    }

    public class GrownUp : Duck
    {
        public GrownUp()
        {
            Strategy = new QuackStrategy();
        }
    }

    public class DuckCall : Duck
    {
        public DuckCall()
        {
            Strategy = new QuackStrategy();
        }
    }

    public class Decoy : Duck
    {
        public Decoy()
        {
            Strategy = new DecoyStrategy();
        }
    }
}