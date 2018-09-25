using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Models;


namespace DAL
{
    public class JobListService
    {
        public DataSet GetAllDepartment()
        {
            string sql = "select DepartmentName,DepartmentID from JobList";
            return SQLHelper.GetDataSet(sql);
        }
    }
}
