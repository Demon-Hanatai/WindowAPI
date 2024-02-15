using WindowAPI.winnls.Enums;
using WindowAPI.winnls.Structures;
using static WindowAPI.winnls.CallBacks.CallBacks;
namespace WindowAPI.winnls
{
    public static class Functions
    {

        /// <summary>
        ///Compares two character strings, for a locale specified by identifier.
        /// </summary>
        /// <param name="Locale">Locale identifier of the locale used for the comparison. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwCmpFlags">Flags that indicate how the function compares the two strings. For detailed definitions, see the dwCmpFlags parameter of CompareStringEx.</param>
        /// <param name="lpString1">Pointer to the first string to compare.</param>
        /// <param name="cchCount1">Length of the string indicated by lpString1, excluding the terminating null character. This value represents bytes for the ANSI version of the function and wide characters for the Unicode version. The application can supply a negative value if the string is null-terminated. In this case, the function determines the length automatically.</param>
        /// <param name="lpString2">Pointer to the second string to compare.</param>
        /// <param name="cchCount2">Length of the string indicated by lpString2, excluding the terminating null character. This value represents bytes for the ANSI version of the function and wide characters for the Unicode version. The application can supply a negative value if the string is null-terminated. In this case, the function determines the length automatically.</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int CompareString(LUID Locale, uint dwCmpFlags, string lpString1, int cchCount1, string lpString2, int cchCount2);

        /// <summary>
        ///Compares two character strings, for a locale specified by identifier.
        /// </summary>
        /// <param name="Locale">Locale identifier of the locale used for the comparison. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwCmpFlags">Flags that indicate how the function compares the two strings. For detailed definitions, see the dwCmpFlags parameter of CompareStringEx.</param>
        /// <param name="lpString1">Pointer to the first string to compare.</param>
        /// <param name="cchCount1">Length of the string indicated by lpString1, excluding the terminating null character. This value represents bytes for the ANSI version of the function and wide characters for the Unicode version. The application can supply a negative value if the string is null-terminated. In this case, the function determines the length automatically.</param>
        /// <param name="lpString2">Pointer to the second string to compare.</param>
        /// <param name="cchCount2">Length of the string indicated by lpString2, excluding the terminating null character. This value represents bytes for the ANSI version of the function and wide characters for the Unicode version. The application can supply a negative value if the string is null-terminated. In this case, the function determines the length automatically.</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int CompareStringA(LUID Locale, uint dwCmpFlags, PANOSE lpString1, int cchCount1, PANOSE lpString2, int cchCount2);

        /// <summary>
        ///Converts a default locale value to an actual locale identifier.
        /// </summary>
        /// <param name="Locale">Default locale identifier value to convert. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern LUID ConvertDefaultLocale(LUID Locale);

        /// <summary>
        ///Enumerates calendar information for a specified locale.
        /// </summary>
        /// <param name="lpCalInfoEnumProc">Pointer to an application-defined callback function. For more information, see EnumCalendarInfoProc.</param>
        /// <param name="Locale">Locale identifier that specifies the locale for which to retrieve calendar information. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="Calendar">Calendar identifier that specifies the calendar for which information is requested. Note that this identifier can be ENUM_ALL_CALENDARS, to enumerate all calendars that are associated with the locale.</param>
        /// <param name="CalType">Type of calendar information. For more information, see Calendar Type Information. Only one calendar type can be specified per call to this function, except where noted.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumCalendarInfoA(ICMENUMPROCA lpCalInfoEnumProc, LUID Locale, ushort Calendar, nint CalType);

        /// <summary>
        ///Enumerates calendar information for a locale specified by name.
        /// </summary>
        /// <param name="pCalInfoEnumProcExEx">Pointer to an application-defined callback function. For more information, see EnumCalendarInfoProcExEx.</param>
        /// <param name="lpLocaleName"></param>
        /// <param name="Calendar">Calendar identifier that specifies the calendar for which information is requested. Note that this identifier can be ENUM_ALL_CALENDARS, to enumerate all calendars that are associated with the locale.</param>
        /// <param name="lpReserved"></param>
        /// <param name="CalType">Type of calendar information. For more information, see Calendar Type Information. Only one calendar type can be specified per call to this function, except where noted.</param>
        /// <param name="lParam">Application-provided parameter to pass to the callback function. This value is especially useful for multi-threaded applications.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumCalendarInfoExEx(LOCALEENUMPROCEX pCalInfoEnumProcExEx, string lpLocaleName, ushort Calendar, string lpReserved, nint CalType, nint lParam);

        /// <summary>
        ///Enumerates calendar information for a specified locale.
        /// </summary>
        /// <param name="lpCalInfoEnumProc">Pointer to an application-defined callback function. For more information, see EnumCalendarInfoProc.</param>
        /// <param name="Locale">Locale identifier that specifies the locale for which to retrieve calendar information. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="Calendar">Calendar identifier that specifies the calendar for which information is requested. Note that this identifier can be ENUM_ALL_CALENDARS, to enumerate all calendars that are associated with the locale.</param>
        /// <param name="CalType">Type of calendar information. For more information, see Calendar Type Information. Only one calendar type can be specified per call to this function, except where noted.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumCalendarInfoW(ICMENUMPROCW lpCalInfoEnumProc, LUID Locale, ushort Calendar, nint CalType);

