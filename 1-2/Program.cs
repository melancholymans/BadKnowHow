using System;


class Program
{
    static void convert(ref string color)
    {
        /*
        if (color == "Red")
        {
            color = "赤";
        }
        else if(color == "Green")
        {
            color = "緑";
        }
        else
        {
            color = "未知の色";
        }
        */
        switch (color)
        {
            case "Red":
                color = "赤";
                break;
            case "Green":
                color = "緑";
                break ;
            default:
                color = "未知の色";
                break;
        }
    }

    static void Main(string[] args)
    {
        string s = "Red";
        convert(ref s);
        Console.WriteLine(s);
    }

}