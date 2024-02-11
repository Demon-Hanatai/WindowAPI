//Auto Create-#=
namespace WindowAPI.Fontsub
{
    public static class CallBack
    {

        /// <summary>
        ///Client-provided callback function, used by CreateFontPackage and MergeFontPackage to allocate memory.
        /// </summary>

        public delegate void CFP_ALLOCPROC(int unnamedParam1);

        /// <summary>
        ///Client-provided callback function, used by CreateFontPackage and MergeFontPackage to free memory.
        /// </summary>

        public delegate void CFP_FREEPROC(IntPtr unnamedParam1);

        /// <summary>
        ///Client-provided callback function, used by CreateFontPackage and MergeFontPackage to reallocate memory when the size of an allocated buffer needs to change.
        /// </summary>

        public delegate void CFP_REALLOCPROC(IntPtr unnamedParam1, int unnamedParam2);


    }
}