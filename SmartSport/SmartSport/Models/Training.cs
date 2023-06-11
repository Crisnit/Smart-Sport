using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSport.Models
{
    class Training
    {
        public Training()
        {
            TrainingDateTime = DateTime.Now.Date;
        }

        public DateTime TrainingDateTime { get; set; }

        public string Note { get; set; }
    }
}
