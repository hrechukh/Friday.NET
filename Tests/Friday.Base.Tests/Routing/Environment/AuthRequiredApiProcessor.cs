﻿using Friday.Base.Routing;
using Friday.Base.Routing.Attributes;

namespace Friday.Base.Tests.Routing.Environment
{


    

    internal class AuthRequiredApiProcessor
    {
        [AuthRequired]
        public void OnSomeDto(SomeDto dto)
        {
            

        }
        

        public void OnAuthRequestDto(IRoutingContext context,AuthRequestDto dto)
        {
            context.Principal= new BasicUserNamePrincipal("test");
        }

    }


}