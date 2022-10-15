using System;
using System.IO;

namespace ProjectM.Shared
{
    public static class Environments
    {
        public static string AppDataPath
        {
            get
            {
                if (string.IsNullOrEmpty(_appDataPath))
                {
                    _appDataPath = Environment.ExpandEnvironmentVariables(Fields.AppDataPath);
                }
                if (!Directory.Exists(_appDataPath))
                {
                    Directory.CreateDirectory(_appDataPath);
                }
                return _appDataPath;
            }
        }
        private static string _appDataPath;

        public static string LogFilePath
        {
            get
            {
                if (string.IsNullOrEmpty(_logFilePath))
                {
                    _logFilePath = Path.Combine(AppDataPath, Fields.LogFileName);
                }
                return _logFilePath;
            }
        }
        private static string _logFilePath;
    }
}
