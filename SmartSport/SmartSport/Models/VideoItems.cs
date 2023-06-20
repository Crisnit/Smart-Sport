using Java.Security;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SmartSport.Models
{
    internal class VideoItems
    {
        public VideoItems() 
        { 
           var video=new VideoItem();

           ItemsDictionary = new Dictionary<int, VideoItem>()
           {
               {1, video }
           };

            ItemsList = new List<VideoItem>()
            {
                video
            };
        }

        public Dictionary<int, VideoItem> ItemsDictionary { get; set;}

        public List<VideoItem> ItemsList { get; set; }
    }
}
