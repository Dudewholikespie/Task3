namespace Ice_tasks
{
    public abstract class Units
    {
        protected int xPos;
        protected int yPos;
        protected int Hp;
        protected int speed;
        protected int dmg;
        protected int atkRange;
        protected int team;
        protected string unitSymbol;
       

        public int  Xpos { get => xPos; set => xPos = value; }
        public int Ypos { get => yPos; set => yPos = value; }
        public int HP { get => Hp; set => Hp = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Dmg { get => dmg; set => dmg = value; }
        public int Range { get => atkRange; set => atkRange = value; }
        public int Team { get => team; set => team = value; }
        public string Usymbol { get => unitSymbol; set => unitSymbol = value; }


        protected Units(int xPos, int yPos, int hp, int dmg, int atkRange, int team, string unitSymbol)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            Hp = hp;
            this.dmg = dmg;
            this.atkRange = atkRange;
            this.team = team;
            this.unitSymbol = unitSymbol;
        }

       
    }
}
