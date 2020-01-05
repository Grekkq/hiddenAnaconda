using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hiddenAnaconda {
    public static class Constants {
        public const int NumberOfSecondSInDay = 86400;
        public const string DateFormat = "yyy.MM.dd";
        public const string AdminPermission = "Administrator";
        public const string DriverPermission = "Kierowca";
        public const string MenagerPermission = "Menedżer";
        public const string RoutePlannerPermission = "Układacz Tras";
        public const string DateElementForArrivalTime = "01.01.1900 ";
        public const string OneWayStop = "jednokierunkowy";
        public const string BusStopName = "BusStopName";
        public const string BusStopCityName = "BusStopCityName";
        public const string BusStopWay = "BusStopWay";
        public const string ListBoxNumberDelimiter = ".";
        //generacja raportu
        public const string WorkDays = "roboczy";
        public const string WorkDaysAlias = "Od Poniedziałku do Piątku";
        public const string DaysOff = "wolny";
        public const string DaysOffAlias = "Wolne";
        public const string Holidays = "świąteczny";
        public const string HolidaysAlias = "Święta";

        public static readonly Regex FindArrivalTimeInString = new Regex(@"\d[0-9]([^\d]|$)");
        public static readonly Regex ValidateTimeFormat = new Regex(@"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");

        public static int TranslatePermissionLevel(string permission) {
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

        public static string TranslatePermissionLevel(int permission) {
            switch (permission) {
                case (6):
                    return AdminPermission;
                case (4):
                    return RoutePlannerPermission;
                case (2):
                    return MenagerPermission;
                case (0):
                    return DriverPermission;
            }
            return DriverPermission;
        }
    }

}
