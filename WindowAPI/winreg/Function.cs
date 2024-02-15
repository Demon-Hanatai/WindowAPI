using WindowAPI.minwinbase.Structures;
using WindowAPI.winreg.Structures;
namespace WindowAPI.winreg
{
    public static class Functions
    {

        /// <summary>
        ///Stops a system shutdown that has been initiated.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AbortSystemShutdownA(string lpMachineName);

        /// <summary>
        ///Stops a system shutdown that has been initiated.
        /// </summary>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool AbortSystemShutdownW(string lpMachineName);

        /// <summary>
        ///Initiates a shutdown and restart of the specified computer, and restarts any applications that have been registered for restart.
        /// </summary>
        /// <param name="lpMachineName"></param>
        /// <param name="lpMessage"></param>
        /// <param name="dwGracePeriod">The number of seconds to wait before shutting down the computer. If the value of this parameter is zero, the computer is shut down immediately. This value is limited to MAX_SHUTDOWN_TIMEOUT.If the value of this parameter is greater than zero, and the dwShutdownFlags parameter specifies the flag SHUTDOWN_GRACE_OVERRIDE, the function fails and returns the error code ERROR_BAD_ARGUMENTS.</param>
        /// <param name="dwShutdownFlags">One or more bit flags that specify options for the shutdown. The following values are defined.</param>
        /// <param name="dwReason">The reason for initiating the shutdown. This parameter must be one of the system shutdown reason codes. If this parameter is zero, the default is an undefined shutdown that is logged as "No title for this reason could be found". By default, it is also an unplanned shutdown. Depending on how the system is configured, an unplanned shutdown triggers the creation of a file that contains the system state information, which can delay shutdown. Therefore, do not use zero for this parameter.If the function succeeds, it returns ERROR_SUCCESS.If the function fails, it returns one of the following error codes.To shut down the local computer, the calling thread must have the SE_SHUTDOWN_NAME privilege. To shut down a remote computer, the calling thread must have the SE_REMOTE_SHUTDOWN_NAME privilege on the remote computer. By default, users can enable the SE_SHUTDOWN_NAME privilege on the computer they are logged onto, and administrators can enable the SE_REMOTE_SHUTDOWN_NAME privilege on remote computers. For more information, see Running with Special Privileges.Common reasons for failure include an invalid or inaccessible computer name or insufficient privilege. The error ERROR_SHUTDOWN_IN_PROGRESS is returned if a shutdown is already in progress on the specified computer. The error ERROR_NOT_READY can be returned if fast-user switching is enabled but no user is logged on.A non-zero return value does not mean the logoff was or will be successful. The shutdown is an asynchronous process, and it can occur long after the API call has returned, or not at all. Even if the timeout value is zero, the shutdown can still be aborted by applications, services, or even the system. The non-zero return value indicates that the validation of the rights and parameters was successful and that the system accepted the shutdown request.Shutting Down</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint InitiateShutdownA(string lpMachineName, string lpMessage, uint dwGracePeriod, uint dwShutdownFlags, uint dwReason);

        /// <summary>
        ///Initiates a shutdown and restart of the specified computer, and restarts any applications that have been registered for restart.
        /// </summary>
        /// <param name="lpMachineName"></param>
        /// <param name="lpMessage"></param>
        /// <param name="dwGracePeriod">The number of seconds to wait before shutting down the computer. If the value of this parameter is zero, the computer is shut down immediately. This value is limited to MAX_SHUTDOWN_TIMEOUT.If the value of this parameter is greater than zero, and the dwShutdownFlags parameter specifies the flag SHUTDOWN_GRACE_OVERRIDE, the function fails and returns the error code ERROR_BAD_ARGUMENTS.</param>
        /// <param name="dwShutdownFlags">One or more bit flags that specify options for the shutdown. The following values are defined.</param>
        /// <param name="dwReason">The reason for initiating the shutdown. This parameter must be one of the system shutdown reason codes. If this parameter is zero, the default is an undefined shutdown that is logged as "No title for this reason could be found". By default, it is also an unplanned shutdown. Depending on how the system is configured, an unplanned shutdown triggers the creation of a file that contains the system state information, which can delay shutdown. Therefore, do not use zero for this parameter.If the function succeeds, it returns ERROR_SUCCESS.If the function fails, it returns one of the following error codes.To shut down the local computer, the calling thread must have the SE_SHUTDOWN_NAME privilege. To shut down a remote computer, the calling thread must have the SE_REMOTE_SHUTDOWN_NAME privilege on the remote computer. By default, users can enable the SE_SHUTDOWN_NAME privilege on the computer they are logged onto, and administrators can enable the SE_REMOTE_SHUTDOWN_NAME privilege on remote computers. For more information, see Running with Special Privileges.Common reasons for failure include an invalid or inaccessible computer name or insufficient privilege. The error ERROR_SHUTDOWN_IN_PROGRESS is returned if a shutdown is already in progress on the specified computer. The error ERROR_NOT_READY can be returned if fast-user switching is enabled but no user is logged on.A non-zero return value does not mean the logoff was or will be successful. The shutdown is an asynchronous process, and it can occur long after the API call has returned, or not at all. Even if the timeout value is zero, the shutdown can still be aborted by applications, services, or even the system. The non-zero return value indicates that the validation of the rights and parameters was successful and that the system accepted the shutdown request.Shutting Down</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint InitiateShutdownW(string lpMachineName, string lpMessage, uint dwGracePeriod, uint dwShutdownFlags, uint dwReason);

        /// <summary>
        ///Initiates a shutdown and optional restart of the specified computer.
        /// </summary>
        /// <param name="lpMachineName"></param>
        /// <param name="lpMessage"></param>
        /// <param name="dwTimeout">The length of time that the shutdown dialog box should be displayed, in seconds. While this dialog box is displayed, the shutdown can be stopped by the AbortSystemShutdown function.If dwTimeout is not zero, InitiateSystemShutdown displays a dialog box on the specified computer. The dialog box displays the name of the user who called the function, displays the message specified by the lpMessage parameter, and prompts the user to log off. The dialog box beeps when it is created and remains on top of other windows in the system. The dialog box can be moved but not closed. A timer counts down the remaining time before a forced shutdown.If dwTimeout is zero, the computer shuts down without displaying the dialog box, and the shutdown cannot be stopped by AbortSystemShutdown.Windows Server 2003 and Windows XP with SP1:  The time-out value is limited to MAX_SHUTDOWN_TIMEOUT seconds.Windows Server 2003 and Windows XP with SP1:  If the computer to be shut down is a Terminal Services server, the system displays a dialog box to all local and remote users warning them that shutdown has been initiated. The dialog box includes who requested the shutdown, the display message (see lpMessage), and how much time there is until the server is shut down.</param>
        /// <param name="bForceAppsClosed">If this parameter is TRUE, applications with unsaved changes are to be forcibly closed. Note that this can result in data loss.If this parameter is FALSE, the system displays a dialog box instructing the user to close the applications.</param>
        /// <param name="bRebootAfterShutdown">If this parameter is TRUE, the computer is to restart immediately after shutting down. If this parameter is FALSE, the system flushes all caches to disk and safely powers down the system.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.To shut down the local computer, the calling thread must have the SE_SHUTDOWN_NAME privilege. To shut down a remote computer, the calling thread must have the SE_REMOTE_SHUTDOWN_NAME privilege on the remote computer. By default, users can enable the SE_SHUTDOWN_NAME privilege on the computer they are logged onto, and administrators can enable the SE_REMOTE_SHUTDOWN_NAME privilege on remote computers. For more information, see Running with Special Privileges.Common reasons for failure include an invalid or inaccessible computer name or insufficient privilege. The error ERROR_SHUTDOWN_IN_PROGRESS is returned if a shutdown is already in progress on the specified computer. The error ERROR_NOT_READY can be returned if fast-user switching is enabled but no user is logged on.A non-zero return value does not mean the logoff was or will be successful. The shutdown is an asynchronous process, and it can occur long after the API call has returned, or not at all. Even if the timeout value is zero, the shutdown can still be aborted by applications, services or even the system. The non-zero return value indicates that the validation of the rights and parameters was successful and that the system accepted the shutdown request.When this function is called, the caller must specify whether or not applications with unsaved changes should be forcibly closed. If the caller chooses not to force these applications closed, and an application with unsaved changes is running on the console session, the shutdown will remain in progress until the user logged into the console session aborts the shutdown, saves changes, closes the application, or forces the application to close. During this period, the shutdown may not be aborted except by the console user, and another shutdown may not be initiated.Note that calling this function with the value of the bForceAppsClosed parameter set to TRUE avoids this situation. Remember that doing this may result in loss of data.Windows Server 2003 and Windows XP:  If the computer is locked and the bForceAppsClosed parameter is FALSE, the last error code is ERROR_MACHINE_LOCKED. If the system is not ready to handle the request, the last error code is ERROR_NOT_READY. The application should wait a short while and retry the call. For example, the system can be unready to initiate a shutdown, and return ERROR_NOT_READY, if the shutdown request comes at the same time a user tries to log onto the system. In this case, the application should wait a short while and retry the call.For an example, see Displaying the Shutdown Dialog Box.AbortSystemShutdownInitiateSystemShutdownExShutting DownSystem Shutdown Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool InitiateSystemShutdownA(string lpMachineName, string lpMessage, uint dwTimeout, bool bForceAppsClosed, bool bRebootAfterShutdown);

        /// <summary>
        ///Initiates a shutdown and optional restart of the specified computer, and optionally records the reason for the shutdown.
        /// </summary>
        /// <param name="lpMachineName"></param>
        /// <param name="lpMessage"></param>
        /// <param name="dwTimeout">The length of time that the shutdown dialog box should be displayed, in seconds. While this dialog box is displayed, shutdown can be stopped by the AbortSystemShutdown function.If dwTimeout is not zero, InitiateSystemShutdownEx displays a dialog box on the specified computer. The dialog box displays the name of the user who called the function, displays the message specified by the lpMessage parameter, and prompts the user to log off. The dialog box beeps when it is created and remains on top of other windows in the system. The dialog box can be moved but not closed. A timer counts down the remaining time before shutdown.If dwTimeout is zero, the computer shuts down without displaying the dialog box, and the shutdown cannot be stopped by AbortSystemShutdown.Windows Server 2003 and Windows XP with SP1:  The time-out value is limited to MAX_SHUTDOWN_TIMEOUT seconds.Windows Server 2003 and Windows XP with SP1:  If the computer to be shut down is a Terminal Services server, the system displays a dialog box to all local and remote users warning them that shutdown has been initiated. The dialog box includes who requested the shutdown, the display message (see lpMessage), and how much time there is until the server is shut down.</param>
        /// <param name="bForceAppsClosed">If this parameter is TRUE, applications with unsaved changes are to be forcibly closed. If this parameter is FALSE, the system displays a dialog box instructing the user to close the applications.</param>
        /// <param name="bRebootAfterShutdown">If this parameter is TRUE, the computer is to restart immediately after shutting down. If this parameter is FALSE, the system flushes all caches to disk and safely powers down the system.</param>
        /// <param name="dwReason">The reason for initiating the shutdown. This parameter must be one of the system shutdown reason codes.If this parameter is zero, the default is an undefined shutdown that is logged as "No title for this reason could be found". By default, it is also an unplanned shutdown. Depending on how the system is configured, an unplanned shutdown triggers the creation of a file that contains the system state information, which can delay shutdown. Therefore, do not use zero for this parameter.Windows XP:  System state information is not saved during an unplanned system shutdown. The preceding text does not apply.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.To shut down the local computer, the calling thread must have the SE_SHUTDOWN_NAME privilege. To shut down a remote computer, the calling thread must have the SE_REMOTE_SHUTDOWN_NAME privilege on the remote computer. By default, users can enable the SE_SHUTDOWN_NAME privilege on the computer they are logged onto, and administrators can enable the SE_REMOTE_SHUTDOWN_NAME privilege on remote computers. For more information, see Running with Special Privileges.Common reasons for failure include an invalid or inaccessible computer name or insufficient privilege. The error ERROR_SHUTDOWN_IN_PROGRESS is returned if a shutdown is already in progress on the specified computer. The error ERROR_NOT_READY can be returned if fast-user switching is enabled but no user is logged on.A non-zero return value does not mean the logoff was or will be successful. The shutdown is an asynchronous process, and it can occur long after the API call has returned, or not at all. Even if the timeout value is zero, the shutdown can still be aborted by applications, services, or even the system. The non-zero return value indicates that the validation of the rights and parameters was successful and that the system accepted the shutdown request.When this function is called, the caller must specify whether or not applications with unsaved changes should be forcibly closed. If the caller chooses not to force these applications to close and an application with unsaved changes is running on the console session, the shutdown will remain in progress until the user logged into the console session aborts the shutdown, saves changes, closes the application, or forces the application to close. During this period the shutdown may not be aborted except by the console user, and another shutdown may not be initiated.Note that calling this function with the value of the bForceAppsClosed parameter set to TRUE avoids this situation. Remember that doing this may result in loss of data.Windows Server 2003 and Windows XP:  If the computer is locked and the bForceAppsClosed parameter is FALSE, the last error code is ERROR_MACHINE_LOCKED. If the system is not ready to handle the request, the last error code is ERROR_NOT_READY. The application should wait a short while and retry the call. For example, the system can be unready to initiate a shutdown, and return ERROR_NOT_READY, if the shutdown request comes at the same time a user tries to log onto the system. In this case, the application should wait a short while and retry the call.AbortSystemShutdownShutting DownSystem Shutdown Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool InitiateSystemShutdownExA(string lpMachineName, string lpMessage, uint dwTimeout, bool bForceAppsClosed, bool bRebootAfterShutdown, uint dwReason);

