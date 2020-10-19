using Internship1.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Internship1.Service
{
    public class UserDownload
    {
        public void Download_Click(List<ExportModel> model, System.EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "csvfile|*.csv";
            sfd.Title = "Save a .csv File";
            sfd.ShowDialog();


            // If the file name is not an empty string open it for saving.
            if (sfd.FileName != "")
            {

                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)sfd.OpenFile();
                


                fs.Close();
            }
        }
    }   
}