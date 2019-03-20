using MailRules.Types;
using System;
using System.Globalization;

namespace MailRules.Semantics
{
    public static class MailRules
    {
        public static bool True()
        {
            return true;
        }

        public static bool Not(bool stmt)
        {
            return !stmt;
        }

        public static bool And(bool stmt1, bool stmt2)
        {
            return stmt1 & stmt2;
        }

        public static bool Or(bool stmt1, bool stmt2)
        {
            return stmt1 | stmt2;
        }

        public static bool Id(bool stmt)
        {
            return stmt;
        }

        public static bool Is(string str1, string str2)
        {
            return str1 == str2;
        }

        public static bool Contains(string str1, string str2)
        {
            return str1.Contains(str2, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool StartsWith(string str, string prefix)
        {
            return str.StartsWith(prefix, ignoreCase: true, culture: CultureInfo.InvariantCulture);
        }

        public static bool EndsWith(string str, string suffix)
        {
            return str.EndsWith(suffix, ignoreCase: true, culture: CultureInfo.InvariantCulture);
        }

        public static MailAction Rule(bool condition, MailAction action)
        {
            if(condition)
            {
                return action;
            }
            else
            {
                return MailAction.None;
            }
        }
    }
}