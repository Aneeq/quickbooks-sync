﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QBSync.QbWebConnector
{
    public enum LogMessageType
    {
        Error = 0,
        Authenticate = 1,
        GetError = 2,
        Send = 3,
        Receive = 4,
        Close = 5
    }
}