using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSport.Models
{
    public class VideoItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string VideoSource {get; set; }

        public string PreviewSource {get; set; }

        public VideoItem() 
        {
            Id = 1;
            Name = "1";
            VideoSource = "https://public.kexogg.ru/URFU_MEME.mp4";
            PreviewSource = "1";
        }

        public VideoItem(int id, string name, string videoSource, string previewSource)
        {
            Id = id;
            Name = name;
            VideoSource = videoSource;
            PreviewSource =previewSource;
        }
    }
}
