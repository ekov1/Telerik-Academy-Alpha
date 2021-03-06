﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string singleLine = @"\/\/.*|\#.*";
            string multiline = @"\/\*.*\*\/";
            var matcher = new Regex(singleLine);
            var multiLineMatcher = new Regex(multiline);
            var strBr = new StringBuilder();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == @"{!}")
                {
                    break;
                }
                else
                {
                    var matches = matcher.Matches(input);
                    {
                        foreach (Match match in matches)
                        {
                            input = input.Replace(match.ToString(), string.Empty);
                        }
                    }

                    strBr.Append(input);
                }
            }

            var kekeroni = strBr.ToString();

            var machoos = multiLineMatcher.Matches(kekeroni);
            foreach (Match match in machoos)
            {
                kekeroni = kekeroni.Replace(match.ToString(), string.Empty);
            }

            var sumMoreMuchas = new Regex(@"\\\\");

            var michka = sumMoreMuchas.Matches(kekeroni);

            foreach (Match match in michka)
            {
                kekeroni = kekeroni.Replace(match.ToString(), String.Empty);
            }

            var variableMatcher = new Regex(@"(\\@|@)(_|[a-zA-Z])[a-zA-Z|0-9|_]+");
            var michas = variableMatcher.Matches(kekeroni);

            List<string> xd = new List<string>();
            foreach (Match match in michas)
            {
                if (!match.ToString().StartsWith(@"\") &)
                {
                    xd.Add(match.ToString().TrimStart('@'));
                }
            }
            xd = xd.Distinct().ToList();
            xd.Sort();

            Console.WriteLine(xd.Count);

            foreach (var str in xd)
            {
                Console.WriteLine(str);
            }
        }
    }
}
