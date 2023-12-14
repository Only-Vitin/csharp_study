using System;
using System.IO;

namespace pacman.Controller
{
    public class Map
    {
        public static string[,] map;
        
        public static void ReadMap()
        {
            string path = Path.GetFullPath("Map.txt");
            var lines = File.ReadAllLines(path);
            for(int i = 0; i < lines.GetLength(0); i++){
                foreach(char line in lines[i])
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}