#pragma checksum "C:\GIT\familienfest\repro\familienfest\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a879168b08c481a01dd5bed472df470ea08a9a9"
// <auto-generated/>
#pragma warning disable 1591
namespace familienfest.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\GIT\familienfest\repro\familienfest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GIT\familienfest\repro\familienfest\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GIT\familienfest\repro\familienfest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GIT\familienfest\repro\familienfest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GIT\familienfest\repro\familienfest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GIT\familienfest\repro\familienfest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GIT\familienfest\repro\familienfest\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GIT\familienfest\repro\familienfest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GIT\familienfest\repro\familienfest\_Imports.razor"
using familienfest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\GIT\familienfest\repro\familienfest\_Imports.razor"
using familienfest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\GIT\familienfest\repro\familienfest\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-lbdc5aplug");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-lbdc5aplug");
            __builder.OpenComponent<familienfest.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-lbdc5aplug");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-lbdc5aplug><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-lbdc5aplug>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-lbdc5aplug");
            __builder.AddContent(15, 
#nullable restore
#line 18 "C:\GIT\familienfest\repro\familienfest\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\GIT\familienfest\repro\familienfest\Shared\MainLayout.razor"
       
    private BSCollapse NavbarCollapse;
    private FormsModel formsModel = new FormsModel();
    bool UserControlledIsOpen { get; set; } = true;
    void onclick(MouseEventArgs e)
    {
        NavbarCollapse.Toggle();
        Console.WriteLine("Navbar State->" + NavbarCollapse.IsOpen.ToString());
    }
    void OpenChanged(bool e)
    {
        Console.WriteLine("OpenChanged->" + e.ToString());
    }

    void UserControlledClick(MouseEventArgs e)
    {
        UserControlledIsOpen = !UserControlledIsOpen;
        StateHasChanged();

    }

    public class FormsModel
    {
        public string Blank { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
