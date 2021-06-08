using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCore
{
    public class Piece
    {
        public object Parent;

        public int x1;
        public int y1;

        public Piece(int x, int y)
        {
            x1 = x;
            y1 = y;
        }

        public bool Move(int x2, int y2)
        {
            if (CanMove(x2, y2))
            {
                x1 = x2;
                y1 = y2;
                return true;
            }
            else
                return false;
        }

        public virtual bool CanMove(int x2, int y2)
        {
            return false;
        }
    }

    class King : Piece
    {
        public King(int x2, int y2) : base(x2, y2) { }

        public override bool CanMove(int x2, int y2)
        {
            return ((Math.Abs(x1 - x2) <= 1) && (Math.Abs(y2 - y1)) <= 1);
        }
    }

    class Queen : Piece
    {
        public Queen(int x2, int y2) : base(x2, y2) { }

        public override bool CanMove(int x2, int y2)
        {
            return (x1 == x2 || y1 == y2) || (Math.Abs(x2 - x1) == (Math.Abs(y2 - y1)));
        }
    }

    class Rook : Piece
    {
        public Rook(int x2, int y2) : base(x2, y2) { }

        public override bool CanMove(int x2, int y2)
        {
            return (x1 == x2 || y1 == y2) & (x1 != x2 || y1 != y2);
        }
    }

    class Bishop : Piece
    {
        public Bishop(int x2, int y2) : base(x2, y2) { }

        public override bool CanMove(int x2, int y2)
        {
            return (Math.Abs(x2 - x1) == Math.Abs(y2 - y1));
        }
    }

    class Knight : Piece
    {
        public Knight(int x2, int y2) : base(x2, y2) { }

        public override bool CanMove(int x2, int y2)
        {
            return (((Math.Abs(x1 - x2)) == 2) && (Math.Abs(y1 - y2) == 1) || ((Math.Abs(x1 - x2)) == 1) && (Math.Abs(y1 - y2) == 2)) ;
        }
    }
}