        /// <summary>
        ///Initiates a shutdown and optional restart of the specified computer, and optionally records the reason for the shutdown.
        /// </summary>
        /// <param name="lpMachineName"></param>
        /// <param name="lpMessage"></param>
        /// <param name="dwTimeout">The length of time that the shutdown dialog box should be displayed, in seconds. While this dialog box is displayed, shutdown can be stopped by the AbortSystemShutdown function.If dwTimeout is not zero, InitiateSystemShutdownEx displays a dialog box on the specified computer. The dialog box displays the name of the user who called the function, displays the message specified by the lpMessage parameter, and prompts the user to log off. The dialog box beeps when it is created and remains on top of other windows in the system. The dialog box can be moved but not closed. A timer counts down the remaining time before shutdown.If dwTimeout is zero, the computer shuts down without displaying the dialog box, and the shutdown cannot be stopped by AbortSystemShutdown.Windows Server 2003 and Windows XP with SP1:  The time-out value is limited to MAX_SHUTDOWN_TIMEOUT seconds.Windows Server 2003 and Windows XP with SP1:  If the computer to be shut down is a Terminal Services server, the system displays a dialog box to all local and remote users warning them that shutdown has been initiated. The dialog box includes who requested the shutdown, the display message (see lpMessage), and how much time there is until the server is shut down.</param>
        /// <param name="bForceAppsClosed">If this parameter is TRUE, applications with unsaved changes are to be forcibly closed. If this parameter is FALSE, the system displays a dialog box instructing the user to close the applications.</param>
        /// <param name="bRebootAfterShutdown">If this parameter is TRUE, the computer is to restart immediately after shutting down. If this parameter is FALSE, the system flushes all caches to disk and safely powers down the system.</param>
        /// <param name="dwReason">The reason for initiating the shutdown. This parameter must be one of the system shutdown reason codes.If this parameter is zero, the default is an undefined shutdown that is logged as "No title for this reason could be found". By default, it is also an unplanned shutdown. Depending on how the system is configured, an unplanned shutdown triggers the creation of a file that contains the system state information, which can delay shutdown. Therefore, do not use zero for this parameter.Windows XP:  System state information is not saved during an unplanned system shutdown. The preceding text does not apply.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.To shut down the local computer, the calling thread must have the SE_SHUTDOWN_NAME privilege. To shut down a remote computer, the calling thread must have the SE_REMOTE_SHUTDOWN_NAME privilege on the remote computer. By default, users can enable the SE_SHUTDOWN_NAME privilege on the computer they are logged onto, and administrators can enable the SE_REMOTE_SHUTDOWN_NAME privilege on remote computers. For more information, see Running with Special Privileges.Common reasons for failure include an invalid or inaccessible computer name or insufficient privilege. The error ERROR_SHUTDOWN_IN_PROGRESS is returned if a shutdown is already in progress on the specified computer. The error ERROR_NOT_READY can be returned if fast-user switching is enabled but no user is logged on.A non-zero return value does not mean the logoff was or will be successful. The shutdown is an asynchronous process, and it can occur long after the API call has returned, or not at all. Even if the timeout value is zero, the shutdown can still be aborted by applications, services, or even the system. The non-zero return value indicates that the validation of the rights and parameters was successful and that the system accepted the shutdown request.When this function is called, the caller must specify whether or not applications with unsaved changes should be forcibly closed. If the caller chooses not to force these applications to close and an application with unsaved changes is running on the console session, the shutdown will remain in progress until the user logged into the console session aborts the shutdown, saves changes, closes the application, or forces the application to close. During this period the shutdown may not be aborted except by the console user, and another shutdown may not be initiated.Note that calling this function with the value of the bForceAppsClosed parameter set to TRUE avoids this situation. Remember that doing this may result in loss of data.Windows Server 2003 and Windows XP:  If the computer is locked and the bForceAppsClosed parameter is FALSE, the last error code is ERROR_MACHINE_LOCKED. If the system is not ready to handle the request, the last error code is ERROR_NOT_READY. The application should wait a short while and retry the call. For example, the system can be unready to initiate a shutdown, and return ERROR_NOT_READY, if the shutdown request comes at the same time a user tries to log onto the system. In this case, the application should wait a short while and retry the call.AbortSystemShutdownShutting DownSystem Shutdown Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool InitiateSystemShutdownExW(string lpMachineName, string lpMessage, uint dwTimeout, bool bForceAppsClosed, bool bRebootAfterShutdown, uint dwReason);

        /// <summary>
        ///Initiates a shutdown and optional restart of the specified computer.
        /// </summary>
        /// <param name="lpMachineName"></param>
        /// <param name="lpMessage"></param>
        /// <param name="dwTimeout">The length of time that the shutdown dialog box should be displayed, in seconds. While this dialog box is displayed, the shutdown can be stopped by the AbortSystemShutdown function.If dwTimeout is not zero, InitiateSystemShutdown displays a dialog box on the specified computer. The dialog box displays the name of the user who called the function, displays the message specified by the lpMessage parameter, and prompts the user to log off. The dialog box beeps when it is created and remains on top of other windows in the system. The dialog box can be moved but not closed. A timer counts down the remaining time before a forced shutdown.If dwTimeout is zero, the computer shuts down without displaying the dialog box, and the shutdown cannot be stopped by AbortSystemShutdown.Windows Server 2003 and Windows XP with SP1:  The time-out value is limited to MAX_SHUTDOWN_TIMEOUT seconds.Windows Server 2003 and Windows XP with SP1:  If the computer to be shut down is a Terminal Services server, the system displays a dialog box to all local and remote users warning them that shutdown has been initiated. The dialog box includes who requested the shutdown, the display message (see lpMessage), and how much time there is until the server is shut down.</param>
        /// <param name="bForceAppsClosed">If this parameter is TRUE, applications with unsaved changes are to be forcibly closed. Note that this can result in data loss.If this parameter is FALSE, the system displays a dialog box instructing the user to close the applications.</param>
        /// <param name="bRebootAfterShutdown">If this parameter is TRUE, the computer is to restart immediately after shutting down. If this parameter is FALSE, the system flushes all caches to disk and safely powers down the system.If the function succeeds, the return value is nonzero.If the function fails, the return value is zero. To get extended error information, call GetLastError.To shut down the local computer, the calling thread must have the SE_SHUTDOWN_NAME privilege. To shut down a remote computer, the calling thread must have the SE_REMOTE_SHUTDOWN_NAME privilege on the remote computer. By default, users can enable the SE_SHUTDOWN_NAME privilege on the computer they are logged onto, and administrators can enable the SE_REMOTE_SHUTDOWN_NAME privilege on remote computers. For more information, see Running with Special Privileges.Common reasons for failure include an invalid or inaccessible computer name or insufficient privilege. The error ERROR_SHUTDOWN_IN_PROGRESS is returned if a shutdown is already in progress on the specified computer. The error ERROR_NOT_READY can be returned if fast-user switching is enabled but no user is logged on.A non-zero return value does not mean the logoff was or will be successful. The shutdown is an asynchronous process, and it can occur long after the API call has returned, or not at all. Even if the timeout value is zero, the shutdown can still be aborted by applications, services or even the system. The non-zero return value indicates that the validation of the rights and parameters was successful and that the system accepted the shutdown request.When this function is called, the caller must specify whether or not applications with unsaved changes should be forcibly closed. If the caller chooses not to force these applications closed, and an application with unsaved changes is running on the console session, the shutdown will remain in progress until the user logged into the console session aborts the shutdown, saves changes, closes the application, or forces the application to close. During this period, the shutdown may not be aborted except by the console user, and another shutdown may not be initiated.Note that calling this function with the value of the bForceAppsClosed parameter set to TRUE avoids this situation. Remember that doing this may result in loss of data.Windows Server 2003 and Windows XP:  If the computer is locked and the bForceAppsClosed parameter is FALSE, the last error code is ERROR_MACHINE_LOCKED. If the system is not ready to handle the request, the last error code is ERROR_NOT_READY. The application should wait a short while and retry the call. For example, the system can be unready to initiate a shutdown, and return ERROR_NOT_READY, if the shutdown request comes at the same time a user tries to log onto the system. In this case, the application should wait a short while and retry the call.For an example, see Displaying the Shutdown Dialog Box.AbortSystemShutdownInitiateSystemShutdownExShutting DownSystem Shutdown Functions</param>
        /// <remarks>
        /// To get extended error information, call GetLastError.
        /// </remarks>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool InitiateSystemShutdownW(string lpMachineName, string lpMessage, uint dwTimeout, bool bForceAppsClosed, bool bRebootAfterShutdown);

        /// <summary>
        ///Closes a handle to the specified registry key.
        /// </summary>
        /// <param name="hKey">A handle to the open key to be closed. The handle must have been opened by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, RegOpenKeyTransacted, or RegConnectRegistry function.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.The handle for a specified key should not be used after it has been closed, because it will no longer be valid. Key handles should not be left open any longer than necessary.The RegCloseKey function does not necessarily write information to the registry before returning; it can take as much as several seconds for the cache to be flushed to the hard disk. If an application must explicitly write registry information to the hard disk, it can use the RegFlushKey function. RegFlushKey, however, uses many system resources and should be called only when necessary.For an example, see Deleting a Key with Subkeys.RegConnectRegistryRegCreateKeyExRegDeleteKeyRegFlushKeyRegOpenKeyExRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegCloseKey(nint hKey);

        /// <summary>
        ///Establishes a connection to a predefined registry key on another computer.
        /// </summary>
        /// <param name="lpMachineName"></param>
        /// <param name="hKey">A predefined registry handle. This parameter can be one of the following predefined keys on the remote computer.HKEY_LOCAL_MACHINE HKEY_PERFORMANCE_DATA HKEY_USERS</param>
        /// <param name="phkResult"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegConnectRegistryA(string lpMachineName, nint hKey, out nint phkResult);

        /// <summary>
        ///Establishes a connection to a predefined registry key on another computer.
        /// </summary>
        /// <param name="lpMachineName"></param>
        /// <param name="hKey">A predefined registry handle. This parameter can be one of the following predefined keys on the remote computer.HKEY_LOCAL_MACHINE HKEY_PERFORMANCE_DATA HKEY_USERS</param>
        /// <param name="phkResult"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegConnectRegistryW(string lpMachineName, nint hKey, out nint phkResult);

        /// <summary>
        ///Copies the specified registry key, along with its values and subkeys, to the specified destination key.
        /// </summary>
        /// <param name="hKeySrc">A handle to an open registry key. The key must have been opened with the KEY_READ access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the predefined keys.</param>
        /// <param name="lpSubKey"></param>
        /// <param name="hKeyDest">A handle to the destination key. The calling process must have KEY_CREATE_SUB_KEY access to the key.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the predefined keys.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.This function also copies the security descriptor for the key.To compile an application that uses this function, define _WIN32_WINNT as 0x0600 or later. For more information, see Using the Windows Headers.Registry Functions</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegCopyTreeA(nint hKeySrc, string lpSubKey, nint hKeyDest);

        /// <summary>
        ///Copies the specified registry key, along with its values and subkeys, to the specified destination key.
        /// </summary>
        /// <param name="hKeySrc">A handle to an open registry key. The key must have been opened with the KEY_READ access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the predefined keys.</param>
        /// <param name="lpSubKey"></param>
        /// <param name="hKeyDest">A handle to the destination key. The calling process must have KEY_CREATE_SUB_KEY access to the key.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the predefined keys.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.This function also copies the security descriptor for the key.To compile an application that uses this function, define _WIN32_WINNT as 0x0600 or later. For more information, see Using the Windows Headers.Registry Functions</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegCopyTreeW(nint hKeySrc, string lpSubKey, nint hKeyDest);

