using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SonarSweep
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
            
            var x = 0;
            List<int> deeps = splitReadText.Where(str => int.TryParse(str, out x))
                .Select(str => x)
                .ToList();

            var count = 0;
            for (var i = 1; i < deeps.Count; i++)
            {
                if (deeps[i] > deeps[i - 1])
                {
                    count++;
                }
            }
            
            Console.WriteLine(count);
        }
    }
}

