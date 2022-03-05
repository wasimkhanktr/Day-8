using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    interface Compute
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMnth);
        void computeEmpWage();

        int getTotalWage(string company);
    }
}