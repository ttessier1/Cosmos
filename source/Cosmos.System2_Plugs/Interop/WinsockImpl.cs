﻿using IL2CPU.API.Attribs;
using System;
using System.Net.Sockets;

namespace Cosmos.Core_Plugs.Interop
{
    [Plug("Interop+Winsock, System.Net.Sockets", IsOptional = true)]
    public static unsafe class WinsockImpl
    {
        [PlugMethod(Signature = "System_Net_Sockets_SocketError__Interop_Winsock_shutdown_System_Net_Sockets_SafeSocketHandle__System_Int32_")]
        public static SocketError shutdown(SafeSocketHandle socketHandle, int how)
        {
            throw new NotImplementedException();
        }

        [PlugMethod(Signature = "System_Net_Sockets_SocketError__Interop_Winsock_shutdown_System_Net_Sockets_SafeSocketHandle__System_Int32_")]
        public static int recv(SafeSocketHandle socketHandle, byte* pinnedBuffer, int len, SocketFlags socketFlags)
        {
            throw new NotImplementedException();
        }
    }
}
