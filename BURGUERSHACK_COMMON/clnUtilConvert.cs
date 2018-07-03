﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUERSHACK_DESKTOP
{
    class clnUtilConvert
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

        internal static int ToInt(object val) => Convert.ToInt32(val);

        public static double? ToNullableDouble(object val)
        {
            if (!isNull(val))
                return ToDouble(val);
            return null;
        }

        internal static double ToDouble(object val) => Convert.ToDouble(val);

        public static decimal? ToNullableDecimal(object val)
        {
            if (!isNull(val))
                return ToDecimal(val);
            return null;
        }

        internal static decimal ToDecimal(object val) => Convert.ToDecimal(val);

        public static DateTime? ToNullableDateTime(object val)
        {
            if (!isNull(val))
                return ToDateTime(val);
            return null;
        }

        internal static DateTime ToDateTime(object val) => Convert.ToDateTime(val);

        internal static string ToString(object val) => Convert.ToString(val);

        internal static DateTime ObterData(object val) => DateTime.ParseExact(Convert.ToString(val), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

        internal static DateTime? ObterNullableData(object val)
        {
            if (!isNull(val) && clnUtil.validarData(val.ToString()))
                return ObterData(val);
            return null;
        }

        internal static DateTime ObterHora(object val) => DateTime.ParseExact(Convert.ToString(val), "HH:mm", System.Globalization.CultureInfo.InvariantCulture);

        internal static char? ToNullableChar(object val)
        {
            if (!isNull(val))
                return ToNullableChar(val);
            return null;
        }

        internal static char ToChar(object val) => Convert.ToChar(val);

        internal static bool ToBool(object val) => Convert.ToBoolean(val);

        internal static object ToBit(object val) => (val.Equals(true) ? 1 : 0);

    }
}
