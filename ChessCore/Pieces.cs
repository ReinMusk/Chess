﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCore
{
    class Piece
    {
        protected int x1;
        protected int y1;

        public Mover mover;

        public Piece(int x, int y)
        {
            x1 = x;
            y1 = y;
        }

        public virtual bool CanMove(int x2, int y2)
        {
            return false;
        }

        public virtual void Move()
        { }
    }

    class King : Piece
    {
        protected int x2;
        protected int y2;

        public King(int x2, int y2) : base(x2, y2) { }

        public override bool CanMove(int x2, int y2)
        {
            if ((Math.Abs(x1 - x2) <= 1) && (Math.Abs(y2 - y1)) <= 1)
            {
                x1 = x2;
                y1 = y2;
                return true;
            }

            return false;
        }

        public override void Move()
        {
            mover.King(x1, y1, x2, y2);
        }
    }

    class Queen : Piece
    {
        protected int x2;
        protected int y2;

        public Queen(int x2, int y2) : base(x2, y2) { }

        public override bool CanMove(int x2, int y2)
        {
            if ((x1 == x2 || y1 == y2) || (Math.Abs(x2 - x1) == (Math.Abs(y2 - y1))))
            {
                x1 = x2;
                y1 = y2;
                return true;
            }

            return false;
        }

        public override void Move()
        {
            mover.Queen(x1, y1, x2, y2);
        }
    }

    class Rook : Piece
    {
        protected int x2;
        protected int y2;

        public Rook(int x2, int y2) : base(x2, y2) { }

        public override bool CanMove(int x2, int y2)
        {
            if ((x1 == x2 || y1 == y2) & (x1 != x2 || y1 != y2))
            {
                x1 = x2;
                y1 = y2;
                return true;
            }

            return false;
        }

        public override void Move()
        {
            mover.Rook(x1, y1, x2, y2);
        }
    }

    class Bishop : Piece
    {
        protected int x2;
        protected int y2;

        public Bishop(int x2, int y2) : base(x2, y2) { }

        public override bool CanMove(int x2, int y2)
        {
            if (Math.Abs(x2 - x1) == Math.Abs(y2 - y1))
            {
                x1 = x2;
                y1 = y2;
                return true;
            }

            return false;
        }

        public override void Move()
        {
            mover.Bishop(x1, y1, x2, y2);
        }
    }

    class Knight : Piece
    {
        protected int x2;
        protected int y2;

        public Knight(int x2, int y2) : base(x2, y2) { }

        public override bool CanMove(int x2, int y2)
        {
            if (((Math.Abs(x1 - x2)) == 2) && (Math.Abs(y1 - y2) == 1) || ((Math.Abs(x1 - x2)) == 1) && (Math.Abs(y1 - y2) == 2))
            {
                x1 = x2;
                y1 = y2;
                return true;
            }

            return false;
        }

        public override void Move()
        {
            mover.Knight(x1, y1, x2, y2);
        }
    }
}
