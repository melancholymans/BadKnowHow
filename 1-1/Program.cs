using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Markup;

class Program
{
    static void Main(string[] args)
    {

        //Dictionary<string, Action<TextWriter>> dic = new Dictionary<string, Action<TextWriter>>();
        var dic = new Dictionary<string, Action<TextWriter>>();
        dic.Add("sample1", (writer) => { writer.WriteLine("I,m sample1"); });
        dic.Add("sample2", (writer) => { writer.WriteLine("I,m sample2"); });
        foreach(var item in dic.Values)
        {
            item(Console.Out);
        }
    }
}