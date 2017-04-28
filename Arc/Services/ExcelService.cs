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

            OleDbConnection connection = null;
            if (strExt == ".xls")
            {
                connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fullPathFile + ";Extended Properties=Excel 8.0;");
            }
            else
            {
                if (strExt == ".xlsx")
                {
                    connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fullPathFile + ";Extended Properties=Excel 12.0;");
                }
            }

            try
            {
                String name = "Plan1";
                OleDbCommand command = new OleDbCommand("Select * From [" + name + "$]", connection);
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
