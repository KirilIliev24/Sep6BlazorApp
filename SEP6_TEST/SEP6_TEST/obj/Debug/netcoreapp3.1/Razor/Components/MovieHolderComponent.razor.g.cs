#pragma checksum "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\Components\MovieHolderComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2e0becabb31b71db51d086774b17824c30f2cba"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP6_TEST.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\_Imports.razor"
using SEP6_TEST;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\_Imports.razor"
using SEP6_TEST.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\Components\MovieHolderComponent.razor"
using SEP6_TEST.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/moviecontainer")]
    public partial class MovieHolderComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card text-white bg-transparent border-info mb-3");
            __builder.AddAttribute(2, "style", "width: 18rem;");
            __builder.AddMarkupContent(3, "\r\n    <img class=\"card-img-top\" src=\"/Images/diesel.png\" alt=\"Movie Image\">\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "h5");
            __builder.AddAttribute(8, "class", "card-title");
            __builder.AddContent(9, 
#nullable restore
#line 8 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\Components\MovieHolderComponent.razor"
                                movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-footer bg-transparent border-info");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "h6");
            __builder.AddContent(16, "Year: ");
            __builder.AddContent(17, 
#nullable restore
#line 11 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\Components\MovieHolderComponent.razor"
                   movie.Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "h6");
            __builder.AddContent(20, "Rating: ");
            __builder.AddContent(21, 
#nullable restore
#line 12 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\Components\MovieHolderComponent.razor"
                     movie.rating.Rating1

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, "/10 out of ");
            __builder.AddContent(23, 
#nullable restore
#line 12 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\Components\MovieHolderComponent.razor"
                                                     movie.rating.Votes

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, " ratings");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Harry\OneDrive\Documents\VIA\SEP06\SEP6BlazorAppMain\Sep6BlazorApp\SEP6_TEST\SEP6_TEST\Components\MovieHolderComponent.razor"
       
    [Parameter] public Movie movie { get; set; }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
