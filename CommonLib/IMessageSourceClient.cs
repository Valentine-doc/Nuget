﻿using ChatCommLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib
{
    public interface IMessageSourceClient
    {
        public void Send(MessageUdp message);
        public MessageUdp Receive();
    }
}
