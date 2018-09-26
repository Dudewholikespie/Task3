namespace Ice_tasks
{
    public class fBuilding : Buildings
    {
        protected  string unitsProd;
        protected  int GticksProd;
        protected  int xSpawn;
        protected  int ySpawn;

        public int XPos { get => xPos; set => xPos = value; }
        public int YPos { get => yPos; set => yPos = value; }
        public int Health { get => health; set => health = value; }
        public int Team { get => team; set => team = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public string UnitsProd { get => unitsProd; set => unitsProd = value; }
        public int GTicksprod { get => GticksProd; set => GticksProd = value; }
        public int Xspawn { get => xSpawn; set => xSpawn = value; }
        public int Yspawn { get => ySpawn; set => ySpawn = value; }





        public fBuilding(int xPos, int yPos, int health, int team, string symbol, string unitsProd, int GticksProd, int xSpawn, int ySpawn) : base(xPos, yPos, health, team, symbol)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.health = health;
            this.team = team;
            this.symbol = symbol;
            this.unitsProd = unitsProd;
            this.GticksProd = GticksProd;
            this.xSpawn = xSpawn;
            this.ySpawn = ySpawn;
        }

        public bool SpawnUnits(int tickTime)
        {
            bool isTrue;
            if (GticksProd == tickTime)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;

            }
            return isTrue;
        }
    }
}
