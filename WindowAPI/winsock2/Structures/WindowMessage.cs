using WindowAPI.Winbase.h.Enums;
using static WindowAPI.winsock2.CallBacks.CallBacks;


namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WindowMessage
    {
        public _FILE_ID_TYPE Type;
        public nint hWnd;
        public uint uMsg;
        public nint context;
        public nint lpOverlapped;
        public LPWSAOVERLAPPEDCOMPLETIONROUTINE lpfnCompletionProc;
        public nint hPort;
        public uint Key;
    }



}