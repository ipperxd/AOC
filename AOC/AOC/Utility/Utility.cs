namespace AOC.Utility;

public static class Utility
{
    public static string[] LoadData(string date)
    {
        //  var path = "D:\\Code - Projects\\AOC\\AOC\\AOC\\Data\\" + date;
        var path = "C:\\Users\\AndersRavnIpsen\\AT-Repo\\AOC\\AOC\\AOC\\Data\\" + date;
        var data = File.ReadAllLines(path);

        return data;

    }
}
