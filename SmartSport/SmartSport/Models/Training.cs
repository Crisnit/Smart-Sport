using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SmartSport.Models
{
    [Table("Trainings")]
    public class Training
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public Training() 
        {
            TrainingDateTime = DateTime.Now;
            Note = "";
            StringDate= TrainingDateTime.ToString("d");
            StringTime = TrainingDateTime.TimeOfDay.ToString("hh\\:mm");
            NotificationText = "Ваша тренировка начнётся " + StringDate + " в " + StringTime;
        }
        public DateTime TrainingDateTime { get; set; }

        public string StringDate { get; set; }

        public string StringTime { get; set; }

        public string Note { get; set; }

        public int VideoId { get; set; }

        public string NotificationText { get; set; }
    }
}
