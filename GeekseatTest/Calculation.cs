using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekseatTest
{
    class Calculation
    {
        private int num;
        private int sum;
        public int[] GetKilled(int age, int year)
        {
            int data1 = 1, data2 = 1, data3, i;
            num = year - age;

            if (num < 3)
                return new int[2] { num, num };

            sum = data1 + data2;
            for (i = 2; i < num; i++)
            {
                data3 = data1 + data2;
                sum += data3;
                data1 = data2;
                data2 = data3;
            }
            return new int[2] { num, sum };
        }

        public double AVG(int valueA, int valueB) => (double)(valueA + valueB) / 2;
    }
}
