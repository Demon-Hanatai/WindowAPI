namespace WindowAPI.minwinbase.CallBacks
{
    public static class CallBacks
    {
        /// <summary>
        ///An application-defined callback function used with the ReadFileEx and WriteFileEx functions. It is called when the asynchronous input and output (I/O) operation is completed or canceled and the calling thread is in an alertable state (by using the SleepEx, MsgWaitForMultipleObjectsEx, WaitForSingleObjectEx, or WaitForMultipleObjectsEx function with the fAlertable parameter set to TRUE).
        /// </summary>
        /// <param name="dwErrorCode">The I/O completion status. This parameter can be one of the system error codes.</param>
        /// <param name="dwNumberOfBytesTransfered">The number of bytes transferred. If an error occurs, this parameter is zero.</param>
        /// <param name="lpOverlapped">A pointer to the OVERLAPPED structure specified by the asynchronous I/O function.The system does not use the OVERLAPPED structure after the completion routine is called, so the completion routine can deallocate the memory used by the overlapped structure.NoneThe return value for an asynchronous operation is 0 (ERROR_SUCCESS) if the operation completed successfully or if the operation completed with a warning. To determine whether an I/O operation was completed successfully, check that dwErrorCode is 0, call GetOverlappedResult, then call GetLastError. For example, if the buffer was not large enough to receive all of the data from a call to ReadFileEx, dwErrorCode is set to 0, GetOverlappedResult fails, and GetLastError returns ERROR_MORE_DATA.Returning from this function allows another pending I/O completion routine to be called. All waiting completion routines are called before the alertable thread's wait is completed with a return code of WAIT_IO_COMPLETION. The system may call the waiting completion routines in any order. They may or may not be called in the order the I/O functions are completed.Each time the system calls a completion routine, it uses some of the application's stack. If the completion routine does additional asynchronous I/O and alertable waits, the stack may grow.For more information, see Asynchronous Procedure Calls.For example code, see Named Pipe Server Using Completion Routines.BindIoCompletionCallbackFile Management FunctionsOVERLAPPEDReadFileExSleepExSynchronous and Asynchronous I/OWaitForMultipleObjectsExWaitForSingleObjectExWriteFileEx</param>

        public delegate void LPOVERLAPPEDCOMPLETIONROUTINE(uint dwErrorCode, uint dwNumberOfBytesTransfered, nint lpOverlapped);


    }
}