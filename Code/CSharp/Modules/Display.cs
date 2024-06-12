using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.CSharp.Modules
{
    public class Display
    {
        public static string ShowList(List<int> list)
        {
            string numbers = null;
            for (int i = 0; i < list.Count; i++)
            {
                numbers = numbers + $"{list[i]} ";
            }
            return numbers;
        }
    }
}
