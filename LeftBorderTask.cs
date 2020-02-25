﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Autocomplete
{
    public class LeftBorderTask
    {
        public static int GetLeftBorderIndex(IReadOnlyList<string> phrases, string prefix, int left, int right)
        {
            {
                if (left == right - 1) return left;
                //var m = left + (right - left) / 2;
                var m = (int)(((long)left + (long)right) / 2);
                if (String.Compare(phrases[m], prefix, StringComparison.OrdinalIgnoreCase) < 0)                
                    return GetLeftBorderIndex(phrases, prefix, m, right);
                return GetLeftBorderIndex(phrases, prefix, left, m);
            }
        }
    }
}
