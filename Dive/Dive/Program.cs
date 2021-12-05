using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Dive
{
    internal static class Program
    {
        public static void Main()
        {
            const string path = "./input.txt";
            if (!File.Exists(path))
            {
                throw new Exception($"{path} is not exist!");
            }

            string readText = File.ReadAllText(path);
            
            List<string> splitReadText = readText.Split('\n').ToList();
            
            var forward = 0;
            var depth = 0;

            foreach (var line in splitReadText.Select(str => str.Split(' ').ToList()))
            {
                switch (line[0])
                {
                    case "forward":
                    {
                        int i;
                        int.TryParse(line[1], out i);
                        forward += i;
                        break;
                    }
                    case "up":
                    {
                        int i;
                        int.TryParse(line[1], out i);
                        depth -= i;
                        break;
                    }
                    case "down":
                    {
                        int i;
                        int.TryParse(line[1], out i);
                        depth += i;
                        break;
                    }
                }
            }

            var result = forward * depth;
            
            Console.WriteLine($"Result = {result}");
        }
    }
}