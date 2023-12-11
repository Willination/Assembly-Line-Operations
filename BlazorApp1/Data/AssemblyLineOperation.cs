using System.ComponentModel;
using System.Globalization;

namespace BlazorApp1.Data
{
    [TypeConverter(typeof(AssemblyLineOperationConverter))]
    public class AssemblyLineOperation
    {
        public int AssemblyLineOperationID { get; set; }
        public string? OperationName { get; set; }

        public int OrderInWhichToPerform { get; set; }
        public byte[]? OperationImageData { get; set; }
        public AssemblyLineDevice? AssemblyLineDevice { get; set; }
    }

    public class AssemblyLineOperationConverter : TypeConverter
    {
     
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

    
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string operationString)
            {
            
                return new AssemblyLineOperation { /* Initialize AssemblyLineOperation properties from operationString */ };
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}