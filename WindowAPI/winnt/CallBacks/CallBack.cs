namespace WindowAPI.winnt.CallBacks
{
    public static class CallBacks
    {
        /// <summary>
        ///An application-defined completion routine. Specify this address when calling the QueueUserAPC function. The PAPCFUNC type defines a pointer to this callback function. APCProc is a placeholder for the application-defined function name.
        /// </summary>
        /// <param name="Parameter">The data passed to the function using the dwData parameter of the QueueUserAPC function.NoneAsynchronous Procedure CallsQueueUserAPCSynchronization Functions</param>

        public delegate void PAPCFUNC(int Parameter);

        /// <summary>
        ///An application-defined function. If the FLS slot is in use, FlsCallback is called on fiber deletion, thread exit, and when an FLS index is freed. Specify this function when calling the FlsAlloc function. The PFLS_CALLBACK_FUNCTION type defines a pointer to this callback function. FlsCallback is a placeholder for the application-defined function name.
        /// </summary>
        /// <param name="lpFlsData">The value stored in the FLS slot for the calling fiber.NoneEach FLS index has an associated FlsCallback function. The callback function can be used for any purpose, but it is intended to be used primarily to free memory.FibersFlsAllocProcess and Thread Functions</param>

        public delegate void PFLSCALLBACKFUNCTION(IntPtr lpFlsData);

        /// <summary>
        ///An application-defined function previously registered with the AddSecureMemoryCacheCallback function that is called when a secured memory range is freed or its protections are changed.
        /// </summary>
        /// <param name="Addr">The starting address of the memory range.</param>
        /// <param name="Range">The size of the memory range, in bytes.The return value indicates the success or failure of this function.If the caller has secured the specified memory range, this function should unsecure the memory and return TRUE.If the caller has not secured the specified memory range, this function should return FALSE.After the callback function is registered, it is called after any attempt to free the specified memory range or change its protections. If the application has secured any part of the specified memory range, the callback function must invalidate all of the application's cached memory mappings for the secured memory range, unsecure the secured parts of the memory range, and return TRUE. Otherwise it must return FALSE.The application secures and unsecures a memory range by sending requests to a device driver, which uses the MmSecureVirtualMemory and MmUnsecureVirtualMemory functions to actually secure and unsecure the range. Operations on other types of secured or locked memory do not trigger this callback.Examples of function calls that trigger the callback function include calls to the VirtualFree, VirtualFreeEx, VirtualProtect, VirtualProtectEx, and UnmapViewOfFile functions.The callback function can also be triggered by a heap operation. In this case, the function must not perform any further operations on the heap that triggered the callback. This includes calling heap functions on a private heap or the process's default heap, or calling standard library functions such as malloc and free, which implicitly use the process's default heap.To unregister the callback function, use the RemoveSecureMemoryCacheCallback function.AddSecureMemoryCacheCallbackRemoveSecureMemoryCacheCallback</param>

        public delegate bool PSECUREMEMORYCACHECALLBACK(IntPtr Addr, int Range);

        /// <summary>
        ///An application-defined function that serves as a vectored exception handler. Specify this address when calling the AddVectoredExceptionHandler function. The PVECTORED_EXCEPTION_HANDLER type defines a pointer to this callback function. VectoredHandler is a placeholder for the application-defined name.
        /// </summary>
        /// <param name="ExceptionInfo">A pointer to an EXCEPTION_POINTERS structure that receives the exception record.To return control to the point at which the exception occurred, return EXCEPTION_CONTINUE_EXECUTION (0xffffffff). To continue the handler search, return EXCEPTION_CONTINUE_SEARCH (0x0).The handler should not call functions that acquire synchronization objects or allocate memory, because this can cause problems. Typically, the handler will simply access the exception record and return.EXCEPTION_POINTERSVectored Exception Handling</param>

        public delegate int PVECTOREDEXCEPTIONHANDLER(int ExceptionInfo);

        /// <summary>
        ///The application-defined user-mode scheduling (UMS) scheduler entry point function associated with a UMS completion list.
        /// </summary>
        /// <param name="Reason">The reason the scheduler entry point is being called. This parameter can be one of the following values.</param>
        /// <param name="ActivationPayload">If the Reason parameter is UmsSchedulerStartup, this parameter is NULL.If the Reason parameter is UmsSchedulerThreadBlocked, bit 0 of this parameter indicates the type of activity that was being serviced when the UMS worker thread blocked.If the Reason parameter is UmsSchedulerThreadYield, this parameter is a pointer to the UMS thread context of the UMS worker thread that yielded.</param>
        /// <param name="SchedulerParam">If the Reason parameter is UmsSchedulerStartup, this parameter is the SchedulerParam member of the UMS_SCHEDULER_STARTUP_INFO structure passed to the EnterUmsSchedulingMode function that triggered the entry point call.If the Reason parameter is UmsSchedulerThreadYield this parameter is the SchedulerParam parameter passed to the UmsThreadYield function that triggered the entry point call.If the Reason parameter is UmsSchedulerThreadBlocked, this parameter is NULL.NoneThe UmsSchedulerProc function pointer type is defined as PUMS_SCHEDULER_ENTRY_POINT in WinBase.h. The underlying function type is defined as RTL_UMS_SCHEDULER_ENTRY_POINT in WinNT.hEach UMS scheduler thread has an associated UmsSchedulerProc entry point function that is specified when the thread calls the EnterUmsSchedulingMode function. The system calls the scheduler entry point function with a reason of UmsSchedulerStartup when the scheduler thread is converted for UMS.Subsequently, when a UMS worker thread that is running on the scheduler thread yields or blocks, the system calls the scheduler thread's entry point function with a pointer to the UMS thread context of the worker thread.The application's scheduler is responsible for selecting the next UMS worker thread to run. The scheduler implements all policies that influence execution of its UMS threads, including processor affinity and thread priority. For example, a scheduler might give priority to I/O-intensive threads, or it might run threads on a first-come, first-served basis. This logic can be implemented in the scheduler entry point function or elsewhere in the application.When a blocked UMS worker thread becomes unblocked, the system queues the unblocked thread to the associated completion list and signals the completion list event. To retrieve UMS worker threads from the completion list, use the DequeueUmsCompletionListItems function.DequeueUmsCompletionListItemsEnterUmsSchedulingModeUmsThreadYield</param>

        public delegate void RTLUMSSCHEDULERENTRYPOINT(nint Reason, int ActivationPayload, IntPtr SchedulerParam);


    }
}