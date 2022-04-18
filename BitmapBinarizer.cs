using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace KG1
{
    static class BitmapBinarizer
    {

        public static int[,] BoundaryMatrix(int depth)
        {
            int sz = 1 << depth;
            int[,] res = new int[sz, sz];

            for (int i = 0; i < sz; i++)
            {
                for (int j = 0; j < sz; j++)
                {
                    for (int k = 0; k < depth; k++)
                    {
                        res[i, j] = res[i, j] * 4 + (i.BitAt(k) * 3 + j.BitAt(k) * 2) % 4; 
                    }
                }
            }
            return res;
        }

        public static Bitmap Binarize(BitmapWrapper bm, int depth = 1)
        {
            int[,] bounds = BoundaryMatrix(depth);
            bm.Lock();
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    if (bm[x, y].R < bounds[y % (1 << depth), x % (1 << depth)] * 256 / (1 << (2 * depth)))
                    {
                        bm[x, y] = Color.Black;
                    }
                    else bm[x, y] = Color.White;
                }
            }
            bm.Unlock();
            return bm;
        }
    }
}
