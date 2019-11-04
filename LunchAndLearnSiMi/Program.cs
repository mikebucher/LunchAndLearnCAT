using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchAndLearnSiMi
{
    static class Program
    {
        static List<nanobot> nanobots;
        static nanobot biggestbot;
        static double largestradius = 0;
        static int counter = 0;

        static void Main(string[] args)
        {
            LoadFile();
            largestradius = nanobots.Max(x => x.r);

            biggestbot = nanobots.FirstOrDefault(x => x.r == largestradius);

            foreach (nanobot bot in nanobots)
            {
                if (calcdistance(bot, biggestbot) <= largestradius) counter++;
            }

            Console.WriteLine("Largest Radius: " + largestradius.ToString());
            Console.WriteLine("Amount of bots in range: " + counter.ToString());
            Console.ReadLine();
        }

        static double calcdistance(nanobot origin, nanobot otherone)
        {
            return Math.Abs(origin.x - otherone.x) + Math.Abs(origin.y - otherone.y) + Math.Abs(origin.z - otherone.z);
        }

        static void LoadFile()
        {
            string strReadFile = @"C:\input.txt";
            string[] separator = { ">, r=" };

            //pos=<-63146556,43584945,33395491>, r=79347912

            var fileLines = File.ReadAllLines(strReadFile).ToList();
            nanobots = new List<nanobot>();
            foreach (string line in fileLines)
            {
                string[] temp = line.Substring(5).Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string[] pos = temp[0].Split(',');

                if (temp.Length >= 2)
                {
                    nanobot bot = new nanobot();
                    bot.x = double.Parse(pos[0]);
                    bot.y = double.Parse(pos[1]);
                    bot.z = double.Parse(pos[2]);
                    bot.r = double.Parse(temp[1]);
                    nanobots.Add(bot);
                }
            }
        }
    }


    class nanobot
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double r { get; set; }
    }
}
