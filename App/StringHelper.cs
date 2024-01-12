using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class StringHelper
    {
        public String Ellipsis(String input, int maxLength = 80)
        {
            return $"{input[0..maxLength]}...";
        }
    }
}
