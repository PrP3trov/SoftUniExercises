using System;
using System.Linq;
using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            PropertyInfo[] propWithAttributes = properties
                .Where(p => Attribute.IsDefined(p, typeof(MyValidationAttribute),true))
                .ToArray();
            foreach (var prop in propWithAttributes)
            {
                var validation = prop.GetCustomAttributes(typeof(MyValidationAttribute), true)
                      .Cast<MyValidationAttribute>();
                foreach (var attr in validation)
                {
                    object value = prop.GetValue(obj);
                    if (attr.IsValid(value) == false)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
