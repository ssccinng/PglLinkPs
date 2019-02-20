using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PglLinkPs
{
    public class NatureClass
    {

        private string[] aa = { "", "物攻", "物防", "特攻", "特防", "速度" };
        public string rss;
        public string[] rsslist = { "", "勿花果", "异奇果", "芒芒果", "乐芭果", "芭亚果" };
        public int up;
        public int id;

        public int down;

        public string name;

        public NatureClass(string name, int up, int down, int rss, int id)
        {
            if (up == 0)
            {
                name += "(无修正)";
            }
            else
            {
                name += string.Format("(+%s -%s)", aa[up], aa[down]);
            }
            this.name = name;
            this.up = up;
            this.down = down;
            this.id = id;
            this.rss = rsslist[rss];
        }
    }

}
