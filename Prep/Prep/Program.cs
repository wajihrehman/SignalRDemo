using System;

namespace CalPoints
{
    class Solution
    {
        public int CalPoints(string[] ops)
        {
            var arr =new List<int>();

            foreach (var item in ops)
            {
                switch (item)
                {
                    case "C":
                        var len = arr.Count();
                        arr.RemoveAt(len-1);
                        break;
                    case "D":
                        var len2 = arr.Count();
                        var temp1 = arr[len2 - 1] * 2;
                        arr.Add(temp1);
                        break;
                    case "+":
                        var len1 = arr.Count();
                        var temp = arr[len1 - 1] + arr[len1 - 2];
                        arr.Add(temp);
                        break;
                    default:
                        arr.Add(int.Parse(item));
                        break;
                }
            }
            var output = 0;

            foreach(var item in arr)
            {
                output += item;

            }
            
            return output;
        }
    }

    class CalPoints
    {
        //public static void Main(string[] args)
        //{
        //    var soluiton = new Solution();
        //    var space=new char[] {' ' };

        //    string[] ops = Console.ReadLine().Split(space);
        //    int output = soluiton.CalPoints(ops);
        //    Console.WriteLine(output.ToString());
        //}
    }
}