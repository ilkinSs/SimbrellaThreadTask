using SimbrellaThreadTask.Lib;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SimbrellaThreadTask
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 5; i++)
            {
                new Thread(delegate ()
                {
                    Client.WriteMessage(i);
                }).Start();
            }        
        }
    }
}
