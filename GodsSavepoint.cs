using System;
using System.Collections.Generic;
using System.Text;

namespace Database_Gods
{
    class GodsSavepoint
    {
        public string name;
        public GodsSavepoint(string theName)
        {
            name = theName;
        }
        public string AddName()
        {
            return name;
        }
    }
}
