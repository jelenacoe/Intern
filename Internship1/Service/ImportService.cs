using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web.Mvc;
using System.Web;
using System.Text;
using Internship1.Models;
using Microsoft.Ajax.Utilities;
using System.Security.Cryptography.X509Certificates;

namespace Internship1.Service
{
    public class ImportService
    {
       
        //We index what we need with "ExportModel"
        //For each language index
        public static List<ExportModel> ExportModels;
        public static List<ExportModel> ImportFileEn(string[] lines)
        {
           
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                

                 ExportModel obj = new ExportModel()
                 {
                     ID = Convert.ToInt32(line[0]),
                     TITLE = line[7],
                     DETAILS = line[16]
                 };
                ExportModels.Add(obj);
            }
            
            return ExportModels;

 
        }
        public static List<ExportModel> ImportFileDe(string[] lines) 
        {
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                
                ExportModel obj = new ExportModel()
                {
                    ID = Convert.ToInt32(line[0]),
                    TITLE = line[8],
                    DETAILS = line[17]
                };




                ExportModels.Add(obj);
            }
            

            return ExportModels;
        }
        public static List<ExportModel> ImportFileEs(string[] lines)
        {
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                ExportModel obj = new ExportModel()
                {
                    ID = Convert.ToInt32(line[0]),
                    TITLE = line[9],
                    DETAILS = line[18]
                };
               
                 
                ExportModels.Add(obj);
            }

            return ExportModels;

        }

        public static List<ExportModel> ImportFileFr(string[] lines)
        {
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                ExportModel obj = new ExportModel()
                {
                    ID = Convert.ToInt32(line[0]),
                    TITLE = line[10],
                    DETAILS = line[19]
                };
                ExportModels.Add(obj);
            }

            return ExportModels;
        }
        public static List<ExportModel> ImportFileIt(string[] lines)
        {
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                ExportModel obj = new ExportModel()
                {
                    ID = Convert.ToInt32(line[0]),
                    TITLE = line[11],
                    DETAILS = line[20]
                };
                ExportModels.Add(obj);
            }

            return ExportModels;
        }
        
        public static List<ExportModel> ImportFileJa(string[] lines)
        {
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                ExportModel obj = new ExportModel()
                {
                    ID = Convert.ToInt32(line[0]),
                    TITLE = line[12],
                    DETAILS = line[21]
                };
                ExportModels.Add(obj);
            }

            return ExportModels;

        }
        public static List<ExportModel> ImportFilePt(string[] lines)
        {
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                ExportModel obj = new ExportModel()
                {
                    ID = Convert.ToInt32(line[0]),
                    TITLE = line[13],
                    DETAILS = line[22]
                };
                ExportModels.Add(obj);
            }

            return ExportModels;
        }
            public static List<ExportModel> ImportFileRu(string[] lines)
            {
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                ExportModel obj = new ExportModel()
                {
                    ID = Convert.ToInt32(line[0]),
                    TITLE = line[14],
                    DETAILS = line[23]
                };

                ExportModels.Add(obj);
            }

            return ExportModels;
        }
        public static List<ExportModel> ImportFileZh(string[] lines)
        {
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                ExportModel obj = new ExportModel()
                {
                    ID = Convert.ToInt32(line[0]),
                    TITLE = line[15],
                    DETAILS = line[24]
                };
                ExportModels.Add(obj);
            }

            return ExportModels;
        }

    }
          
}