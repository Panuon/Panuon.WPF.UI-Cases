using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectM.Shared
{
    public class Logger
        : ILogger
    {
        #region Fields
        private static Serilog.Core.Logger _logger;
        #endregion

        #region Properties
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }

                return _instance;
            }
        }
        private static Logger _instance;
        #endregion

        #region Methods

        public void Error(Exception exception, string messageTemplate)
        {
            InitializeLogger();
            _logger?.Error(exception, messageTemplate);
        }

        public void Error(Exception exception, string messageTemplate, params object[] args)
        {
            InitializeLogger();
            _logger?.Error(exception, messageTemplate, args);
        }

        public void Infomation(string message)
        {
            InitializeLogger();
            _logger?.Information(message);
        }

        public void Infomation(string messageTemplate, params object[] args)
        {
            InitializeLogger();
            _logger?.Information(messageTemplate, args);
        }

        public void Warning(string message)
        {
            InitializeLogger();
            _logger?.Warning(message);
        }

        public void Warning(Exception exception, string messageTemplate, params object[] args)
        {
            InitializeLogger();
            _logger?.Warning(exception, messageTemplate, args);
        }

        public void Warning(string messageTemplate, params object[] args)
        {
            InitializeLogger();
            _logger?.Warning(messageTemplate, args);
        }

        #endregion

        #region Function
        private void InitializeLogger()
        {
            if (_logger == null)
            {
                var logFilePath = Environments.LogFilePath;

                _logger = new LoggerConfiguration()
                     .WriteTo.File(logFilePath, rollingInterval: RollingInterval.Day, retainedFileCountLimit: 30)
                     .CreateLogger();
            }
        }
        #endregion

    }
}
