using CodeHollow.FeedReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace News
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void LstbxNewsTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            News news = (News)lstbxNewsTitle.SelectedItem;
            
            rchbxNewsDetail.Text=news.Description;
            rchbxPublish.Text = news.PublishDate.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Type[] types = asm.GetTypes();

            foreach(Type type in types)
            {
                if(type.IsClass && type.BaseType.Name == "Channel")
                {
                    Channel channel = (Channel)Activator.CreateInstance(type);
                    cmbbxChannels.Items.Add(channel);
                }
                
            }
          
        }

        private void CmbbxChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbxNewsTitle.Items.Clear();
            rchbxNewsDetail.Clear();
            rchbxPublish.Clear();

            Channel channel = (Channel)cmbbxChannels.SelectedItem;
            channel.FindNews();

            foreach (News news in channel.ListNews)
            {
                lstbxNewsTitle.Items.Add(news);
            }
            
        }
    }
}
