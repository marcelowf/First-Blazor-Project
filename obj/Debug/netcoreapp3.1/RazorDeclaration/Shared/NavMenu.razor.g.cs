// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace VOLVO_FRONT.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\VOLVO_ESTAGIO\DOTNET\VOLVO_TRABALHO\VOLVO_FRONT\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VOLVO_ESTAGIO\DOTNET\VOLVO_TRABALHO\VOLVO_FRONT\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VOLVO_ESTAGIO\DOTNET\VOLVO_TRABALHO\VOLVO_FRONT\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\VOLVO_ESTAGIO\DOTNET\VOLVO_TRABALHO\VOLVO_FRONT\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\VOLVO_ESTAGIO\DOTNET\VOLVO_TRABALHO\VOLVO_FRONT\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\VOLVO_ESTAGIO\DOTNET\VOLVO_TRABALHO\VOLVO_FRONT\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\VOLVO_ESTAGIO\DOTNET\VOLVO_TRABALHO\VOLVO_FRONT\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\VOLVO_ESTAGIO\DOTNET\VOLVO_TRABALHO\VOLVO_FRONT\_Imports.razor"
using VOLVO_FRONT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\VOLVO_ESTAGIO\DOTNET\VOLVO_TRABALHO\VOLVO_FRONT\_Imports.razor"
using VOLVO_FRONT.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\VOLVO_ESTAGIO\DOTNET\VOLVO_TRABALHO\VOLVO_FRONT\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
