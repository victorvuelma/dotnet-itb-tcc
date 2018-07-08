using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUERSHACK_COMMON.UTIL
{
    public class clnUtilConvert
    {

        public static bool isNull(object val)
        {
            return val == null || Convert.IsDBNull(val);
        }

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

        public static DateTime ObterData(object val) => DateTime.ParseExact(Convert.ToString(val), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

        public static DateTime? ObterNullableData(object val)
        {
            if (!isNull(val) && clnUtilValidar.validarData(val.ToString()))
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
