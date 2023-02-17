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


            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || i == 1 || i == row || j == i)
                    {
                        Console.Write(j + " " + " ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                }
                Console.WriteLine();
            }
        }
        

        public static void HollowInvertedHalfPyramidUsingNumberJ()
        {

            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= row; i++)
            {
                for (int j = row; j >= i; j--)
                {
                    if (j == i || i == 1 || i == row || j==row)
                    {
                        Console.Write(j+" "+" ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                    
                }
                Console.WriteLine();
            }
            
        }


        public static void FloyedsTriangle()
        {
            Console.WriteLine("Enter a Row: ");
            int row = Convert.ToInt32(Console.ReadLine());
           
            int count = 0;

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    if (count >= 10)
                    {
                        Console.Write(count+ " ");

                    }
                    else
                    {
                        
                        Console.Write(count+ "  ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void ZeroOnePattern()
        {
            Console.WriteLine("Enter a Row: ");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if(j%2== 0)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write(1);
                 
                    }                    
                }
                Console.WriteLine();
            }
        }

        public static void NumberPyramidI()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= row; i++)// row
            {
                for (int j = row - 1; j >= i; j--) // space
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= i; k++) //print
                {
                    if (i >= 10)
                    {
                        Console.Write(i + "  ");
                    }
                    else
                    {
                        Console.Write(i + "   ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
        
        public static void NumberPyramidJ()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= row; i++)// row
            {
                for (int j = row-1; j >= i; j--) // space
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= i; k++) //print
                {
                    if (k >= 10)
                    {
                        Console.Write(k + "  ");
                    }
                    else
                    {
                        Console.Write(k + "   ");
                    }
                    
                }
                Console.WriteLine();
            }
        }


        public static void HollowNumberPyramidI()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= row; i++)// row
            {
                for (int j = row-1; j >= i; j--) // space
                {
                    Console.Write("  ");
                }
                for (int k = 1;k <= i; k++) //print
                {
                    if (i == 1 || i == row || k == 1 || k == i)
                    {
                        if(i>=10)
                        {
                            Console.Write(i + "  ");

                        }
                        else
                        {
                            Console.Write(i + "   "); 
                        }
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();
            }
        }


        public static void HollowNumberPyramidJ()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= row; i++)// row
            {
                for (int j = row - 1; j >= i; j--) // space
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= i; k++) //print
                {
                    if (i == 1 || i == row || k == 1 || k == i)
                    {
                        if (k >= 10)
                        {
                            Console.Write(k + "  ");

                        }
                        else
                        {
                            Console.Write(k + "   ");
                        }
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();
            }
        }


        public static void HollowNumberPyramidPrintBoth1()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= row; i++)// row
            {
                for (int j = row - 1; j >= i; j--) // space
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= i; k++) //print
                {
                    if (i == 1 || i == row || k == 1 || k == i)
                    {
                        if (1 >= 10)
                        {
                            Console.Write(1 + "  ");

                        }
                        else
                        {
                            Console.Write(1 + "   ");
                        }
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void HollowNumberPyramidPrintBoth2()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= row; i++)// row
            {
                for (int j = row - 1; j >= i; j--) // space
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= i; k++) //print
                {
                    if (i == 1 || i == row || k == 1 || k == i)
                    {
                        if (2 >= 10)
                        {
                            Console.Write(2 + "  ");

                        }
                        else
                        {
                            Console.Write(2 + "   ");
                        }
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();
            }
        }


        public static void PalindromicNumberPyramid()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= row; i++)// row
            {
                for (int j = i; j <= row; j++) // space
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= i; k++) //print
                {
                    if (k >= 10)
                    {
                        Console.Write(k + " ");
                    }
                    else
                    {
                        Console.Write(k + " ");
                    }

                }
                for (int j = i - 1; j >= 1; j--) // space
                {
                    if (j >= 10)
                    {
                        Console.Write(j + " ");
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }
                   
                }
                Console.WriteLine();
            }
        }

        public static void DifferentTypeOfPalindromePyramid()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= row; i++)// row
            {
               
                for (int j = 1; j <= i; j++) //print
                {
                    if (j >= 10)

                    {
                        Console.Write(j + " ");
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }

                }
                for (int j = i - 1; j >= 1; j--) // space
                {
                    if (j >= 10)
                    {
                        Console.Write(j + " ");
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }
                   
                }
                Console.WriteLine();
            }
        }

        public static void PascalTriangle()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());
            int k;
            int j;
            int val=1;
            for (int i = 0; i < row; i++)
            {
                for(k = 1; k <= row - i; k++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                    
                        val= 1;
                    
                    else
                    
                        val=val*(i-j+1)/j;
                        Console.Write(val+" ");
                    
                }
                Console.WriteLine() ;
             }
        }

        public static void ZigZag()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a colomn");
            int colomn = Convert.ToInt32(Console.ReadLine());
            
            for(int i=1; i <= row; i++)
            {
                for(int j = 1; j <= colomn; j++)
                {
                    if(((i+j)%4==0) || (i==2 && j % 4 == 0))
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

        public static void Diamond()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = row - 1; i >= 1; i--)
            {
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void HollowDiamond()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= row; i++)
            {
                for(int j = 1; j <= row-i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= 2*i-1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
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

            for (int i = row-1; i >= 1; i--)
            {
                for (int j = 1; j <= row-i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= 2*i-1; k++)
                
                {
                    if (k == 1 || k == 2 * i - 1)
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


        public static void FillHollowDiamond()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        
                        Console.Write(i-1);
                    }

                }
                Console.WriteLine();
            }

            for (int i = row-1; i >= 1; i--)
            {
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)

                {
                    if (k == 1 || k == 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(i-1);
                    }
                }
                Console.WriteLine();
            }
        }

        public static void KshapPattern()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());
            int k = -1;



            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (j == 1 || i + j == 5 || i > 4 && i + j == k)
                    {
                        Console.Write("kk");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
                k = k + 2;
            }
        }

        public static void KLogic()
        {

            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());
          

            for (int i = 1; i <= row-1; i++)
            {
                for (int j = row; j >= i; j--)
                {
                    if (i==1&&j==2 || i == 1 && j == 3|| i == 1 && j == 4)
                    {
                        Console.Write(" ");
                    }
                    else if(i == 1 || j == row || j == i || i == row||j==1)
                    {
                        Console.Write("k");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine();
            }

            for (int i = row; i >= 1; i--)
            {
                for (int j = row; j >= i; j--)
                {
                    if (i == 1 && j == 2 || i == 1 && j == 3 || i == 1 && j == 4)
                    {
                        Console.Write(" ");

                    }
                    else if (i == 1 || j == row || j == i || i == row||j==1 )
                    {
                        Console.Write("k");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine();
            }

        }

        public static void SolidHalfDiamoundUsingstars()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= row; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
            for (int i = row-1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        
        public static void DifferentTypeOfSolidHalfDiamound()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= row; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (i >= 10)
                    {
                        Console.Write(i+" ");
                    }
                    else
                    {
                        Console.Write(i+"  ");
                    }
                    
                }
                Console.WriteLine();
            }
            for (int i = row-1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if(i >= 10)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.Write(i+"  ");
                    }

                }
                Console.WriteLine();
            }
        }

        public static void HollowDiamondInscribedInARectangle()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write("*");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for (int i = row; i >= 1; i--)
            {
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write("*");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }

        public static void SolidRhombus()
        {
            Console.WriteLine("Enter a Row");
            int row=Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= row; i++)
            {
                for(int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= row; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void HollowSolidRhombus()
        {
            Console.WriteLine("Enter a Row");
            int row=Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= row; i++)
            {
                for(int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= row; j++)
                {
                    if (i == 1 || i == row || j == 1 || j == row)
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

        public static void SolidButterfly()
        {
            Console.WriteLine("Enter a Row");
            int row= Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= 2 * (row - i); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = row; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= 2 * (row - i); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static void HollowSolidButterfly()
        {
            Console.WriteLine("Enter a Row");
            int row= Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == 1 || j == 1 || j == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                for (int j = 1; j <= 2 * (row - i); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    if (i == 1  || j == 1 || j == i)
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

            for (int i = row; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == 1 || j == 1 || j == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                for (int j = 1; j <= 2 * (row - i); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    if (i == 1 || j == 1 || j == i)
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


        public static void DiagonalAndSidesOfARectangle()
        {
            Console.WriteLine("Enter a Row");
            int row = Convert.ToInt32(Console.ReadLine());

            if (row % 2 != 0)
            {
                for(int i = 0; i < row; i++)
                {
                    for(int j = 0; j < row; j++)
                    {
                        if (i == 0 || j == 0 || i == j || i == row - 1 || j == row - 1 || i + j == row - 1)
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
            else
            {
                Console.Write("Give a Correct output: odd number");
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
                Console.WriteLine("Press 16 to Hollow Inverted Half Pyramid Using Number j");
                Console.WriteLine("Press 17 to Floyed's Triangle");
                Console.WriteLine("Press 18 to Zero One Pattern");
                Console.WriteLine("Press 19 to Number Pyramid i");
                Console.WriteLine("Press 20 to Number Pyramid j");
                Console.WriteLine("Press 21 to Hollow Number Pyramid i");
                Console.WriteLine("Press 22 to Hollow Number Pyramid j");
                Console.WriteLine("Press 23 to Hollow Number Pyramid Print Both 1");
                Console.WriteLine("Press 24 to Hollow Number Pyramid Print Both 2");
                Console.WriteLine("Press 25 to Palindromic Number  Pyramid(Full Pyramid)");
                Console.WriteLine("Press 26 to Different Type Of Palindrome pyramids");
                Console.WriteLine("Press 27 to Pascal Triangle");
                Console.WriteLine("Press 28 to ZigZag");
                Console.WriteLine("Press 29 to Diamond Using Stars");
                Console.WriteLine("Press 30 to Hollow Diamond Using Stars");
                Console.WriteLine("Press 31 to Fill Hollow Diamond");
                Console.WriteLine("Press 32 to K Shap Patterns");
                Console.WriteLine("Press 33 to K Logic");
                Console.WriteLine("Press 34 to Solid Half Diamond Using Stars");
                Console.WriteLine("Press 35 to Different Type Of Solid Half Diamound");
                Console.WriteLine("Press 36 to Hollow Diamound Inscribed in a rectangle");
                Console.WriteLine("Press 37 to Solid Rgombus");
                Console.WriteLine("Press 38 to Hollow Solid Rgombus");
                Console.WriteLine("Press 39 to Solid Butterfly");
                Console.WriteLine("Press 40 to Hollow Solid Butterfly");
                Console.WriteLine("Press 41 to Diagonal And Sides Of A Rectangle");


                





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
                    case 16:
                        Patterns.HollowInvertedHalfPyramidUsingNumberJ();
                        break;
                    case 17:
                        Patterns.FloyedsTriangle();
                        break;
                    case 18:
                        Patterns.ZeroOnePattern();
                        break;
                    case 19:
                        Patterns.NumberPyramidI();
                        break;
                    case 20:
                        Patterns.NumberPyramidJ();
                        break;
                    case 21:
                        Patterns.HollowNumberPyramidI();
                        break;
                    case 22:
                        Patterns.HollowNumberPyramidJ();
                        break;
                    case 23:
                        Patterns.HollowNumberPyramidPrintBoth1();
                        break;
                    case 24:
                        Patterns.HollowNumberPyramidPrintBoth2();
                        break;
                    case 25:
                        Patterns.PalindromicNumberPyramid();
                        break;
                    case 26:
                        Patterns.DifferentTypeOfPalindromePyramid();
                        break;
                    case 27:
                        Patterns.PascalTriangle();
                        break;
                    case 28:
                        Patterns.ZigZag();
                        break;
                    case 29:
                        Patterns.Diamond();
                        break;
                    case 30:
                        Patterns.HollowDiamond();
                        break;
                    case 31:
                        Patterns.FillHollowDiamond();
                        break;
                    case 32:
                        Patterns.KshapPattern();
                        break;
                    case 33:
                        Patterns.KLogic();
                        break;
                    case 34:
                        Patterns.SolidHalfDiamoundUsingstars();
                        break;
                    case 35:
                        Patterns.DifferentTypeOfSolidHalfDiamound();
                        break;
                    case 36:
                        Patterns.HollowDiamondInscribedInARectangle(); 
                        break;
                    case 37:
                        Patterns.SolidRhombus();
                        break;
                    case 38:
                        Patterns.HollowSolidRhombus();
                        break;
                    case 39:
                        Patterns.SolidButterfly();
                        break;
                    case 40:
                        Patterns.HollowSolidButterfly();
                        break;
                    case 41:
                        Patterns.DiagonalAndSidesOfARectangle();
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