        /// <summary>
        ///Creates the specified registry key. If the key already exists in the registry, the function opens it.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The calling process must have KEY_CREATE_SUB_KEY access to the key. For more information, see Registry Key Security and Access Rights.Access for key creation is checked against the security descriptor of the registry key, not the access mask specified when the handle was obtained. Therefore, even if hKey was opened with a samDesired of KEY_READ, it can be used in operations that create keys if allowed by its security descriptor.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="phkResult"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegCreateKeyA(nint hKey, string lpSubKey, out nint phkResult);

        /// <summary>
        ///Creates the specified registry key. If the key already exists, the function opens it. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The calling process must have KEY_CREATE_SUB_KEY access to the key. For more information, see Registry Key Security and Access Rights.Access for key creation is checked against the security descriptor of the registry key, not the access mask specified when the handle was obtained. Therefore, even if hKey was opened with a samDesired of KEY_READ, it can be used in operations that modify the registry if allowed by its security descriptor.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:</param>
        /// <param name="lpSubKey">The name of a subkey that this function opens or creates. The subkey specified must be a subkey of the key identified by the hKey parameter; it can be up to 32 levels deep in the registry tree. For more information on key names, see Structure of the Registry.If lpSubKey is a pointer to an empty string, phkResult receives a new handle to the key specified by hKey.This parameter cannot be NULL.ReservedThis parameter is reserved and must be zero.</param>
        /// <param name="lpClass"></param>
        /// <param name="dwOptions">This parameter can be one of the following values.</param>
        /// <param name="samDesired">A mask that specifies the access rights for the key to be created. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="lpSecurityAttributes"></param>
        /// <param name="phkResult"></param>
        /// <param name="lpdwDisposition"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegCreateKeyExA(nint hKey, string lpSubKey, string lpClass, uint dwOptions, nint samDesired, SECURITY_ATTRIBUTES lpSecurityAttributes, out nint phkResult, out uint lpdwDisposition);

        /// <summary>
        ///Creates the specified registry key. If the key already exists, the function opens it. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The calling process must have KEY_CREATE_SUB_KEY access to the key. For more information, see Registry Key Security and Access Rights.Access for key creation is checked against the security descriptor of the registry key, not the access mask specified when the handle was obtained. Therefore, even if hKey was opened with a samDesired of KEY_READ, it can be used in operations that modify the registry if allowed by its security descriptor.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:</param>
        /// <param name="lpSubKey">The name of a subkey that this function opens or creates. The subkey specified must be a subkey of the key identified by the hKey parameter; it can be up to 32 levels deep in the registry tree. For more information on key names, see Structure of the Registry.If lpSubKey is a pointer to an empty string, phkResult receives a new handle to the key specified by hKey.This parameter cannot be NULL.ReservedThis parameter is reserved and must be zero.</param>
        /// <param name="lpClass"></param>
        /// <param name="dwOptions">This parameter can be one of the following values.</param>
        /// <param name="samDesired">A mask that specifies the access rights for the key to be created. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="lpSecurityAttributes"></param>
        /// <param name="phkResult"></param>
        /// <param name="lpdwDisposition"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegCreateKeyExW(nint hKey, string lpSubKey, string lpClass, uint dwOptions, nint samDesired, SECURITY_ATTRIBUTES lpSecurityAttributes, out nint phkResult, out uint lpdwDisposition);

        /// <summary>
        ///Creates the specified registry key and associates it with a transaction. If the key already exists, the function opens it. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The calling process must have KEY_CREATE_SUB_KEY access to the key. For more information, see Registry Key Security and Access Rights.Access for key creation is checked against the security descriptor of the registry key, not the access mask specified when the handle was obtained. Therefore, even if hKey was opened with a samDesired of KEY_READ, it can be used in operations that create keys if allowed by its security descriptor.This handle is returned by the RegCreateKeyTransacted or RegOpenKeyTransacted function, or it can be one of the following predefined keys:</param>
        /// <param name="lpSubKey">The name of a subkey that this function opens or creates. The subkey specified must be a subkey of the key identified by the hKey parameter; it can be up to 32 levels deep in the registry tree. For more information on key names, see Structure of the Registry.If lpSubKey is a pointer to an empty string, phkResult receives a new handle to the key specified by hKey.This parameter cannot be NULL.ReservedThis parameter is reserved and must be zero.</param>
        /// <param name="lpClass"></param>
        /// <param name="dwOptions">This parameter can be one of the following values.</param>
        /// <param name="samDesired">A mask that specifies the access rights for the key to be created. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="lpSecurityAttributes"></param>
        /// <param name="phkResult"></param>
        /// <param name="lpdwDisposition"></param>
        /// <param name="hTransaction">A handle to an active transaction. This handle is returned by the CreateTransaction function.pExtendedParemeterThis parameter is reserved and must be NULL.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.When a key is created using this function, subsequent operations on the key are transacted. If a non-transacted operation is performed on the key before the transaction is committed, the transaction is rolled back. After a transaction is committed or rolled back, you must re-open the key using RegCreateKeyTransacted or RegOpenKeyTransacted with an active transaction handle to make additional operations transacted. For more information about transactions, see Kernel Transaction Manager.Note that subsequent operations on subkeys of this key are not automatically transacted. Therefore, RegDeleteKeyEx does not perform a transacted delete operation. Instead, use the RegDeleteKeyTransacted function to perform a transacted delete operation.The key that the RegCreateKeyTransacted function creates has no values. An application can use the RegSetValueEx function to set key values.The RegCreateKeyTransacted function creates all missing keys in the specified path. An application can take advantage of this behavior to create several keys at once. For example, an application can create a subkey four levels deep at the same time as the three preceding subkeys by specifying a string of the following form for the lpSubKey parameter:subkey1\subkey2\subkey3\subkey4Note that this behavior will result in creation of unwanted keys if an existing key in the path is spelled incorrectly.An application cannot create a key that is a direct child of HKEY_USERS or HKEY_LOCAL_MACHINE. An application can create subkeys in lower levels of the HKEY_USERS or HKEY_LOCAL_MACHINE trees.RegCloseKeyRegDeleteKeyTransactedRegOpenKeyTransactedRegSaveKeyRegistry FunctionsRegistry OverviewSECURITY_ATTRIBUTES</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegCreateKeyTransactedA(nint hKey, string lpSubKey, string lpClass, uint dwOptions, nint samDesired, SECURITY_ATTRIBUTES lpSecurityAttributes, out nint phkResult, out uint lpdwDisposition, nint hTransaction);

        /// <summary>
        ///Creates the specified registry key and associates it with a transaction. If the key already exists, the function opens it. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The calling process must have KEY_CREATE_SUB_KEY access to the key. For more information, see Registry Key Security and Access Rights.Access for key creation is checked against the security descriptor of the registry key, not the access mask specified when the handle was obtained. Therefore, even if hKey was opened with a samDesired of KEY_READ, it can be used in operations that create keys if allowed by its security descriptor.This handle is returned by the RegCreateKeyTransacted or RegOpenKeyTransacted function, or it can be one of the following predefined keys:</param>
        /// <param name="lpSubKey">The name of a subkey that this function opens or creates. The subkey specified must be a subkey of the key identified by the hKey parameter; it can be up to 32 levels deep in the registry tree. For more information on key names, see Structure of the Registry.If lpSubKey is a pointer to an empty string, phkResult receives a new handle to the key specified by hKey.This parameter cannot be NULL.ReservedThis parameter is reserved and must be zero.</param>
        /// <param name="lpClass"></param>
        /// <param name="dwOptions">This parameter can be one of the following values.</param>
        /// <param name="samDesired">A mask that specifies the access rights for the key to be created. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="lpSecurityAttributes"></param>
        /// <param name="phkResult"></param>
        /// <param name="lpdwDisposition"></param>
        /// <param name="hTransaction">A handle to an active transaction. This handle is returned by the CreateTransaction function.pExtendedParemeterThis parameter is reserved and must be NULL.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.When a key is created using this function, subsequent operations on the key are transacted. If a non-transacted operation is performed on the key before the transaction is committed, the transaction is rolled back. After a transaction is committed or rolled back, you must re-open the key using RegCreateKeyTransacted or RegOpenKeyTransacted with an active transaction handle to make additional operations transacted. For more information about transactions, see Kernel Transaction Manager.Note that subsequent operations on subkeys of this key are not automatically transacted. Therefore, RegDeleteKeyEx does not perform a transacted delete operation. Instead, use the RegDeleteKeyTransacted function to perform a transacted delete operation.The key that the RegCreateKeyTransacted function creates has no values. An application can use the RegSetValueEx function to set key values.The RegCreateKeyTransacted function creates all missing keys in the specified path. An application can take advantage of this behavior to create several keys at once. For example, an application can create a subkey four levels deep at the same time as the three preceding subkeys by specifying a string of the following form for the lpSubKey parameter:subkey1\subkey2\subkey3\subkey4Note that this behavior will result in creation of unwanted keys if an existing key in the path is spelled incorrectly.An application cannot create a key that is a direct child of HKEY_USERS or HKEY_LOCAL_MACHINE. An application can create subkeys in lower levels of the HKEY_USERS or HKEY_LOCAL_MACHINE trees.RegCloseKeyRegDeleteKeyTransactedRegOpenKeyTransactedRegSaveKeyRegistry FunctionsRegistry OverviewSECURITY_ATTRIBUTES</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegCreateKeyTransactedW(nint hKey, string lpSubKey, string lpClass, uint dwOptions, nint samDesired, SECURITY_ATTRIBUTES lpSecurityAttributes, out nint phkResult, out uint lpdwDisposition, nint hTransaction);

        /// <summary>
        ///Creates the specified registry key. If the key already exists in the registry, the function opens it.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The calling process must have KEY_CREATE_SUB_KEY access to the key. For more information, see Registry Key Security and Access Rights.Access for key creation is checked against the security descriptor of the registry key, not the access mask specified when the handle was obtained. Therefore, even if hKey was opened with a samDesired of KEY_READ, it can be used in operations that create keys if allowed by its security descriptor.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="phkResult"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegCreateKeyW(nint hKey, string lpSubKey, out nint phkResult);

        /// <summary>
        ///Deletes a subkey and its values. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The access rights of this key do not affect the delete operation. For more information about access rights, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following Predefined Keys:</param>
        /// <param name="lpSubKey">The name of the key to be deleted. It must be a subkey of the key that hKey identifies, but it cannot have subkeys. This parameter cannot be NULL.The function opens the subkey with the DELETE access right.Key names are not case sensitive.For more information, see Registry Element Size Limits.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. To get a generic description of the error, you can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag.A deleted key is not removed until the last handle to it is closed.The subkey to be deleted must not have subkeys. To delete a key and all its subkeys, you need to enumerate the subkeys and delete them individually. To delete keys recursively, use the RegDeleteTree or SHDeleteKey function.For an example that uses this function, see Deleting a Key with Subkeys.RegCloseKeyRegCreateKeyExRegDeleteTreeRegOpenKeyExRegistry FunctionsRegistry OverviewSHDeleteEmptyKeySHDeleteKey</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDeleteKeyA(nint hKey, string lpSubKey);

        /// <summary>
        ///Deletes a subkey and its values from the specified platform-specific view of the registry. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The access rights of this key do not affect the delete operation. For more information about access rights, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:</param>
        /// <param name="lpSubKey">The name of the key to be deleted. This key must be a subkey of the key specified by the value of the hKey parameter.The function opens the subkey with the DELETE access right.Key names are not case sensitive.The value of this parameter cannot be NULL.</param>
        /// <param name="samDesired">An access mask the specifies the platform-specific view of the registry.ReservedThis parameter is reserved and must be zero.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.A deleted key is not removed until the last handle to it is closed.On WOW64, 32-bit applications view a registry tree that is separate from the registry tree that 64-bit applications view. This function enables an application to delete an entry in the alternate registry view.The subkey to be deleted must not have subkeys. To delete a key and all its subkeys, you need to enumerate the subkeys and delete them individually. To delete keys recursively, use the RegDeleteTree or SHDeleteKey function.If the function succeeds, RegDeleteKeyEx removes the specified key from the registry. The entire key, including all of its values, is removed.RegCreateKeyExRegDeleteKeyTransactedRegOpenKeyExRegistry FunctionsRegistry Redirector</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDeleteKeyExA(nint hKey, string lpSubKey, nint samDesired);

