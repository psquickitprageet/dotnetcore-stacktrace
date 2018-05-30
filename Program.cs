using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using log4net;

namespace TestNewPkgCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
			log4net.Config.XmlConfigurator.Configure(logRepository, new FileInfo("App1.config"));

			Console.WriteLine("Hello World!");
			var logger = LogManager.GetLogger(typeof(Program));
			//Send plaintext
			try
			{
				//a = a / b;
				getException4();
			}
			catch (Exception ex)
			{
				logger.Error(ex.Message, ex);
			}
			Console.ReadKey();
		}

		static void getException4()
		{
			getException3();
		}
		static void getException3()
		{
			getException2();
		}
		static void getException2()
		{
			getException1();
		}
		static void getException1()
		{
			getException();
		}
		static void getException()
		{
			int a = 10, b = 0;
			a = a / b;
			// throw new Exception("New exception");
		}
	}
}
