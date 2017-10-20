using NUnit.Framework;
using System;

namespace Test
{
    public static class TestLogger
    {
        public static void LogMessage(string Message)
        {
            String TimeStamp = DateTime.Now.ToString("u");
            String Messsage = (TimeStamp + ": - " + Message + "\r\n");
            TestContext.Write(Messsage);
        }

    }
}
