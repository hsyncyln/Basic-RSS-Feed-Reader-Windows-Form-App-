using CodeHollow.FeedReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    class CnnTurk : Channel
    {
        public CnnTurk()
        {
            this.Name = "Cnn Turk";
            this.Url = "https://www.cnnturk.com/feed/rss/all/news";

        
        }
    }
}
