using Java.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSport.Models
{
    internal class VideoItems
    {
        public VideoItems() 
        { 
           Items = new Dictionary<int, VideoItem>()
           {
               {1, new VideoItem() }
           };
        }

        public Dictionary<int, VideoItem> Items { get; set;}
    }
}
