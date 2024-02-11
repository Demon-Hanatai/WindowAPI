using System.Runtime.InteropServices;
namespace WindowAPI.Prnasnot.h
{
    public static class Function
    {

        /// <summary>
        ///Creates a communication channel between a Print Spooler-hosted printing component, such as a print driver or port monitor, and an application that receives notifications from the component.
        /// </summary>
        /// <param name="pszName">A pointer to the name of a print server or print queue.</param>
        /// <param name="pNotificationType">A pointer to the GUID of the data schema for the type of notifications to be sent in the channel.</param>
        /// <param name="eUserFilter">A value specifying whether notifications will be sent to:</param>
        /// <param name="eConversationStyle">A value specifying whether communication is bidirectional or unidirectional.</param>
        /// <param name="pCallback">A pointer to an object that the listening application will use to call back the Print Spooler-hosted component. This should be NULL if directionality is kUniDirectional.</param>

        [DllImport("Spoolss.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ CreatePrintAsyncNotifyChannel(string pszName, IntPtr /*UKNOW:NEED_FIX*/ pNotificationType, IntPtr /*UKNOW:NEED_FIX*/ eUserFilter, IntPtr /*UKNOW:NEED_FIX*/ eConversationStyle, IntPtr /*UKNOW:NEED_FIX*/ pCallback, out IntPtr /*UKNOW:NEED_FIX*/ ppIAsynchNotification);

        /// <summary>
        ///Enables an application to register for notifications from Print Spooler-hosted printing components such as printer drivers, print processors, and port monitors.
        /// </summary>
        /// <param name="pszName">A pointer to the name of a print server or print queue.</param>
        /// <param name="pNotificationType">A pointer to the GUID of the data schema for the type of notifications that the application must receive.</param>
        /// <param name="eUserFilter">A value specifying whether notifications will be sent to:</param>
        /// <param name="eConversationStyle">A value specifying whether communication is bidirectional or unidirectional.</param>
        /// <param name="pCallback">A pointer to an object that the Print Spooler-hosted component will use to call back the application. This should never be NULL.</param>

        [DllImport("Spoolss.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ RegisterForPrintAsyncNotifications(string pszName, IntPtr /*UKNOW:NEED_FIX*/ pNotificationType, IntPtr /*UKNOW:NEED_FIX*/ eUserFilter, IntPtr /*UKNOW:NEED_FIX*/ eConversationStyle, IntPtr /*UKNOW:NEED_FIX*/ pCallback, out IntPtr phNotify);

        /// <summary>
        ///Enables an application that has registered to receive notifications from Print Spooler-hosted printing components to unregister.
        /// </summary>
        /// <param name="unnamedParam1">The registration handle to be unregistered.The return values are COM error codes. Because this function might complete the operation successfully yet return an HRESULT other than S_OK you should use the SUCCEEDED or FAILED macro to determine the success of the call. To get the specific HRESULT that was returned by the function, use the HRESULT_CODE macro.The following code example shows how these macros can be used to evaluate the return value.For more information about COM error codes, see Error Handling.See PrintAsyncNotifyError for other possible return values.If the channel is bidirectional, a call to UnRegisterForPrintAsyncNotifications only prevents notifications from communication channels created after that point. To end notifications from the existing channel, the listening application must close the channel with IPrintAsyncNotifyChannel::CloseChannel.A call to UnRegisterForPrintAsyncNotifications will decrement the reference count of the pCallback object passed to RegisterForPrintAsyncNotifications.After this function succeeds, hRegistrationHandler is invalid and must not be used again.Print Spooler API FunctionsPrinting</param>

        [DllImport("Spoolss.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr /*UKNOW:NEED_FIX*/ UnRegisterForPrintAsyncNotifications(IntPtr unnamedParam1);


    }
}