﻿using NLog;
using NlogFileDemo.Interface;

namespace NlogFileDemo.Service
{
    public class Logging : ILog
    {
        private static NLog.ILogger logger = LogManager.GetCurrentClassLogger();

        public Logging() { }
        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Information(string message)
        {
            logger.Info(message);
        }

        public void Warning(string message)
        {
            logger.Warn(message);        
        }
    }
}
