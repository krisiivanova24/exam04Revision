using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8queens
{
    class Program
    {
        public static int Size = 8;
        public static int solutions = 0;
        public static bool[,] boardOfChess = new bool[Size, Size];

        public static HashSet<int> attackedRows = new HashSet<int>();
        public static HashSet<int> attackedColumn = new HashSet<int>();
        public static HashSet<int> attackedLeftDiagonale = new HashSet<int>();
        public static HashSet<int> attackedRigthDiagonale = new HashSet<int>();


        static void Main(string[] args)
        {

            PutQueens(0);
            Console.WriteLine($"Solutions which are Found: {solutions}" );

        }
         private static void PutQueens(int row)
        {
            if (row == Size)
            {
                PrintResult();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackPositions(row, col);
                        PutQueens(row + 1);
                        UnmarkAllAttackPositions(row, col);
                    }

                }
            }
        }
         private static bool CanPlaceQueen(int row, int col)
        {
            var positionOcuo = attackedRows.Contains(row) 
                || attackedColumn.Contains(col) 
                || attackedLeftDiagonale.Contains(col - row) 
                || attackedRigthDiagonale.Contains(col + row);
            return !positionOcuo;
        }
        private static void MarkAllAttackPositions(int row, int col)
        {
            attackedRows.Add(row);
            attackedColumn.Add(col);
            attackedLeftDiagonale.Add(col - row);
            attackedRigthDiagonale.Add(col + row);
            boardOfChess[row, col] = true;
        }
        private static void UnmarkAllAttackPositions(int row, int col)
        {
            attackedRows.Remove(row);
            attackedColumn.Remove(col);
            attackedLeftDiagonale.Remove(col - row);
            attackedRigthDiagonale.Remove(col + row);
            boardOfChess[row, col] = false;
        }
        private static void PrintResult()
        {
            Console.WriteLine("SolutionFound: " + solutions);
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    Console.Write(boardOfChess[row, col] ? "* " : "- ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            solutions++;
        }
    }
}

