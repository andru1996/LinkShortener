using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkShortener.Gui.Helpers
{
    public static class Helper
    {
        public static string ConvertLinkIdToChars(long linkId, int сharCounts = 52)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var charNumbers = new List<int>();
            do
            {
                var charNumber = linkId % сharCounts;
                linkId = linkId / сharCounts;
                charNumbers.Add((int)charNumber);
            }
            while (linkId > 0);
            charNumbers.Reverse();
            var chars = charNumbers.Select(x => alphabet[x]);
            return new string(chars.ToArray());
        }

        public static string GetPathForLinkStringId(HttpRequestBase request)
        {
            var scheme = request.Url.Scheme; // will get http, https, etc.
            var host = request.Url.Host; // will get www.mywebsite.com
            var port = request.Url.Port; // will get the port
            //var path = Request.Url.AbsolutePath; //request.Url.Authority
            return $"{scheme}://{host}:{port}/";
        }
    }
}