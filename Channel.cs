using CodeHollow.FeedReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    abstract class Channel
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public List<News> ListNews { get; set; }

        public void FindNews()
        {
            Feed feed = FeedReader.Read(this.Url);
            ListNews = new List<News>();

            foreach (FeedItem item in feed.Items)
            {
                string title = item.Title;
                title = title.Replace("&#39;", "'");

                string description = item.Title;
                description = description.Replace("&#39;", "'");


                News news = new News( title, item.Link, description, item.PublishingDate);
                this.ListNews.Add(news);
            }
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
