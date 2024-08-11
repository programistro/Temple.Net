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
            var propertyType = property.PropertyType;

            // Проверяем, является ли свойство коллекцией
            bool isCollection = propertyType.IsGenericType && 
                                (propertyType.GetGenericTypeDefinition() == typeof(ICollection<>) || 
                                 propertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>));

            // Если значение null и свойство не является коллекцией
            if (value == null && !isCollection)
            {
                // Обработка nullable типов
                var underlyingType = Nullable.GetUnderlyingType(propertyType);
                if (underlyingType != null)
                {
                    propertyType = underlyingType;
                }

                // Установка значений по умолчанию
                if (propertyType == typeof(DateOnly))
                {
                    property.SetValue(target, DateOnly.MinValue);
                }
                else if (propertyType == typeof(int))
                {
                    property.SetValue(target, 0);
                }
                else if (propertyType == typeof(string))
                {
                    property.SetValue(target, "Пусто");
                }
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
