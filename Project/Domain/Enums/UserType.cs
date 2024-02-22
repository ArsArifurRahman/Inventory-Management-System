using System.ComponentModel;

namespace Domain.Enums;
public enum UserType
{
    [Description("Admin")] Admin,
    [Description("Sub-Admin")] SubAdmin,
    [Description("Sales Person")] SalesPerson
}