        /// <summary>
        ///Enumerates the long date, short date, or year/month formats that are available for a specified locale.
        /// </summary>
        /// <param name="lpDateFmtEnumProcEx">Pointer to an application-defined callback function. For more information, see EnumDateFormatsProcEx.</param>
        /// <param name="Locale">Locale identifier that specifies the locale for which to retrieve date format information. You can use the MAKELCID macro to create an identifier or use one of the following predefined values.</param>
        /// <param name="dwFlags">Flag specifying date formats. For detailed definitions, see the dwFlags parameter of EnumDateFormatsExEx.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumDateFormatsExA(PROPENUMPROCEXA lpDateFmtEnumProcEx, LUID Locale, uint dwFlags);

        /// <summary>
        ///Enumerates the long date, short date, or year/month formats that are available for a specified locale.
        /// </summary>
        /// <param name="lpDateFmtEnumProcEx">Pointer to an application-defined callback function. For more information, see EnumDateFormatsProcEx.</param>
        /// <param name="Locale">Locale identifier that specifies the locale for which to retrieve date format information. You can use the MAKELCID macro to create an identifier or use one of the following predefined values.</param>
        /// <param name="dwFlags">Flag specifying date formats. For detailed definitions, see the dwFlags parameter of EnumDateFormatsExEx.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumDateFormatsExW(PROPENUMPROCEXW lpDateFmtEnumProcEx, LUID Locale, uint dwFlags);

        /// <summary>
        ///Enumerates the two-letter International Organization for Standardization (ISO) 3166-1 codes or numeric United Nations (UN) Series M, Number 49 (M.49) codes for geographical locations that are available on the operating system.
        /// </summary>
        /// <param name="geoClass">The geographical location class for which to enumerate the available two-letter ISO 3166-1 or numeric UN M.49 codes.</param>
        /// <param name="geoEnumProc">Pointer to the application-defined callback function Geo_EnumNameProc. The EnumSystemGeoNames function calls this callback function for each of the two-letter ISO 3166-1 or numeric UN M.49 codes for geographical locations that are available on the operating system until callback function returns FALSE.</param>
        /// <param name="data"></param>
        /// <remarks>
        /// To get extended error information, call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumSystemGeoNames(SYSGEOCLASS geoClass, GEOENUMNAMEPROC geoEnumProc, nint data);

        /// <summary>
        ///Enumerates the language groups that are either installed on or supported by an operating system.
        /// </summary>
        /// <param name="lpLanguageGroupEnumProc">Pointer to an application-defined callback function. For more information, see EnumLanguageGroupsProc.</param>
        /// <param name="dwFlags">Flags specifying the language group identifiers to enumerate. This parameter can have one of the following values.</param>
        /// <param name="lParam">Application-defined value to pass to the callback function. This parameter can be used in error checking. It can also be used to ensure thread safety in the callback function.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumSystemLanguageGroupsA(UILANGUAGEENUMPROCA lpLanguageGroupEnumProc, uint dwFlags, int lParam);

        /// <summary>
        ///Enumerates the language groups that are either installed on or supported by an operating system.
        /// </summary>
        /// <param name="lpLanguageGroupEnumProc">Pointer to an application-defined callback function. For more information, see EnumLanguageGroupsProc.</param>
        /// <param name="dwFlags">Flags specifying the language group identifiers to enumerate. This parameter can have one of the following values.</param>
        /// <param name="lParam">Application-defined value to pass to the callback function. This parameter can be used in error checking. It can also be used to ensure thread safety in the callback function.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumSystemLanguageGroupsW(UILANGUAGEENUMPROCW lpLanguageGroupEnumProc, uint dwFlags, int lParam);

        /// <summary>
        ///Enumerates the locales that are either installed on or supported by an operating system.
        /// </summary>
        /// <param name="lpLocaleEnumProc">Pointer to an application-defined callback function. For more information, see EnumLocalesProc.</param>
        /// <param name="dwFlags">Flags specifying the locale identifiers to enumerate. The flags can be used singly or combined using a binary OR. If the application specifies 0 for this parameter, the function behaves as for LCID_SUPPORTED.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumSystemLocalesA(LOCALEENUMPROCEX lpLocaleEnumProc, uint dwFlags);

        /// <summary>
        ///Enumerates the locales that are either installed on or supported by an operating system.
        /// </summary>
        /// <param name="lpLocaleEnumProcEx">Pointer to an application-defined callback function. The EnumSystemLocalesEx function enumerates locales by making repeated calls to this callback function. For more information, see EnumLocalesProcEx.</param>
        /// <param name="dwFlags">Flags identifying the locales to enumerate. The flags can be used singly or combined using a binary OR. If the application specifies 0 for this parameter, the function behaves as for LOCALE_ALL.</param>
        /// <param name="lParam">An application-provided parameter to be passed to the callback function. This is especially useful for multi-threaded applications.</param>
        /// <param name="lpReserved"></param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumSystemLocalesEx(LOCALEENUMPROCEX lpLocaleEnumProcEx, uint dwFlags, nint lParam, nint lpReserved);

        /// <summary>
        ///Enumerates the locales that are either installed on or supported by an operating system.
        /// </summary>
        /// <param name="lpLocaleEnumProc">Pointer to an application-defined callback function. For more information, see EnumLocalesProc.</param>
        /// <param name="dwFlags">Flags specifying the locale identifiers to enumerate. The flags can be used singly or combined using a binary OR. If the application specifies 0 for this parameter, the function behaves as for LCID_SUPPORTED.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumSystemLocalesW(LOCALEENUMPROCEX lpLocaleEnumProc, uint dwFlags);

