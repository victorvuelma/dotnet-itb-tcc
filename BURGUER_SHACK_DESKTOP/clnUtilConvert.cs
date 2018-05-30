using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    class clnUtilConvert
    {

        public static int? ToNullableInt(object val)
        {
            if (val != null && !(val is DBNull))
                return ToInt(val);
            return null;
        }

        internal static int ToInt(object val) => Convert.ToInt32(val);

        public static DateTime? ToNullableDateTime(object val)
        {
            if (val != null && !(val is DBNull))
                return ToDateTime(val);
            return null;
        }

        internal static DateTime ToDateTime(object val) => Convert.ToDateTime(val);

        internal static string ToString(object val) => Convert.ToString(val);

        internal static DateTime ObterData(object val) => DateTime.ParseExact(Convert.ToString(val), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

        internal static DateTime? ObterNullableData(object val)
        {
            if (val != null && !(val is DBNull))
                return ObterData(val);
            return null;
        }

    }
}
