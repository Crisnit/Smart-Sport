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
            Name = "Hips Dips Workout";
            VideoSource = "https://public.kexogg.ru/Videos/Hips.mp4";
            PreviewSource = "hips.jpg";
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