        /// <summary>
        ///Deletes a subkey and its values from the specified platform-specific view of the registry. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The access rights of this key do not affect the delete operation. For more information about access rights, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:</param>
        /// <param name="lpSubKey">The name of the key to be deleted. This key must be a subkey of the key specified by the value of the hKey parameter.The function opens the subkey with the DELETE access right.Key names are not case sensitive.The value of this parameter cannot be NULL.</param>
        /// <param name="samDesired">An access mask the specifies the platform-specific view of the registry.ReservedThis parameter is reserved and must be zero.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.A deleted key is not removed until the last handle to it is closed.On WOW64, 32-bit applications view a registry tree that is separate from the registry tree that 64-bit applications view. This function enables an application to delete an entry in the alternate registry view.The subkey to be deleted must not have subkeys. To delete a key and all its subkeys, you need to enumerate the subkeys and delete them individually. To delete keys recursively, use the RegDeleteTree or SHDeleteKey function.If the function succeeds, RegDeleteKeyEx removes the specified key from the registry. The entire key, including all of its values, is removed.RegCreateKeyExRegDeleteKeyTransactedRegOpenKeyExRegistry FunctionsRegistry Redirector</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDeleteKeyExW(nint hKey, string lpSubKey, nint samDesired);

        /// <summary>
        ///Deletes a subkey and its values from the specified platform-specific view of the registry as a transacted operation. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The access rights of this key do not affect the delete operation. For more information about access rights, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpSubKey">The name of the key to be deleted. This key must be a subkey of the key specified by the value of the hKey parameter.The function opens the subkey with the DELETE access right.Key names are not case sensitive.The value of this parameter cannot be NULL.</param>
        /// <param name="samDesired">An access mask the specifies the platform-specific view of the registry.ReservedThis parameter is reserved and must be zero.</param>
        /// <param name="hTransaction">A handle to an active transaction. This handle is returned by the CreateTransaction function.pExtendedParameterThis parameter is reserved and must be NULL.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.A deleted key is not removed until the last handle to it is closed.On WOW64, 32-bit applications view a registry tree that is separate from the registry tree that 64-bit applications view. This function enables an application to delete an entry in the alternate registry view.The subkey to be deleted must not have subkeys. To delete a key and all its subkeys, you need to enumerate the subkeys and delete them individually. To delete keys recursively, use the RegDeleteTree or SHDeleteKey function.If the function succeeds, RegDeleteKeyTransacted removes the specified key from the registry. The entire key, including all of its values, is removed. To remove the entire tree as a transacted operation, use the RegDeleteTree function with a handle returned from RegCreateKeyTransacted or RegOpenKeyTransacted.RegCreateKeyTransactedRegOpenKeyTransactedRegistry FunctionsRegistry Redirector</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDeleteKeyTransactedA(nint hKey, string lpSubKey, nint samDesired, nint hTransaction);

        /// <summary>
        ///Deletes a subkey and its values from the specified platform-specific view of the registry as a transacted operation. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The access rights of this key do not affect the delete operation. For more information about access rights, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpSubKey">The name of the key to be deleted. This key must be a subkey of the key specified by the value of the hKey parameter.The function opens the subkey with the DELETE access right.Key names are not case sensitive.The value of this parameter cannot be NULL.</param>
        /// <param name="samDesired">An access mask the specifies the platform-specific view of the registry.ReservedThis parameter is reserved and must be zero.</param>
        /// <param name="hTransaction">A handle to an active transaction. This handle is returned by the CreateTransaction function.pExtendedParameterThis parameter is reserved and must be NULL.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.A deleted key is not removed until the last handle to it is closed.On WOW64, 32-bit applications view a registry tree that is separate from the registry tree that 64-bit applications view. This function enables an application to delete an entry in the alternate registry view.The subkey to be deleted must not have subkeys. To delete a key and all its subkeys, you need to enumerate the subkeys and delete them individually. To delete keys recursively, use the RegDeleteTree or SHDeleteKey function.If the function succeeds, RegDeleteKeyTransacted removes the specified key from the registry. The entire key, including all of its values, is removed. To remove the entire tree as a transacted operation, use the RegDeleteTree function with a handle returned from RegCreateKeyTransacted or RegOpenKeyTransacted.RegCreateKeyTransactedRegOpenKeyTransactedRegistry FunctionsRegistry Redirector</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDeleteKeyTransactedW(nint hKey, string lpSubKey, nint samDesired, nint hTransaction);

        /// <summary>
        ///Removes the specified value from the specified registry key and subkey.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_SET_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpValueName"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDeleteKeyValueA(nint hKey, string lpSubKey, string lpValueName);

        /// <summary>
        ///Removes the specified value from the specified registry key and subkey.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_SET_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpValueName"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDeleteKeyValueW(nint hKey, string lpSubKey, string lpValueName);

        /// <summary>
        ///Deletes a subkey and its values. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The access rights of this key do not affect the delete operation. For more information about access rights, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following Predefined Keys:</param>
        /// <param name="lpSubKey">The name of the key to be deleted. It must be a subkey of the key that hKey identifies, but it cannot have subkeys. This parameter cannot be NULL.The function opens the subkey with the DELETE access right.Key names are not case sensitive.For more information, see Registry Element Size Limits.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. To get a generic description of the error, you can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag.A deleted key is not removed until the last handle to it is closed.The subkey to be deleted must not have subkeys. To delete a key and all its subkeys, you need to enumerate the subkeys and delete them individually. To delete keys recursively, use the RegDeleteTree or SHDeleteKey function.For an example that uses this function, see Deleting a Key with Subkeys.RegCloseKeyRegCreateKeyExRegDeleteTreeRegOpenKeyExRegistry FunctionsRegistry OverviewSHDeleteEmptyKeySHDeleteKey</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDeleteKeyW(nint hKey, string lpSubKey);

        /// <summary>
        ///Deletes the subkeys and values of the specified key recursively.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the following access rights: DELETE, KEY_ENUMERATE_SUB_KEYS, and KEY_QUERY_VALUE. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function, or it can be one of the following Predefined Keys:</param>
        /// <param name="lpSubKey"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDeleteTreeA(nint hKey, string lpSubKey);

        /// <summary>
        ///Deletes the subkeys and values of the specified key recursively.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the following access rights: DELETE, KEY_ENUMERATE_SUB_KEYS, and KEY_QUERY_VALUE. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function, or it can be one of the following Predefined Keys:</param>
        /// <param name="lpSubKey"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDeleteTreeW(nint hKey, string lpSubKey);

        /// <summary>
        ///Removes a named value from the specified registry key. Note that value names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_SET_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpValueName"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDeleteValueA(nint hKey, string lpValueName);

        /// <summary>
        ///Removes a named value from the specified registry key. Note that value names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_SET_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpValueName"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDeleteValueW(nint hKey, string lpValueName);

        /// <summary>
        ///Disables handle caching of the predefined registry handle for HKEY_CURRENT_USER for the current process. This function does not work on a remote computer.
        /// </summary>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDisablePredefinedCache();

        /// <summary>
        ///Disables handle caching for all predefined registry handles for the current process.
        /// </summary>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegDisablePredefinedCacheEx();

        /// <summary>
        ///Disables registry reflection for the specified key. Disabling reflection for a key does not affect reflection of any subkeys.
        /// </summary>
        /// <param name="hBase">A handle to an open registry key. This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function; it cannot specify a key on a remote computer.If the key is not on the reflection list, the function succeeds but has no effect. For more information, see Registry Redirector and Registry Reflection.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.On WOW64, 32-bit applications view a registry tree that is separate from the registry tree that 64-bit applications view. Registry reflection copies specific registry keys and values between the two views.To restore registry reflection for a disabled key, use the RegEnableReflectionKey function.RegCreateKeyExRegEnableReflectionKeyRegOpenKeyExRegQueryReflectionKeyRegistry FunctionsRegistry Redirector</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int RegDisableReflectionKey(nint hBase);

        /// <summary>
        ///Restores registry reflection for the specified disabled key. Restoring reflection for a key does not affect reflection of any subkeys.
        /// </summary>
        /// <param name="hBase">A handle to the registry key that was previously disabled using the RegDisableReflectionKey function. This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function; it cannot specify a key on a remote computer.If the key is not on the reflection list, this function succeeds but has no effect. For more information, see Registry Redirector and Registry Reflection.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.On WOW64, 32-bit applications view a registry tree that is separate from the registry tree that 64-bit applications view. Registry reflection copies specific registry keys and values between the two views.RegCreateKeyExRegDisableReflectionKeyRegOpenKeyExRegQueryReflectionKeyRegistry FunctionsRegistry Redirector</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int RegEnableReflectionKey(nint hBase);

        /// <summary>
        ///Enumerates the subkeys of the specified open registry key. The function retrieves the name of one subkey each time it is called.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_ENUMERATE_SUB_KEYS access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="dwIndex">The index of the subkey of hKey to be retrieved. This value should be zero for the first call to the RegEnumKey function and then incremented for subsequent calls.Because subkeys are not ordered, any new subkey will have an arbitrary index. This means that the function may return subkeys in any order.</param>
        /// <param name="lpName"></param>
        /// <param name="cchName">The size of the buffer pointed to by the lpName parameter, in TCHARs. To determine the required buffer size, use the RegQueryInfoKey function to determine the size of the largest subkey for the key identified by the hKey parameter.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a system error code. If there are no more subkeys available, the function returns ERROR_NO_MORE_ITEMS.If the lpName buffer is too small to receive the name of the key, the function returns ERROR_MORE_DATA.To enumerate subkeys, an application should initially call the RegEnumKey function with the dwIndex parameter set to zero. The application should then increment the dwIndex parameter and call the RegEnumKey function until there are no more subkeys (meaning the function returns ERROR_NO_MORE_ITEMS).The application can also set dwIndex to the index of the last key on the first call to the function and decrement the index until the subkey with index 0 is enumerated. To retrieve the index of the last subkey, use the RegQueryInfoKey.While an application is using the RegEnumKey function, it should not make calls to any registration functions that might change the key being queried.RegCloseKeyRegCreateKeyExRegDeleteKeyRegEnumKeyExRegOpenKeyExRegQueryInfoKeyRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegEnumKeyA(nint hKey, uint dwIndex, out string lpName, uint cchName);

        /// <summary>
        ///Enumerates the subkeys of the specified open registry key. The function retrieves information about one subkey each time it is called.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_ENUMERATE_SUB_KEYS access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="dwIndex">The index of the subkey to retrieve. This parameter should be zero for the first call to the RegEnumKeyEx function and then incremented for subsequent calls.Because subkeys are not ordered, any new subkey will have an arbitrary index. This means that the function may return subkeys in any order.</param>
        /// <param name="lpName"></param>
        /// <param name="lpcchName">A pointer to a variable that specifies the size of the buffer specified by the lpName parameter, in characters. This size should include the terminating null character. If the function succeeds, the variable pointed to by lpcchName contains the number of characters stored in the buffer, not including the terminating null character.To determine the required buffer size, use the RegQueryInfoKey function to determine the size of the largest subkey for the key identified by the hKey parameter.lpReservedThis parameter is reserved and must be NULL.</param>
        /// <param name="lpClass">A pointer to a buffer that receives the user-defined class of the enumerated subkey. This parameter can be NULL.</param>
        /// <param name="lpcchClass"></param>
        /// <param name="lpftLastWriteTime"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegEnumKeyExA(nint hKey, uint dwIndex, out string lpName, out uint lpcchName, out string lpClass, out uint lpcchClass, out FILETIME lpftLastWriteTime);

        /// <summary>
        ///Enumerates the subkeys of the specified open registry key. The function retrieves information about one subkey each time it is called.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_ENUMERATE_SUB_KEYS access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="dwIndex">The index of the subkey to retrieve. This parameter should be zero for the first call to the RegEnumKeyEx function and then incremented for subsequent calls.Because subkeys are not ordered, any new subkey will have an arbitrary index. This means that the function may return subkeys in any order.</param>
        /// <param name="lpName"></param>
        /// <param name="lpcchName">A pointer to a variable that specifies the size of the buffer specified by the lpName parameter, in characters. This size should include the terminating null character. If the function succeeds, the variable pointed to by lpcName contains the number of characters stored in the buffer, not including the terminating null character.To determine the required buffer size, use the RegQueryInfoKey function to determine the size of the largest subkey for the key identified by the hKey parameter.lpReservedThis parameter is reserved and must be NULL.</param>
        /// <param name="lpClass">A pointer to a buffer that receives the user-defined class of the enumerated subkey. This parameter can be NULL.</param>
        /// <param name="lpcchClass"></param>
        /// <param name="lpftLastWriteTime"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegEnumKeyExW(nint hKey, uint dwIndex, out string lpName, out uint lpcchName, out string lpClass, out uint lpcchClass, out FILETIME lpftLastWriteTime);

