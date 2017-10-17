﻿using System.Collections.Generic;
using Friday.Base.Routing.Attributes;

namespace Friday.Base.Routing
{
    public  interface IRouteRegistry
    {
        void RegisterRoute(RouteRule routeRule);
        void RegisterAttributeHandler(RouteAttributeHandler handler);
        IReadOnlyCollection<RouteRule> Routes { get; }

    }
}