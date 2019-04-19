using System;
using System.Collections.Generic;

namespace Vendigo
{
    public interface IJapanese<T>
    {
        string Colors { get; set; }

        string RfIdFrequency { get; set; }

        void RfIdBroadcast();

    }
}