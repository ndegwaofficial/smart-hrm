using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.DataAccess;
using SmartHRM.Models;
using SmartHRM.DataAccess.Repository;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json.Linq;

namespace SmartHRMWeb.Helpers
{
    public static class FunctionHelper
    {
       
        static FunctionHelper()
        {
          
           
        }

        public static double getnightshiftamount(double HoursWorked,double nightshiftRate)
        {
            return HoursWorked * nightshiftRate;
        }

        public static double getamountcasualovertime(int empID, double dblvalue,double empdays, double multiplier, ApplicationDbContext _db)
        {
            double dblrate = 0;
            var results = (from emp in _db.Employees
                           join grade in _db.EmployeeGrades
                           on emp.EmployeeGradeId equals grade.Id
                           where emp.Id == empID
                           select new
                           {
                               emp.Id,
                               emp.EmployeeCategoryId,
                               emp.BasicPay,
                               grade.DailyRate,
                               grade.HourlyRate,
                               grade.opthourly,
                               grade.optdaily,
                               grade.opttonnage,
                               grade.TonnageRate,
                               grade.permanentemp
                           }).SingleOrDefault();

            if (results != null)
            {
                if (results.permanentemp == true)
                {
                    if (results.BasicPay > 0)
                    {
                        return ((((results.BasicPay / empdays)/8) * dblvalue)*multiplier);
                    }
                    
                }
                else
                {
                    if (results?.opthourly == true)
                    {
                        dblrate = results.HourlyRate;
                    }
                    else if (results?.optdaily == true)
                    {
                        dblrate = (results.DailyRate) / 8;
                    }
                    else if (results?.opttonnage == true)
                    {
                        dblrate = results.TonnageRate;
                    }
                    return (multiplier * dblvalue * dblrate);
                }

            }

            return 0;
        }

        public static double getamountcasual(int empID, double dblvalue, double empdays, ApplicationDbContext _db)
        {
            double dblrate = 0;
            var results = (from emp in _db.Employees
                           join grade in _db.EmployeeGrades
                           on emp.EmployeeGradeId equals grade.Id
                           where emp.Id == empID
                           select new
                           {
                               emp.Id,
                               emp.EmployeeCategoryId,
                               emp.BasicPay,
                               grade.DailyRate,
                               grade.HourlyRate,
                               grade.opthourly,
                               grade.optdaily,
                               grade.opttonnage,
                               grade.TonnageRate,
                               grade.permanentemp
                           }).SingleOrDefault();

            if (results != null)
            {
                if (results.permanentemp == true)
                {
                    if (results.BasicPay > 0)
                    {
                        return ((results.BasicPay / empdays) * dblvalue);
                    }
                    else
                    {
                        return 0;
                    }


                }
                
            }

            return 0;
        }

        public static double gethoursdaysamount(int empID, double dblvalue, double multiplier, ApplicationDbContext _db)
        {
            double dblrate = 0;
            var results = (from emp in _db.Employees                          
                        join grade in _db.EmployeeGrades
                        on emp.EmployeeGradeId equals grade.Id
                        where emp.Id == empID
                        select new
                        {
                            emp.Id,
                            emp.EmployeeCategoryId,
                            emp.BasicPay ,
                            grade.DailyRate,
                            grade.HourlyRate,
                            grade.opthourly,
                            grade.optdaily,
                            grade.opttonnage,
                            grade.TonnageRate,
                            grade.permanentemp
                        }).SingleOrDefault();

            if(results != null)
            {
                if (results?.opthourly == true)
                {
                    dblrate = results.HourlyRate;
                }
                else if (results?.optdaily == true)
                {
                    dblrate = (results.DailyRate) / 8;
                }
                else if (results?.opttonnage == true)
                {
                    dblrate = results.TonnageRate;
                }
                return (multiplier * dblvalue * dblrate);
            }
                           
            return 0;
        }

    }
}
