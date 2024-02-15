namespace WindowAPI.minwinbase
{
    public static class Functions
    {

        /// <summary>
        ///Discards the specified local memory object. The lock count of the memory object must be zero.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern void LocalDiscard(nint ptr);


    }
}