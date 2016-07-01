using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    class Scales
    {
        static public string[,] Notes()
        {
            string[,] notes = new string[6, 13]
            {{"E", "F", "F#(Gb)", "G", "G#(Ab)", "A", "A#(Bb)", "B", "C", "C#(Db)", "D", "D#(Eb)", "E"},
             {"B", "C", "C#(Db)", "D", "D#(Eb)", "E", "F", "F#(Gb)", "G", "G#(Ab)", "A", "A#(Bb)", "B"},
             {"G", "G#(Ab)", "A", "A#(Bb)", "B", "C", "C#(Db)", "D", "D#(Eb)", "E", "F", "F#(Gb)", "G"},
             {"D", "D#(Eb)", "E", "F", "F#(Gb)", "G", "G#(Ab)", "A", "A#(Bb)", "B", "C", "C#(Db)", "D"},
             {"A", "A#(Bb)", "B", "C", "C#(Db)", "D", "D#(Eb)", "E", "F", "F#(Gb)", "G", "G#(Ab)", "A"},
             {"E", "F", "F#(Gb)", "G", "G#(Ab)", "A", "A#(Bb)", "B", "C", "C#(Db)", "D", "D#(Eb)", "E"}};
            return notes;
        }
        static public char[,] ReturnAMajorScale(char[,] fretBoard, ref int rootString)
        {
            Random rand = new Random();
            int chosenScale = rand.Next() % 5 + 1;
            switch (chosenScale)
            {
                case 1:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 0] = 'O';
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 3] = 'O';
                    }
                    for (int i = 2; i < 5; ++i)
                    {
                        fretBoard[i, 1] = '-';
                        fretBoard[i, 2] = 'O';
                    }
                    fretBoard[1, 1] = 'R';
                    fretBoard[4, 3] = 'R';
                    fretBoard[2, 3] = '-';
                    rootString = 1;
                    break;
                case 2:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 3] = 'O';
                    }
                    fretBoard[2, 0] = 'O';
                    fretBoard[3, 0] = 'O';
                    fretBoard[4, 0] = 'O';
                    fretBoard[2, 1] = '-';
                    fretBoard[4, 1] = 'R';
                    fretBoard[2, 2] = 'O';
                    fretBoard[2, 3] = 'R';
                    fretBoard[1, 4] = 'O';
                    rootString = 4;
                    break;
                case 3:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 3] = 'O';
                    }
                    fretBoard[2, 0] = 'O';
                    fretBoard[2, 1] = 'R';
                    fretBoard[1, 2] = 'O';
                    fretBoard[1, 3] = '-';
                    fretBoard[0, 4] = 'R';
                    fretBoard[1, 4] = 'O';
                    fretBoard[4, 4] = 'O';
                    fretBoard[5, 4] = 'R';
                    rootString = 2;
                    break;
                case 4:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 0] = 'O';
                        fretBoard[i, 3] = 'O';
                    }
                    fretBoard[1, 0] = '-';
                    fretBoard[0, 1] = 'R';
                    fretBoard[1, 1] = 'O';
                    fretBoard[4, 1] = 'O';
                    fretBoard[5, 1] = 'R';
                    fretBoard[2, 2] = 'O';
                    fretBoard[3, 2] = 'O';
                    fretBoard[3, 3] = 'R';
                    rootString = 5;
                    break;
                case 5:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 3] = 'O';
                    }
                    fretBoard[2, 0] = 'O';
                    fretBoard[3, 0] = 'O';
                    fretBoard[3, 1] = 'R';
                    fretBoard[0, 4] = 'O';
                    fretBoard[1, 4] = 'R';
                    fretBoard[5, 4] = 'O';
                    rootString = 3;
                    break;
            }
            return fretBoard;
        }
        static public char[,] ReturnAMinorScale(char[,] fretBoard, ref int rootString)
        {
            Random rand = new Random();
            int chosenScale = rand.Next() % 5 + 1;
            switch (chosenScale)
            {
                case 1:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 3] = 'O';
                        fretBoard[i, 4] = 'O';
                    }
                    fretBoard[2, 0] = 'O';
                    fretBoard[0, 1] = 'R';
                    fretBoard[5, 1] = 'R';
                    fretBoard[1, 2] = 'O';
                    fretBoard[1, 3] = '-';
                    fretBoard[3, 3] = 'R';
                    fretBoard[2, 4] = '-';
                    fretBoard[3, 4] = '-';
                    rootString = 5;
                    break;
                case 2:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 2] = 'O';
                        fretBoard[i, 4] = 'O';
                    }
                    fretBoard[1, 1] = '-';
                    fretBoard[3, 1] = 'R';
                    fretBoard[2, 2] = '-';
                    fretBoard[3, 2] = '-';
                    fretBoard[2, 3] = 'O';
                    fretBoard[3, 3] = 'O';
                    fretBoard[1, 4] = 'R';
                    rootString = 3;
                    break;
                case 3:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 3] = 'O';
                    }
                    fretBoard[2, 0] = 'O';
                    fretBoard[3, 0] = 'O';
                    fretBoard[1, 1] = 'R';
                    fretBoard[4, 3] = 'R';
                    fretBoard[0, 4] = 'O';
                    fretBoard[1, 4] = 'O';
                    fretBoard[5, 4] = 'O';
                    rootString = 1;
                    break;
                case 4:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 2] = 'O';
                        fretBoard[i, 4] = 'O';
                    }
                    for (int i = 2; i < 5; ++i)
                    {
                        fretBoard[i, 2] = '-';
                        fretBoard[i, 3] = 'O';
                    }
                    fretBoard[4, 1] = 'R';
                    fretBoard[2, 3] = 'R';
                    fretBoard[2, 4] = '-';
                    rootString = 4;
                    break;
                case 5:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 2] = 'O';
                        fretBoard[i, 4] = 'O';
                    }
                    fretBoard[2, 1] = 'R';
                    fretBoard[3, 1] = 'O';
                    fretBoard[4, 1] = 'O';
                    fretBoard[2, 2] = '-';
                    fretBoard[2, 3] = 'O';
                    fretBoard[0, 4] = 'R';
                    fretBoard[5, 4] = 'R';
                    fretBoard[1, 5] = 'O';
                    rootString = 2;
                    break;
            }
            return fretBoard;
        }
        static public char[,] ReturnAMajorPentatonicScale(char[,] fretBoard, ref int rootString)
        {
            Random rand = new Random();
            int chosenScale = rand.Next() % 5 + 1;
            switch (chosenScale)
            {
                case 1:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 3] = 'O';
                        fretBoard[i, 1] = 'R';
                    }
                    for (int i = 2; i < 5; ++i)
                    {
                        fretBoard[i, 0] = 'O';
                        fretBoard[i, 1] = '-';
                    }
                    fretBoard[1, 1] = 'O';
                    fretBoard[2, 2] = 'O';
                    fretBoard[2, 3] = '-';
                    fretBoard[3, 3] = 'R';
                    rootString = 5;
                    break;
                case 2:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 3] = 'O';
                    }
                    fretBoard[2, 0] = 'O';
                    fretBoard[2, 1] = '-';
                    fretBoard[3, 1] = 'R';
                    fretBoard[1, 3] = '-';
                    fretBoard[1, 4] = 'R';
                    rootString = 3;
                    break;
                case 3:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 0] = 'O';
                        fretBoard[i, 3] = 'O';
                    }
                    fretBoard[1, 0] = '-';
                    fretBoard[1, 1] = 'R';
                    fretBoard[2, 2] = 'O';
                    fretBoard[3, 2] = 'O';
                    fretBoard[2, 3] = '-';
                    fretBoard[3, 3] = '-';
                    fretBoard[4, 3] = 'R';
                    rootString = 1;
                    break;
                case 4:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 3] = 'O';
                    }
                    fretBoard[2, 0] = 'O';
                    fretBoard[3, 0] = 'O';
                    fretBoard[2, 1] = '-';
                    fretBoard[3, 1] = '-';
                    fretBoard[4, 1] = 'R';
                    fretBoard[2, 3] = 'R';
                    rootString = 4;
                    break;
                case 5:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 4] = 'R';
                    }
                    for (int i = 2; i < 5; ++i)
                    {
                        fretBoard[i, 3] = 'O';
                        fretBoard[i, 4] = '-';
                    }
                    fretBoard[2, 1] = 'R';
                    fretBoard[1, 4] = 'O';
                    rootString = 2;
                    break;
            }
            return fretBoard;
        }
        static public char[,] ReturnAMinorPentatonicScale(char[,] fretBoard, ref int rootString)
        {
            Random rand = new Random();
            int chosenScale = rand.Next() % 5 + 1;
            switch (chosenScale)
            {
                case 1:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 4] = 'O';
                    }
                    for (int i = 2; i < 5; ++i)
                    {
                        fretBoard[i, 3] = 'O';
                        fretBoard[i, 4] = '-';
                    }
                    fretBoard[0, 1] = 'R';
                    fretBoard[5, 1] = 'R';
                    fretBoard[3, 3] = 'R';
                    rootString = 5;
                    break;
                case 2:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 2] = 'O';
                        fretBoard[i, 4] = 'O';
                    }
                    for (int i = 2; i < 5; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 2] = '-';
                    }
                    fretBoard[3, 1] = 'R';
                    fretBoard[2, 3] = 'O';
                    fretBoard[1, 4] = 'R';
                    fretBoard[2, 4] = '-';
                    rootString = 3;
                    break;
                case 3:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 3] = 'O';
                    }
                    fretBoard[2, 0] = 'O';
                    fretBoard[1, 1] = 'R';
                    fretBoard[2, 1] = '-';
                    fretBoard[1, 3] = '-';
                    fretBoard[4, 3] = 'R';
                    fretBoard[1, 4] = 'O';
                    rootString = 1;
                    break;
                case 4:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 4] = 'O';
                    }
                    for (int i = 2; i < 4; ++i)
                    {
                        fretBoard[i, 3] = 'O';
                        fretBoard[i, 4] = '-';
                    }
                    fretBoard[1, 1] = '-';
                    fretBoard[4, 1] = 'R';
                    fretBoard[1, 2] = 'O';
                    fretBoard[2, 3] = 'R';
                    rootString = 4;
                    break;
                case 5:
                    for (int i = 0; i < 6; ++i)
                    {
                        fretBoard[i, 2] = 'O';
                        fretBoard[i, 4] = 'O';
                    }
                    for (int i = 2; i < 4; ++i)
                    {
                        fretBoard[i, 1] = 'O';
                        fretBoard[i, 2] = '-';
                    }
                    fretBoard[2, 1] = 'R';
                    fretBoard[0, 4] = 'R';
                    fretBoard[5, 4] = 'R';
                    rootString = 2;
                    break;
            }
            return fretBoard;
        } 
    }
}
