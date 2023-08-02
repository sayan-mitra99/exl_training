using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            String[] lines = File.ReadAllLines("d:\\youtube.csv");
            Console.WriteLine(lines.Length-1);// total count
            Console.WriteLine(lines[1].Length);
            List<string> channel = new List<string>();
            for (int i=0;i<lines.Length;i++)
            {
                channel.Add(lines[i].Split(",")[lines[i].Length-2]);
            }
            channel.Remove(channel[0]);
            List<string> unique = channel.Distinct().ToList();
            Console.WriteLine(unique.Count());// unique channel count
            Console.WriteLine(channel.Count());
            foreach(string i in unique)
            {
                Console.WriteLine(i);
            }
            // List<string> l = lines.ToList();
            // Console.WriteLine(l.Count()-1);

        }
    }
}
