namespace WindowAPI.console.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_HISTORY_INFO
    {
        public uint cbSize;
        public uint HistoryBufferSize;
        public uint NumberOfHistoryBuffers;
        [MarshalAs(UnmanagedType.Bool)]
        public bool dwFlags;
    }

}