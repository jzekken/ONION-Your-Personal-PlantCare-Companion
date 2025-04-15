using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public class BaseUserControl : UserControl
    {
        protected OleDbConnection? myConn;
        protected OleDbDataAdapter? da;
        protected DataSet? ds;

        public BaseUserControl()
        {
            InitializeDatabase();
        }

        protected void InitializeDatabase()
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\ACER ASPIRE 3\\source\\repos\\ONION-Your-Personal-PlantCare-Companion\\Resources\\PlantData.accdb\"");
                ds = new DataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database: " + ex.Message);
            }
        }
        protected async Task<DataTable> FetchDataAsync(string query)
        {
            DataTable table = new DataTable();

            try
            {
                await Task.Run(() =>
                {
                    myConn.Open();
                    da = new OleDbDataAdapter(query, myConn);
                    da.Fill(table);
                    myConn.Close();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }

            return table;
        }
    }
}

