#pragma checksum "D:\VIA\6th semester\SEP 6\Testing\SEP6_TEST\SEP6_TEST\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a81c2f0498e1c5d23b09b7148905072abf8cffcf"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP6_TEST.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\VIA\6th semester\SEP 6\Testing\SEP6_TEST\SEP6_TEST\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VIA\6th semester\SEP 6\Testing\SEP6_TEST\SEP6_TEST\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VIA\6th semester\SEP 6\Testing\SEP6_TEST\SEP6_TEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VIA\6th semester\SEP 6\Testing\SEP6_TEST\SEP6_TEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\VIA\6th semester\SEP 6\Testing\SEP6_TEST\SEP6_TEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\VIA\6th semester\SEP 6\Testing\SEP6_TEST\SEP6_TEST\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\VIA\6th semester\SEP 6\Testing\SEP6_TEST\SEP6_TEST\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\VIA\6th semester\SEP 6\Testing\SEP6_TEST\SEP6_TEST\_Imports.razor"
using SEP6_TEST;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\VIA\6th semester\SEP 6\Testing\SEP6_TEST\SEP6_TEST\_Imports.razor"
using SEP6_TEST.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<SEP6_TEST.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\" style=\"background-color: #3a0647\">\r\n        <a href=\"https://localhost:44336/login\" target=\"_blank\">Log Out</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 13 "D:\VIA\6th semester\SEP 6\Testing\SEP6_TEST\SEP6_TEST\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
