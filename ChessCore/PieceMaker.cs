using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    static public class PieceFab
    {
        public static List<PieceData> InitPieceData()
        {
            var pieceData = new List<PieceData>();

            pieceData.Add(new PieceData
            {
                Name = "Circle",
                Data = new Dictionary<string, int>
                {
                    { "X", 1 },
                    { "Y", 1 },
                    { "Radius", 100 }
                }
            });

            pieceData.Add(new PieceData
            {
                Name = "King",
                Data = new Dictionary<string, int>
                {
                    
                }
            });

            pieceData.Add(new PieceData
            {
                Name = "Queen",
                Data = new Dictionary<string, int>
                {
                    
                }
            });

            pieceData.Add(new PieceData
            {
                Name = "Rook",
                Data = new Dictionary<string, int>
                {
                    
                }
            });

            pieceData.Add(new PieceData
            {
                Name = "Bishop",
                Data = new Dictionary<string, int>
                {
                    
                }
            });

            pieceData.Add(new PieceData
            {
                Name = "Knight",
                Data = new Dictionary<string, int>
                {
                    
                }
            });

            return pieceData;
        }

    }
}
