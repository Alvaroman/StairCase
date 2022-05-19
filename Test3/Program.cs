int totalSteps = 3, stairCase1 = 3, count = 0;
List<List<int>> list = new();
double totalI = Math.Pow(double.Parse(totalSteps.ToString()), double.Parse(stairCase1.ToString()));

calculate(int.Parse(totalI.ToString()), new List<int>());

void calculate(int totalI, List<int> fathers)
{
    for (int i = 0; i < totalSteps; i++)
    {
        if (totalI / totalSteps != 1)
        {
            var newFathers = new List<int>(fathers);
            newFathers.Add(i + 1);
            calculate(totalI / totalSteps, newFathers);
        }
        else
        {
            var newFathers2 = new List<int>(fathers);
            newFathers2.Add(i + 1);
            list.Add(newFathers2);
        }
    }
}


List<List<int>> allowed = new List<List<int>>();
for (int i = 0; i < list.Count; i++)
{
    List<int> thisList = new List<int>();
    for (int j = 0; j < stairCase1; j++)
    {
        if (thisList.Sum() + list[i][j] > stairCase1)
        {
            break;
        }
        else
        {
            thisList.Add(list[i][j]);
            if (thisList.Sum() == stairCase1 && !areEquals(allowed, thisList))
            {
                allowed.Add(thisList);
                break;
            }
        }
    }
}

Console.WriteLine("This is sparta!!");
for (int i = 0; i < allowed.Count; i++)
{
    for (int j = 0; j < allowed[i].Count; j++)
    {
        Console.Write(allowed[i][j]);
    }
    Console.WriteLine();
}

bool areEquals(List<List<int>> totals, List<int> listToCompare)
{
    bool areEquals1 = false;
    for (int i = 0; i < totals.Count; i++)
    {
        if (totals[i].Count == listToCompare.Count)
        {
            for (int j = 0; j < totals[i].Count; j++)
            {
                if (totals[i][j] != listToCompare[j])
                {
                    break;
                }
                if (j == totals[i].Count - 1)
                {
                    return true;
                }
            }
        }
    }
    return areEquals1;
}