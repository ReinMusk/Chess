using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessCore;

namespace ChessCore
{
    public class PieceData
    {
        public string Name;
        public Dictionary<string, int> Data;

        public override string ToString()
        {
            return Name;
        }
    }

    public static class PieceFab
    {
        public static Piece Make(PieceData picData)
        {
            Piece pic = null;

            switch (picData.Name)
            {
                case "King":
                    pic = new King(picData.Data["X"], picData.Data["Y"]);
                    break;
                case "Queen":
                    pic = new Queen(picData.Data["X"], picData.Data["Y"]);
                    break;
                case "Rook":
                    pic = new Rook(picData.Data["X"], picData.Data["Y"]);
                    break;
                case "Bishop":
                    pic = new Bishop(picData.Data["X"], picData.Data["Y"]);
                    break;
                case "Knight":
                    pic = new Knight(picData.Data["X"], picData.Data["Y"]);
                    break;
            }

            return pic;
        }

        public static List<PieceData> InitPieceData()
        {
            var pieceData = new List<PieceData>
            {
                new PieceData
                {
                    Name = "Circle",
                    Data = new Dictionary<string, int>
                    {
                        { "X", 1 },
                        { "Y", 1 }
                    }
                },

                new PieceData
                {
                    Name = "King",
                    Data = new Dictionary<string, int>
                    {
                        { "X", 1 },
                        { "Y", 1 }
                    }
                },

                new PieceData
                {
                    Name = "Queen",
                    Data = new Dictionary<string, int>
                    {
                        { "X", 1 },
                        { "Y", 1 }
                    }
                },

                new PieceData
                {
                    Name = "Rook",
                    Data = new Dictionary<string, int>
                    {
                        { "X", 1 },
                        { "Y", 1 }
                    }
                },

                new PieceData
                {
                    Name = "Bishop",
                    Data = new Dictionary<string, int>
                    {
                        { "X", 1 },
                        { "Y", 1 }
                    }
                },

                new PieceData
                {
                    Name = "Knight",
                    Data = new Dictionary<string, int>
                    {
                        { "X", 1 },
                        { "Y", 1 }
                    }
                }
            };

            return pieceData;
        }

    }
}
