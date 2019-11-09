using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            int [,] Matrix  =  BuidArray(length);

            Console.WriteLine("The matrix is ");
            PrintArray(Matrix,length);     
            Console.WriteLine("Upper triangle ");
            PrintTrianguar(Matrix,length);
            

            Console.ReadKey();
        }


        static int[,] BuidArray(int length)
        {
            
            int[,] Matrix = new int[length, length];
            Random rand = new Random();           
            for (int i = 0; i < length; i++) 
            {
                for (int j = 0; j < length; j++)
                {      
                   Matrix[i, j] = rand.Next(1,10);
                }
            }

            return Matrix;
        }

        static void PrintArray(int [,] Matrix,int length)
        {
             for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        static void PrintTrianguar(int [,] Matrix,int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (i !=0) 
                { 
                 for (int j = i; j > 0; j--)
                 {
                    Console.Write("0");
                 }
                }

                for (int j = i; j < length; j++)
                {
                    Console.Write(Matrix[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
