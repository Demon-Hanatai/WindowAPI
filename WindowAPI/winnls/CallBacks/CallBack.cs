namespace WindowAPI.winnls.CallBacks
{
    public static class CallBacks
    {
        /// <summary>
        ///An application-defined callback function that processes enumerated geographical location information provided by the EnumSystemGeoNames function. The GEO_ENUMNAMEPROC type defines a pointer to this callback function. Geo_EnumNameProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate bool GEOENUMNAMEPROC(string unnamedParam1, nint unnamedParam2);

        /// <summary>
        ///An application-defined callback function that processes enumerated language group locale information provided by the EnumLanguageGroupLocales function. The LANGGROUPLOCALE_ENUMPROC type defines a pointer to this callback function. EnumLanguageGroupLocalesProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate bool LANGGROUPLOCALEENUMPROCA(ushort unnamedParam1, LUID unnamedParam2, string unnamedParam3, int unnamedParam4);

        /// <summary>
        ///An application-defined callback function that processes enumerated language group locale information provided by the EnumLanguageGroupLocales function. The LANGGROUPLOCALE_ENUMPROC type defines a pointer to this callback function. EnumLanguageGroupLocalesProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate bool LANGGROUPLOCALEENUMPROCW(ushort unnamedParam1, LUID unnamedParam2, string unnamedParam3, int unnamedParam4);

        /// <summary>
        ///An application-defined callback function that processes enumerated locale information provided by the EnumSystemLocalesEx function. The LOCALE_ENUMPROCEX type defines a pointer to this callback function. EnumLocalesProcEx is a placeholder for the application-defined function name.
        /// </summary>

        public delegate bool LOCALEENUMPROCEX(string unnamedParam1, uint unnamedParam2, nint unnamedParam3);

        /// <summary>
        ///An application-defined callback function that processes enumerated user interface language information provided by the EnumUILanguages function. The UILANGUAGE_ENUMPROC type defines a pointer to this callback function. EnumUILanguagesProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate bool UILANGUAGEENUMPROCA(string unnamedParam1, int unnamedParam2);

        /// <summary>
        ///An application-defined callback function that processes enumerated user interface language information provided by the EnumUILanguages function. The UILANGUAGE_ENUMPROC type defines a pointer to this callback function. EnumUILanguagesProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate bool UILANGUAGEENUMPROCW(string unnamedParam1, int unnamedParam2);


    }
}