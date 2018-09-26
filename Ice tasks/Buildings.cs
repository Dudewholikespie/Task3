namespace Ice_tasks
{
    public abstract class Buildings
    {
        protected int xPos;
        protected int yPos;
        protected int health;
        protected int team;
        protected string symbol;
        public int XPos { get => xPos; set => xPos = value; }
        public int YPos { get => yPos; set => yPos = value; }
        public int Health { get => health; set => health = value; }
        public int Team { get => team; set => team = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public Buildings(int xPos, int yPos, int health, int team, string symbol)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.health = health;
            this.team = team;
            this.symbol = symbol;
        }

        public override string ToString()
        {
            string buildingStats = System.Convert.ToString(xPos) + System.Convert.ToString(yPos) + System.Convert.ToString(health) + team + symbol;

            return buildingStats;



        }
    }
}
