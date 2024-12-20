using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AOC.Repository._2016;
public class Day1_2016 : Iday
{
    string[] data;
    public enum direction
    {
        North,
        South,
        West,
        East,
        None
        }

    private direction currentDirecttion = direction.North;
    public void SetData()
    {
        data = Utility.Utility.LoadData("2016\\Day1.txt");
    }

    public string Solution1()
    {
        SetData();   

        Vector endP = new Vector();

        char[] delimiterChars = { ',' };
        string[] words = data[0].Split(delimiterChars);

        for (int i = 0; i < words.Length; i++)
        {
           
            words[i] = words[i].Trim();

            char dir = words[i][0];
            var subWord = words[i].Substring(1);
            int num = Int32.Parse(subWord);

            Console.WriteLine(dir + " " + num.ToString());

            currentDirecttion = ChangesDirection(dir);
            endP = MoveInGrid(num, endP);
            

            Console.WriteLine(endP.x.ToString() + " " + endP.y + " " + currentDirecttion);

        }
         
        int result = Math.Abs(endP.x) + Math.Abs(endP.y);
        return result.ToString();
    }

    public string Solution2()
    {
        SetData();
        Vector endP = new Vector();
        char[] delimiterChars = { ',' };
        string[] words = data[0].Split(delimiterChars);

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].Trim();
        }

        for (int i = 0; i < words.Length; i++)
        {
            Vector startP = endP;
            Console.WriteLine(startP.x.ToString() + " " + startP.y + " " + currentDirecttion);
            char dir = words[i][0];
            var subWord = words[i].Substring(1);
            int num = Int32.Parse(subWord);

            currentDirecttion = ChangesDirection(dir);
            endP = MoveInGrid(num, endP);
            
            Console.WriteLine(words[i]);
            Console.WriteLine(endP.x.ToString() + " " + endP.y + " " + currentDirecttion);

            if (CheckIfLoop(words[i], words[i + 1], words[i + 2], words[i + 3]))
            {
                
                dir = words[i + 1][0];
                subWord = words[i + 1].Substring(1);
                num = Int32.Parse(subWord);

                
                currentDirecttion = ChangesDirection(dir);
                endP = MoveInGrid(num, endP);
                Console.WriteLine(words[i + 1]);
                Console.WriteLine(endP.x.ToString() + " " + endP.y + " " + currentDirecttion);


                dir = words[i + 2][0];
                subWord = words[i + 2].Substring(1);
                num = Int32.Parse(subWord);

                currentDirecttion = ChangesDirection(dir);
                endP = MoveInGrid(num, endP);
                Console.WriteLine(words[i + 2]);
                Console.WriteLine(endP.x.ToString() + " " + endP.y + " " + currentDirecttion);

                dir = words[i + 3][0];
                subWord = words[i + 3].Substring(1);
                num = Int32.Parse(subWord);

                currentDirecttion = ChangesDirection(dir);
                endP = MoveInGrid(num, endP);
                Console.WriteLine(words[i + 3]);
                Console.WriteLine(endP.x.ToString() + " " + endP.y + " " + currentDirecttion);
                break;
            }

            
        }

        int result = Math.Abs(endP.x) + Math.Abs(endP.y);
        return result.ToString();
    }

    direction ChangesDirection(char letter)
    {
        switch (currentDirecttion) {
            case direction.North:
                if (letter == 'R')
                    return direction.East;
                else if (letter == 'L')
                    return direction.West;
                break;
            case direction.West:
                if (letter == 'R')
                    return direction.North;
                else if (letter == 'L')
                    return direction.South;
                break;

            case direction.East:
                if (letter == 'R')
                    return direction.South;
                else if (letter == 'L')
                    return direction.North;
                break;

            case direction.South:
                if (letter == 'R')
                    return direction.West;
                else if (letter == 'L')
                    return direction.East;
                break;
        }
        return direction.None;
    }

    public Vector MoveInGrid(int num, Vector pos)
    {
        switch (currentDirecttion)
        {
            case direction.North:
                pos.y += num;
                break;
            case direction.South:
                pos.y -= num;
                break;
            case direction.East:
                pos.x += num;
                break;
            case direction.West:
                pos.x -= num;
                break;

        }

        return pos;
    }

    bool CheckIfLoop(string current, string nextOne, string nextTwo, string nextthree)
    {
        if (current[0] == 'L' && nextOne[0] == 'L' && nextTwo[0] == 'L' && nextthree[0] == 'L' ||
            current[0] == 'R' && nextOne[0] == 'R' && nextTwo[0] == 'R' && nextthree[0] == 'R')
        {
            if (current == nextthree && nextOne == nextTwo
            || current == nextthree && nextOne == nextTwo)
                return true;
        }
        return false;
    }
}


public class Vector
{
    public int x { get; set; }
    public int y { get; set; }
        
        public Vector()
        {
            x = 0;
            y = 0;
        }
}

