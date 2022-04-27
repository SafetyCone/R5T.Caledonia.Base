using System;
using System.Diagnostics;

using R5T.T0064;


namespace R5T.Caledonia
{
    [ServiceDefinitionMarker]
    public interface ICommandLineInvocationOperator : IServiceDefinition
    {
        int Run(string command, string arguments, DataReceivedEventHandler receiveOutputData, DataReceivedEventHandler receiveErrorData);

        CommandLineInvocationResult Run(CommandLineInvocation invocation);
    }
}
