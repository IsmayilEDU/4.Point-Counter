namespace _4.Class___struct
{
    //  Task 1
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X: {X}\nY: {Y}";
        }
    }

    //  Task 2
    internal class Counter
    { 
        //  Min
        public const int Min = 0;

        //  Max
        public const int Max = 100;

        //  Current
        private int _current;
        public int Current 
        {
            get { return _current; }
            set
            {
                if(value >= Min && value <= Max) 
                {
                    _current = value;
                }
            }
                 
        }

        //  Constructor with parametres
        public Counter(int current) 
        {
            Current = current;
        }
        
        //  Increement
        public void increement()
        {
            if ( Current + 1 == 100 ) { Current= 0; }
            else { Current++; }
        }

        //  ToString method
        public override string ToString() 
        {
            return $"Current: {Current}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}