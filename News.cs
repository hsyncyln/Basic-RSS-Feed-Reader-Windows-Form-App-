using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    class News
    {
  
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public DateTime? PublishDate { get; set; }

        public News(string title, string link, string description, DateTime? publishDate)
        {
            
            this.Title = title;
            this.Link = link;
            this.Description = description;
            this.PublishDate = publishDate;
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
