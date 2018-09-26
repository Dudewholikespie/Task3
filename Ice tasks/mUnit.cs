namespace Ice_tasks
{
    public class mUnit : Units
    {
        
        public int MelXpos { get => xPos; set => xPos = value; }
        public int MelYpos { get => yPos; set => yPos = value; }
        public int MelHP { get => Hp; set => Hp = value; }
        public int MelSpeed { get => speed; set => speed = value; }
        public int MelDmg { get => dmg; set => dmg = value; }
        public int MelRange { get => atkRange; set => atkRange = value; }
        public int MelTeam { get => team; set => team = value; }
        public string MelUsymbol { get => unitSymbol; set => unitSymbol = value; }


        public mUnit(int xPos, int yPos, int Hp, int speed, int dmg, int atkRange, int team, string unitSymbol) : base(xPos, yPos, Hp, dmg, atkRange, team, unitSymbol)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.Hp = Hp;
            this.speed = speed;
            this.dmg = dmg;
            this.atkRange = atkRange;
            this.team = team;
            this.unitSymbol = unitSymbol;

        }

        public override string ToString()
        {
            string symbol;
            symbol = unitSymbol;
            return symbol;
           
        }

      

    }
}
