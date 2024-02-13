

namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MSGBOXPARAMSA
    {
        public uint cbSize;
        public IntPtr hwndOwner;
        public IntPtr hInstance;
        public string lpszText;
        public string lpszCaption;
        public uint dwStyle;
        public string lpszIcon;
        public uint dwContextHelpId;
        public MSGBOXCALLBACK lpfnMsgBoxCallback;
        public uint dwLanguageId;
    }



}