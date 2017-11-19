﻿using Friday.Base.Routing;
using Friday.Base.Routing.Attributes;

namespace Friday.Base.Tests.Routing.Environment
{
	internal static class RoutingTestEnvironment
	{
		internal static SomeDto GetTestDtoData()
		{
			return new SomeDto();
		}


		internal static (RoutingProvider provider, AuthRequiredApiProcessor processor) GetAuthProviderWithProcessor()
		{
			var processor = new AuthRequiredApiProcessor();
			var provider = GetDefaultRoutingProvider(processor);
			provider.RegisterAttributeHandler(new AuthRequiredAttributeHandler());
			return (provider, processor);
		}


		internal static RoutingProvider GetAuthProvider()
		{
			return GetAuthProviderWithProcessor().provider;
		}

		internal static RoutingProvider GetDefaultRoutingProvider(params object[] processor)
		{
			var provider = new RoutingProvider();
			foreach (var o in processor)
			{
				provider.RegisterRoute(new RouteRule("default_" + o.GetType().Name, "On{typeName}", o));
			}

			return provider;
		}
	}
}