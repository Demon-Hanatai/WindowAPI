namespace WindowAPI.wingdi.CallBacks
{
    public static class CallBacks
    {
        /// <summary>
        ///The AbortProc function is an application-defined callback function used with the SetAbortProc function. It is called when a print job is to be canceled during spooling. The ABORTPROC type defines a pointer to this callback function. AbortProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate bool ABORTPROC(nint unnamedParam1, uint unnamedParam2);

        /// <summary>
        ///The EnhMetaFileProc function is an application-defined callback function used with the EnumEnhMetaFile function. The ENHMFENUMPROC type defines a pointer to this callback function. EnhMetaFileProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate uint ENHMFENUMPROC(nint hdc, nint lpht, int ENHMETARECORD, uint nHandles, nint data);

        /// <summary>
        ///The EnumObjectsProc function is an application-defined callback function used with the EnumObjects function. It is used to process the object data. The GOBJENUMPROC type defines a pointer to this callback function. EnumObjectsProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate uint GOBJENUMPROC(nint unnamedParam1, nint unnamedParam2);

        /// <summary>
        ///The EnumICMProfilesProcCallback callback is an application-defined callback function that processes color profile data from EnumICMProfiles .
        /// </summary>

        public delegate uint ICMENUMPROCA(string unnamedParam1, nint unnamedParam2);

        /// <summary>
        ///The EnumICMProfilesProcCallback callback is an application-defined callback function that processes color profile data from EnumICMProfiles .
        /// </summary>

        public delegate uint ICMENUMPROCW(string unnamedParam1, nint unnamedParam2);

        /// <summary>
        ///The LineDDAProc function is an application-defined callback function used with the LineDDA function. It is used to process coordinates. The LINEDDAPROC type defines a pointer to this callback function. LineDDAProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate void LINEDDAPROC(uint unnamedParam1, uint unnamedParam2, nint unnamedParam3);

        /// <summary>
        ///The EnumMetaFileProc function is an application-defined callback function that processes Windows-format metafile records. This function is called by the EnumMetaFile function. The MFENUMPROC type defines a pointer to this callback function. EnumMetaFileProc is a placeholder for the application-defined function name.
        /// </summary>
        /// <param name="hdc"></param>
        /// <param name="lpht"></param>
        /// <param name="lpMR"></param>
        /// <param name="nObj">Specifies the number of objects with associated handles in the handle table.paramThis function must return a nonzero value to continue enumeration; to stop enumeration, it must return zero.An application must register the callback function by passing its address to the EnumMetaFile function.EnumMetaFileProc is a placeholder for the application-supplied function name.EnhMetaFileProcEnumEnhMetaFileEnumMetaFileMetafile FunctionsMetafiles Overview</param>
        /// <param name="param"></param>

        public delegate uint MFENUMPROC(nint hdc, nint lpht, int lpMR, uint nObj, nint param);


    }
}