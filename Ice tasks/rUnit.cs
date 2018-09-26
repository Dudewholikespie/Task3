namespace Ice_tasks
{
    public class rUnit : Units
    {
        public int RanXpos { get => xPos; set => xPos = value; }
        public int RanYpos { get => yPos; set => yPos = value; }
        public int RanHP { get => Hp; set => Hp = value; }
        public int RAnSpeed { get => speed; set => speed = value; }
        public int RanDmg { get => dmg; set => dmg = value; }
        public int RanRange { get => atkRange; set => atkRange = value; }
        public int RanTeam { get => team; set => team = value; }
        public string RanUsymbol { get => unitSymbol; set => unitSymbol = value; }

        public rUnit(int xPos, int yPos, int Hp, int speed, int dmg, int atkRange, int team, string unitSymbol) : base(xPos, yPos, Hp, dmg, atkRange, team, unitSymbol)
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
    }
}
