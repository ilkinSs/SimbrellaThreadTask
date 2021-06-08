using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimbrellaThreadTask.Lib
{
    public static class Client 
    {
        public static void WriteMessage(int threadNum){        
                while (true)
                {
                  Logger.LogIntoFile($"Id = {Guid.NewGuid()}; I am {threadNum} THREAD");
                    Thread.Sleep(10);
                }                                                                               
        }
    }
}
