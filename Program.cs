// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;

[DllImport("libTest.so", EntryPoint = "printText")]
static extern void printTest(string text);

Console.WriteLine("Hello, World!");
printTest("SARLANGA!!!");

