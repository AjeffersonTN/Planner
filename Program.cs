﻿using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
           Building FiveOneTwoEigth = new Building("512 8th Avenue"){
               Stories = 4,
               Width = 205.56,
               Depth = 142.87


           };
           Building EightOneZero = new Building("810 Detroit Avenue"){
               Stories = 4,
               Width = 205.56,
               Depth = 142.87


           };
           Building NineThreeOne = new Building("931 Demonbreun Avenue"){
               Stories = 4,
               Width = 205.56,
               Depth = 142.87


           };
        }
    }
}