﻿using Core;

Console.WriteLine("Hello, World!");

if (args == null || args.Length < 2)
{
    throw new Exception("Input and Output path arguments have to be provided.");
}

Sorter sorter = new Sorter();
sorter.Sort(args[0], args[1]);