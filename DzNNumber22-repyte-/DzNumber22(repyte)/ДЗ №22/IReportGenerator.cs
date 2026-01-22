using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ__22
{
    public delegate void EmployeeHandler(Employee employee);

    public interface IReportGenerator
    {
        void GenerateReport();
    }
}