        /// <summary>
        ///Enumerates the time formats that are available for a locale specified by identifier.
        /// </summary>
        /// <param name="lpTimeFmtEnumProc">Pointer to an application-defined callback function. For more information, see EnumTimeFormatsProc.</param>
        /// <param name="Locale">Locale identifier that specifies the locale for which to retrieve time format information. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwFlags">The time format. This parameter can specify a combination of any of the following values.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumTimeFormatsA(ICMENUMPROCA lpTimeFmtEnumProc, LUID Locale, uint dwFlags);

        /// <summary>
        ///Enumerates the time formats that are available for a locale specified by name.
        /// </summary>
        /// <param name="lpTimeFmtEnumProcEx">Pointer to an application-defined callback function. For more information, see EnumTimeFormatsProcEx.</param>
        /// <param name="lpLocaleName"></param>
        /// <param name="dwFlags">The time format. Set to 0 to use the current user's long time format, or TIME_NOSECONDS (starting with Windows 7) to use the short time format.</param>
        /// <param name="lParam">An application-provided parameter to be passed to the callback function. This is especially useful for multi-threaded applications.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumTimeFormatsEx(ICMENUMPROCA lpTimeFmtEnumProcEx, string lpLocaleName, uint dwFlags, nint lParam);

        /// <summary>
        ///Enumerates the time formats that are available for a locale specified by identifier.
        /// </summary>
        /// <param name="lpTimeFmtEnumProc">Pointer to an application-defined callback function. For more information, see EnumTimeFormatsProc.</param>
        /// <param name="Locale">Locale identifier that specifies the locale for which to retrieve time format information. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwFlags">The time format. This parameter can specify a combination of any of the following values.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumTimeFormatsW(ICMENUMPROCW lpTimeFmtEnumProc, LUID Locale, uint dwFlags);

        /// <summary>
        ///Locates a Unicode string (wide characters) or its equivalent in another Unicode string for a locale specified by identifier.
        /// </summary>
        /// <param name="Locale">Locale identifier that specifies the locale. You can use the MAKELCID macro to create an identifier or use one of the following predefined values.</param>
        /// <param name="dwFindNLSStringFlags">Flags specifying details of the find operation. For detailed definitions, see the dwFindNLSStringFlags parameter of FindNLSStringEx.</param>
        /// <param name="lpStringSource">Pointer to the source string, in which the function searches for the string specified by lpStringValue.</param>
        /// <param name="cchSource">Size, in characters excluding the terminating null character, of the string indicated by lpStringSource. The application cannot specify 0 or any negative number other than -1 for this parameter. The application specifies -1 if the source string is null-terminated and the function should calculate the size automatically.</param>
        /// <param name="lpStringValue">Pointer to the search string, for which the function searches in the source string.</param>
        /// <param name="cchValue">Size, in characters excluding the terminating null character, of the string indicated by lpStringValue. The application cannot specify 0 or any negative number other than -1 for this parameter. The application specifies -1 if the search string is null-terminated and the function should calculate the size automatically.</param>
        /// <param name="pcchFound"></param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int FindNLSString(LUID Locale, uint dwFindNLSStringFlags, string lpStringSource, int cchSource, string lpStringValue, int cchValue, out int pcchFound);

        /// <summary>
        ///Maps one Unicode string to another, performing the specified transformation. For an overview of the use of the string functions, see Strings.
        /// </summary>
        /// <param name="dwMapFlags">Flags specifying the type of transformation to use during string mapping. This parameter can be a combination of the following values.</param>
        /// <param name="lpSrcStr">Pointer to a source string that the function maps.</param>
        /// <param name="cchSrc">Size, in characters, of the source string indicated by lpSrcStr, excluding the terminating null character. The application can set the parameter to any negative value to specify that the source string is null-terminated. In this case, the function calculates the string length automatically, and null-terminates the mapped string indicated by lpDestStr.</param>
        /// <param name="lpDestStr"></param>
        /// <param name="cchDest">Size, in characters, of the destination string indicated by lpDestStr. If space for a terminating null character is included in cchSrc, cchDest must also include space for a terminating null character.The application can set cchDest to 0. In this case, the function does not use the lpDestStr parameter and returns the required buffer size for the mapped string. If the MAP_FOLDDIGITS flag is specified, the return value is the maximum size required, even if the actual number of characters needed is smaller than the maximum size. If the maximum size is not passed, the function fails with ERROR_INSUFFICIENT_BUFFER.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int FoldStringA(uint dwMapFlags, string lpSrcStr, int cchSrc, out string lpDestStr, int cchDest);

        /// <summary>
        ///Retrieves information about any valid installed or available code page.
        /// </summary>
        /// <param name="CodePage">Identifier for the code page for which to retrieve information. For details, see the CodePage parameter of GetCPInfoEx.</param>
        /// <param name="lpCPInfo"></param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetCPInfo(uint CodePage, out CPINFO lpCPInfo);

        /// <summary>
        ///Formats a number string as a currency string for a locale specified by identifier.
        /// </summary>
        /// <param name="Locale">Locale identifier that specifies the locale for which this function formats the currency string. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwFlags">Flags controlling currency format. The application must set this parameter to 0 if lpFormat is not set to NULL. In this case, the function formats the string using user overrides to the default currency format for the locale. If lpFormat is set to NULL, the application can specify LOCALE_NOUSEROVERRIDE to format the string using the system default currency format for the specified locale.</param>
        /// <param name="lpValue">For details, see the lpValue parameter of GetCurrencyFormatEx.</param>
        /// <param name="lpFormat"></param>
        /// <param name="lpCurrencyStr"></param>
        /// <param name="cchCurrency">Size, in characters, of the lpCurrencyStr buffer. The application sets this parameter to 0 if the function is to return the size of the buffer required to hold the formatted currency string. In this case, the lpCurrencyStr parameter is not used.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetCurrencyFormatA(LUID Locale, uint dwFlags, string lpValue, CURRENCYFMTA lpFormat, out string lpCurrencyStr, int cchCurrency);

