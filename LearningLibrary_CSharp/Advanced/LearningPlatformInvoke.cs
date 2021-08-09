using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced
{
    public class LearningPlatformInvoke : IDemo
    {
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
        internal static extern IntPtr GetCurrentProcessHandle();

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flNewProtect, ref uint lpflOldProtect);

        public void Demo()
        {
            throw new NotImplementedException();
        }
    }
}