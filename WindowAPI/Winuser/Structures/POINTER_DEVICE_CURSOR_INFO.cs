namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct POINTER_DEVICE_CURSOR_INFO
    {
        public int cursorId;
        public POINTER_DEVICE_CURSOR_TYPE cursor;
    }



}