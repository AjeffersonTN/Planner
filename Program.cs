using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue")
            {
                Stories = 4,
                Width = 205.56,
                Depth = 142.87,

            };
            FiveOneTwoEight.Construct();
            FiveOneTwoEight.Purchase("OG Johnson");
            // Console.WriteLine(FiveOneTwoEight); this prints using the ToString Method
            FiveOneTwoEight.Print(); //have to invoke the Print method on the building in ordr to display in console


            Building EightOneZero = new Building("810 Detroit Avenue")
            {
                Stories = 4,
                Width = 205.56,
                Depth = 142.87,

            };
            EightOneZero.Construct();
            EightOneZero.Purchase("Chris Bob");
            // Console.WriteLine(EightOneZero); this prints using the ToString Method
            EightOneZero.Print(); //have to invoke the Print method on the building in ordr to display in console

            Building NineThreeOne = new Building("931 Demonbreun Avenue")
            {
                Stories = 4,
                Width = 205.56,
                Depth = 142.87
            };
            NineThreeOne.Construct();
            NineThreeOne.Purchase("Tommy Bob");
            // Console.WriteLine(NineThreeOne); this prints using the ToString Method
            NineThreeOne.Print(); //have to invoke the Print method on the building in ordr to display in console

        }
    }
}
