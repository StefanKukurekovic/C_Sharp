using System;
using System.Collections.Generic;
using System.Text;

namespace SWA
{
    class Checker
    {
        public bool isDefaultValue (bool val)
        {
            if (val == false)
                return true;
            else
                return false;
        }

        public bool isDefaultValue(int val)
        {
            if (val == 0)
                return true;
            else
                return false;
        }

        public bool isDefaultValue(int intVal, bool booleanVal)
        {
            if (intVal == 0 && booleanVal == false)
                return true;
            else
                return false;
        }
    }
}
