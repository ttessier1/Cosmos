﻿using Cosmos.Debug.Common;
using Cosmos.Debug.DebugConnectors;

namespace Cosmos.VS.Windows
{
    public static class Global
    {
        /// <summary>A pipe used to send requests to the AD7Process.</summary>
        public static PipeClient PipeUp = new PipeClient(Pipes.UpName);

        public static EnvDTE.OutputWindowPane OutputPane;

        public static PipeClient ConsoleTextChannel;
    }
}
