using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;

namespace PrintTextFromFile
{
    public class PrintPlugin : IPlugin
    {
        public static string _Id => "print";
        public string Id => _Id;

        public PluginOutput Execute(PluginInput input)
        {
            string filePath = Directory.GetCurrentDirectory() + @"\..\..\..\Src\MySchool.txt";
           // Console.WriteLine(File.ReadAllLines(filePath));

            string text = File.ReadAllText(filePath);


              return new PluginOutput(text);
        }
    }
}
