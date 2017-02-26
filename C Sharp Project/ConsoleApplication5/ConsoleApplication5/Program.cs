using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


class Program
{
    static void Main(string[] args)
    {
        BankServer();
    }


    static void BankServer()
    {
        Console.WriteLine(" Server started...");
        TcpChannel tcpChannel = new TcpChannel(9998);
        ChannelServices.RegisterChannel(tcpChannel);
        Type commonInterfaceType = Type.GetType("Bank");
        RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType,
                             "MyBank", WellKnownObjectMode.Singleton);
        System.Console.WriteLine("Press ENTER to Exit");
        System.Console.ReadLine();
    }

}
