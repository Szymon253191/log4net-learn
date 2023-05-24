using System;
using log4net;

namespace log4net_TESTING
{
    public class Program
    {
        public static readonly log4net.ILog log =
        LogHelper.GetLogger();
        //log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [STAThread]
        static void Main(string[] args)
        {
            var application = new App();
            application.InitializeComponent();
            application.Run();
        }
    }
}
