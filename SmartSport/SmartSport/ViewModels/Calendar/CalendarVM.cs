using System;

namespace SmartSport.ViewModels.Calendar
{
    public class CalendarVm
    {
        public static DateTime CurrentDateTime=DateTime.Now;
        public string CurrentMonth= CurrentDateTime.Month.ToString();
        
    }

}
