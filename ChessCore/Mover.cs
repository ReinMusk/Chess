using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCore
{
    abstract public class Mover
    {
        public abstract void King(int x1, int y1, int x2, int y2);
        public abstract void Queen(int x1, int y1, int x2, int y2);
        public abstract void Rook(int x1, int y1, int x2, int y2);
        public abstract void Bishop(int x1, int y1, int x2, int y2);
        public abstract void Knight(int x1, int y1, int x2, int y2);
    }
}
