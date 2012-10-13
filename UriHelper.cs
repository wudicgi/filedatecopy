using System;
using System.Collections.Generic;
using System.Text;

namespace FileDateCopy
{
    public static class UriHelper
    {
        static UriHelper()
        {
        }

        public static string Compact(string uri, int len)
        {
            return CompactFile(uri, len);
        }

        private static string CompactFile(string uri, int len)
        {
            string compact;
            string[] temp = uri.Split(':');
            compact = String.Concat(temp[0], ":", temp[1]); // more: String.Join(":", temp, 1, 4)
            if (StringHelper.StrLen(compact) <= len)
            {
                return compact;
            }

            string prefix = temp[0] + ":"; // more: String.Join(":", temp, 1, 3)
            string[] parts = temp[1].Split('\\');
            string path = String.Join("\\", parts, 0, parts.Length - 1);
            string basename = "\\" + parts[parts.Length - 1];

            if (StringHelper.StrLen(prefix) + 4 + StringHelper.StrLen(basename) >= len)
            {
                if (path != "")
                {
                    path = "\\...";
                }
                int len_tmp = len - StringHelper.StrLen(prefix) - StringHelper.StrLen(path);
                compact = String.Concat(prefix, path, StringHelper.Ellipsis(basename, len_tmp));
                return compact;
            }

            int len_path = len - StringHelper.StrLen(prefix) - StringHelper.StrLen(basename);
            path = StringHelper.EllipsisPath(path, len_path);

            compact = String.Concat(prefix, path, basename);

            return compact;
        }
    }
}