        /// <summary>
        ///Enumerates the subkeys of the specified open registry key. The function retrieves the name of one subkey each time it is called.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_ENUMERATE_SUB_KEYS access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="dwIndex">The index of the subkey of hKey to be retrieved. This value should be zero for the first call to the RegEnumKey function and then incremented for subsequent calls.Because subkeys are not ordered, any new subkey will have an arbitrary index. This means that the function may return subkeys in any order.</param>
        /// <param name="lpName"></param>
        /// <param name="cchName">The size of the buffer pointed to by the lpName parameter, in TCHARs. To determine the required buffer size, use the RegQueryInfoKey function to determine the size of the largest subkey for the key identified by the hKey parameter.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a system error code. If there are no more subkeys available, the function returns ERROR_NO_MORE_ITEMS.If the lpName buffer is too small to receive the name of the key, the function returns ERROR_MORE_DATA.To enumerate subkeys, an application should initially call the RegEnumKey function with the dwIndex parameter set to zero. The application should then increment the dwIndex parameter and call the RegEnumKey function until there are no more subkeys (meaning the function returns ERROR_NO_MORE_ITEMS).The application can also set dwIndex to the index of the last key on the first call to the function and decrement the index until the subkey with index 0 is enumerated. To retrieve the index of the last subkey, use the RegQueryInfoKey.While an application is using the RegEnumKey function, it should not make calls to any registration functions that might change the key being queried.RegCloseKeyRegCreateKeyExRegDeleteKeyRegEnumKeyExRegOpenKeyExRegQueryInfoKeyRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegEnumKeyW(nint hKey, uint dwIndex, out string lpName, uint cchName);

        /// <summary>
        ///Enumerates the values for the specified open registry key. The function copies one indexed value name and data block for the key each time it is called.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="dwIndex">The index of the value to be retrieved. This parameter should be zero for the first call to the RegEnumValue function and then be incremented for subsequent calls.Because values are not ordered, any new value will have an arbitrary index. This means that the function may return values in any order.</param>
        /// <param name="lpValueName"></param>
        /// <param name="lpcchValueName">A pointer to a variable that specifies the size of the buffer pointed to by the lpValueName parameter, in characters. When the function returns, the variable receives the number of characters stored in the buffer, not including the terminating null character.If the buffer specified by lpValueName is not large enough to hold the data, the function returns ERROR_MORE_DATA and the buffer size in the variable pointed to by lpValueName is not changed. In this case, the contents of lpcchValueName are undefined.Registry value names are limited to 32,767 bytes. The ANSI version of this function treats this parameter as a SHORT value. Therefore, if you specify a value greater than 32,767 bytes, there is an overflow and the function may return ERROR_MORE_DATA.lpReservedThis parameter is reserved and must be NULL.</param>
        /// <param name="lpType"></param>
        /// <param name="lpData"></param>
        /// <param name="lpcbData"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegEnumValueA(nint hKey, uint dwIndex, out string lpValueName, out uint lpcchValueName, out uint lpType, out byte lpData, out uint lpcbData);

        /// <summary>
        ///Enumerates the values for the specified open registry key. The function copies one indexed value name and data block for the key each time it is called.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="dwIndex">The index of the value to be retrieved. This parameter should be zero for the first call to the RegEnumValue function and then be incremented for subsequent calls.Because values are not ordered, any new value will have an arbitrary index. This means that the function may return values in any order.</param>
        /// <param name="lpValueName"></param>
        /// <param name="lpcchValueName">A pointer to a variable that specifies the size of the buffer pointed to by the lpValueName parameter, in characters. When the function returns, the variable receives the number of characters stored in the buffer, not including the terminating null character.Registry value names are limited to 32,767 bytes. The ANSI version of this function treats this parameter as a SHORT value. Therefore, if you specify a value greater than 32,767 bytes, there is an overflow and the function may return ERROR_MORE_DATA.lpReservedThis parameter is reserved and must be NULL.</param>
        /// <param name="lpType"></param>
        /// <param name="lpData"></param>
        /// <param name="lpcbData"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegEnumValueW(nint hKey, uint dwIndex, out string lpValueName, out uint lpcchValueName, out uint lpType, out byte lpData, out uint lpcbData);

        /// <summary>
        ///Writes all the attributes of the specified open registry key into the registry.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.Calling RegFlushKey is an expensive operation that significantly affects system-wide performance as it consumes disk bandwidth and blocks modifications to all keys by all processes in the registry hive that is being flushed until the flush operation completes. RegFlushKey should only be called explicitly when an application must guarantee that registry changes are persisted to disk immediately after modification. All modifications made to keys are visible to other processes without the need to flush them to disk.Alternatively, the registry has a 'lazy flush' mechanism that flushes registry modifications to disk at regular intervals of time. In addition to this regular flush operation, registry changes are also flushed to disk at system shutdown. Allowing the 'lazy flush' to flush registry changes is the most efficient way to manage registry writes to the registry store on disk.The RegFlushKey function returns only when all the data for the hive that contains the specified key has been written to the registry store on disk.The RegFlushKey function writes out the data for other keys in the hive that have been modified since the last lazy flush or system start.After RegFlushKey returns, use RegCloseKey to close the handle to the registry key.RegCloseKeyRegDeleteKeyRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegFlushKey(nint hKey);

        /// <summary>
        ///The RegGetKeySecurity function retrieves a copy of the security descriptor protecting the specified open registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open key for which to retrieve the security descriptor.</param>
        /// <param name="SecurityInformation">A SECURITY_INFORMATION value that indicates the requested security information.</param>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="lpcbSecurityDescriptor">A pointer to a variable that specifies the size, in bytes, of the buffer pointed to by the pSecurityDescriptor parameter. When the function returns, the variable contains the number of bytes written to the buffer.If the function succeeds, the function returns ERROR_SUCCESS.If the function fails, it returns a nonzero error code defined in WinError.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.If the buffer specified by the pSecurityDescriptor parameter is too small, the function returns ERROR_INSUFFICIENT_BUFFER and the lpcbSecurityDescriptor parameter contains the number of bytes required for the requested security descriptor.To read the owner, group, or discretionary access control list (DACL) from the key's security descriptor, the calling process must have been granted READ_CONTROL access when the handle was opened. To get READ_CONTROL access, the caller must be the owner of the key or the key's DACL must grant the access.To read the system access control list (SACL) from the security descriptor, the calling process must have been granted ACCESS_SYSTEM_SECURITY access when the key was opened. The correct way to get this access is to enable the SE_SECURITY_NAME privilege in the caller's current token, open the handle for ACCESS_SYSTEM_SECURITY access, and then disable the privilege.FormatMessageLow-level Access ControlLow-level Access Control FunctionsRegDeleteKeyRegOpenKeyExRegSetKeySecuritySECURITY_INFORMATION</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegGetKeySecurity(nint hKey, ACL_SIZE_INFORMATION SecurityInformation, out SECURITY_DESCRIPTOR pSecurityDescriptor, out uint lpcbSecurityDescriptor);

        /// <summary>
        ///Retrieves the type and data for the specified registry value.
        /// </summary>
        /// <param name="hkey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpValue"></param>
        /// <param name="dwFlags"></param>
        /// <param name="pdwType"></param>
        /// <param name="pvData"></param>
        /// <param name="pcbData"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegGetValueA(nint hkey, string lpSubKey, string lpValue, uint dwFlags, out uint pdwType, out nint pvData, out uint pcbData);

        /// <summary>
        ///Retrieves the type and data for the specified registry value.
        /// </summary>
        /// <param name="hkey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpValue"></param>
        /// <param name="dwFlags"></param>
        /// <param name="pdwType"></param>
        /// <param name="pvData"></param>
        /// <param name="pcbData"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegGetValueW(nint hkey, string lpSubKey, string lpValue, uint dwFlags, out uint pdwType, out nint pvData, out uint pcbData);

        /// <summary>
        ///Loads the specified registry hive as an application hive.
        /// </summary>
        /// <param name="lpFile">The name of the hive file. This hive must have been created with the RegSaveKey or RegSaveKeyEx function. If the file does not exist, an empty hive file is created with the specified name.</param>
        /// <param name="phkResult"></param>
        /// <param name="samDesired">A mask that specifies the access rights requested for the returned root key. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="dwOptions">If this parameter is REG_PROCESS_APPKEY, the hive cannot be loaded again while it is loaded by the caller. This prevents access to this registry hive by another caller.ReservedThis parameter is reserved.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.Unlike RegLoadKey, RegLoadAppKey does not load the hive under HKEY_LOCAL_MACHINE or HKEY_USERS. Instead, the hive is loaded under a special root that cannot be enumerated. As a result, there is no way to enumerate hives currently loaded by RegLoadAppKey. All operations on hives loaded by RegLoadAppKey have to be performed relative to the handle returned in phkResult.If two processes are required to perform operations on the same hive, each process must call RegLoadAppKey to retrieve a handle. During the RegLoadAppKey operation, the registry will verify if the file has already been loaded. If it has been loaded, the registry will return a handle to the previously loaded hive rather than re-loading the hive.All keys inside the hive must have the same security descriptor, otherwise the function will fail. This security descriptor must grant the caller the access specified by the samDesired parameter or the function will fail. You cannot use the RegSetKeySecurity function on any key inside the hive.In Windows 8 and later, each process can call RegLoadAppKey to load multiple hives. In Windows 7 and earlier, each process can load only one hive using RegLoadAppKey at a time.Any hive loaded using RegLoadAppKey is automatically unloaded when all handles to the keys inside the hive are closed using RegCloseKey.To compile an application that uses this function, define _WIN32_WINNT as 0x0600 or later. For more information, see Using the Windows Headers.RegSaveKeyRegistry FunctionsRegistry Hive</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegLoadAppKeyA(string lpFile, out nint phkResult, nint samDesired, uint dwOptions);

        /// <summary>
        ///Loads the specified registry hive as an application hive.
        /// </summary>
        /// <param name="lpFile">The name of the hive file. This hive must have been created with the RegSaveKey or RegSaveKeyEx function. If the file does not exist, an empty hive file is created with the specified name.</param>
        /// <param name="phkResult"></param>
        /// <param name="samDesired">A mask that specifies the access rights requested for the returned root key. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="dwOptions">If this parameter is REG_PROCESS_APPKEY, the hive cannot be loaded again while it is loaded by the caller. This prevents access to this registry hive by another caller.ReservedThis parameter is reserved.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.Unlike RegLoadKey, RegLoadAppKey does not load the hive under HKEY_LOCAL_MACHINE or HKEY_USERS. Instead, the hive is loaded under a special root that cannot be enumerated. As a result, there is no way to enumerate hives currently loaded by RegLoadAppKey. All operations on hives loaded by RegLoadAppKey have to be performed relative to the handle returned in phkResult.If two processes are required to perform operations on the same hive, each process must call RegLoadAppKey to retrieve a handle. During the RegLoadAppKey operation, the registry will verify if the file has already been loaded. If it has been loaded, the registry will return a handle to the previously loaded hive rather than re-loading the hive.All keys inside the hive must have the same security descriptor, otherwise the function will fail. This security descriptor must grant the caller the access specified by the samDesired parameter or the function will fail. You cannot use the RegSetKeySecurity function on any key inside the hive.In Windows 8 and later, each process can call RegLoadAppKey to load multiple hives. In Windows 7 and earlier, each process can load only one hive using RegLoadAppKey at a time.Any hive loaded using RegLoadAppKey is automatically unloaded when all handles to the keys inside the hive are closed using RegCloseKey.To compile an application that uses this function, define _WIN32_WINNT as 0x0600 or later. For more information, see Using the Windows Headers.RegSaveKeyRegistry FunctionsRegistry Hive</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegLoadAppKeyW(string lpFile, out nint phkResult, nint samDesired, uint dwOptions);

        /// <summary>
        ///Creates a subkey under HKEY_USERS or HKEY_LOCAL_MACHINE and loads the data from the specified registry hive into that subkey.
        /// </summary>
        /// <param name="hKey">A handle to the key where the subkey will be created. This can be a handle returned by a call to RegConnectRegistry, or one of the following predefined handles:HKEY_LOCAL_MACHINE HKEY_USERS This function always loads information at the top of the registry hierarchy. The HKEY_CLASSES_ROOT and HKEY_CURRENT_USER handle values cannot be specified for this parameter, because they represent subsets of the HKEY_LOCAL_MACHINE and HKEY_USERS handle values, respectively.</param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpFile">The name of the file containing the registry data. This file must be a local file that was created with the RegSaveKey function. If this file does not exist, a file is created with the specified name.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.There are two registry hive file formats. Registry hives created on current operating systems typically cannot be loaded by earlier ones.If hKey is a handle returned by RegConnectRegistry, then the path specified in lpFile is relative to the remote computer.The calling process must have the SE_RESTORE_NAME and SE_BACKUP_NAME privileges on the computer in which the registry resides. For more information, see Running with Special Privileges. To load a hive without requiring these special privileges, use the RegLoadAppKey function.RegConnectRegistryRegDeleteKeyRegLoadAppKeyRegReplaceKeyRegRestoreKeyRegSaveKeyRegUnLoadKeyRegistry FunctionsRegistry Hive</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegLoadKeyA(nint hKey, string lpSubKey, string lpFile);

