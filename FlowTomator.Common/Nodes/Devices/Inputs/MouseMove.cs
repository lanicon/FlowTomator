﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowTomator.Common
{
    [Node("MouseMove", "Devices")]
    public class MouseMoveEvent : Event
    {
        public override NodeResult Check()
        {
            return NodeResult.Fail;
        }
    }
}