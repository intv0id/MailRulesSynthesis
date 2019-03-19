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

        public static bool Is(string str1, string str1)
        {
            throw NotImplemetedException();
        }

        public static bool Contains(string str1, string str2)
        {
            throw NotImplemetedException();
        }

        public static bool IsInAddressBook(string contact)
        {
            throw NotImplemetedException();
        }

        public static bool StartsWith(string str, string prefix)
        {
            throw NotImplemetedException();
        }

        public static bool StartsWith(string str, string suffix)
        {
            throw NotImplemetedException();
        }
    }
}