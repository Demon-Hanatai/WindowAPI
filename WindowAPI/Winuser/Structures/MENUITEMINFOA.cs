
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MENUITEMINFOA
    {
        public IntPtr cbSize;
        public IntPtr fMask;
        public IntPtr fType;
        public IntPtr fState;
        public IntPtr wID;
        public IntPtr hSubMenu;
        public IntPtr hbmpChecked;
        public IntPtr hbmpUnchecked;
        public IntPtr dwItemData;
        public string dwTypeData;
        public IntPtr cch;
        public IntPtr hbmpItem;
    }



}