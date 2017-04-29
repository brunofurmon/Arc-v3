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
                connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0;", fullPathFile);
            }
            else if (strExt == ".xlsx")
            {
                connectionString = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0;", fullPathFile);
            }
            else
            {
                return null;
            }

            OleDbConnection connection = new OleDbConnection(connectionString);
            try
            {
                String name = "Plan1";
                OleDbCommand command = new OleDbCommand("SELECT * FROM [" + name + "$]", connection);
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
