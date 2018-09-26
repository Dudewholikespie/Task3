namespace Ice_tasks
{
    public  class rBuilding : Buildings
    {
        protected string resourceType;
        protected int RPT;
        protected int remainingResources;


        public int XPos { get => xPos; set => xPos = value; }
        public int YPos { get => yPos; set => yPos = value; }
        public int Health { get => health; set => health = value; }
        public int Team { get => team; set => team = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public string ResourceType { get => resourceType; set => resourceType = value; }
        public int Rpt { get => RPT; set => RPT = value; }

        public int RemainingResources { get => remainingResources; set => remainingResources = value; }

        public rBuilding(int xPos, int yPos, int health, int team, string symbol, string resourceType, int RPT, int remainingResources) : base(xPos, yPos, health, team, symbol)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.health = health;
            this.team = team;
            this.symbol = symbol;
            this.resourceType = resourceType;
            this.RPT = RPT;
            this.remainingResources = remainingResources;
        }


        public void ResourceGen()
        {

            remainingResources += RPT;


        }

        public string resourceToText()
        {
            int resourceDisplay = remainingResources;
            string RDP = System.Convert.ToString(resourceDisplay) + " " + resourceType + " Remaining";
            return RDP;
        }


        public string rType()
        {
            string sym = symbol;
            return sym;
        }
    }
}