        /// <summary>
        ///Creates a subkey under HKEY_USERS or HKEY_LOCAL_MACHINE and loads the data from the specified registry hive into that subkey.
        /// </summary>
        /// <param name="hKey">A handle to the key where the subkey will be created. This can be a handle returned by a call to RegConnectRegistry, or one of the following predefined handles:HKEY_LOCAL_MACHINE HKEY_USERS This function always loads information at the top of the registry hierarchy. The HKEY_CLASSES_ROOT and HKEY_CURRENT_USER handle values cannot be specified for this parameter, because they represent subsets of the HKEY_LOCAL_MACHINE and HKEY_USERS handle values, respectively.</param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpFile">The name of the file containing the registry data. This file must be a local file that was created with the RegSaveKey function. If this file does not exist, a file is created with the specified name.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.There are two registry hive file formats. Registry hives created on current operating systems typically cannot be loaded by earlier ones.If hKey is a handle returned by RegConnectRegistry, then the path specified in lpFile is relative to the remote computer.The calling process must have the SE_RESTORE_NAME and SE_BACKUP_NAME privileges on the computer in which the registry resides. For more information, see Running with Special Privileges. To load a hive without requiring these special privileges, use the RegLoadAppKey function.RegConnectRegistryRegDeleteKeyRegLoadAppKeyRegReplaceKeyRegRestoreKeyRegSaveKeyRegUnLoadKeyRegistry FunctionsRegistry Hive</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegLoadKeyW(nint hKey, string lpSubKey, string lpFile);

        /// <summary>
        ///Loads the specified string from the specified key and subkey.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function. It can also be one of the following predefined keys:</param>
        /// <param name="pszValue"></param>
        /// <param name="pszOutBuf"></param>
        /// <param name="cbOutBuf">The size of the pszOutBuf buffer, in bytes.</param>
        /// <param name="pcbData"></param>
        /// <param name="Flags">This parameter can be 0 or the following value.</param>
        /// <param name="pszDirectory"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegLoadMUIStringA(nint hKey, string pszValue, out string pszOutBuf, uint cbOutBuf, out uint pcbData, uint Flags, string pszDirectory);

        /// <summary>
        ///Loads the specified string from the specified key and subkey.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function. It can also be one of the following predefined keys:</param>
        /// <param name="pszValue"></param>
        /// <param name="pszOutBuf"></param>
        /// <param name="cbOutBuf">The size of the pszOutBuf buffer, in bytes.</param>
        /// <param name="pcbData"></param>
        /// <param name="Flags">This parameter can be 0 or the following value.</param>
        /// <param name="pszDirectory"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegLoadMUIStringW(nint hKey, string pszValue, out string pszOutBuf, uint cbOutBuf, out uint pcbData, uint Flags, string pszDirectory);

        /// <summary>
        ///Notifies the caller about changes to the attributes or contents of a specified registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function. It can also be one of the following predefined keys:HKEY_CLASSES_ROOT HKEY_CURRENT_CONFIG HKEY_CURRENT_USER HKEY_LOCAL_MACHINE HKEY_USERS This parameter must be a local handle. If RegNotifyChangeKeyValue is called with a remote handle, it returns ERROR_INVALID_HANDLE.The key must have been opened with the KEY_NOTIFY access right. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="bWatchSubtree">If this parameter is TRUE, the function reports changes in the specified key and its subkeys. If the parameter is FALSE, the function reports changes only in the specified key.</param>
        /// <param name="dwNotifyFilter">A value that indicates the changes that should be reported. This parameter can be one or more of the following values.</param>
        /// <param name="hEvent"></param>
        /// <param name="fAsynchronous">If this parameter is TRUE, the function returns immediately and reports changes by signaling the specified event. If this parameter is FALSE, the function does not return until a change has occurred.If hEvent does not specify a valid event, the fAsynchronous parameter cannot be TRUE.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.This function detects a single change. After the caller receives a notification event, it should call the function again to receive the next notification.If the specified key is closed, the event is signaled. This means that an application should not depend on the key being open after returning from a wait operation on the event.The REG_NOTIFY_THREAD_AGNOSTIC flag introduced in Windows 8 enables the use of RegNotifyChangeKeyValue for ThreadPool threads.If the thread that called RegNotifyChangeKeyValue exits, the event is signaled. To continue to monitor additional changes in the value of the key, call RegNotifyChangeKeyValue again from another thread.With the exception of RegNotifyChangeKeyValue calls with REG_NOTIFY_THREAD_AGNOSTIC set, this function must be called on persistent threads. If the calling thread is from a thread pool and it is not persistent, the event is signaled every time the thread terminates, not just when there is a registry change. To ensure accurate results, run the thread pool work in a persistent thread by using the SetThreadpoolCallbackPersistent function, or create your own thread using the CreateThread function. (For the original thread pool API, specify WT_EXECUTEINPERSISTENTTHREAD using the QueueUserWorkItem function.)This function should not be called multiple times with the same value for the hKey but different values for the bWatchSubtree and dwNotifyFilter parameters. The function will succeed but the changes will be ignored. To change the watch parameters, you must first close the key handle by calling RegCloseKey, reopen the key handle by calling RegOpenKeyEx, and then call RegNotifyChangeKeyValue with the new parameters.Each time a process calls RegNotifyChangeKeyValue with the same set of parameters, it establishes another wait operation, creating a resource leak. Therefore, check that you are not calling RegNotifyChangeKeyValue with the same parameters until the previous wait operation has completed.To monitor registry operations in more detail, see Registry.Windows XP/2000:  When RegNotifyChangeKeyValue is called for a particular key handle, change notifications occur for as long as the key handle is valid. This causes a second call to RegNotifyChangeKeyValue to return immediately, if any changes occur in the interim between the first and second calls. If the function is being used asynchronously, the passed event handle will be signaled immediately if any changes occur in the interim.The following program illustrates how to use RegNotifyChangeKeyValue.RegCloseKeyRegDeleteKeyRegEnumKeyExRegEnumValueRegQueryInfoKeyRegQueryValueExRegistry Functions</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegNotifyChangeKeyValue(nint hKey, bool bWatchSubtree, uint dwNotifyFilter, nint hEvent, bool fAsynchronous);

        /// <summary>
        ///Retrieves a handle to the HKEY_CURRENT_USER key for the user the current thread is impersonating.
        /// </summary>
        /// <param name="samDesired">A mask that specifies the desired access rights to the key. The function fails if the security descriptor of the key does not permit the requested access for the calling process. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="phkResult"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegOpenCurrentUser(nint samDesired, out nint phkResult);

        /// <summary>
        ///Opens the specified registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="phkResult"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegOpenKeyA(nint hKey, string lpSubKey, out nint phkResult);

        /// <summary>
        ///Opens the specified registry key. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:HKEY_CLASSES_ROOT HKEY_CURRENT_CONFIG HKEY_CURRENT_USER HKEY_LOCAL_MACHINE HKEY_USERS</param>
        /// <param name="lpSubKey"></param>
        /// <param name="ulOptions">Specifies the option to apply when opening the key. Set this parameter to zero or the following:</param>
        /// <param name="samDesired">A mask that specifies the desired access rights to the key to be opened. The function fails if the security descriptor of the key does not permit the requested access for the calling process. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="phkResult"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegOpenKeyExA(nint hKey, string lpSubKey, uint ulOptions, nint samDesired, out nint phkResult);

        /// <summary>
        ///Opens the specified registry key. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:HKEY_CLASSES_ROOT HKEY_CURRENT_CONFIG HKEY_CURRENT_USER HKEY_LOCAL_MACHINE HKEY_USERS</param>
        /// <param name="lpSubKey"></param>
        /// <param name="ulOptions">Specifies the option to apply when opening the key. Set this parameter to zero or the following:</param>
        /// <param name="samDesired">A mask that specifies the desired access rights to the key to be opened. The function fails if the security descriptor of the key does not permit the requested access for the calling process. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="phkResult"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegOpenKeyExW(nint hKey, string lpSubKey, uint ulOptions, nint samDesired, out nint phkResult);

        /// <summary>
        ///Opens the specified registry key and associates it with a transaction. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:HKEY_CLASSES_ROOT HKEY_CURRENT_USER HKEY_LOCAL_MACHINE HKEY_USERS</param>
        /// <param name="lpSubKey"></param>
        /// <param name="ulOptions">This parameter is reserved and must be zero.</param>
        /// <param name="samDesired">A mask that specifies the desired access rights to the key. The function fails if the security descriptor of the key does not permit the requested access for the calling process. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="phkResult"></param>
        /// <param name="hTransaction">A handle to an active transaction. This handle is returned by the CreateTransaction function.pExtendedParemeterThis parameter is reserved and must be NULL.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.When a key is opened using this function, subsequent operations on the key are transacted. If a non-transacted operation is performed on the key before the transaction is committed, the transaction is rolled back. After a transaction is committed or rolled back, you must re-open the key using the RegCreateKeyTransacted or RegOpenKeyTransacted function with an active transaction handle to make additional operations transacted. For more information about transactions, see Kernel Transaction Manager.Note that subsequent operations on subkeys of this key are not automatically transacted. Therefore, the RegDeleteKeyEx function does not perform a transacted delete operation. Instead, use the RegDeleteKeyTransacted function to perform a transacted delete operation.Unlike the RegCreateKeyTransacted function, the RegOpenKeyTransacted function does not create the specified key if the key does not exist in the registry.If your service or application impersonates different users, do not use this function with HKEY_CURRENT_USER. Instead, call the RegOpenCurrentUser function.If the key returned in phkResult is a predefined registry key, it is not included in the provided transaction.A single registry key can be opened only 65,534 times. When attempting the 65,535th open operation, this function fails with ERROR_NO_SYSTEM_RESOURCES.RegCloseKeyRegCreateKeyTransactedRegDeleteKeyTransactedRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegOpenKeyTransactedA(nint hKey, string lpSubKey, uint ulOptions, nint samDesired, out nint phkResult, nint hTransaction);

        /// <summary>
        ///Opens the specified registry key and associates it with a transaction. Note that key names are not case sensitive.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:HKEY_CLASSES_ROOT HKEY_CURRENT_USER HKEY_LOCAL_MACHINE HKEY_USERS</param>
        /// <param name="lpSubKey"></param>
        /// <param name="ulOptions">This parameter is reserved and must be zero.</param>
        /// <param name="samDesired">A mask that specifies the desired access rights to the key. The function fails if the security descriptor of the key does not permit the requested access for the calling process. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="phkResult"></param>
        /// <param name="hTransaction">A handle to an active transaction. This handle is returned by the CreateTransaction function.pExtendedParemeterThis parameter is reserved and must be NULL.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.When a key is opened using this function, subsequent operations on the key are transacted. If a non-transacted operation is performed on the key before the transaction is committed, the transaction is rolled back. After a transaction is committed or rolled back, you must re-open the key using the RegCreateKeyTransacted or RegOpenKeyTransacted function with an active transaction handle to make additional operations transacted. For more information about transactions, see Kernel Transaction Manager.Note that subsequent operations on subkeys of this key are not automatically transacted. Therefore, the RegDeleteKeyEx function does not perform a transacted delete operation. Instead, use the RegDeleteKeyTransacted function to perform a transacted delete operation.Unlike the RegCreateKeyTransacted function, the RegOpenKeyTransacted function does not create the specified key if the key does not exist in the registry.If your service or application impersonates different users, do not use this function with HKEY_CURRENT_USER. Instead, call the RegOpenCurrentUser function.If the key returned in phkResult is a predefined registry key, it is not included in the provided transaction.A single registry key can be opened only 65,534 times. When attempting the 65,535th open operation, this function fails with ERROR_NO_SYSTEM_RESOURCES.RegCloseKeyRegCreateKeyTransactedRegDeleteKeyTransactedRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegOpenKeyTransactedW(nint hKey, string lpSubKey, uint ulOptions, nint samDesired, out nint phkResult, nint hTransaction);

        /// <summary>
        ///Opens the specified registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="phkResult"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegOpenKeyW(nint hKey, string lpSubKey, out nint phkResult);

        /// <summary>
        ///Retrieves a handle to the HKEY_CLASSES_ROOT key for a specified user. The user is identified by an access token. The returned key has a view of the registry that merges the contents of the HKEY_LOCAL_MACHINE\Software\Classes key with the contents of the Software\Classes keys in the user's registry hive. For more information, see HKEY_CLASSES_ROOT Key.
        /// </summary>
        /// <param name="hToken">A handle to a primary or impersonation access token that identifies the user of interest. This can be a token handle returned by a call to LogonUser, CreateRestrictedToken, DuplicateToken, DuplicateTokenEx, OpenProcessToken, or OpenThreadToken functions.The handle must have TOKEN_QUERY access. For more information, see Access Rights for Access-Token Objects.dwOptionsThis parameter is reserved and must be zero.</param>
        /// <param name="samDesired">A mask that specifies the desired access rights to the key. The function fails if the security descriptor of the key does not permit the requested access for the calling process. For more information, see Registry Key Security and Access Rights.</param>
        /// <param name="phkResult"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegOpenUserClassesRoot(nint hToken, nint samDesired, out nint phkResult);

