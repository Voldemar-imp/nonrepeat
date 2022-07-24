using System;
using System.Collections.Generic;

namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] trees1 = { "ёлка", "дуб", "берёза", "ёлка", "дуб" };
            string[] trees2 = { "берёза", "ёлка", "ясень", "осина" };
            List<string> nonrepeatList = new List<string>();

            AddToList(nonrepeatList, trees1);
            AddToList(nonrepeatList, trees2);

            foreach (string str in nonrepeatList)
            {
                Console.WriteLine(str + " ");
            }
        }

        static void AddToList(List<string> list, string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                bool isRepeat = false;

                foreach (string value in list)
                {
                    if (values[i] == value)
                    {
                        isRepeat = true;
                    }
                }

                if (isRepeat == false)
                {
                    list.Add(values[i]);
                }
            }
        }

    }
}
