﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauges101
{
    public interface Repository
    {
        List<Sample> GetSamples();
    }
}
