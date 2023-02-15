using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    public class Patterns
    {
        public static void SolidRectangle()
        {
            Console.WriteLine("Enter a Row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Colomn");
            int colomn = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colomn; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();
        }

        public static void HollowRectangle()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Colomn");
            int colomn = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= colomn; j++)
                {
                    if (i == 1 || i == row || j == 1 || j == colomn)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void HalfPyramid()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Colomn");
            int colomn = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();
        }

        public static void InvertedHalfPyramid()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Colomn");
            int colomn = Convert.ToInt32(Console.ReadLine());

            for (int i = row; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();

        }

        public static void HollowInvertedHalfPyramid()
        {

            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Colomn");
            int colomn = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = row; j >= i; j--)
                {
                    if (i == 1 || j == colomn || j == i || i == row)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine();
            }
        }

        public static void Halfpyramid180degRotation()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= row; i++)// row
            {
                for (int j = row - 1; j >= i; j--) // space
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++) //print
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Fullpyramid()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= row; i++)// row
            {
                for (int j = row - 1; j >= i; j--) // space
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++) //print
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void InvertedFullPyramid()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = row; i >= 1; i--)// row
            {
                for (int j = row - 1; j >= i; j--) // space
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++) //print
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void HollowFullPyramid()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= row; i++)// row
            {
                for (int j = row - 1; j >= i; j--) // space
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++) //print
                {
                    if (i == 1 || i == row || k == 1 || k == i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void InvertedHollowFullPyramid()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = row; i >= 1; i--)// row
            {
                for (int j = row - 1; j >= i; j--) // space
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++) //print
                {
                    if (i == 1 || i == row || k == 1 || k == i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }


        public static void HalfPyramidUsingNumber()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j > 10)
                    {
                        Console.Write(j + " " + " ");
                    }
                    else
                    {
                        Console.Write(j + "   ");
                    }
                }
                Console.WriteLine();
            }
        }


        public static void InvertedHalfPyramidUsingNumber()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Colomn");
            int colomn = Convert.ToInt32(Console.ReadLine());

            for (int i = row; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j > 10)
                    {
                        Console.Write(j + " " + " ");
                    }
                    else
                    {
                        Console.Write(j + "   ");
                        
                    }
                }
                Console.WriteLine();
            }
        }


        public static void HalfPyramidUsingNumberI()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i >= 10)
                    {
                        Console.Write(i + " " + " ");
                    }
                    else
                    {
                        Console.Write(i + "   ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void InvertedHalfPyramidUsingNumberI()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Colomn");
            int colomn = Convert.ToInt32(Console.ReadLine());

            for (int i = row; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i >= 10)
                    {
                        Console.Write(i + " " + " ");
                    }
                    else
                    {
                        Console.Write(i + "   ");

                    }
                }
                Console.WriteLine();
            }
        }

        public static void HollowHalfPyramidUsingNumberJ()
        {

            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Colomn");
            int colomn = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || i == j || i == row || j<10)
                    {
                        Console.Write(j+" "+" ");
                    }
                    else
                    {
                        Console.WriteLine(j+ " ");
                    }
                    
                }
                Console.WriteLine();
            }
            
        }


        public static void pattern()
        {
            bool choice1 = true;
            string ch1;

            while (choice1)
            {
                Console.WriteLine("Press 1 to Solid Rectangle");
                Console.WriteLine("Press 2 to Hollow Rectangle");
                Console.WriteLine("Press 3 to Half Pyramid");
                Console.WriteLine("Press 4 to Inverted Half Pyramid");
                Console.WriteLine("Press 5 to Hollow Inverted Half Pyramind");
                Console.WriteLine("Press 6 to Half Pyramind 180deg Rotation");
                Console.WriteLine("Press 7 to Full Pyramind");
                Console.WriteLine("Press 8 to Inverted Full Pyramind");
                Console.WriteLine("Press 9 to Hollow Full Pyramind");
                Console.WriteLine("Press 10 to Inverted Hollow Full Pyramid");
                Console.WriteLine("Press 11 to Half Pyramid Using Number");
                Console.WriteLine("Press 12 to Inverted Half Pyramid Using Number");
                Console.WriteLine("Press 13 to Half Pyramid Using Number i");
                Console.WriteLine("Press 14 to Inverted Pyramid Using Number i");
                Console.WriteLine("Press 15 to Hollow Half Pyramid Using Number j");



                int key1 = Convert.ToInt32(Console.ReadLine());
                switch (key1)
                {
                    case 1:
                        Patterns.SolidRectangle();
                        break;
                    case 2:
                        Patterns.HollowRectangle();
                        break;
                    case 3:
                        Patterns.HalfPyramid();
                        break;
                    case 4:
                        Patterns.InvertedHalfPyramid();
                        break;
                    case 5:
                        Patterns.HollowInvertedHalfPyramid();
                        break;
                    case 6:
                        Patterns.Halfpyramid180degRotation();
                        break;
                    case 7:
                        Patterns.Fullpyramid();
                        break;
                    case 8:
                        Patterns.InvertedFullPyramid();
                        break;
                    case 9:
                        Patterns.HollowFullPyramid();
                        break;
                    case 10:
                        Patterns.InvertedHollowFullPyramid();
                        break;
                    case 11:
                        Patterns.HalfPyramidUsingNumber();
                        break;
                    case 12:
                        Patterns.InvertedHalfPyramidUsingNumber();
                        break;
                    case 13:
                        Patterns.HalfPyramidUsingNumberI();
                        break;
                    case 14:
                        Patterns.InvertedHalfPyramidUsingNumberI();
                        break;
                    case 15:
                        Patterns.HollowHalfPyramidUsingNumberJ();
                        break;


                }
                Console.WriteLine("Would you like to continue (Y/N)");

                ch1 = Console.ReadLine();
                Console.WriteLine("PRESS ENTER TO CONTINUE");
                ch1 = ch1.ToUpper();

                if (ch1 == "Y")
                {
                    choice1 = true;
                }
                else
                {
                    choice1 = false;
                    Console.WriteLine("Thank You Visit Again");
                }
                Console.ReadKey();
            }
        }

    }
}

