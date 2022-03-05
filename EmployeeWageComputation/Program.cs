using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder empWageBuilder = new Builder();
            Builder.addCompanyEmpWage("DMart", 20, 2, 10);
            Builder.addCompanyEmpWage("Reliance", 10, 4, 20);
            Builder.computeEmpWage();
        }
    }
}