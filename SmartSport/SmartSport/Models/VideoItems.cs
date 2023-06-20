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
           var video=new VideoItem();

           Items = new Dictionary<int, VideoItem>()
           {
               {1, video }
           };
        }

        public Dictionary<int, VideoItem> Items { get; set;}
    }
}
