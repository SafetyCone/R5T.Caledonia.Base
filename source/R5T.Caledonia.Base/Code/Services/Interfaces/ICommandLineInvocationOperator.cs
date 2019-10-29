using System;
using System.Diagnostics;


namespace R5T.Caledonia
{
    public interface ICommandLineInvocationOperator
    {
        int Run(string command, string arguments, DataReceivedEventHandler receiveOutputData, DataReceivedEventHandler receiveErrorData);
        CommandLineInvocationResult Run(CommandLineInvocation invocation);
    }
}
