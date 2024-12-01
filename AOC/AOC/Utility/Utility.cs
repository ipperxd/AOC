namespace AOC.Utility;

public static class Utility
{
    public static string[] LoadData(string date)
    {
        var path = "D:\\Code - Projects\\AOC\\AOC\\AOC\\Data\\2022\\" + date;
        var data = File.ReadAllLines(path);

        return data;

    }
}
