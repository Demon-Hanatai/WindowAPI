namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct COMBOBOXINFO
    {
        public uint cbSize;
        public RECT rcItem;
        public RECT rcButton;
        public uint stateButton;
        public IntPtr hwndCombo;
        public IntPtr hwndItem;
        public IntPtr hwndList;
    }



}