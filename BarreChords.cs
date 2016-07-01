using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    class BarreChords
    {
        public static char[,] String6Major(char[,] fretBoard)
        {
            for (int i = 0; i < 6; ++i)
            {
                fretBoard[i, 0] = 'O';
            }
            fretBoard[2, 1] = 'O';
            fretBoard[3, 2] = 'O';
            fretBoard[4, 2] = 'O';
            return fretBoard;
        }
        public static char[,] String6Minor(char[,] fretBoard)
        {
            for (int i = 0; i < 6; ++i)
            {
                fretBoard[i, 0] = 'O';
            }
            fretBoard[3, 2] = 'O';
            fretBoard[4, 2] = 'O';
            return fretBoard;
        }
        public static char[,] String5Major(char[,] fretBoard)
        {
            for (int i = 0; i < 5; ++i)
            {
                fretBoard[i, 0] = 'O';
            }
            fretBoard[5, 0] = 'X';
            fretBoard[1, 2] = 'O';
            fretBoard[2, 2] = 'O';
            fretBoard[3, 2] = 'O';
            return fretBoard;
        }
        public static char[,] String5Minor(char[,] fretBoard)
        {
            for (int i = 0; i < 5; ++i)
            {
                fretBoard[i, 0] = 'O';
            }
            fretBoard[5, 0] = 'X';
            fretBoard[1, 1] = 'O';
            fretBoard[2, 2] = 'O';
            fretBoard[3, 2] = 'O';
            return fretBoard;
        }
        public static char[,] String6Seventh(char[,] fretBoard)
        {
            for (int i = 0; i < 6; ++i)
            {
                fretBoard[i, 0] = 'O';
            }
            fretBoard[2, 1] = 'O';
            fretBoard[4, 2] = 'O';
            return fretBoard;
        }
        public static char[,] String6MinorSeventh(char[,] fretBoard)
        {
            for (int i = 0; i < 6; ++i)
            {
                fretBoard[i, 0] = 'O';
            }
            fretBoard[1, 3] = 'O';
            fretBoard[4, 2] = 'O';
            return fretBoard;
        }
        public static char[,] String6MajorSeventh(char[,] fretBoard)
        {
            for (int i = 0; i < 6; ++i)
            {
                fretBoard[i, 0] = 'O';
            }
            fretBoard[2, 1] = 'O';
            fretBoard[3, 1] = 'O';
            fretBoard[4, 2] = 'O';
            return fretBoard;
        }
        public static char[,] String5Seventh(char[,] fretBoard)
        {
            for (int i = 0; i < 5; ++i)
            {
                fretBoard[i, 0] = 'O';
            }
            fretBoard[5, 0] = 'X';
            fretBoard[1, 2] = 'O';
            fretBoard[3, 2] = 'O';
            return fretBoard;
        }
        public static char[,] String5MinorSeventh(char[,] fretBoard)
        {
            for (int i = 0; i < 5; ++i)
            {
                fretBoard[i, 0] = 'O';
            }
            fretBoard[5, 0] = 'X';
            fretBoard[1, 1] = 'O';
            fretBoard[3, 2] = 'O';
            return fretBoard;
        }
        public static char[,] String5MajorSeventh(char[,] fretBoard)
        {
            for (int i = 0; i < 5; ++i)
            {
                fretBoard[i, 0] = 'O';
            }
            fretBoard[5, 0] = 'X';
            fretBoard[1, 2] = 'O';
            fretBoard[2, 1] = 'O';
            fretBoard[3, 2] = 'O';
            return fretBoard;
        }
    }
}
