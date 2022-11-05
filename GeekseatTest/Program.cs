using System;

namespace GeekseatTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            string ageA, ageB, yearA, yearB;
            int valueAgeA, valueAgeB, valueYearA, valueYearB, valueA, valueB;
            int[] result;
            while (true)
            {
                Console.WriteLine(Helpers.personA);
                Console.Write(Helpers.ageofDeath);
                ageA = Console.ReadLine().Trim();
                Console.Write(Helpers.yearofDeath);
                yearA = Console.ReadLine().Trim();
                Console.WriteLine("\n----------------------\n");
                Console.WriteLine(Helpers.personB);
                Console.Write(Helpers.ageofDeath);
                ageB = Console.ReadLine().Trim();
                Console.Write(Helpers.yearofDeath);
                yearB = Console.ReadLine().Trim();

                //Validation Data
                if (!Int32.TryParse(ageA, out valueAgeA) ||
                    !Int32.TryParse(yearA, out valueYearA) ||
                    !Int32.TryParse(ageB, out valueAgeB) ||
                    !Int32.TryParse(yearB, out valueYearB) ||
                    ((valueYearA - valueAgeA) < 0) ||
                    ((valueYearB - valueAgeB) < 0))
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine(Helpers.notValid);
                    Console.WriteLine(Helpers.messageNotValid);
                }
                else
                {
                    //Function to Calculation for Person A
                    Console.WriteLine("\n----------------------\n");
                    result = cal.GetKilled(valueAgeA, valueYearA);
                    string resultA = String.Format(Helpers.result, new object[6] {
                        Helpers.personA, valueYearA, valueAgeA, result[0], result[0], result[1]
                    });
                    valueA = result[1];
                    Console.WriteLine("{0}", resultA);

                    //Function to Calculation for Person B
                    result = cal.GetKilled(valueAgeB, valueYearB);
                    string resultB = String.Format(Helpers.result, new object[6] {
                        Helpers.personB, valueYearB, valueAgeB, result[0], result[0], result[1]
                    });
                    valueB = result[1];
                    Console.WriteLine("{0}", resultB);

                    //Function Average
                    double Average = cal.AVG(valueA, valueB);
                    Console.WriteLine(Helpers.Average, new object[3] {
                        valueA,valueB,Average
                    });
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
