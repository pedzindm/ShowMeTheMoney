using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Office.Core;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections;
using System.Data;

namespace DBapp
{
    class ExcelH
    {
        private Excel.Application app;
        private Excel.Workbook sourcebk;
        private Excel.Worksheet sourcesh;
        ArrayList Clients = new ArrayList();

        private void OpenSourceWorkbook(string workbookPath)
        {

            this.sourcebk = app.Workbooks.Open(workbookPath, 0, true, 5, "", "", false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            sourcebk.BeforeClose += new Microsoft.Office.Interop.Excel.WorkbookEvents_BeforeCloseEventHandler(sourcebk_BeforeClose);

        }


        private void sourcebk_BeforeClose(ref bool Cancel)
        {
            sourcebk.Saved = true;
        }

        private Excel.Worksheet getSourceWorkSheet(string sheetname)
        {
            sourcesh = sourcebk.Sheets[sheetname];
            return sourcesh;
        }

        private void addClient(Customer cust)
        {
            Clients.Add(cust);
        }

        private void closesourcebk()
        {
            app.Workbooks.Close();
        }


        public ArrayList getclients(ExcelH excel, string path)
        {
            populateClients( excel, path);

                return Clients;
        }
        private void populateClients(ExcelH excel, string path)
        {
            //creates new excel applciation
            app = new Excel.Application();


            string ifcClientDirectory = path;

            string[] temp = Directory.GetDirectories(ifcClientDirectory);

            foreach (string str in temp)
            {
                Customer tempCust = new Customer();
                tempCust.percentage = new string[26];
                tempCust.category = new string[26];
                tempCust.Path = path;
                tempCust.filename = Path.GetFileName(str);

                string[] chunks = tempCust.filename.Split(new char[] { '-' });

                if (chunks.Length < 2)
                {
                    tempCust.CustomerID = "null";
                    tempCust.CustomerName = "null";
                    continue;
                }
                else
                {
                    string tempID = chunks[1].Trim();
                    string tempname = chunks[0].Trim();
                    tempCust.CustomerID = tempID;
                    tempCust.CustomerName = tempname;
                }

                tempCust.Path += "\\" + tempCust.filename;

                excel.OpenSourceWorkbook(this.getworkbook(tempCust));

                transfer(excel, tempCust, tempCust.Path);
                excel.addClient(tempCust);

            }


            closesourcebk();
            app.Quit();
        }

        private void transfer(ExcelH excel, Customer tempcust, string p)
        {
            int i = 0;
            Excel.Worksheet ws = excel.getSourceWorkSheet("OBJECTIVES & ASSET ALLOCATION");
            while (i < 26)
            {
                if (ws.Cells[13 + i, 4].Value2 != null)
                {

                    tempcust.percentage[i] = ws.Cells[13 + i, 4].Value2.ToString();
                }
                else
                {
                    tempcust.percentage[i] = "0";

                }


                tempcust.category[i] = ws.Cells[13 + i, 3].Value2.ToString();

                i++;

            }
            excel.closesourcebk();
        }

        private string getworkbook(Customer cust)
        {

            cust.Path += "\\PERMANENT";

            string[] permanentFiles = Directory.GetFiles(cust.Path, "CPT*.xls*");

            if (permanentFiles.Length != 1)
            {
                return null;
            }

            string WBPATH = permanentFiles[0];

            return WBPATH;
        }

    }


    }

