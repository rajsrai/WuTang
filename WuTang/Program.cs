using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;


class Program
{

    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Welcome to the WuTang Name Generator");
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        if (Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
        {
            Console.WriteLine("Wuing you...");
            var ps = new ProcessStartInfo("https://wunameaas.herokuapp.com/enterthewu/" + name)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
        else
        {
            Console.WriteLine("Wu Tang Clan Ain't Nothing to F**k With");
        }
      }
  }
    
