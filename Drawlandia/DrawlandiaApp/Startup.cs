﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;

namespace DrawlandiaApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}