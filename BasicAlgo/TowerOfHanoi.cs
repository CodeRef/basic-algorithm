namespace Cabana
{
    using static System.Console;
    /*
     *  Demonstrate Tower Of Hanoi
     *  
     *  credit : http://www.sanfoundry.com/csharp-program-tower-of-hanoi/
     */
    public class TowerOfHanoi
    {
        int _mNumdiscs;
        public int Numdiscs
        {
            get
            {
                return _mNumdiscs;
            }
            set
            {
                if (value > 0)
                    _mNumdiscs = value;
            }
        }
        public TowerOfHanoi()
        {
            Numdiscs = 0;
        }
        public TowerOfHanoi(int newval)
        {
            Numdiscs = newval;
        }

        public void Movetower(int n, int from, int to, int other)
        {
            if (n > 0)
            {
                Movetower(n - 1, from, other, to);
                WriteLine("Move disk {0} from tower {1} to tower {2}", n, from, to);
                Movetower(n - 1, other, to, from);
            }
        }
    }
}