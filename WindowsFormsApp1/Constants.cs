using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiddenAnaconda
{
    public static class Constants
    {
        public const int NumberOfSecondSInDay = 86400;
        public const string DateFormat = "yyy.MM.dd";
        public const string AdminPermission = "Administrator";
        public const string DriverPermission = "Kierowca";
        public const string MenagerPermission = "Menedżer";
        public const string RoutePlannerPermission = "Układacz Tras";
        public const string DateElementForArrivalTime = "01.01.1900 ";
        public static int TranslatePermissionLevel(string permission)
        {
            switch (permission) {
                case (AdminPermission):
                    return 6;
                case (RoutePlannerPermission):
                    return 4;
                case (MenagerPermission):
                    return 2;
                case (DriverPermission):
                    return 0;
            }
            return 0;
        }
    }

}
