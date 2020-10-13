using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Internship1.Models
{
    public class ExportModel
    {
        public int ID;
        public string TITLE;
        public string DETAILS;

        public ExportModel()
        { }
             public ExportModel(int id, string title, string details)
             {
                 int ID=id;
                 string TITLE=title;
                 string DETAILS=details;
             }
        }
}