        /// <summary>
        ///Maps a predefined registry key to the specified registry key.
        /// </summary>
        /// <param name="hKey">A handle to one of the following predefined keys:</param>
        /// <param name="hNewHKey"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegOverridePredefKey(nint hKey, nint hNewHKey);

        /// <summary>
        ///Retrieves information about the specified registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpClass"></param>
        /// <param name="lpcchClass"></param>
        /// <param name="lpcSubKeys"></param>
        /// <param name="lpcbMaxSubKeyLen"></param>
        /// <param name="lpcbMaxClassLen"></param>
        /// <param name="lpcValues"></param>
        /// <param name="lpcbMaxValueNameLen"></param>
        /// <param name="lpcbMaxValueLen"></param>
        /// <param name="lpcbSecurityDescriptor"></param>
        /// <param name="lpftLastWriteTime"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegQueryInfoKeyA(nint hKey, out string lpClass, out uint lpcchClass, out uint lpcSubKeys, out uint lpcbMaxSubKeyLen, out uint lpcbMaxClassLen, out uint lpcValues, out uint lpcbMaxValueNameLen, out uint lpcbMaxValueLen, out uint lpcbSecurityDescriptor, out FILETIME lpftLastWriteTime);

        /// <summary>
        ///Retrieves information about the specified registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpClass"></param>
        /// <param name="lpcchClass"></param>
        /// <param name="lpcSubKeys"></param>
        /// <param name="lpcbMaxSubKeyLen"></param>
        /// <param name="lpcbMaxClassLen"></param>
        /// <param name="lpcValues"></param>
        /// <param name="lpcbMaxValueNameLen"></param>
        /// <param name="lpcbMaxValueLen"></param>
        /// <param name="lpcbSecurityDescriptor"></param>
        /// <param name="lpftLastWriteTime"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegQueryInfoKeyW(nint hKey, out string lpClass, out uint lpcchClass, out uint lpcSubKeys, out uint lpcbMaxSubKeyLen, out uint lpcbMaxClassLen, out uint lpcValues, out uint lpcbMaxValueNameLen, out uint lpcbMaxValueLen, out uint lpcbSecurityDescriptor, out FILETIME lpftLastWriteTime);

        /// <summary>
        ///Retrieves the type and data for a list of value names associated with an open registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, seeRegistry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="val_list"></param>
        /// <param name="num_vals">The number of elements in the val_list array.</param>
        /// <param name="lpValueBuf"></param>
        /// <param name="ldwTotsize"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegQueryMultipleValuesA(nint hKey, out VALENTA val_list, uint num_vals, out string lpValueBuf, out uint ldwTotsize);

        /// <summary>
        ///Retrieves the type and data for a list of value names associated with an open registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="val_list"></param>
        /// <param name="num_vals">The number of elements in the val_list array.</param>
        /// <param name="lpValueBuf"></param>
        /// <param name="ldwTotsize"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegQueryMultipleValuesW(nint hKey, out VALENTW val_list, uint num_vals, out string lpValueBuf, out uint ldwTotsize);

        /// <summary>
        ///Determines whether reflection has been disabled or enabled for the specified key.
        /// </summary>
        /// <param name="hBase">A handle to the registry key. This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function; it cannot specify a key on a remote computer.</param>
        /// <param name="bIsReflectionDisabled"></param>

