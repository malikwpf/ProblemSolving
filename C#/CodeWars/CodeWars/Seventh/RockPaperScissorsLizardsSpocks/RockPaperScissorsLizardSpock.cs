namespace CodeWars.Seventh.RockPaperScissorsLizardsSpocks
{
    public class RockPaperScissorsLizardSpock
    {
        public static Ordering Rpsls(Value a, Value b)
        {
            if (a == b)
            {
                return Ordering.EQ;
            }

            else if (a == Value.Rock)
            {
                if (b == Value.Scissors || b == Value.Lizard)
                {
                    return Ordering.GT;
                }
                return Ordering.LT;
            }

            else if (a == Value.Paper)
            {
                if (b == Value.Rock || b == Value.Spock)
                {
                    return Ordering.GT;
                }

                return Ordering.LT;
            }

            else if (a == Value.Scissors)
            {
                if (b == Value.Lizard || b == Value.Paper)
                {
                    return Ordering.GT;
                }

                return Ordering.LT;
            }

            else if (a == Value.Lizard)
            {
                if (b == Value.Paper || b == Value.Spock)
                {
                    return Ordering.GT;
                }

                return Ordering.LT;
            }

            else
            {
                if (b == Value.Scissors || b == Value.Rock)
                {
                    return Ordering.GT;
                }

                return Ordering.LT;
            }
        }
    }
}
