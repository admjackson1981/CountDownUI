using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeCreation 
{
   protected DateTime WeddingDay { get; private set; }
    
    public timeCreation(DateTime weddingDay)
    {
        WeddingDay = weddingDay;
    }

    public string ReturnTimingString {
        get {

            DateTime date1 =  DateTime.Now;
            DateTime date2 = new DateTime(2022, 8, 20, 09, 30, 00);

            // Calculate the interval between the two dates.
            TimeSpan interval = date2 - date1;
            
          

            string timeString = string.Format("{0}:{1}:{2}:{3}", interval.Days, interval.Hours, interval.Minutes, interval.Seconds);


            return timeString;
              }
    }

   
   
}
