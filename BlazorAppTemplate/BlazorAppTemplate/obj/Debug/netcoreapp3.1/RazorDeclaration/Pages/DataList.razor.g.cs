#pragma checksum "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\Pages\DataList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4628fcb3cdab7b25b7fc3c353d90b862e0d957e6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppTemplate.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\_Imports.razor"
using BlazorAppTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\_Imports.razor"
using BlazorAppTemplate.Shared;

#line default
#line hidden
#nullable disable
    public partial class DataList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\Pages\DataList.razor"
 
    [Parameter]
    public IEnumerable<TItem> Data { get; set; }
    [Parameter]
    public RenderFragment<TItem> ChildContent { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
