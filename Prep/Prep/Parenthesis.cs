using System;

namespace CalPoints2
{
    class Solution2
    {
        public string CalPoints2(string ops)
        {
            var flag = false;
          var finalArr= new List<string>();
            var result =new List<bool>();
            foreach (var op in ops.ToCharArray())
            {
                finalArr.Add(op.ToString());
            }
            foreach (var item in finalArr)
            {
                var index = finalArr.IndexOf(item);
                var index1 = finalArr[finalArr.Count() - (index + 1)];
                if (item == "(")
                {
                    if (finalArr[finalArr.Count() - (index + 1)] == ")")
                    {
                        result.Add(true);
                    }
                    else
                    {
                        result.Add(false);
                    }
                }
                else if (item == "[")
                {
                    if (finalArr[finalArr.Count() - (index + 1)] == "]")
                    {
                        
                            result.Add(true);
                        }
                    else
                        {
                            result.Add(false);
                        }
                    }
                else if (item == "{")
                {
                    if (finalArr[finalArr.Count() - (index + 1)] == "}")
                    {
                        result.Add(true);
                    }
                    else
                    {
                        result.Add(false);
                    }

                }
            }
            if (result.Contains(false))
            return "Invalid";

            return "Valid";
        }
    }

    class CalPoints2
    {
        //public static void Main(string[] args)
        //{
        //    var soluiton = new Solution2();
        //    var space = new char[] { ' ' };

        //    string ops = Console.ReadLine();
        //    string output = soluiton.CalPoints2(ops);
        //    Console.WriteLine(output.ToString());
        //}
    }
}