namespace HangedManClasses
{
    public class Draw
    {
        private int _level;

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public void DrawLevel(int level = 0)
        {
            this.Level = level;

            switch (Level)
            {
                case 1:
                    Console.WriteLine(DrawLevel1());
                    break;
                case 2:
                    Console.WriteLine(DrawLevel2());
                    break;
                case 3:
                    Console.WriteLine(DrawLevel3());
                    break;
                case 4:
                    Console.WriteLine(DrawLevel4());
                    break;
                case 5:
                    Console.WriteLine(DrawLevel5());
                    break;
                case 6:
                    Console.WriteLine(DrawLevel6());
                    break;
                case 7:
                    Console.WriteLine(DrawLevel7());
                    break;
                //case 8:
                //    Console.WriteLine(DrawLevel8());
                //    break;
                default:
                    Console.WriteLine();
                    break;
            }
            
        }

        public string DrawLevel1()
        {
            return @"+---+
    |
    |
    |
    |
   ---";
        }

        public string DrawLevel2()
        {
            return @"+---+
0   |
    |
    |
    |
   ---";
        }
        public string DrawLevel3()
        {
            return @"+---+
0   |
|   |
    |
    |
   ---";
        }
        public string DrawLevel4()
        {
            return @"+---+
 0  |
/|  |
    |
    |
   ---";
        }
        public string DrawLevel5()
        {
            return @"+---+
 0  |
/|\ |
    |
    |
   ---";
        }
        public string DrawLevel6()
        {
            return @"+---+
 0  |
/|\ |
/   |
    |
   ---";
        }
        public string DrawLevel7()
        {
            return @"+---+
 0  |
/|\ |
/ \ |
    |
   ---";
        }

    }
}