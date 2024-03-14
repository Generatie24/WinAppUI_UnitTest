using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCode
{
    public class ListProcessor
    {
        public List<string> SortList(List<string> list)
        {
            list.Sort();
            return list;
        }

        public List<string> FindStringWithSubstring(List<string> list, string substring)
        {
            var machingStrings = new List<string>();
            foreach (var s in list)
            {
                if (s.Contains(substring))
                {
                    machingStrings.Add(s);
                }
            }
            return machingStrings;
        }
    }
}
