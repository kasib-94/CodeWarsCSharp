
using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> list = new List<int>();
        foreach (object item in listOfItems)
        {

            if (item.GetType() == typeof(int))
            {
                list.Add((int)item);
            }
        }

        return list;
    }
}