        /// <summary>
        ///Formats a number string as a currency string for a locale specified by identifier.
        /// </summary>
        /// <param name="Locale">Locale identifier that specifies the locale for which this function formats the currency string. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwFlags">Flags controlling currency format. The application must set this parameter to 0 if lpFormat is not set to NULL. In this case, the function formats the string using user overrides to the default currency format for the locale. If lpFormat is set to NULL, the application can specify LOCALE_NOUSEROVERRIDE to format the string using the system default currency format for the specified locale.</param>
        /// <param name="lpValue">For details, see the lpValue parameter of GetCurrencyFormatEx.</param>
        /// <param name="lpFormat"></param>
        /// <param name="lpCurrencyStr"></param>
        /// <param name="cchCurrency">Size, in characters, of the lpCurrencyStr buffer. The application sets this parameter to 0 if the function is to return the size of the buffer required to hold the formatted currency string. In this case, the lpCurrencyStr parameter is not used.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetCurrencyFormatW(LUID Locale, uint dwFlags, string lpValue, CURRENCYFMTW lpFormat, out string lpCurrencyStr, int cchCurrency);

        /// <summary>
        ///Formats a duration of time as a time string for a locale specified by identifier.
        /// </summary>
        /// <param name="Locale">Locale identifier that specifies the locale for which this function formats the duration. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwFlags">Flags specifying function options. If lpFormat is not set to NULL, this parameter must be set to 0. If lpFormat is set to NULL, your application can specify LOCALE_NOUSEROVERRIDE to format the string using the system default duration format for the specified locale.</param>
        /// <param name="lpDuration"></param>
        /// <param name="ullDuration">64-bit unsigned integer that represents the number of 100-nanosecond intervals in the duration. If both lpDuration and ullDuration are present, lpDuration takes precedence. If lpDuration is set to NULL and ullDuration is set to 0, the duration is zero.</param>
        /// <param name="lpFormat"></param>
        /// <param name="lpDurationStr"></param>
        /// <param name="cchDuration">Size, in characters, of the buffer indicated by lpDurationStr.Alternatively, the application can set this parameter to 0. In this case, the function retrieves NULL in lpDurationStr and returns the required size for the duration string buffer.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetDurationFormat(LUID Locale, uint dwFlags, SYSGEOTYPE lpDuration, uint ullDuration, string lpFormat, out string lpDurationStr, int cchDuration);

        /// <summary>
        ///Retrieves information about a geographic location that you specify by using a two-letter International Organization for Standardization (ISO) 3166-1 code or numeric United Nations (UN) Series M, Number 49 (M.49) code.
        /// </summary>
        /// <param name="location">The two-letter ISO 3166-1 or numeric UN M.49 code for the geographic location for which to get information. To get the codes that are available on the operating system, call EnumSystemGeoNames.</param>
        /// <param name="geoType">The type of information you want to retrieve. Possible values are defined by the SYSGEOTYPE enumeration. The following values of the SYSGEOTYPE enumeration should not be used with GetGeoInfoEx:</param>
        /// <param name="geoData"></param>
        /// <param name="geoDataCount">The size of the buffer to which the GeoData parameter points, in characters. Set this parameter to 0 to specify that the function should only return the size of the buffer required to store the requested information without writing the requested information to the buffer.The number of bytes of geographical location information that the function wrote the output buffer. If geoDataCount is 0, the function returns the size of the buffer required to hold the information without writing the information to the buffer.0 indicates that the function did not succeed. To get extended error information, call GetLastError, which can return one of the following error codes:For information about two-letter ISO 3166-1 codes, see Country Codes - ISO 3166. For information about numeric UN M.49 codes, see Standard country or area codes for statistical use (M49).EnumSystemGeoNamesGetGeoInfoNational Language SupportNational Language Support FunctionsSYSGEOTYPE</param>
        /// <remarks>
        /// To get extended error information, call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetGeoInfoEx(string location, SYSGEOTYPE geoType, out string geoData, int geoDataCount);

        /// <summary>
        ///Retrieves information about the current version of a specified NLS capability for a locale specified by identifier.
        /// </summary>
        /// <param name="Function">The NLS capability to query. This value must be COMPARE_STRING. See the SYSNLS_FUNCTION enumeration.</param>
        /// <param name="Locale">Locale identifier that specifies the locale. You can use the MAKELCID macro to create an identifier or use one of the following predefined values.</param>
        /// <param name="lpVersionInformation">Pointer to an NLSVERSIONINFO structure. The application must initialize the dwNLSVersionInfoSize member to sizeof(NLSVERSIONINFO).</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNLSVersion(SYSNLS_FUNCTION Function, LUID Locale, out NLSVERSIONINFO lpVersionInformation);

