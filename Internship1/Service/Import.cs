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
    public class Import
    {
        public static List<ExportModel> ExportModels;
        public static List<ExportModel> ImportFileEn(string csv_file_path)
        {
            //string csv_file_path = @"C:\Users\Korisnik\Desktop\Posao\Internship - Execom\ExportModel.csv";
            string[] lines = System.IO.File.ReadAllLines(csv_file_path);
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                //ExportModel obj = new ExportModel(Convert.ToInt32(line[0].ToString()), line[7], line[16]);

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
        public static List<ExportModel> ImportFileDe(string csv_file_path) 
        {
            string[] lines = System.IO.File.ReadAllLines(csv_file_path);
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                //ExportModel obj = new ExportModel(Convert.ToInt32(line[0]), line[8], line[17]);
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
        public static List<ExportModel> ImportFileEs(string csv_file_path)
        {
            string[] lines = System.IO.File.ReadAllLines(csv_file_path);
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
               // ExportModel obj = new ExportModel(Convert.ToInt32(line[0]), line[9], line[18]);
                ExportModel obj = new ExportModel()
                {
                    ID = Convert.ToInt32(line[0]),
                    TITLE = line[9],
                    DETAILS = line[18]
                };
                /* ExportModel obj = new ExportModel()
                 {
                     Number = Convert.ToInt32(line[0]),
                     DisplayTitle = new DisplayTitle()
                     { 
                         Es = line[9]
                     },
                     DisplayDetails = new DisplayDetails()
                     {
                         Es = line[18]
                     }



                 };*/
                ExportModels.Add(obj);
            }

            return ExportModels;

        }

        public static List<ExportModel> ImportFileFr(string csv_file_path)
        {
            string[] lines = System.IO.File.ReadAllLines(csv_file_path);
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                // ExportModel obj = new ExportModel(Convert.ToInt32(line[0]), line[10], line[19]);
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
        public static List<ExportModel> ImportFileIt(string csv_file_path)
        {
            string[] lines = System.IO.File.ReadAllLines(csv_file_path);
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                //ExportModel obj = new ExportModel(Convert.ToInt32(line[0]), line[11], line[20]);
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
        
        public static List<ExportModel> ImportFileJa(string csv_file_path)
        {
            string[] lines = System.IO.File.ReadAllLines(csv_file_path);
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                //ExportModel obj = new ExportModel(Convert.ToInt32(line[0]), line[12], line[21]);
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
        public static List<ExportModel> ImportFilePt(string csv_file_path)
        {
            string[] lines = System.IO.File.ReadAllLines(csv_file_path);
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                //ExportModel obj = new ExportModel(Convert.ToInt32(line[0]), line[13], line[22]);
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
            public static List<ExportModel> ImportFileRu(string csv_file_path)
            {
            string[] lines = System.IO.File.ReadAllLines(csv_file_path);
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                //ExportModel obj = new ExportModel(Convert.ToInt32(line[0]), line[14], line[23]);
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
        public static List<ExportModel> ImportFileZh(string csv_file_path)
        {
            string[] lines = System.IO.File.ReadAllLines(csv_file_path);
            ExportModels = new List<ExportModel>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                //ExportModel obj = new ExportModel(Convert.ToInt32(line[0]), line[15], line[24]);
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