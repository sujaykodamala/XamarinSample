using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace HydrologyXamarin
{
  public   class WellReadings
    {
      [AutoIncrement,PrimaryKey]
      public int ID { get; set; }
      public string Name { get; set; }
      public decimal latitude { get; set; }
      public decimal longiude { get; set; }
      public string address { get; set; }
      public int Zip { get; set; }
      public string City { get; set; }
      [MaxLength(2)]
      public char state {get;set;}
      public string Country { get; set; }
      
    }
}