        /// <summary>
        ///Retrieves information about the current version of a specified NLS capability for a locale specified by name.
        /// </summary>
        /// <param name="function">The NLS capability to query. This value must be COMPARE_STRING. See the SYSNLS_FUNCTION enumeration.</param>
        /// <param name="lpLocaleName"></param>
        /// <param name="lpVersionInformation">Pointer to an NLSVERSIONINFOEX structure. The application must initialize the dwNLSVersionInfoSize member to sizeof(NLSVERSIONINFOEX).</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetNLSVersionEx(SYSNLS_FUNCTION function, string lpLocaleName, out NLSVERSIONINFOEX lpVersionInformation);

        /// <summary>
        ///Formats a number string as a number string customized for a locale specified by identifier.
        /// </summary>
        /// <param name="Locale">Locale identifier that specifies the locale. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwFlags">Flags controlling the operation of the function. The application must set this parameter to 0 if lpFormat is not set to NULL. In this case, the function formats the string using user overrides to the default number format for the locale. If lpFormat is set to NULL, the application can specify LOCALE_NOUSEROVERRIDE to format the string using the system default number format for the specified locale.</param>
        /// <param name="lpValue">Pointer to a null-terminated string containing the number string to format. This string can only contain the following characters. All other characters are invalid. The function returns an error if the string indicated by lpValue deviates from these rules.</param>
        /// <param name="lpFormat"></param>
        /// <param name="lpNumberStr"></param>
        /// <param name="cchNumber">Size, in TCHAR values, for the number string buffer indicated by lpNumberStr. Alternatively, the application can set this parameter to 0. In this case, the function returns the required size for the number string buffer, and does not use the lpNumberStr parameter.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetNumberFormatA(LUID Locale, uint dwFlags, string lpValue, NUMBERFMTA lpFormat, out string lpNumberStr, int cchNumber);

        /// <summary>
        ///Formats a number string as a number string customized for a locale specified by identifier.
        /// </summary>
        /// <param name="Locale">Locale identifier that specifies the locale. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwFlags">Flags controlling the operation of the function. The application must set this parameter to 0 if lpFormat is not set to NULL. In this case, the function formats the string using user overrides to the default number format for the locale. If lpFormat is set to NULL, the application can specify LOCALE_NOUSEROVERRIDE to format the string using the system default number format for the specified locale.</param>
        /// <param name="lpValue">Pointer to a null-terminated string containing the number string to format. This string can only contain the following characters. All other characters are invalid. The function returns an error if the string indicated by lpValue deviates from these rules.</param>
        /// <param name="lpFormat"></param>
        /// <param name="lpNumberStr"></param>
        /// <param name="cchNumber">Size, in TCHAR values, for the number string buffer indicated by lpNumberStr. Alternatively, the application can set this parameter to 0. In this case, the function returns the required size for the number string buffer, and does not use the lpNumberStr parameter.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetNumberFormatW(LUID Locale, uint dwFlags, string lpValue, NUMBERFMTW lpFormat, out string lpNumberStr, int cchNumber);

        /// <summary>
        ///Deprecated. Retrieves character type information for the characters in the specified source string. For each character in the string, the function sets one or more bits in the corresponding 16-bit element of the output array. Each bit identifies a given character type, for example, letter, digit, or neither.
        /// </summary>
        /// <param name="Locale">Locale identifier that specifies the locale. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwInfoType">Flags specifying the character type information to retrieve. For possible flag values, see the dwInfoType parameter of GetStringTypeW. For detailed information about the character type bits, see Remarks for GetStringTypeW.</param>
        /// <param name="lpSrcStr">Pointer to the ANSI string for which to retrieve the character types. The string can be a double-byte character set (DBCS) string if the supplied locale is appropriate for DBCS. The string is assumed to be null-terminated if cchSrc is set to any negative value.</param>
        /// <param name="cchSrc">Size, in characters, of the string indicated by lpSrcStr. If the size includes a terminating null character, the function retrieves character type information for that character. If the application sets the size to any negative integer, the source string is assumed to be null-terminated and the function calculates the size automatically with an additional character for the null termination.</param>
        /// <param name="lpCharType"></param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetStringTypeA(LUID Locale, uint dwInfoType, string lpSrcStr, int cchSrc, out uint lpCharType);

        /// <summary>
        ///Retrieves the language identifier for the system default UI language of the operating system (also known as the "install language" on Windows Vista and later). For more information, see User Interface Language Management.
        /// </summary>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern ushort GetSystemDefaultUILanguage();

        /// <summary>
        ///Retrieves the two-letter International Organization for Standardization (ISO) 3166-1 code or numeric United Nations (UN) Series M, Number 49 (M.49) code for the default geographical location of the user.
        /// </summary>
        /// <param name="geoName"></param>
        /// <param name="geoNameCount">The size of the buffer that the geoName parameter specifies. If this value is zero, the function only returns the number of characters that function would copy to the output buffer, but does not write the name of the default geographic location of the user to the buffer.The number of characters the function would copy to the output buffer, if the value of the geoNameCount parameter is zero. Otherwise, the number of characters that the function copied to the buffer that the geoName parameter specifies.Zero indicates that the function failed. To get extended error information, call GetLastError, which can return one of the following error codes:For information about two-letter ISO 3166-1 codes, see Country Codes - ISO 3166. For information about numeric UN M.49 codes, see Standard country or area codes for statistical use (M49).GetUserGeoIDNational Language SupportNational Language Support FunctionsSetUserGeoName</param>
        /// <remarks>
        /// To get extended error information, call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetUserDefaultGeoName(out string geoName, int geoNameCount);

