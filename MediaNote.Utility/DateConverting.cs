using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MediaNote.Utility
{
    public static class DateConverting
    {
        
        public static string ToShamsi(this DateTime date)
        {
            PersianCalendar perC = new PersianCalendar();

            #region declare a variable for return
            string dateTime = perC.GetYear(date) + "/" + 
                perC.GetMonth(date).ToString("00") + "/" +
                perC.GetDayOfMonth(date).ToString("00") + "    " +
                perC.GetHour(date).ToString("00") + ":" +
                perC.GetMinute(date).ToString("00") + ":" +
                perC.GetSecond(date).ToString("00");
            #endregion

            return dateTime;

        }


    }
}
