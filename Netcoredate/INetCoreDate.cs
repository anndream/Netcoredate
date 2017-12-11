using System;

namespace Netcoredate{

    public interface INetCoreDate{

        bool InBetween(DateTime target,DateTime begin, DateTime end);

    }
}