        /// <summary>
        ///Retrieves the user default locale name.
        /// </summary>
        /// <param name="lpLocaleName"></param>
        /// <param name="cchLocaleName">Size, in characters, of the buffer indicated by lpLocaleName. The maximum possible length of a locale name, including a terminating null character, is LOCALE_NAME_MAX_LENGTH. This is the recommended size to supply in this parameter.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetUserDefaultLocaleName(out string lpLocaleName, int cchLocaleName);

        /// <summary>
        ///Retrieves information about the display language setting. For more information, see User Interface Language Management.
        /// </summary>
        /// <param name="dwFlags">Flags identifying language format and filtering. The following flags specify the language format to use for the display language list. The flags are mutually exclusive, and the default is MUI_LANGUAGE_NAME.</param>
        /// <param name="pulNumLanguages"></param>
        /// <param name="pwszLanguagesBuffer"></param>
        /// <param name="pcchLanguagesBuffer">Pointer to the size, in characters, for the language buffer indicated by pwszLanguagesBuffer. On successful return from the function, the parameter contains the size of the retrieved language buffer.Alternatively if this parameter is set to 0 and pwszLanguagesBuffer is set to NULL, the function retrieves the required size of the language buffer in pcchLanguagesBuffer.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError function, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool GetUserPreferredUILanguages(uint dwFlags, out uint pulNumLanguages, out string pwszLanguagesBuffer, out uint pcchLanguagesBuffer);

        /// <summary>
        ///Converts an internationalized domain name (IDN) or another internationalized label to a Unicode (wide character) representation of the ASCII string that represents the name in the Punycode transfer encoding syntax.
        /// </summary>
        /// <param name="dwFlags">Flags specifying conversion options. The following table lists the possible values.</param>
        /// <param name="lpUnicodeCharStr">Pointer to a Unicode string representing an IDN or another internationalized label.</param>
        /// <param name="cchUnicodeChar">Count of characters in the input Unicode string indicated by lpUnicodeCharStr.</param>
        /// <param name="lpASCIICharStr"></param>
        /// <param name="cchASCIIChar">Size of the buffer indicated by lpASCIICharStr. The application can set the parameter to 0 to retrieve NULL in lpASCIICharStr.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Normaliz.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int IdnToAscii(uint dwFlags, string lpUnicodeCharStr, int cchUnicodeChar, out string lpASCIICharStr, int cchASCIIChar);

        /// <summary>
        ///Converts an internationalized domain name (IDN) or another internationalized label to the NamePrep form specified by Network Working Group RFC 3491, but does not perform the additional conversion to Punycode. For more information and links to related draft standards, see Handling Internationalized Domain Names (IDNs).
        /// </summary>
        /// <param name="dwFlags">Flags specifying conversion options. For detailed definitions, see the dwFlags parameter of IdnToAscii.</param>
        /// <param name="lpUnicodeCharStr">Pointer to a Unicode string representing an IDN or another internationalized label.</param>
        /// <param name="cchUnicodeChar">Count of Unicode characters in the input Unicode string indicated by lpUnicodeCharStr.</param>
        /// <param name="lpNameprepCharStr"></param>
        /// <param name="cchNameprepChar">Size, in characters, of the buffer indicated by lpNameprepCharStr. The application can set the size to 0 to retrieve NULL in lpNameprepCharStr and have the function return the required buffer size.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Normaliz.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int IdnToNameprepUnicode(uint dwFlags, string lpUnicodeCharStr, int cchUnicodeChar, out string lpNameprepCharStr, int cchNameprepChar);

        /// <summary>
        ///Converts the Punycode form of an internationalized domain name (IDN) or another internationalized label to the normal Unicode UTF-16 encoding syntax.
        /// </summary>
        /// <param name="dwFlags">Flags specifying conversion options. For detailed definitions, see the dwFlags parameter of IdnToAscii.</param>
        /// <param name="lpASCIICharStr">Pointer to a string representing the Punycode encoding of an IDN or another internationalized label. This string must consist only of ASCII characters, and can include Punycode-encoded Unicode. The function decodes Punycode values to their UTF-16 values.</param>
        /// <param name="cchASCIIChar">Count of characters in the input string indicated by lpASCIICharStr.</param>
        /// <param name="lpUnicodeCharStr"></param>
        /// <param name="cchUnicodeChar">Size, in characters, of the buffer indicated by lpUnicodeCharStr. The application can set the size to 0 to retrieve NULL in lpUnicodeCharStr and have the function return the required buffer size.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Normaliz.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int IdnToUnicode(uint dwFlags, string lpASCIICharStr, int cchASCIIChar, out string lpUnicodeCharStr, int cchUnicodeChar);

        /// <summary>
        ///Determines if a specified character is a lead byte for the system default Windows ANSI code page (CP_ACP). A lead byte is the first byte of a two-byte character in a double-byte character set (DBCS) for the code page.
        /// </summary>
        /// <param name="TestChar">The character to test.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsDBCSLeadByte(byte TestChar);

        /// <summary>
        ///Determines if a specified character is potentially a lead byte. A lead byte is the first byte of a two-byte character in a double-byte character set (DBCS) for the code page.
        /// </summary>
        /// <param name="CodePage">Identifier of the code page used to check lead byte ranges. This parameter can be one of the code page identifiers defined in Unicode and Character Set Constants or one of the following predefined values. This function validates lead byte values only in code pages 932, 936, 949, 950, and 1361.</param>
        /// <param name="TestChar">The character to test.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsDBCSLeadByteEx(uint CodePage, byte TestChar);

