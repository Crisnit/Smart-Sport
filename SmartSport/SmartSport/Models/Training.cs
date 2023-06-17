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
            Note = "1";
            VideoID = 1;
        }
        public DateTime TrainingDateTime { get; set; }

        public string Note { get; set; }

        public int VideoID { get; set; }

    }
}