        [DllImport("AdvApi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int RegQueryReflectionKey(nint hBase, out bool bIsReflectionDisabled);

        /// <summary>
        ///Retrieves the data associated with the default or unnamed value of a specified registry key. The data must be a null-terminated string.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpData"></param>
        /// <param name="lpcbData"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegQueryValueA(nint hKey, string lpSubKey, out string lpData, out int lpcbData);

        /// <summary>
        ///Retrieves the type and data for the specified value name associated with an open registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpValueName"></param>
        /// <param name="lpType"></param>
        /// <param name="lpData"></param>
        /// <param name="lpcbData"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegQueryValueExA(nint hKey, string lpValueName, out uint lpType, out byte lpData, out uint lpcbData);

        /// <summary>
        ///Retrieves the type and data for the specified value name associated with an open registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpValueName"></param>
        /// <param name="lpType"></param>
        /// <param name="lpData"></param>
        /// <param name="lpcbData"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegQueryValueExW(nint hKey, string lpValueName, out uint lpType, out byte lpData, out uint lpcbData);

        /// <summary>
        ///Retrieves the data associated with the default or unnamed value of a specified registry key. The data must be a null-terminated string.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_QUERY_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpData"></param>
        /// <param name="lpcbData"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegQueryValueW(nint hKey, string lpSubKey, out string lpData, out int lpcbData);

        /// <summary>
        ///Changes the name of the specified registry key.
        /// </summary>

        [DllImport("req.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegRenameKey();

        /// <summary>
        ///Replaces the file backing a registry key and all its subkeys with another file, so that when the system is next started, the key and subkeys will have the values stored in the new file.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:HKEY_CLASSES_ROOT HKEY_CURRENT_CONFIG HKEY_CURRENT_USER HKEY_LOCAL_MACHINE HKEY_USERS</param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpNewFile">The name of the file with the registry information. This file is typically created by using the RegSaveKey function.</param>
        /// <param name="lpOldFile">The name of the file that receives a backup copy of the registry information being replaced.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.There are two different registry hive file formats. Registry hives created on current operating systems typically cannot be loaded by earlier ones.The file specified by the lpNewFile parameter remains open until the system is restarted.If hKey is a handle returned by RegConnectRegistry, then the paths specified in lpNewFile and lpOldFile are relative to the remote computer.The calling process must have the SE_RESTORE_NAME and SE_BACKUP_NAME privileges on the computer in which the registry resides. For more information, see Running with Special Privileges.RegConnectRegistryRegDeleteKeyRegLoadKeyRegRestoreKeyRegSaveKeyRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegReplaceKeyA(nint hKey, string lpSubKey, string lpNewFile, string lpOldFile);

        /// <summary>
        ///Replaces the file backing a registry key and all its subkeys with another file, so that when the system is next started, the key and subkeys will have the values stored in the new file.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:HKEY_CLASSES_ROOT HKEY_CURRENT_CONFIG HKEY_CURRENT_USER HKEY_LOCAL_MACHINE HKEY_USERS</param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpNewFile">The name of the file with the registry information. This file is typically created by using the RegSaveKey function.</param>
        /// <param name="lpOldFile">The name of the file that receives a backup copy of the registry information being replaced.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.There are two different registry hive file formats. Registry hives created on current operating systems typically cannot be loaded by earlier ones.The file specified by the lpNewFile parameter remains open until the system is restarted.If hKey is a handle returned by RegConnectRegistry, then the paths specified in lpNewFile and lpOldFile are relative to the remote computer.The calling process must have the SE_RESTORE_NAME and SE_BACKUP_NAME privileges on the computer in which the registry resides. For more information, see Running with Special Privileges.RegConnectRegistryRegDeleteKeyRegLoadKeyRegRestoreKeyRegSaveKeyRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegReplaceKeyW(nint hKey, string lpSubKey, string lpNewFile, string lpOldFile);

        /// <summary>
        ///Reads the registry information in a specified file and copies it over the specified key. This registry information may be in the form of a key and multiple levels of subkeys.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function. It can also be one of the following predefined keys:HKEY_CLASSES_ROOT HKEY_CURRENT_CONFIG HKEY_CURRENT_USER HKEY_LOCAL_MACHINE HKEY_USERS Any information contained in this key and its descendent keys is overwritten by the information in the file pointed to by the lpFile parameter.</param>
        /// <param name="lpFile">The name of the file with the registry information. This file is typically created by using the RegSaveKey function.</param>
        /// <param name="dwFlags">The flags that indicate how the key or keys are to be restored. This parameter can be one of the following values.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.There are two different registry hive file formats. Registry hives created on current operating systems typically cannot be loaded by earlier ones.If any subkeys of the hKey parameter are open, RegRestoreKey fails.The calling process must have the SE_RESTORE_NAME and SE_BACKUP_NAME privileges on the computer in which the registry resides. For more information, see Running with Special Privileges.This function replaces the keys and values below the specified key with the keys and values that are subsidiary to the top-level key in the file, no matter what the name of the top-level key in the file might be. For example, hKey might identify a key A with subkeys B and C, while the lpFile parameter specifies a file containing key X with subkeys Y and Z. After a call to RegRestoreKey, the registry would contain key A with subkeys Y and Z. The value entries of A would be replaced by the value entries of X.The new information in the file specified by lpFile overwrites the contents of the key specified by the hKey parameter, except for the key name.If hKey represents a key in a remote computer, the path described by lpFile is relative to the remote computer.RegDeleteKeyRegLoadKeyRegReplaceKeyRegSaveKeyRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegRestoreKeyA(nint hKey, string lpFile, uint dwFlags);

        /// <summary>
        ///Reads the registry information in a specified file and copies it over the specified key. This registry information may be in the form of a key and multiple levels of subkeys.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function. It can also be one of the following predefined keys:HKEY_CLASSES_ROOT HKEY_CURRENT_CONFIG HKEY_CURRENT_USER HKEY_LOCAL_MACHINE HKEY_USERS Any information contained in this key and its descendent keys is overwritten by the information in the file pointed to by the lpFile parameter.</param>
        /// <param name="lpFile">The name of the file with the registry information. This file is typically created by using the RegSaveKey function.</param>
        /// <param name="dwFlags">The flags that indicate how the key or keys are to be restored. This parameter can be one of the following values.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.There are two different registry hive file formats. Registry hives created on current operating systems typically cannot be loaded by earlier ones.If any subkeys of the hKey parameter are open, RegRestoreKey fails.The calling process must have the SE_RESTORE_NAME and SE_BACKUP_NAME privileges on the computer in which the registry resides. For more information, see Running with Special Privileges.This function replaces the keys and values below the specified key with the keys and values that are subsidiary to the top-level key in the file, no matter what the name of the top-level key in the file might be. For example, hKey might identify a key A with subkeys B and C, while the lpFile parameter specifies a file containing key X with subkeys Y and Z. After a call to RegRestoreKey, the registry would contain key A with subkeys Y and Z. The value entries of A would be replaced by the value entries of X.The new information in the file specified by lpFile overwrites the contents of the key specified by the hKey parameter, except for the key name.If hKey represents a key in a remote computer, the path described by lpFile is relative to the remote computer.RegDeleteKeyRegLoadKeyRegReplaceKeyRegSaveKeyRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegRestoreKeyW(nint hKey, string lpFile, uint dwFlags);

        /// <summary>
        ///Saves the specified key and all of its subkeys and values to a new file, in the standard format.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:</param>
        /// <param name="lpFile">The name of the file in which the specified key and subkeys are to be saved. If the file already exists, the function fails.If the string does not include a path, the file is created in the current directory of the calling process for a local key, or in the %systemroot%\system32 directory for a remote key. The new file has the archive attribute.</param>
        /// <param name="lpSecurityAttributes"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegSaveKeyA(nint hKey, string lpFile, SECURITY_ATTRIBUTES lpSecurityAttributes);

        /// <summary>
        ///Saves the specified key and all of its subkeys and values to a registry file, in the specified format.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key.This function does not support the HKEY_CLASSES_ROOT predefined key.</param>
        /// <param name="lpFile">The name of the file in which the specified key and subkeys are to be saved. If the file already exists, the function fails.The new file has the archive attribute.If the string does not include a path, the file is created in the current directory of the calling process for a local key, or in the %systemroot%\system32 directory for a remote key.</param>
        /// <param name="lpSecurityAttributes"></param>
        /// <param name="Flags">The format of the saved key or hive. This parameter can be one of the following values.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.If more than one of the possible values listed above for the Flags parameter is specified in one call to this function—for example, if two or more values are OR'ed— or if REG_NO_COMPRESSION is specified and hKey specifies a key that is not the root of a hive, this function returns ERROR_INVALID_PARAMETER.Unlike RegSaveKey, this function does not support the HKEY_CLASSES_ROOT predefined key.If hKey represents a key on a remote computer, the path described by lpFile is relative to the remote computer.The RegSaveKeyEx function saves only nonvolatile keys. It does not save volatile keys. A key is made volatile or nonvolatile at its creation; see RegCreateKeyEx.You can use the file created by RegSaveKeyEx in subsequent calls to the RegLoadKey, RegReplaceKey, or RegRestoreKey function. If RegSaveKeyEx fails partway through its operation, the file will be corrupt and subsequent calls to RegLoadKey, RegReplaceKey, or RegRestoreKey for the file will fail.Using RegSaveKeyEx together with RegRestoreKey to copy subtrees in the registry is not recommended. This method does not trigger notifications and can invalidate handles used by other applications. Instead, use the SHCopyKey function or the RegCopyTree function.The calling process must have the SE_BACKUP_NAME privilege enabled. For more information, see Running with Special Privileges.RegCreateKeyExRegDeleteKeyRegLoadKeyRegReplaceKeyRegRestoreKeyRegSaveKeyRegistry FilesRegistry FunctionsSECURITY_ATTRIBUTES</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegSaveKeyExA(nint hKey, string lpFile, SECURITY_ATTRIBUTES lpSecurityAttributes, uint Flags);

        /// <summary>
        ///Saves the specified key and all of its subkeys and values to a registry file, in the specified format.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key.This function does not support the HKEY_CLASSES_ROOT predefined key.</param>
        /// <param name="lpFile">The name of the file in which the specified key and subkeys are to be saved. If the file already exists, the function fails.The new file has the archive attribute.If the string does not include a path, the file is created in the current directory of the calling process for a local key, or in the %systemroot%\system32 directory for a remote key.</param>
        /// <param name="lpSecurityAttributes"></param>
        /// <param name="Flags">The format of the saved key or hive. This parameter can be one of the following values.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.If more than one of the possible values listed above for the Flags parameter is specified in one call to this function—for example, if two or more values are OR'ed— or if REG_NO_COMPRESSION is specified and hKey specifies a key that is not the root of a hive, this function returns ERROR_INVALID_PARAMETER.Unlike RegSaveKey, this function does not support the HKEY_CLASSES_ROOT predefined key.If hKey represents a key on a remote computer, the path described by lpFile is relative to the remote computer.The RegSaveKeyEx function saves only nonvolatile keys. It does not save volatile keys. A key is made volatile or nonvolatile at its creation; see RegCreateKeyEx.You can use the file created by RegSaveKeyEx in subsequent calls to the RegLoadKey, RegReplaceKey, or RegRestoreKey function. If RegSaveKeyEx fails partway through its operation, the file will be corrupt and subsequent calls to RegLoadKey, RegReplaceKey, or RegRestoreKey for the file will fail.Using RegSaveKeyEx together with RegRestoreKey to copy subtrees in the registry is not recommended. This method does not trigger notifications and can invalidate handles used by other applications. Instead, use the SHCopyKey function or the RegCopyTree function.The calling process must have the SE_BACKUP_NAME privilege enabled. For more information, see Running with Special Privileges.RegCreateKeyExRegDeleteKeyRegLoadKeyRegReplaceKeyRegRestoreKeyRegSaveKeyRegistry FilesRegistry FunctionsSECURITY_ATTRIBUTES</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegSaveKeyExW(nint hKey, string lpFile, SECURITY_ATTRIBUTES lpSecurityAttributes, uint Flags);

        /// <summary>
        ///Saves the specified key and all of its subkeys and values to a new file, in the standard format.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key.This handle is returned by the RegCreateKeyEx or RegOpenKeyEx function, or it can be one of the following predefined keys:</param>
        /// <param name="lpFile">The name of the file in which the specified key and subkeys are to be saved. If the file already exists, the function fails.If the string does not include a path, the file is created in the current directory of the calling process for a local key, or in the %systemroot%\system32 directory for a remote key. The new file has the archive attribute.</param>
        /// <param name="lpSecurityAttributes"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegSaveKeyW(nint hKey, string lpFile, SECURITY_ATTRIBUTES lpSecurityAttributes);

        /// <summary>
        ///The RegSetKeySecurity function sets the security of an open registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open key for which the security descriptor is set.</param>
        /// <param name="SecurityInformation">A set of bit flags that indicate the type of security information to set. This parameter can be a combination of the SECURITY_INFORMATION bit flags.</param>
        /// <param name="pSecurityDescriptor">A pointer to a SECURITY_DESCRIPTOR structure that specifies the security attributes to set for the specified key.If the function succeeds, the function returns ERROR_SUCCESS.If the function fails, it returns a nonzero error code defined in WinError.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.If hKey is one of the predefined keys, use the RegCloseKey function to close the predefined key to ensure that the new security information is in effect the next time the predefined key is referenced.FormatMessageLow-level Access ControlLow-level Access Control FunctionsRegCloseKeyRegDeleteKeyRegGetKeySecuritySECURITY_DESCRIPTORSECURITY_INFORMATION</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegSetKeySecurity(nint hKey, ACL_SIZE_INFORMATION SecurityInformation, SECURITY_DESCRIPTOR pSecurityDescriptor);

        /// <summary>
        ///Sets the data for the specified value in the specified registry key and subkey.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_SET_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpValueName"></param>
        /// <param name="dwType">The type of data pointed to by the lpData parameter. For a list of the possible types, see Registry Value Types.</param>
        /// <param name="lpData"></param>
        /// <param name="cbData">The size of the information pointed to by the lpData parameter, in bytes. If the data is of type REG_SZ, REG_EXPAND_SZ, or REG_MULTI_SZ, cbData must include the size of the terminating null character or characters.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.To compile an application that uses this function, define _WIN32_WINNT as 0x0600 or later. For more information, see Using the Windows Headers.RegDeleteKeyValueRegistry Functions</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegSetKeyValueA(nint hKey, string lpSubKey, string lpValueName, uint dwType, nint lpData, uint cbData);

        /// <summary>
        ///Sets the data for the specified value in the specified registry key and subkey.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_SET_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpValueName"></param>
        /// <param name="dwType">The type of data pointed to by the lpData parameter. For a list of the possible types, see Registry Value Types.</param>
        /// <param name="lpData"></param>
        /// <param name="cbData">The size of the information pointed to by the lpData parameter, in bytes. If the data is of type REG_SZ, REG_EXPAND_SZ, or REG_MULTI_SZ, cbData must include the size of the terminating null character or characters.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.To compile an application that uses this function, define _WIN32_WINNT as 0x0600 or later. For more information, see Using the Windows Headers.RegDeleteKeyValueRegistry Functions</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegSetKeyValueW(nint hKey, string lpSubKey, string lpValueName, uint dwType, nint lpData, uint cbData);

        /// <summary>
        ///Sets the data for the default or unnamed value of a specified registry key. The data must be a text string.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_SET_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="dwType">The type of information to be stored. This parameter must be the REG_SZ type. To store other data types, use the RegSetValueEx function.</param>
        /// <param name="lpData">The data to be stored. This parameter cannot be NULL.</param>
        /// <param name="cbData">This parameter is ignored. The function calculates this value based on the size of the data in the lpData parameter.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.If the key specified by the lpSubKey parameter does not exist, the RegSetValue function creates it.If the ANSI version of this function is used (either by explicitly calling RegSetValueA or by not defining UNICODE before including the Windows.h file), the lpData parameter must be an ANSI character string. The string is converted to Unicode before it is stored in the registry.RegCreateKeyExRegFlushKeyRegOpenKeyExRegQueryValueExRegSetValueExRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegSetValueA(nint hKey, string lpSubKey, uint dwType, string lpData, uint cbData);

        /// <summary>
        ///Sets the data and type of a specified value under a registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_SET_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpValueName"></param>
        /// <param name="dwType">The type of data pointed to by the lpData parameter. For a list of the possible types, see Registry Value Types.</param>
        /// <param name="lpData">The data to be stored.For string-based types, such as REG_SZ, the string must be null-terminated. With the REG_MULTI_SZ data type, the string must be terminated with two null characters.</param>
        /// <param name="cbData">The size of the information pointed to by the lpData parameter, in bytes. If the data is of type REG_SZ, REG_EXPAND_SZ, or REG_MULTI_SZ, cbData must include the size of the terminating null character or characters.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.Value sizes are limited by available memory. However, storing large values in the registry can affect its performance. Long values (more than 2,048 bytes) should be stored as files, with the locations of the files stored in the registry.Application elements such as icons, bitmaps, and executable files should be stored as files and not be placed in the registry.If dwType is the REG_SZ, REG_MULTI_SZ, or REG_EXPAND_SZ type and the ANSI version of this function is used (either by explicitly calling RegSetValueExA or by not defining UNICODE before including the Windows.h file), the data pointed to by the lpData parameter must be an ANSI character string. The string is converted to Unicode before it is stored in the registry.Note that operations that access certain registry keys are redirected. For more information, see Registry Virtualization and 32-bit and 64-bit Application Data in the Registry.Consider using the RegSetKeyValue function, which provides a more convenient way to set the value of a registry key.RegSetKeyValueRegCreateKeyExRegFlushKeyRegOpenKeyExRegQueryValueExRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegSetValueExA(nint hKey, string lpValueName, uint dwType, byte lpData, uint cbData);

        /// <summary>
        ///Sets the data and type of a specified value under a registry key.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_SET_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpValueName"></param>
        /// <param name="dwType">The type of data pointed to by the lpData parameter. For a list of the possible types, see Registry Value Types.</param>
        /// <param name="lpData">The data to be stored.For string-based types, such as REG_SZ, the string must be null-terminated. With the REG_MULTI_SZ data type, the string must be terminated with two null characters.</param>
        /// <param name="cbData">The size of the information pointed to by the lpData parameter, in bytes. If the data is of type REG_SZ, REG_EXPAND_SZ, or REG_MULTI_SZ, cbData must include the size of the terminating null character or characters.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.Value sizes are limited by available memory. However, storing large values in the registry can affect its performance. Long values (more than 2,048 bytes) should be stored as files, with the locations of the files stored in the registry.Application elements such as icons, bitmaps, and executable files should be stored as files and not be placed in the registry.If dwType is the REG_SZ, REG_MULTI_SZ, or REG_EXPAND_SZ type and the ANSI version of this function is used (either by explicitly calling RegSetValueExA or by not defining UNICODE before including the Windows.h file), the data pointed to by the lpData parameter must be an ANSI character string. The string is converted to Unicode before it is stored in the registry.Note that operations that access certain registry keys are redirected. For more information, see Registry Virtualization and 32-bit and 64-bit Application Data in the Registry.Consider using the RegSetKeyValue function, which provides a more convenient way to set the value of a registry key.RegSetKeyValueRegCreateKeyExRegFlushKeyRegOpenKeyExRegQueryValueExRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegSetValueExW(nint hKey, string lpValueName, uint dwType, byte lpData, uint cbData);

        /// <summary>
        ///Sets the data for the default or unnamed value of a specified registry key. The data must be a text string.
        /// </summary>
        /// <param name="hKey">A handle to an open registry key. The key must have been opened with the KEY_SET_VALUE access right. For more information, see Registry Key Security and Access Rights.This handle is returned by the RegCreateKeyEx, RegCreateKeyTransacted, RegOpenKeyEx, or RegOpenKeyTransacted function. It can also be one of the following predefined keys:</param>
        /// <param name="lpSubKey"></param>
        /// <param name="dwType">The type of information to be stored. This parameter must be the REG_SZ type. To store other data types, use the RegSetValueEx function.</param>
        /// <param name="lpData">The data to be stored. This parameter cannot be NULL.</param>
        /// <param name="cbData">This parameter is ignored. The function calculates this value based on the size of the data in the lpData parameter.If the function succeeds, the return value is ERROR_SUCCESS.If the function fails, the return value is a nonzero error code defined in Winerror.h. You can use the FormatMessage function with the FORMAT_MESSAGE_FROM_SYSTEM flag to get a generic description of the error.If the key specified by the lpSubKey parameter does not exist, the RegSetValue function creates it.If the ANSI version of this function is used (either by explicitly calling RegSetValueA or by not defining UNICODE before including the Windows.h file), the lpData parameter must be an ANSI character string. The string is converted to Unicode before it is stored in the registry.RegCreateKeyExRegFlushKeyRegOpenKeyExRegQueryValueExRegSetValueExRegistry FunctionsRegistry Overview</param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegSetValueW(nint hKey, string lpSubKey, uint dwType, string lpData, uint cbData);

        /// <summary>
        ///Unloads the specified registry key and its subkeys from the registry.
        /// </summary>
        /// <param name="hKey">A handle to the registry key to be unloaded. This parameter can be a handle returned by a call to RegConnectRegistry function or one of the following predefined handles:HKEY_LOCAL_MACHINE HKEY_USERS</param>
        /// <param name="lpSubKey"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegUnLoadKeyA(nint hKey, string lpSubKey);

        /// <summary>
        ///Unloads the specified registry key and its subkeys from the registry.
        /// </summary>
        /// <param name="hKey">A handle to the registry key to be unloaded. This parameter can be a handle returned by a call to RegConnectRegistry function or one of the following predefined handles:</param>
        /// <param name="lpSubKey"></param>

        [DllImport("Advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern float RegUnLoadKeyW(nint hKey, string lpSubKey);


    }
}