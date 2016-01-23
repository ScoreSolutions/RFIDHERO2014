using System;
using System.Collections.Generic;
using System.Text;
using LinqDB.Common.Utilities;
namespace LiveFaceScan
{
    public static class CameraSetting
    {
        public static string CameraName;
        public static int VideoFormat;
        public static string Drive;
    }
    public static class userinfo
    {
        public static string id;
        public static string fullname;
        public static string companyname;
        public static string email;
      
    }

        public   class configfile
     {
        public  string GetDrive(){
           
            string INIFlie =  "C:\\Windows\\eBrochure.ini" ;
             IniReader ini = new  IniReader(INIFlie);
            ini.Section = "DbSetting";
            if (ini.ReadString("Drive") != "")
            {
                return ini.ReadString("Drive");
            }
            else {
                return "D";
            }
         }
     }
    
           //Dim ini As IniReader = INIFileName
           //     Return ini.ReadString("UserID").ToString

    public class Item 
    {
      public string Name;
      public int Id;

      public Item(string name, int id) 
      {
          Name = name; 
          Id = id;
      }
} 
   
}
