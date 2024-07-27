using System.Globalization;

namespace Temple.Net.Service;

using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using Temple.Net.Models;

public static class TempleExtensions
{
    public static void FillEmptyFields<T>(this T target) where T : class
    {
        var properties = typeof(T).GetProperties();

        foreach (var property in properties)
        {
            var value = property.GetValue(target);

            Type propertyType = Nullable.GetUnderlyingType(property.PropertyType);

            if (value == null)
            {
                if (propertyType == typeof(DateOnly))
                {
                    property.SetValue(target, DateOnly.MinValue);
                }
                else if (propertyType == typeof(int))
                {
                    property.SetValue(target, 0);
                }
                else
                {
                    property.SetValue(target, "Пусто");
                }
            }
            else if (property.PropertyType == typeof(DateOnly?) && !((DateOnly?)value).HasValue)
            {
                property.SetValue(target, null);
            }
        }
    }
    
    public static DateOnly SetDateTime(this string value)
    {
        CultureInfo culture = new CultureInfo("ru-RU");

        string[] formats = { "dd.MM.yyyy", "MM.yyyy", "yyyy" };
        
        DateOnly dateTime;
        
        bool sucess = DateOnly.TryParseExact(value, formats, culture, DateTimeStyles.None, out dateTime);

        return dateTime;
    }
}
