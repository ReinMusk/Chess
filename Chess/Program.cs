using System;

namespace Chess
{
    class Program
    {
        static void Main()
        {
            King K = new King(4, 4);
            Console.WriteLine(K.Move(5, 5));

            Queen Q = new Queen(1, 1);
            Console.WriteLine(Q.Move(2, 3));

            Rook R = new Rook(4, 4);
            Console.WriteLine(R.Move(5, 5));

            Bishop B = new Bishop(4, 4);
            Console.WriteLine(B.Move(5, 5));

            Knight N = new Knight(1, 1);
            Console.WriteLine(N.Move(1, 4));
        }
    }


    class Piece
    {
        protected int x1;
        protected int y1;

        public Piece(int x, int y)
        {
            x1 = x;
            y1 = y;
        }

        public virtual bool Move(int x2, int y2)
        {
            return false;
        }
    }

    class King : Piece
    {
        public King(int x2, int y2) : base(x2, y2) { }

        public override bool Move(int x2, int y2)
        {
            if ((Math.Abs(x1 - x2) <= 1) && (Math.Abs(y2 - y1)) <= 1)
            {
                x1 = x2;
                y1 = y2;
                return true;
            }

            return false;
        }
    }

    class Queen : Piece
    {
        public Queen(int x2, int y2) : base(x2, y2) { }

        public override bool Move(int x2, int y2)
        {
            if ((x1 == x2 || y1 == y2) || (Math.Abs(x2 - x1) == (Math.Abs(y2 - y1))))
            {
                x1 = x2;
                y1 = y2;
                return true;
            }
            return false;
        }
    }

    class Rook : Piece
    {
        public Rook(int x2, int y2) : base(x2, y2) { }

        public override bool Move(int x2, int y2)
        {
            if ((x1 == x2 || y1 == y2) & (x1 != x2 || y1 != y2))
            {
                x1 = x2;
                y1 = y2;
                return true;
            }
            return false;
        }
    }

    class Bishop : Piece
    {
        public Bishop(int x2, int y2) : base(x2, y2) { }

        public override bool Move(int x2, int y2)
        {
            if (Math.Abs(x2 - x1) == Math.Abs(y2 - y1))
            {
                x1 = x2;
                y1 = y2;
                return true;
            }
            return false;
        }
    }

    class Knight : Piece
    {
        public Knight(int x2, int y2) : base(x2, y2) { }

        public override bool Move(int x2, int y2)
        {
            if (((Math.Abs(x1 - x2)) == 2) && (Math.Abs(y1 - y2) == 1) || ((Math.Abs(x1 - x2)) == 1) && (Math.Abs(y1 - y2) == 2))
            {
                x1 = x2;
                y1 = y2;
                return true;
            }
            return false;
        }
    }
}