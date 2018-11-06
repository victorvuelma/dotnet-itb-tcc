using System;

namespace vitorrdgs.Util.Data
{
    public class UtilConvert
    {

        public static bool isNull(object val) => (val == null || Convert.IsDBNull(val));

        public static int? ToNullableInt(object val)
        {
            if (!isNull(val))
                return ToInt(val);
            return null;
        }

        public static int ToInt(object val) => Convert.ToInt32(val);

        public static double? ToNullableDouble(object val)
        {
            if (!isNull(val))
                return ToDouble(val);
            return null;
        }

        public static double ToDouble(object val) => Convert.ToDouble(val);

        public static decimal? ToNullableDecimal(object val)
        {
            if (!isNull(val))
                return ToDecimal(val);
            return null;
        }

        public static decimal ToDecimal(object val) => Convert.ToDecimal(val);

        public static DateTime? ToNullableDateTime(object val)
        {
            if (!isNull(val))
                return ToDateTime(val);
            return null;
        }

        public static DateTime ToDateTime(object val) => Convert.ToDateTime(val);

        public static string ToString(object val) => Convert.ToString(val);

        public static DateTime ObterData(object val)
        {
            if (DateTime.TryParseExact(Convert.ToString(val), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime result))
            {
                return result;
            }
                return DateTime.ParseExact(Convert.ToString(val), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }

        public static DateTime? ObterNullableData(object val)
        {
            if (!isNull(val) && UtilValidar.validarData(val.ToString()))
                return ObterData(val);
            return null;
        }

        public static DateTime ObterHora(object val) => DateTime.ParseExact(Convert.ToString(val), "HH:mm", System.Globalization.CultureInfo.InvariantCulture);

        public static char? ToNullableChar(object val)
        {
            if (!isNull(val))
                return ToNullableChar(val);
            return null;
        }

        public static char ToChar(object val) => Convert.ToChar(val);

        public static bool ToBool(object val) => Convert.ToBoolean(val);

        public static object ToBit(object val) => (val.Equals(true) ? 1 : 0);

    }
}
