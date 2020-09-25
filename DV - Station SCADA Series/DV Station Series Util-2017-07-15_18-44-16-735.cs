using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;
using DVGMap;

namespace DV_Station_SCADA_Series
{
    class DV_Station_Series_Util
    {
        public DataTable LoadSeries(string aFilename, string aSheetname)
        {
            DataTable DataTable = new DataTable(aFilename);
            DataTableUtils DBUtil = new DataTableUtils();
            try
            {
                if (File.Exists(aFilename))
                {
                    try
                    {
                        DataTable = DBUtil.ExcelToDataTable(aFilename, aSheetname);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("File " + aFilename + " does not exists");
                }

                return DataTable;
            }
            finally
            {
                //
            }
        }

    }
}
