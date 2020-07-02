using CodeHollow.FeedReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    class HaberTurk : Channel
    {
        public HaberTurk()
        {
            this.Name = "HaberTurk";
            this.Url = "https://www.haberturk.com/rss";

            
        }
    }
}
