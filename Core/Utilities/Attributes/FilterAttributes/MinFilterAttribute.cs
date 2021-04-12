using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Attributes.FilterAttributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class MinFilterAttribute : FilterAttribute
    {
        public MinFilterAttribute(string targetProperty) : base(targetProperty, "min")
        {
        }
    }
}
