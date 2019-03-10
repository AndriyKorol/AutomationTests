using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TProject.ComponentHelper;

namespace TProject.TestScript.Log4Net
{

    public class TestLogger
    {
        public void TestLo4NetXml()
        {
            ILog Logger = Log4netHelper.GetXmlLogger(typeof(TestLogger));

            for (var i = 0; i < 300; i++)
            {
                Logger.Debug("This is Debug Information");
                Logger.Info("This is Info Information");
                Logger.Warn("This is Warn Information");
                Logger.Error("This is Error Information");
                Logger.Fatal("This is Fatal Information");
            }
        }
        
        public void TestLo4Net()
        {
            //1.Create the layout
            //var patternLayour = new PatternLayout();
            //patternLayour.ConversionPattern = "%date{dd-MMM-yyyy-HH:mm:ss} [%class] [%level] [%method] - [%message%newline]";
            //patternLayour.ActivateOptions();

            ////2.Use the layout in the appender
            //var consoleAppender = new ConsoleAppender()
            //{
            //    Name = "ConsoleAppender",
            //    Layout = patternLayour,
            //    Threshold = Level.All
            //};
            //consoleAppender.ActivateOptions();

            //var fileAppender = new FileAppender()
            //{
            //    Name = "fileAppender",
            //    Layout = patternLayour,
            //    Threshold = Level.All,
            //    AppendToFile = true,
            //    File = "FileLogger.log"
            //};
            //fileAppender.ActivateOptions();

            //var rollingAppender= new RollingFileAppender()
            //{
            //    Name = "rollingAppender",
            //    Layout = patternLayour,
            //    Threshold = Level.All,
            //    AppendToFile = true,
            //    File = "RollingFile.log",
            //    MaximumFileSize = "1",
            //    MaxSizeRollBackups = 5 //file1.log, file2.log...file5.log and will be stop 
            //};
            //rollingAppender.ActivateOptions();

            ////3.Initialize the configuration
            //BasicConfigurator.Configure(consoleAppender, fileAppender, rollingAppender);

            ////4.Get the instance of the logger
            //ILog Logger = LogManager.GetLogger(typeof(TestLogger));

            ILog Logger = Log4netHelper.GetLogger(typeof(TestLogger));

            for (var i = 0; i < 300; i++)
            {
                Logger.Debug("This is Debug Information");
                Logger.Info("This is Info Information");
                Logger.Warn("This is Warn Information");
                Logger.Error("This is Error Information");
                Logger.Fatal("This is Fatal Information");
            }

           
        }


    }
}

