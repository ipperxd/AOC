using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AOC.Repository._2024;

internal class Day3_2024 : Iday
{
    string[] data;

    public void SetData()
    {
        data = Utility.Utility.LoadData("2024\\Day3.txt");
    }

    public string Solution1()
    {
        SetData();


        string pattern = @"mul\([0-9]+,[0-9]+\)";
        // Create a Regex
        
        int result = 0;
        
        Regex rg = new Regex(pattern);

        var dat = data[0];
        List<string> list = new List<string>();

        MatchCollection collection = rg.Matches(dat);

        Console.WriteLine(collection.Count.ToString());

        for (int count = 0; count < collection.Count; count++)
        {
            bool newLine = false;
            StringBuilder number1 = new StringBuilder();
            StringBuilder number2 = new StringBuilder();
            int numberOne = 0;
            int numberTwo = 0;

            for (int j = 0; j < collection[count].Value.Length; j++)
            {
                var d = collection[count].Value[j];

                if(d == ',')
                    newLine = true;

                if(newLine == false && char.IsDigit(d))
                {
                    number1.Append(d);
                } else if(newLine == true && char.IsDigit(d))
                {
                    number2.Append(d);
                }
            }

            numberOne = int.Parse(number1.ToString());    
            numberTwo = int.Parse(number2.ToString());

            var added = numberOne * numberTwo;

            Console.WriteLine(collection[count] + " " + number1.ToString() + " " + number2.ToString() + " " + added.ToString());

            result += added;    

        }

            return result.ToString();
    }

    public string Solution2()
    {
        SetData();


        string pattern = @"don't|do|mul\([0-9]+,[0-9]+\)";
        // Create a Regex

        int result = 0;

        Regex rg = new Regex(pattern);

        var dat = data[0];
        List<string> list = new List<string>();

        MatchCollection collection = rg.Matches(dat);
        bool isEnabled = true;


        for (int count = 0; count < collection.Count; count++)
         {

            
             bool newLine = false;
             StringBuilder number1 = new StringBuilder();
             StringBuilder number2 = new StringBuilder();
             int numberOne = 0;
             int numberTwo = 0;

            if (string.Compare(collection[count].ToString(), "do") == 0){
                isEnabled = true;
            } else if (string.Compare(collection[count].ToString(),"don't") == 0)
                isEnabled = false;

            if (isEnabled)
            {
                Console.WriteLine(collection[count] + " ");
                for (int j = 0; j < collection[count].Value.Length; j++)
                {
                    var d = collection[count].Value[j];

                    if (d == ',')
                        newLine = true;

                    if (newLine == false && char.IsDigit(d))
                    {
                        number1.Append(d);
                    }
                    else if (newLine == true && char.IsDigit(d))
                    {
                        number2.Append(d);
                    }
                }

                numberOne = int.Parse(number1.ToString());
                numberTwo = int.Parse(number2.ToString());

                var added = numberOne * numberTwo;

                Console.WriteLine(collection[count] + " " + number1.ToString() + " " + number2.ToString() + " " + added.ToString());

                result += added;
            }
        }

        return result.ToString();
    }
}
