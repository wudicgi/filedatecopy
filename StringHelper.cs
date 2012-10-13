using System;
using System.Collections.Generic;
using System.Text;

namespace FileDateCopy
{
    public static class StringHelper
    {
        public static string Ellipsis(string str, int length)
        {
            int len = StrLen(str);
            if (len > length)
            {
                return CutString(str, length - 3) + "...";
            }
            return str;
        }

        public static string EllipsisPath(string str, int length)
        {
            int len = StrLen(str);
            if (len > length)
            {
                str = CutString(str, length - 3);
                int index = str.LastIndexOf('/');
                if (index != -1 && index != str.Length - 1)
                {
                    str = str.Remove(index + 1);
                }
                str += "...";
                return str;
            }
            return str;
        }

        public static string CutString(string str, int length)
        {
            int num = StrLen(str);
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("length");
            }
            if (length > num)
            {
                throw new ArgumentOutOfRangeException("length");
            }
            if (length == 0)
            {
                return "";
            }
            if (length == num)
            {
                return str;
            }
            char[] tmp = new char[str.Length];
            str.CopyTo(0, tmp, 0, str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                if (StrLen(tmp, 0, i) > length)
                {
                    return str.Substring(0, i - 1);
                }
            }
            throw new Exception("ttttttttttttttt");
        }


        public static string PadLeft(string str, int width, char padding)
        {
            int len = StrLen(str);
            if (len > width)
            {
                return str;
            }
            return new string(padding, width - len) + str;
        }

        public static string PadRight(string str, int width, char padding)
        {
            int len = StrLen(str);
            if (len > width)
            {
                return str;
            }
            return str + new string(padding, width - len);
        }

        public static string PadBoth(string str, int width, char padding)
        {
            int len = StrLen(str);
            if (len > width)
            {
                return str;
            }
            string pad = new string(padding, ((width - len) / 2));
            str = String.Concat(pad, str, pad);
            if (StrLen(str) < width)
            {
                str = PadLeft(str, width, padding);
            }
            return str;
        }

        public static int StrLen(string str)
        {
            return Encoding.Default.GetByteCount(str);
        }

        public static int StrLen(char[] chars, int index, int count)
        {
            return Encoding.Default.GetByteCount(chars, index, count);
        }
    }
}
