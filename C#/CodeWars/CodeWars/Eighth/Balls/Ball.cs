namespace CodeWars.Eighth.Balls
{
    public class Ball
    {
        public string ballType { get; set; }

        public Ball()
        {
            this.ballType = "regular";
        }

        public Ball(string ballType)
        {
            this.ballType = "super";
        }

        //Better approach
        //public Ball(string ballType="regular")
        //{
        //    this.ballType = ballType;
        //}
    }
}
