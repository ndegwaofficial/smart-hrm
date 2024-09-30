using System.Collections.Generic;

namespace SmartHRM.Utility.Constants
{
public static class Permissions
{
    public static List<string> GeneratePermissionsForModule(string module)
    {
        return new List<string>()
        {
            $"Permissions.{module}.Create",
            $"Permissions.{module}.View",
            $"Permissions.{module}.Edit",
            $"Permissions.{module}.Delete",
        };
    }

    public static class Employee
    {
        public const string View = "Permissions.Employee.View";
        public const string Create = "Permissions.Employee.Create";
        public const string Edit = "Permissions.Employee.Edit";
        public const string Delete = "Permissions.Employee.Delete";
    }
}
}