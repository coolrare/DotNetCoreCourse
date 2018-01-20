using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class SayHello
    {
        public static string Hello()
        {
#if WINDOWS_UWP
            return "Hello UWP";
#elif NETCOREAPP2_0
            return "Hello .NET Core 2.0";
#elif __ANDROID__
            return "Hello Android";
#elif __IOS__
            return "Hello iOS";
#else
        return "Hello .NET Framework";
#endif
        }
    }
}
