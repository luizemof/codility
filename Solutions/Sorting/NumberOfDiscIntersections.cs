using System;
namespace Codility.Solutions.Sorting
{
    // https://app.codility.com/programmers/lessons/6-sorting/number_of_disc_intersections/
    public class NumberOfDiscIntersections
    {
        private class Points : IComparable
        {
            public long A { get; set; }
            public long B { get; set; }

            public int CompareTo(object obj)
            {
                return CompareTo(obj as Points);
            }

            public int CompareTo(Points obj)
            {
                return this.A.CompareTo(obj.A);
            }
        }

        public int Solution(int[] A)
        {
            int N = A.Length;
            int result = 0;
            Points[] points = new Points[N];

            for (int i = 0; i < N; i++)
            {
                points[i] = new Points() { A = i - (long)A[i], B = i + (long)A[i] };
            }

            Array.Sort(points);

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if ((points[j].A >= points[i].A && points[j].A <= points[i].B)
                        ||
                        (points[i].A >= points[j].A && points[i].A <= points[j].B)
                        ||
                        (points[i].A >= points[j].A && points[i].B <= points[j].B )
                        ||
                        (points[j].A >= points[i].A && points[j].B <= points[i].B))
                    {
                        result++;
                    }
                }
                if (result > 10000000)
                {
                    return -1;
                }
            }


            return result;
        }
    }
}