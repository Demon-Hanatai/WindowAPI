namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MSGBOXPARAMSW
    {
        public uint cbSize;
        public nint hwndOwner;
        public nint hInstance;
        public string lpszText;
        public string lpszCaption;
        public uint dwStyle;
        public string lpszIcon;
        public uint dwContextHelpId;
        public MSGBOXCALLBACK lpfnMsgBoxCallback;
        public uint dwLanguageId;
    }



}