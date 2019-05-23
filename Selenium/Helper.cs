using System.Runtime.InteropServices;

namespace Selenium {
    public static class Helper {
        /// <summary>
        /// Retrive the current OS
        /// </summary>
        /// <returns>Current OS</returns>
        public static OS GetOS () {
            if (RuntimeInformation.IsOSPlatform (OSPlatform.OSX)) {
                return OS.Mac;
            }
            if (RuntimeInformation.IsOSPlatform (OSPlatform.Linux)) {
                return OS.Linux;
            }
            return OS.Windows;
        }
    }
}