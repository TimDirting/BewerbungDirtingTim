using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BewerbungDirtingTim
{
    class KnightTour
    {
        
        public int N;
        public int[,] chessfield;

        int[] xmove = { 2, 1, -1, -2, -2, -1, 1, 2 };
        int[] ymove = { 1, 2, 2, 1, -1, -2, -2, -1 };

        /// <summary>
        /// Init KnightTour \ fill field with -1
        /// </summary>
        /// <param name="point">Start Point</param>
        /// <param name="dimension"> Size of the (chess)Field</param>
        public KnightTour( int dimension)
        {
       
            N = dimension;

            chessfield = new int[N, N];

            // Fill Field
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    chessfield[i, j] = -1;
                }
            }

        }
        /// <summary>
        /// Check if Field contains -1 
        /// </summary>
        /// <returns>True if no -1 in field</returns>
        public bool isSolved()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (chessfield[i, j] == -1)
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Check the limit for the dimension
        /// </summary>
        /// <param name="x">Next Step X</param>
        /// <param name="y">Next Step Y</param>
        /// <param name="field">Field [dim,dim]</param>
        /// <returns>true if in limit</returns>
        private bool isInLimit(int x, int y, int[,] field)
        {
            return (x >= 0 && x < N && y >= 0 && y < N && field[x, y] == -1);
        }


        /// <summary>
        /// Recursive knight's tour
        /// </summary>
        /// <param name="x">Starting Point X</param>
        /// <param name="y">Starting Point Y</param>
        /// <param name="number">Current position (Start with 0)</param>
        /// <returns></returns>
        public bool solve(int x, int y, int number)
        {
            int xnext, ynext;

            if (N * N == number)
                return true;
                

            for (int k = 0; k < 8; k++)
            {
                xnext = x + xmove[k];
                ynext = y + ymove[k];
                if (isInLimit(xnext, ynext, chessfield))
                {
                    chessfield[xnext, ynext] = number;
                    if (solve(xnext, ynext, number + 1))
                        return true;
                    else
                        chessfield[xnext, ynext] = -1;
                }
            }
            return false;
        }



      

    }




    
}
