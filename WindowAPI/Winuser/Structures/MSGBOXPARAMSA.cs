
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MSGBOXPARAMSA
    {
        public IntPtr cbSize;
        public IntPtr hwndOwner;
        public IntPtr hInstance;
        public string lpszText;
        public string lpszCaption;
        public uint dwStyle;
        public string lpszIcon;
        public IntPtr dwContextHelpId;
        public IntPtr lpfnMsgBoxCallback;
        public uint dwLanguageId;
    }



}