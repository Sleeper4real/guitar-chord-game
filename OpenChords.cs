using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    class OpenChords
    {
        public static char[,] ResetFretBoard(char[,] fretBoard)
        {
            fretBoard = new char[6, 7];
            int i;
            int j;
            for (i = 0; i < 6; ++i)
            {
                for (j = 0; j < 7; ++j)
                {
                    fretBoard[i, j] = '-';
                }
            }
            return fretBoard;
        }
        public static char[,] Cmajor(char[,] fretBoard)
        {
            fretBoard[1, 0] = 'O';
            fretBoard[3, 1] = 'O';
            fretBoard[4, 2] = 'O';
            fretBoard[5, 0] = 'X';
            return fretBoard;
        }
        public static char[,] Dminor(char[,] fretBoard)
        {
            fretBoard[0, 0] = 'O';
            fretBoard[1, 2] = 'O';
            fretBoard[2, 1] = 'O';
            fretBoard[4, 0] = 'X';
            fretBoard[5, 0] = 'X';
            return fretBoard;
        }
        public static char[,] Eminor(char[,] fretBoard)
        {
            fretBoard[4, 1] = 'O';
            fretBoard[3, 1] = 'O';
            return fretBoard;
        }
        public static char[,] Fmajor(char[,] fretBoard)
        {
            fretBoard[0, 0] = 'O';
            fretBoard[1, 0] = 'O';
            fretBoard[2, 1] = 'O';
            fretBoard[3, 2] = 'O';
            fretBoard[4, 0] = 'X';
            fretBoard[5, 0] = 'X';
            return fretBoard;
        }
        public static char[,] Gmajor(char[,] fretBoard)
        {
            fretBoard[0, 2] = 'O';
            fretBoard[4, 1] = 'O';
            fretBoard[5, 2] = 'O';
            return fretBoard;
        }
        public static char[,] Aminor(char[,] fretBoard)
        {
            fretBoard[1, 0] = 'O';
            fretBoard[2, 1] = 'O';
            fretBoard[3, 1] = 'O';
            fretBoard[5, 0] = 'X';
            return fretBoard;
        }
        public static char[,] Amajor(char[,] fretBoard)
        {
            fretBoard[1, 1] = 'O';
            fretBoard[2, 1] = 'O';
            fretBoard[3, 1] = 'O';
            fretBoard[5, 0] = 'X';
            return fretBoard;
        }
        public static char[,] Emajor(char[,] fretBoard)
        {
            fretBoard[2, 0] = 'O';
            fretBoard[3, 1] = 'O';
            fretBoard[4, 1] = 'O';
            return fretBoard;
        }
        public static char[,] Dmajor(char[,] fretBoard)
        {
            fretBoard[0, 1] = 'O';
            fretBoard[1, 2] = 'O';
            fretBoard[2, 1] = 'O';
            fretBoard[4, 0] = 'X';
            fretBoard[5, 0] = 'X';
            return fretBoard;
        }
        public static char[,] Fminor(char[,] fretBoard)
        {
            fretBoard[0, 0] = 'O';
            fretBoard[1, 0] = 'O';
            fretBoard[2, 0] = 'O';
            fretBoard[3, 2] = 'O';
            fretBoard[4, 0] = 'X';
            fretBoard[5, 0] = 'X';
            return fretBoard;
        }
    }
}
