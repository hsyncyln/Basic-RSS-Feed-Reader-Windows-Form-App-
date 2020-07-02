using CodeHollow.FeedReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    class Ntv:Channel
    {
        public Ntv()
        {
            this.Name = "Ntv";
            this.Url = "https://www.ntv.com.tr/gundem.rss";

        }
    }
}
