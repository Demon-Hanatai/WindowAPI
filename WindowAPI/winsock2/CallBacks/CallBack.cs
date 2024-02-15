namespace WindowAPI.winsock2.CallBacks
{
    public static class CallBacks
    {
        /// <summary>
        ///LPWSAOVERLAPPED_COMPLETION_ROUTINE is a function pointer type. You implement a matching callback function in your app, and pass that to functions such as WSAIoctl, WSARecv, and WSASend, among others.
        /// </summary>

        public delegate void LPWSAOVERLAPPEDCOMPLETIONROUTINE(uint dwError, uint cbTransferred, nint lpOverlapped, uint dwFlags);


    }
}