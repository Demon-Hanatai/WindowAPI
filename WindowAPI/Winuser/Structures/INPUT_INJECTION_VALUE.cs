
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct INPUT_INJECTION_VALUE
    {
        public ushort page;
        public ushort usage;
        public IntPtr value;
        public ushort index;
    }



}