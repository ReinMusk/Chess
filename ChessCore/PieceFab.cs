using System;
using System.Collections.Generic;
using ChessCore;

namespace ChessCore
{
    public class PieceData
    {
        public Piece piece;
        public string Name;
        public Dictionary<string, int> Data;
        public Uri image;

        public override string ToString()
        {
            return Name;
        }
    }

    public static class PieceFab
    {
        public static Piece Make(PieceData picData, int x, int y)
        {
            Piece pic = null;

            switch (picData.Name)
            {
                case "King":
                    pic = new King(x, y);
                    break;
                case "Queen":
                    pic = new Queen(x, y);
                    break;
                case "Rook":
                    pic = new Rook(x, y);
                    break;
                case "Bishop":
                    pic = new Bishop(x, y);
                    break;
                case "Knight":
                    pic = new Knight(x, y);
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
                    Name = "King",
                    Data = new Dictionary<string, int>
                {
                    { "X", 1 },
                    { "Y", 1 }
                },
                    image = new Uri(@"imges\king.png", UriKind.Relative)
                },

                new PieceData
                {
                    Name = "Queen",
                    Data = new Dictionary<string, int>
                {
                    { "X", 1 },
                    { "Y", 1 }
                },
                    image = new Uri(@"imges\queen.png", UriKind.Relative)
                },

                new PieceData
                {
                    Name = "Rook",
                    Data = new Dictionary<string, int>
                {
                    { "X", 1 },
                    { "Y", 1 }
                },
                    image = new Uri(@"imges\rook.png", UriKind.Relative)
                },

                new PieceData
                {
                    Name = "Bishop",
                    Data = new Dictionary<string, int>
                {
                    { "X", 1 },
                    { "Y", 1 }
                },
                    image = new Uri(@"imges\bishop.png", UriKind.Relative)
                },

                new PieceData
                {
                    Name = "Knight",
                    Data = new Dictionary<string, int>
                {
                    { "X", 1 },
                    { "Y", 1 }
                },
                    image = new Uri(@"imges\knight.png", UriKind.Relative)
                }
            };

            return pieceData;
        }

    }
}
