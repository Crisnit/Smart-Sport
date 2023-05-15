using Android.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSport.ViewModels.Calendar
{
    public class CalendarVm
    {
        public static DateTime CurrentDateTime=DateTime.Now;
        public string CurrentMonth= CurrentDateTime.Month.ToString();
        
    }

}
