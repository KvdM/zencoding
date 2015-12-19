using System;
using System.Collections.Specialized;

namespace ZenCoding
{
    public class CssParser : IZenParser
    {
        StringDictionary _ds = new StringDictionary();

        public CssParser()
        {
            // Visual formatting
            _ds.Add("pos", "position:relative;");

            // Tables
            _ds.Add("tbl", "table-layout:");
            _ds.Add("tbl:a", "table-layout:auto;");
            _ds.Add("tbl:f", "table-layout:fixed;");
            _ds.Add("cps", "caption-side:");
            _ds.Add("cps:t", "caption-side:top;");
            _ds.Add("cps:b", "caption-side:bottom;");
            _ds.Add("ec", "empty-cells:");
            _ds.Add("ec:s", "empty-cells:show;");
            _ds.Add("ec:h", "empty-cells:hide;");
        }

        public string Parse(string zenSyntax)
        {
            return _ds[zenSyntax];
        }
    }
}
