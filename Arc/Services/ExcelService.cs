using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;


namespace Arc.Services
{
    public static class ExcelService
    {
        public static DataTable CreateDataTableFromExcelFile(string fullPathFile)
        {
            string strExt = "";
            strExt = fullPathFile.Substring(fullPathFile.LastIndexOf("."));
            string connectionString;

            if (strExt == ".xls")
            {
                connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=No';", fullPathFile);
            }
            else if (strExt == ".xlsx")
            {
                connectionString = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=No';", fullPathFile);
            }
            else
            {
                return null;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    DataTable dtSheet = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    // Lists of sheets on file (We are actually only interested on the first one)
                    List<string> sheets = new List<string>();

                    foreach (DataRow drSheet in dtSheet.Rows)
                    {
                        if (drSheet["TABLE_NAME"].ToString().Contains("$"))//checks whether row contains '_xlnm#_FilterDatabase' or sheet name(i.e. sheet name always ends with $ sign)
                        {
                            sheets.Add(drSheet["TABLE_NAME"].ToString());
                        }
                    }

                    string firstSheetName = sheets[0];
                    string selectionString = string.Format("SELECT * FROM [{0}]", firstSheetName);
                    OleDbCommand command = new OleDbCommand(selectionString, connection);

                    OleDbDataAdapter sda = new OleDbDataAdapter(command);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    return data;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
