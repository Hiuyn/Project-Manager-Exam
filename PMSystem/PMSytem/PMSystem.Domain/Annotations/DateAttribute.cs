using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace PMSystem.Domain.Annotations
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class DateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is not string dateString) return true;
            string[] formats = { "dd/MM/yyyy" };
            var success = DateTime.TryParseExact(dateString, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
            return success;
        }
    }
}
