using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication55
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Assert(TestScenario1OK());
            Debug.Assert(TestScenario2OK());
            Debug.Assert(TestScenario3OK());
            Debug.Assert(TestScenario4OK());
            int playAgain = 1;
            while (playAgain == 1)
            {
                Console.WriteLine("Welcome to Chord Guesser, please pick a level:" + '\n' + "(1)Easy (2)Medium (3)Hard");
                int level = int.Parse(Console.ReadLine());
                int fret = 1;
                int correct = 0;
                char[,] fretBoard = new char[6, 7];
                fretBoard = OpenChords.ResetFretBoard(fretBoard);
                while (level != 1 && level != 2 && level != 3)
                {
                    Console.WriteLine("Wrong input, please enter 1, 2, or 3");
                    level = int.Parse(Console.ReadLine());
                }
                if (level == 1)
                {
                    Console.WriteLine("-----Difficulty: Easy-----");
                    EasyLevelQuestions(fretBoard, fret, ref correct);
                }
                else if (level == 2)
                {
                    Console.WriteLine("----Difficulty: Medium----");
                    MediumLevelQuestions(fretBoard, fret, ref correct);
                }
                else
                {
                    Console.WriteLine("-----Difficulty: Hard-----");
                    HardLevelQuestions(fretBoard, fret, ref correct);
                }
                Console.WriteLine("Points: {0} out of 4", correct);
                Console.WriteLine("Play again?" + '\n' + "(1)Yes (2)No");
                playAgain = int.Parse(Console.ReadLine());
            }
        }
        static bool TestScenario1OK()
        {
            bool noSameQuestions = true;
            int n = 10;
            int[] chosenQuestions = RandomQuestions(n);
            noSameQuestions = (chosenQuestions[0] != chosenQuestions[1]);
            return noSameQuestions;
        }
        static bool TestScenario2OK()
        {
            char[] openChordTest = new char[10];
            char[,] fretBoard = new char[6, 7];
            fretBoard = OpenChords.Cmajor(OpenChords.ResetFretBoard(fretBoard));
            openChordTest[0] = fretBoard[4, 2];
            fretBoard = OpenChords.Dminor(OpenChords.ResetFretBoard(fretBoard));
            openChordTest[1] = fretBoard[1, 2];
            fretBoard = OpenChords.Eminor(OpenChords.ResetFretBoard(fretBoard));
            openChordTest[2] = fretBoard[4, 1];
            fretBoard = OpenChords.Fmajor(OpenChords.ResetFretBoard(fretBoard));
            openChordTest[3] = fretBoard[3, 2];
            fretBoard = OpenChords.Gmajor(OpenChords.ResetFretBoard(fretBoard));
            openChordTest[4] = fretBoard[5, 2];
            fretBoard = OpenChords.Aminor(OpenChords.ResetFretBoard(fretBoard));
            openChordTest[5] = fretBoard[3, 1];
            fretBoard = OpenChords.Amajor(OpenChords.ResetFretBoard(fretBoard));
            openChordTest[6] = fretBoard[3, 1];
            fretBoard = OpenChords.Emajor(OpenChords.ResetFretBoard(fretBoard));
            openChordTest[7] = fretBoard[4, 1];
            fretBoard = OpenChords.Dmajor(OpenChords.ResetFretBoard(fretBoard));
            openChordTest[8] = fretBoard[1, 2];
            fretBoard = OpenChords.Fminor(OpenChords.ResetFretBoard(fretBoard));
            openChordTest[9] = fretBoard[3, 2];
            Random rand = new Random();
            int k = rand.Next() % 10;
            return (openChordTest[k] == 'O');
        }
        static bool TestScenario3OK()
        {
            char[] barreChordTest = new char[10];
            char[,] fretBoard = new char[6, 7];
            fretBoard = BarreChords.String6Major(OpenChords.ResetFretBoard(fretBoard));
            barreChordTest[0] = fretBoard[3, 1];
            fretBoard = BarreChords.String6Minor(OpenChords.ResetFretBoard(fretBoard));
            barreChordTest[1] = fretBoard[2, 1];
            fretBoard = BarreChords.String5Major(OpenChords.ResetFretBoard(fretBoard));
            barreChordTest[2] = fretBoard[1, 1];
            fretBoard = BarreChords.String5Minor(OpenChords.ResetFretBoard(fretBoard));
            barreChordTest[3] = fretBoard[1, 2];
            fretBoard = BarreChords.String6Seventh(OpenChords.ResetFretBoard(fretBoard));
            barreChordTest[4] = fretBoard[2, 2];
            fretBoard = BarreChords.String6MinorSeventh(OpenChords.ResetFretBoard(fretBoard));
            barreChordTest[5] = fretBoard[3, 2];
            fretBoard = BarreChords.String6MajorSeventh(OpenChords.ResetFretBoard(fretBoard));
            barreChordTest[6] = fretBoard[3, 2];
            fretBoard = BarreChords.String5Seventh(OpenChords.ResetFretBoard(fretBoard));
            barreChordTest[7] = fretBoard[2, 2];
            fretBoard = BarreChords.String5MinorSeventh(OpenChords.ResetFretBoard(fretBoard));
            barreChordTest[8] = fretBoard[1, 2];
            fretBoard = BarreChords.String5MajorSeventh(OpenChords.ResetFretBoard(fretBoard));
            barreChordTest[9] = fretBoard[2, 2];
            Random rand = new Random();
            int k = rand.Next() % 10;
            return (barreChordTest[k] == '-');
        }
        static bool TestScenario4OK()
        {
            char[,] fretBoard = new char[6, 7];
            int rootString = 1;
            int sumOfRootStrings = 0;
            fretBoard = Scales.ReturnAMajorScale(OpenChords.ResetFretBoard(fretBoard), ref rootString);
            sumOfRootStrings += rootString;
            fretBoard = Scales.ReturnAMinorScale(OpenChords.ResetFretBoard(fretBoard), ref rootString);
            sumOfRootStrings += rootString;
            fretBoard = Scales.ReturnAMajorPentatonicScale(OpenChords.ResetFretBoard(fretBoard), ref rootString);
            sumOfRootStrings += rootString;
            fretBoard = Scales.ReturnAMinorPentatonicScale(OpenChords.ResetFretBoard(fretBoard), ref rootString);
            sumOfRootStrings += rootString;
            return (sumOfRootStrings <= 20 && sumOfRootStrings >= 4);
        }
        static void DisplayFretBoard(char[,] fretBoard, int fret)
        {
            int i;
            int j;
            for (i = 0; i < 6; ++i)
            {
                for (j = 0; j < 7; ++j)
                {
                    Console.Write("+---{0}---", fretBoard[i, j]);
                }
                Console.WriteLine("+");
            }
            Console.WriteLine("  fret {0}", fret);
        }
        static int[] RandomQuestions(int n)
        {
            Random rand = new Random();
            int[] chosenQuestions = new int[4];
            int[] allQuestions = new int[n];
            bool again;
            int i;
            int j;
            int m;
            for (i = 0; i < n; ++i)
            {
                allQuestions[i] = i + 1;
            }
            for (i = 0; i < 4; ++i)
            {
                do
                {
                    m = rand.Next() % n;
                    again = false;
                    for (j = 0; j < i; ++j)
                    {
                        if (allQuestions[m] != chosenQuestions[j]) continue;
                        again = true;
                        break;
                    }
                } while (again);
                chosenQuestions[i] = allQuestions[m];
            }
            return chosenQuestions;
        }
        static void EasyLevelQuestions(char[,] fretBoard, int fret, ref int correct)
        {
            int correct = 0;
            int n = 10;
            int[] chosenQuestions = RandomQuestions(n);
            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine("Question{0}", i+1);
                switch (chosenQuestions[i])
                {
                    case 1:
                        fretBoard = OpenChords.Cmajor(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What chord is this?" + '\n' + "(1) C  (2) Am  (3) G");
                        int ans1 = int.Parse(Console.ReadLine());
                        if (ans1 != 1)
                        {
                            Console.WriteLine("Wrong answer! This is a C chord.");
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 2:
                        fretBoard = OpenChords.Dminor(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What chord is this?" + '\n' + "(1) F  (2) Em  (3) Dm");
                        int ans2 = int.Parse(Console.ReadLine());
                        if (ans2 != 3)
                        {
                            Console.WriteLine("Wrong answer! This is a Dm chord.");
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 3:
                        fretBoard = OpenChords.Eminor(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What chord is this?" + '\n' + "(1) Fm  (2) Em  (3) A");
                        int ans3 = int.Parse(Console.ReadLine());
                        if (ans3 != 2)
                        {
                            Console.WriteLine("Wrong answer! This is a Em chord.");
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 4:
                        fretBoard = OpenChords.Fmajor(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What chord is this?" + '\n' + "(1) F  (2) Fm  (3) E");
                        int ans4 = int.Parse(Console.ReadLine());
                        if (ans4 != 1)
                        {
                            Console.WriteLine("Wrong answer! This is a F chord.");
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 5:
                        fretBoard = OpenChords.Gmajor(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What chord is this?" + '\n' + "(1) Dm  (2) G  (3) C");
                        int ans5 = int.Parse(Console.ReadLine());
                        if (ans5 != 2)
                        {
                            Console.WriteLine("Wrong answer! This is a G chord.");
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 6:
                        fretBoard = OpenChords.Aminor(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What chord is this?" + '\n' + "(1) Em  (2) A  (3) Am");
                        int ans6 = int.Parse(Console.ReadLine());
                        if (ans6 != 3)
                        {
                            Console.WriteLine("Wrong answer! This is a Am chord.");
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 7:
                        fretBoard = OpenChords.Amajor(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What chord is this?" + '\n' + "(1) Fm  (2) A  (3) E");
                        int ans7 = int.Parse(Console.ReadLine());
                        if (ans7 != 2)
                        {
                            Console.WriteLine("Wrong answer! This is a A chord.");
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 8:
                        fretBoard = OpenChords.Emajor(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What chord is this?" + '\n' + "(1) D  (2) F  (3) E");
                        int ans8 = int.Parse(Console.ReadLine());
                        if (ans8 != 3)
                        {
                            Console.WriteLine("Wrong answer! This is a E chord.");
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 9:
                        fretBoard = OpenChords.Dmajor(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What chord is this?" + '\n' + "(1) D  (2) Dm  (3) Em");
                        int ans9 = int.Parse(Console.ReadLine());
                        if (ans9 != 1)
                        {
                            Console.WriteLine("Wrong answer! This is a D chord.");
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 10:
                        fretBoard = OpenChords.Fminor(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What chord is this?" + '\n' + "(1) Fm  (2) Em  (3) Am");
                        int ans10 = int.Parse(Console.ReadLine());
                        if (ans10 != 1)
                        {
                            Console.WriteLine("Wrong answer! This is a Fm chord.");
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                }
            }
        }
        static void MediumLevelQuestions(char[,] fretBoard, int fret, ref int correct)
        {
            int n = 10;
            Random rand = new Random();
            int[] chosenQuestions = RandomQuestions(n);
            int[] randomFrets = new int[4];
            string[,] notes = Scales.Notes();
            for (int i = 0; i < 4; ++i)
            {
                randomFrets[i] = rand.Next() % 6 + 1;
            }
            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine("Question{0}", i + 1);
                fret = randomFrets[i];
                switch (chosenQuestions[i])
                {
                    case 1:
                        fretBoard = BarreChords.String6Major(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("Which shape is this?" + '\n' + "(1)Major  (2)Minor  (3)Seventh (4) Minor Seventh (5)Major Seventh");
                        int ans11 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[5, fret + 1], notes[4, fret + 2], notes[5, fret]);
                        int ans12 = int.Parse(Console.ReadLine());
                        if (ans11 != 1 || ans12 != 3)
                        {
                            Console.WriteLine("Wrong answer! This is a E Major shape with root note {0}.", notes[5, fret]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 2:
                        fretBoard = BarreChords.String6Minor(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("Which shape is this?" + '\n' + "(1)Major  (2)Minor  (3)Seventh (4) Minor Seventh (5)Major Seventh");
                        int ans21 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[5, fret], notes[4, fret + 2], notes[5, fret + 1]);
                        int ans22 = int.Parse(Console.ReadLine());
                        if (ans21 != 2 || ans22 != 1)
                        {
                            Console.WriteLine("Wrong answer! This is a E minor shape with root note {0}.", notes[5, fret]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 3:
                        fretBoard = BarreChords.String5Major(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("Which shape is this?" + '\n' + "(1)Major  (2)Minor  (3)Seventh (4) Minor Seventh (5)Major Seventh");
                        int ans31 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[5, fret], notes[4, fret + 1], notes[4, fret]);
                        int ans32 = int.Parse(Console.ReadLine());
                        if (ans31 != 1 || ans32 != 3)
                        {
                            Console.WriteLine("Wrong answer! This is a A Major shape with root note {0}.", notes[4, fret]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 4:
                        fretBoard = BarreChords.String5Minor(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("Which shape is this?" + '\n' + "(1)Major  (2)Minor  (3)Seventh (4) Minor Seventh (5)Major Seventh");
                        int ans41 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[4, fret + 2], notes[4, fret], notes[5, fret]);
                        int ans42 = int.Parse(Console.ReadLine());
                        if (ans41 != 2 || ans42 != 2)
                        {
                            Console.WriteLine("Wrong answer! This is a A minor shape with root note {0}.", notes[4, fret]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 5:
                        fretBoard = BarreChords.String6Seventh(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("Which shape is this?" + '\n' + "(1)Major  (2)Minor  (3)Seventh (4) Minor Seventh (5)Major Seventh");
                        int ans51 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[5, fret + 3], notes[5, fret], notes[4, fret + 1]);
                        int ans52 = int.Parse(Console.ReadLine());
                        if (ans51 != 3 || ans52 != 2)
                        {
                            Console.WriteLine("Wrong answer! This is a E7 shape with root note {0}.", notes[5, fret]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 6:
                        fretBoard = BarreChords.String6MinorSeventh(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("Which shape is this?" + '\n' + "(1)Major  (2)Minor  (3)Seventh (4) Minor Seventh (5)Major Seventh");
                        int ans61 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[4, fret + 1], notes[4, fret + 3], notes[5, fret]);
                        int ans62 = int.Parse(Console.ReadLine());
                        if (ans61 != 4 || ans62 != 3)
                        {
                            Console.WriteLine("Wrong answer! This is a Em7 shape with root note {0}.", notes[5, fret]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 7:
                        fretBoard = BarreChords.String6MajorSeventh(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("Which shape is this?" + '\n' + "(1)Major  (2)Minor  (3)Seventh (4) Minor Seventh (5)Major Seventh");
                        int ans71 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[5, fret], notes[4, fret + 1], notes[5, fret + 4]);
                        int ans72 = int.Parse(Console.ReadLine());
                        if (ans71 != 5 || ans72 != 1)
                        {
                            Console.WriteLine("Wrong answer! This is a Emaj7 shape with root note {0}.", notes[5, fret]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 8:
                        fretBoard = BarreChords.String5Seventh(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("Which shape is this?" + '\n' + "(1)Major  (2)Minor  (3)Seventh (4) Minor Seventh (5)Major Seventh");
                        int ans81 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[5, fret + 1], notes[4, fret], notes[4, fret + 2]);
                        int ans82 = int.Parse(Console.ReadLine());
                        if (ans81 != 3 || ans82 != 2)
                        {
                            Console.WriteLine("Wrong answer! This is a A7 shape with root note {0}.", notes[4, fret]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 9:
                        fretBoard = BarreChords.String5MinorSeventh(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("Which shape is this?" + '\n' + "(1)Major  (2)Minor  (3)Seventh (4) Minor Seventh (5)Major Seventh");
                        int ans91 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[4, fret], notes[5, fret], notes[5, fret + 2]);
                        int ans92 = int.Parse(Console.ReadLine());
                        if (ans91 != 4 || ans92 != 1)
                        {
                            Console.WriteLine("Wrong answer! This is a Am7 shape with root note {0}.", notes[4, fret]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 10:
                        fretBoard = BarreChords.String5MajorSeventh(OpenChords.ResetFretBoard(fretBoard));
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("Which shape is this?" + '\n' + "(1)Major  (2)Minor  (3)Seventh (4) Minor Seventh (5)Major Seventh");
                        int ans101 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[4, fret + 2], notes[4, fret], notes[5, fret]);
                        int ans102 = int.Parse(Console.ReadLine());
                        if (ans101 != 5 || ans102 != 2)
                        {
                            Console.WriteLine("Wrong answer! This is a Amaj7 shape with root note {0}.", notes[4, fret]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                }
            }
        }
        static void HardLevelQuestions(char[,] fretBoard, int fret, ref int correct)
        {
            Random rand = new Random();
            int rootString = 0;
            int n = 4;
            int[] scrambleQuestions = RandomQuestions(n);
            int[] randomFrets = new int[4];
            string[,] notes = Scales.Notes();
            for (int i = 0; i < 4; ++i)
            {
                randomFrets[i] = rand.Next() % 6 + 1;
            }
            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine("Question{0}", i + 1);
                fret = randomFrets[i];
                switch (scrambleQuestions[i])
                {
                    case 1:
                        fretBoard = Scales.ReturnAMajorScale(OpenChords.ResetFretBoard(fretBoard), ref rootString);
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What kind of scale is this?" + '\n' + "(1)Major  (2)Minor (3)Major Pentatonic (4)Minor Pentatonic");
                        int ans11 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[rootString, fret + 1], notes[rootString, fret + 2], notes[rootString, fret + 3]);
                        int ans12 = int.Parse(Console.ReadLine());
                        if (ans11 != 1 || ans12 != 1)
                        {
                            Console.WriteLine("Wrong answer! This is a Major scale with root note {0}.", notes[rootString, fret + 1]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 2:
                        fretBoard = Scales.ReturnAMinorScale(OpenChords.ResetFretBoard(fretBoard), ref rootString);
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What kind of scale is this?" + '\n' + "(1)Major  (2)Minor (3)Major Pentatonic (4)Minor Pentatonic");
                        int ans21 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[rootString, fret], notes[rootString, fret - 1], notes[rootString, fret + 1]);
                        int ans22 = int.Parse(Console.ReadLine());
                        if (ans21 != 2 || ans22 != 3)
                        {
                            Console.WriteLine("Wrong answer! This is a Minor scale with root note {0}.", notes[rootString, fret + 1]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 3:
                        fretBoard = Scales.ReturnAMajorPentatonicScale(OpenChords.ResetFretBoard(fretBoard), ref rootString);
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What kind of scale is this?" + '\n' + "(1)Major  (2)Minor (3)Major Pentatonic (4)Minor Pentatonic");
                        int ans31 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[rootString, fret + 2], notes[rootString, fret + 1], notes[rootString, fret + 3]);
                        int ans32 = int.Parse(Console.ReadLine());
                        if (ans31 != 3 || ans32 != 2)
                        {
                            Console.WriteLine("Wrong answer! This is a Major pentatonic scale with root note {0}.", notes[rootString, fret + 1]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                    case 4:
                        fretBoard = Scales.ReturnAMinorPentatonicScale(OpenChords.ResetFretBoard(fretBoard), ref rootString);
                        DisplayFretBoard(fretBoard, fret);
                        Console.WriteLine("What kind of scale is this?" + '\n' + "(1)Major  (2)Minor (3)Major Pentatonic (4)Minor Pentatonic");
                        int ans41 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Which is the root note?" + '\n' + "(1) {0}  (2) {1}  (3) {2}", notes[rootString, fret - 1], notes[rootString, fret], notes[rootString, fret + 1]);
                        int ans42 = int.Parse(Console.ReadLine());
                        if (ans41 != 4 || ans42 != 3)
                        {
                            Console.WriteLine("Wrong answer! This is a minor pentatonic scale with root note {0}.", notes[rootString, fret + 1]);
                        }
                        else
                        {
                            Console.WriteLine("Correct!");
                            ++correct;
                        }
                        break;
                }
            }
        }
    }
}