        /// <summary>
        ///Verifies that a string is normalized according to Unicode 4.0 TR#15. For more information, see Using Unicode Normalization to Represent Strings.
        /// </summary>
        /// <param name="NormForm">Normalization form to use. NORM_FORM specifies the standard Unicode normalization forms.</param>
        /// <param name="lpString">Pointer to the string to test.</param>
        /// <param name="cwLength">Length, in characters, of the input string, including a null terminating character. If this value is -1, the function assumes the string to be null-terminated and calculates the length automatically.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Normaliz.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsNormalizedString(_NORM_FORM NormForm, string lpString, int cwLength);

        /// <summary>
        ///Determines if a language group is installed or supported on the operating system. For more information, see NLS Terminology.
        /// </summary>
        /// <param name="LanguageGroup">Identifier of language group to validate. This parameter can have one of the following values:</param>
        /// <param name="dwFlags">Flag specifying the validity test to apply to the language group identifier. This parameter can be set to one of the following values.</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsValidLanguageGroup(ushort LanguageGroup, uint dwFlags);

        /// <summary>
        ///[IsValidLocale is available for use in the operating systems specified in the Requirements section. It may be altered or unavailable in subsequent versions. Instead, use IsValidLocaleName to determine the validity of a supplemental locale.]
        /// </summary>
        /// <param name="Locale">Locale identifier of the locale to validate. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwFlags">Flag specifying the validity test to apply to the locale identifier. This parameter can have one of the following values.</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsValidLocale(LUID Locale, uint dwFlags);

        /// <summary>
        ///Determines if the specified locale name is valid for a locale that is installed or supported on the operating system.
        /// </summary>
        /// <param name="lpLocaleName">Pointer to the locale name to validate.</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool IsValidLocaleName(string lpLocaleName);

        /// <summary>
        ///For a locale specified by identifier, maps one input character string to another using a specified transformation, or generates a sort key for the input string.
        /// </summary>
        /// <param name="Locale">Locale identifier that specifies the locale. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwMapFlags">Flags specifying the type of transformation to use during string mapping or the type of sort key to generate. For detailed definitions, see the dwMapFlags parameter of LCMapStringEx.</param>
        /// <param name="lpSrcStr">Pointer to a source string that the function maps or uses for sort key generation. This string cannot have a size of 0.</param>
        /// <param name="cchSrc">Size, in characters, of the source string indicated by lpSrcStr. The size of the source string can include the terminating null character, but does not have to. If the terminating null character is included, the mapping behavior of the function is not greatly affected because the terminating null character is considered to be unsortable and always maps to itself.The application can set the parameter to any negative value to specify that the source string is null-terminated. In this case, if LCMapString is being used in its string-mapping mode, the function calculates the string length itself, and null-terminates the mapped string indicated by lpDestStr.The application cannot set this parameter to 0.</param>
        /// <param name="lpDestStr"></param>
        /// <param name="cchDest">Size, in characters, of the destination string indicated by lpDestStr. If the application is using the function for string mapping, it supplies a character count for this parameter. If space for a terminating null character is included in cchSrc, cchDest must also include space for a terminating null character.If the application is using the function to generate a sort key, it supplies a byte count for the size. This byte count must include space for the sort key 0x00 terminator.The application can set cchDest to 0. In this case, the function does not use the lpDestStr parameter and returns the required buffer size for the mapped string or sort key.If the function succeeds when used for string mapping, it returns the number of characters in the translated string (see cchSrc and cchDest for more details).If the function succeeds when used for string mapping it returns the number of bytes in the sort key.This function returns 0 if it does not succeed. To get extended error information, the application can call GetLastError, which can return one of the following error codes:See Remarks for LCMapStringEx.The ANSI version of LCMapString maps strings to and from Unicode based on the default Windows (ANSI) code page associated with the specified locale. When the ANSI version of this function is used with a Unicode-only locale, the function can succeed because the operating system uses the CP_ACP value, representing the system default Windows ANSI code page. However, characters that are undefined in the system code page appear in the string as a question mark (?).CompareStringFindNLSStringGetNLSVersionHandling Sorting in Your ApplicationsLCMapStringExNational Language SupportNational Language Support Functions</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int LCMapStringA(LUID Locale, uint dwMapFlags, string lpSrcStr, int cchSrc, out string lpDestStr, int cchDest);

