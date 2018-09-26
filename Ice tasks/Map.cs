namespace Ice_tasks
{
    public class Map
    {
        protected int x = 20;
        protected int y = 20;
        protected int i;
        protected int j;
        protected string popMap;
        public string[,] arrayMap = new string[20, 20];
       
        
        Units[] unarr;
        Buildings[] bldArr;
     

        //puts stuff on the map
        public string MapDisplay()
        {

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    arrayMap[i, j] = " . ";
                    


                }
                

            }

            arrayStuffs();
            for  (int i = 0; i< unarr.Length; i++)
            {
               arrayMap[unarr[i].Xpos, unarr[i].Ypos] = unarr[i].Usymbol;
            }

            for (int i = 0; i < bldArr.Length; i++)
            {
                arrayMap[bldArr[i].XPos, bldArr[i].YPos] = bldArr[i].Symbol;
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    
                    popMap += arrayMap[i, j];


                }
                popMap += "\n";

            }
            return popMap;
            
        }

        // creates and arrays for storing buildings and units
        public void arrayStuffs()
        {
            Buildings fOne = new fBuilding(18, 18, 300, 1, " U ", "", 1, 0, 0);
            Buildings fTwo = new fBuilding(2, 2, 300, 1, " u ", "" , 2, 0, 0);
            Buildings rOne = new rBuilding(19, 19, 300, 1, " F ", "food", 2, 0);
            Buildings rTwo = new rBuilding(1, 1, 300, 1, " f ", "food", 2, 0);
            Units MOne = new mUnit(3, 3, 10, 1, 2, 1, 1, "[T]");
            Units MTwo = new mUnit(4, 4, 10, 1, 2, 1, 2, " m ");
            Units ROne = new rUnit(5, 5, 10, 1, 2, 3, 1, " R ");
            Units RTwo = new rUnit(6, 6, 10, 1, 2, 3, 1, " r ");
            unarr = new Units[4];

            unarr[0] = MOne;
            unarr[1] = MTwo;
            unarr[2] = ROne;
            unarr[3] = RTwo;

            bldArr = new Buildings[4];
            bldArr[0] = fOne;
            bldArr[1] = fTwo;
            bldArr[2] = rOne;
            bldArr[3] = rTwo;


        }

        public Map()
        {

        }

        public override string ToString()
        {
            arrayMap.ToString();
            return base.ToString();
        }

    }
}
