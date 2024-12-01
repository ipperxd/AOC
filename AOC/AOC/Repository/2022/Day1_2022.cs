namespace AOC.Repository._2022;
public class Day1_2022 : Iday
{
    string[]? data;

    public void SetData()
    {
        data = Utility.Utility.LoadData("2022\\Day1.txt");
    }

    public string Solution1()
    {
        SetData();

        int TemporarySum = 0;
        List<int> ResultList = new List<int>();

        for (int i = 0; i < data.Length; i++)
        {
            if (string.IsNullOrEmpty(data[i]))
            {
                ResultList.Add(TemporarySum);
                TemporarySum = 0;
            }
            else
                TemporarySum += Convert.ToInt32(data[i]);

        }
        return ResultList.Max().ToString();
    }
    public string Solution2()
    {
        SetData();

        int TemporarySum = 0;
        List<int> ResultList = new List<int>();

        for (int i = 0; i < data.Length; i++)
        {
            if (string.IsNullOrEmpty(data[i]))
            {
                ResultList.Add(TemporarySum);
                TemporarySum = 0;
            }
            else
                TemporarySum += Convert.ToInt32(data[i]);

        }

        ResultList.Sort();
        var secondList = new List<int>();

        secondList.Add(ResultList.Last());
        secondList.Add(ResultList.Last() - 1);
        secondList.Add(ResultList.Last() - 2);

        return secondList.Sum().ToString();

    }
}