        /// <summary>
        ///For a locale specified by identifier, maps one input character string to another using a specified transformation, or generates a sort key for the input string.
        /// </summary>
        /// <param name="Locale">Locale identifier that specifies the locale. You can use the MAKELCID macro to create a locale identifier or use one of the following predefined values.</param>
        /// <param name="dwMapFlags">Flags specifying the type of transformation to use during string mapping or the type of sort key to generate. For detailed definitions, see the dwMapFlags parameter of LCMapStringEx.</param>
        /// <param name="lpSrcStr">Pointer to a source string that the function maps or uses for sort key generation. This string cannot have a size of 0.</param>
        /// <param name="cchSrc">Size, in characters, of the source string indicated by lpSrcStr. The size of the source string can include the terminating null character, but does not have to. If the terminating null character is included, the mapping behavior of the function is not greatly affected because the terminating null character is considered to be unsortable and always maps to itself.The application can set the parameter to any negative value to specify that the source string is null-terminated. In this case, if LCMapString is being used in its string-mapping mode, the function calculates the string length itself, and null-terminates the mapped string indicated by lpDestStr.The application cannot set this parameter to 0.</param>
        /// <param name="lpDestStr"></param>
        /// <param name="cchDest">Size, in characters, of the destination string indicated by lpDestStr. If the application is using the function for string mapping, it supplies a character count for this parameter. If space for a terminating null character is included in cchSrc, cchDest must also include space for a terminating null character.If the application is using the function to generate a sort key, it supplies a byte count for the size. This byte count must include space for the sort key 0x00 terminator.The application can set cchDest to 0. In this case, the function does not use the lpDestStr parameter and returns the required buffer size for the mapped string or sort key.If the function succeeds when used for string mapping, it returns the number of characters in the translated string (see cchSrc and cchDest for more details).If the function succeeds when used for string mapping it returns the number of bytes in the sort key.This function returns 0 if it does not succeed. To get extended error information, the application can call GetLastError, which can return one of the following error codes:This function returns 0 if it does not succeed. To get extended error information, the application can call GetLastError, which can return one of the following error codes:See Remarks for LCMapStringEx.The ANSI version of LCMapString maps strings to and from Unicode based on the default Windows (ANSI) code page associated with the specified locale. When the ANSI version of this function is used with a Unicode-only locale, the function can succeed because the operating system uses the CP_ACP value, representing the system default Windows ANSI code page. However, characters that are undefined in the system code page appear in the string as a question mark (?).CompareStringFindNLSStringGetNLSVersionHandling Sorting in Your ApplicationsLCMapStringExNational Language SupportNational Language Support Functions</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int LCMapStringW(LUID Locale, uint dwMapFlags, string lpSrcStr, int cchSrc, out string lpDestStr, int cchDest);

        /// <summary>
        ///Converts a locale name to a locale identifier.
        /// </summary>
        /// <param name="lpName">Pointer to a null-terminated string representing a locale name, or one of the following predefined values.</param>
        /// <param name="dwFlags">Prior to Windows 7:Reserved; should always be 0.Beginning in Windows 7: Can be set to LOCALE_ALLOW_NEUTRAL_NAMES to allow the return of a neutral LCID.If successful, returns the locale identifier corresponding to the locale name.If the supplied locale name corresponds to a custom locale that is the user default, this function returns LOCALE_CUSTOM_DEFAULT.If the locale name corresponds to a custom locale that is not the user default, is a transient locale, or is a CLDR (Unicode Common Locale Data Repository) locale, the function returns LOCALE_CUSTOM_UNSPECIFIED.The function returns 0 if it does not succeed. To get extended error information, the application can call GetLastError, which can return ERROR_INVALID_PARAMETER if any of the parameter values are invalid.For custom locales, including those created by Microsoft, your applications should prefer locale names over locale identifiers. See The deprecation of LCIDs for more info.Beginning in Windows 8: If your app passes language tags to this function from the Windows.Globalization namespace, it must first convert the tags by calling ResolveLocaleName.DownlevelLocaleNameToLCIDNLS: Name-based APIs SampleNational Language SupportNational Language Support Functions</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return ERROR_INVALID_PARAMETER if any of the parameter values are invalid.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern LUID LocaleNameToLCID(string lpName, uint dwFlags);

        /// <summary>
        ///Normalizes characters of a text string according to Unicode 4.0 TR#15. For more information, see Using Unicode Normalization to Represent Strings.
        /// </summary>
        /// <param name="NormForm">Normalization form to use. NORM_FORM specifies the standard Unicode normalization forms.</param>
        /// <param name="lpSrcString">Pointer to the non-normalized source string.</param>
        /// <param name="cwSrcLength">Length, in characters, of the buffer containing the source string. The application can set this parameter to -1 if the function should assume the string to be null-terminated and calculate the length automatically.</param>
        /// <param name="lpDstString"></param>
        /// <param name="cwDstLength">Length, in characters, of the buffer containing the destination string. Alternatively, the application can set this parameter to 0 to request the function to return the required size for the destination buffer.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Normaliz.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int NormalizeString(_NORM_FORM NormForm, string lpSrcString, int cwSrcLength, out string lpDstString, int cwDstLength);

        /// <summary>
        ///Finds a possible locale name match for the supplied name.
        /// </summary>
        /// <param name="lpNameToResolve"></param>
        /// <param name="lpLocaleName"></param>
        /// <param name="cchLocaleName">Size, in characters, of the buffer indicated by lpLocaleName. The maximum possible length of a locale name, including a terminating null character, is the value of LOCALE_NAME_MAX_LENGTH. This is the recommended size to supply in this parameter.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError, which can return one of the following error codes:
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int ResolveLocaleName(string lpNameToResolve, out string lpLocaleName, int cchLocaleName);

        /// <summary>
        ///Sets the user interface language for the current thread.
        /// </summary>
        /// <param name="LangId">Language identifier for the user interface language for the thread.Windows Vista and later: The application can specify a language identifier of 0 or a nonzero identifier. For more information, see the Remarks section.Windows XP: The application can only set this parameter to 0. This setting causes the function to select the language that best supports the console display. For more information, see the Remarks section.</param>
        /// <remarks>
        /// To get extended error information, the application can call GetLastError.
        /// </remarks>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern ushort SetThreadUILanguage(ushort LangId);

        /// <summary>
        ///Sets the geographic location for the current user to the specified two-letter International Organization for Standardization (ISO) 3166-1 code or numeric United Nations (UN) Series M, Number 49 (M.49) code.
        /// </summary>
        /// <param name="geoName">The two-letter ISO 3166-1 or numeric UN M.49 code for the geographic location to set for the current user. To get the codes that are available on the operating system, call EnumSystemGeoNames.</param>

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SetUserGeoName(string geoName);


    }
}