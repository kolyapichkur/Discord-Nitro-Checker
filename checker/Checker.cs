﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Discord_Nitro_Checker
{
    class checker
    {
        static void Main(string[] args)
        {


            var template = "https://discord.gift/";

Console.WriteLine("Discord Nitro CHECKER!");
Console.WriteLine(" ");



using (StreamReader sr = new StreamReader("codes.txt")) {
  string line;
  while ((line = sr.ReadLine()) != null) {
    Console.WriteLine(template + line);
    System.Diagnostics.Process.Start("cmd","/c start https://discord.gift/" + line);
  }
}

if( new FileInfo( "codes.txt" ).Length == 0 )
{
  Console.WriteLine("File codes.txt is Empty!");
}

        }
    }
}
