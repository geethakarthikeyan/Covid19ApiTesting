using System;


namespace Covid19ApiTesting.Utilities
{
    public static class FileUtil
    {
        public static string GetFilePath(string filepath)
        {
            return AppDomain.CurrentDomain.BaseDirectory + filepath;
        }
    }
}
