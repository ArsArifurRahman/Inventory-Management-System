namespace Domain.Extensions;
using System;
using System.ComponentModel;
using System.Reflection;

public static class EnumExtension
{
    public static string GetDescription(this Enum value)
    {
        FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
        DescriptionAttribute attribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();
        return attribute?.Description;
    }
}

