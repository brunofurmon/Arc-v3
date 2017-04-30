using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;


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

            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                string name = "Plan1";
                string selectionString = string.Format("SELECT * FROM [{0}$]", name);

                OleDbCommand command = new OleDbCommand(selectionString, connection);
                connection.Open();

                OleDbDataAdapter sda = new OleDbDataAdapter(command);
                DataTable data = new DataTable();
                sda.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }
    }
}
