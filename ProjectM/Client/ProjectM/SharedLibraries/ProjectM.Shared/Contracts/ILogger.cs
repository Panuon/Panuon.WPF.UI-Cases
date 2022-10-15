using System;

namespace ProjectM.Shared
{
    public interface ILogger
    {
        void Error(Exception exception, string messageTemplate);

        void Error(Exception exception, string messageTemplate, params object[] args);

        void Infomation(string message);

        void Infomation(string messageTemplate, params object[] args);

        void Warning(string message);

        void Warning(string messageTemplate, params object[] args);
    }
}
