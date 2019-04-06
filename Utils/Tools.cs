
using System;

namespace Utils
{
    public static class Tools
    {
        public static string ErrorMessage(this Exception exception)
        {
            return  exception?.InnerException != null ? exception.InnerException.Message : exception?.Message;
        }

        public static int TryParseInt(this string value)
        {
            int.TryParse(value, out int valueInt);
            return valueInt;
        }
        
        public static DateTime TryParseDatetime(this string value)
        {
            DateTime.TryParse(value, out DateTime valueDatetime);
            return valueDatetime;
        }
    }
}
