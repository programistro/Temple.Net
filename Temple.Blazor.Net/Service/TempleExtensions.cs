namespace Temple.Net.Service;

using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using Temple.Net.Models;

public static class TempleExtensions
{
    public static void FillEmptyFields(this Temple temple)
    {
        // Получаем все свойства класса Temple
        var properties = typeof(Temple).GetProperties();

        foreach (var property in properties)
        {
            // Проверяем, является ли текущее свойство nullable
            // if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
            // {
            //
            // }
            // Получаем значение свойства
            var value = property.GetValue(temple);

            // Определяем тип свойства
            Type propertyType = Nullable.GetUnderlyingType(property.PropertyType);

            // Если значение равно null, устанавливаем его в подходящее значение по умолчанию
            if (value == null)
            {
                if (propertyType == typeof(DateTime)) // Специальная обработка для DateTime
                {
                    property.SetValue(temple, DateTime.MinValue); // Для DateTime устанавливаем DateTime.MinValue
                }
                else if (propertyType == typeof(int)) // Специальная обработка для int
                {
                    property.SetValue(temple, 0); // Для int устанавливаем 0
                }
                else
                {
                    property.SetValue(temple, "Пусто"); // Для других типов устанавливаем "Пусто"
                }
            }
            // Специальная обработка для DateTime?, чтобы не устанавливать DateTime.MinValue, если это не требуется
            else if (property.PropertyType == typeof(DateTime?) && !((DateTime?)value).HasValue)
            {
                property.SetValue(temple, null); // Устанавливаем в null для DateTime?, чтобы явно показать, что дата не была установлена
            }
        }
    }
}
