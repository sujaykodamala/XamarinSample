using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using SQLite;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HydrologyXamarin.ORM
{
   public  class DBRepository
    {

       public string CreateDb()
       {
           var output = "";
           output += "Create Database if doesn't exist";
           string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Model.db3");
           var db = new SQLiteConnection(dbPath);
           output += "Database is created";
           return output;
       }

       //Code to create the table
       public string CreateTable()
       {
           try
           {
               string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Model.db3");
               var db = new SQLiteConnection(dbPath);
               db.CreateTable<Model>();
               string result = "Table created";
               return result;
           }
           catch(Exception ex)
           {
               return "Error:" + ex.Message;
           }
         
       }


       //Code to insert


       public string insertRecord(string Name)
       {
           Model m = new Model();
           try
           {
               string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Model.db3");
               var db = new SQLiteConnection(dbPath);
               m.name = Name;
               db.Insert(m);
               return "Record added";
           }
           catch(Exception ex)
           {
               return "Error" + ex.Message;
           }

       }
    }
}