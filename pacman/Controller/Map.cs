using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;

namespace pacman.Controller
{
    public class Map
    {
        public static string[,] map;
        
        public static void ReadMap()
        {
            var lines = File.ReadAllLines(@"C:\Users\Projeto Trainee\Documents\csharp_study\pacman\Map.txt");
            foreach(var line in lines)
            {

            }
        }
    }
}