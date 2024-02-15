namespace WindowAPI.Winbase.h.CallBacks
{
    public class CallBack
    {
        /// <summary>
        ///An application-defined callback function used with the CopyFileEx, MoveFileTransacted, and MoveFileWithProgress functions. It is called when a portion of a copy or move operation is completed. The LPPROGRESS_ROUTINE type defines a pointer to this callback function. CopyProgressRoutine is a placeholder for the application-defined function name.
        /// </summary>
        /// <param name="TotalFileSize">The total size of the file, in bytes.</param>
        /// <param name="TotalBytesTransferred">The total number of bytes transferred from the source file to the destination file since the copy operation began.</param>
        /// <param name="StreamSize">The total size of the current file stream, in bytes.</param>
        /// <param name="StreamBytesTransferred">The total number of bytes in the current stream that have been transferred from the source file to the destination file since the copy operation began.</param>
        /// <param name="dwStreamNumber">A handle to the current stream. The first time CopyProgressRoutine is called, the stream number is 1.</param>
        /// <param name="dwCallbackReason">The reason that CopyProgressRoutine was called. This parameter can be one of the following values.</param>
        /// <param name="hSourceFile">A handle to the source file.</param>
        /// <param name="hDestinationFile">A handle to the destination file</param>
        /// <param name="lpData"></param>

        public delegate uint LPPROGRESSROUTINE(int TotalFileSize, int TotalBytesTransferred, int StreamSize, int StreamBytesTransferred, uint dwStreamNumber, uint dwCallbackReason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData);

        /// <summary>
        ///An application-defined callback function used with the CopyFile2 function. It is called when a portion of a copy or move operation is completed. The PCOPYFILE2_PROGRESS_ROUTINE type defines a pointer to this callback function. CopyFile2ProgressRoutine is a placeholder for the application-defined function name.
        /// </summary>
        /// <param name="COPYFILE2_MESSAGE"></param>
        /// <param name="pvCallbackContext"></param>

        public delegate int PCOPYFILE2PROGRESSROUTINE(int COPYFILE2_MESSAGE, IntPtr pvCallbackContext);

        /// <summary>
        ///An application-defined callback function used with ReadEncryptedFileRaw. The system calls ExportCallback one or more times, each time with a block of the encrypted file's data, until it has received all of the file data. ExportCallback writes the encrypted file's data to another storage media, usually for purposes of backing up the file.
        /// </summary>
        /// <param name="pbData">A pointer to a block of the encrypted file's data to be backed up. This block of data is allocated by the system.</param>
        /// <param name="pvCallbackContext"></param>
        /// <param name="ulLength">The size of the data pointed to by the pbData parameter, in bytes.If the function succeeds, it must set the return value to ERROR_SUCCESS.If the function fails, set the return value to a nonzero error code defined in WinError.h. For example, if this function fails because an API that it calls fails, you can set the return value to the value returned by GetLastError for the failed API.You can use the application-defined context block for internal tracking of information such as the file handle and the current offset in the file.CloseEncryptedFileRawFile EncryptionFile Management FunctionsImportCallbackOpenEncryptedFileRawReadEncryptedFileRawWriteEncryptedFileRaw</param>

        public delegate uint PFEEXPORTFUNC(int pbData, IntPtr pvCallbackContext, int ulLength);

        /// <summary>
        ///An application-defined callback function used with WriteEncryptedFileRaw. The system calls ImportCallback one or more times, each time to retrieve a portion of a backup file's data. ImportCallback reads the data from a backup file sequentially and restores the data, and the system continues calling it until it has read all of the backup file data.
        /// </summary>
        /// <param name="pbData">A pointer to a system-supplied buffer that will receive a block of data to be restored.</param>
        /// <param name="pvCallbackContext"></param>
        /// <param name="ulLength">On function entry, this parameter specifies the length of the buffer the system has supplied. The callback function must write no more than this many bytes to the buffer pointed to by the pbData parameter.On exit, the function must set this to the number of bytes of data written into the pbData.If the function succeeds, it must set the return value to ERROR_SUCCESS, and set the value pointed to by the ulLength parameter to the number of bytes copied into pbData.When the end of the backup file is reached, set ulLength to zero to tell the system that the entire file has been processed.If the function fails, set the return value to a nonzero error code defined in WinError.h. For example, if this function fails because an API that it calls fails, you can set the return value to the value returned by GetLastError for the failed API.The system calls the ImportCallback function until the callback function indicates there is no more data to restore. To indicate that there is no more data to be restored, set *ulLength to 0 and use a return code of ERROR_SUCCESS. You can use the application-defined context block for internal tracking of information such as the file handle and the current offset in the file.CloseEncryptedFileRawExportCallbackFile EncryptionFile Management FunctionsOpenEncryptedFileRawReadEncryptedFileRawWriteEncryptedFileRaw</param>

        public delegate uint PFEIMPORTFUNC(int pbData, IntPtr pvCallbackContext, int ulLength);

        /// <summary>
        ///An application-defined function used with the CreateFiber function. It serves as the starting address for a fiber. The LPFIBER_START_ROUTINE type defines a pointer to this callback function. FiberProc is a placeholder for the application-defined function name.
        /// </summary>

        public delegate void PFIBERSTARTROUTINE(IntPtr lpFiberParameter);


    }
}