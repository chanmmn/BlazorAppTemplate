#pragma checksum "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\Pages\ListPerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d32eae1306b190491f144ba8bee1fcc4db119f00"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 2 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\Pages\ListPerson.razor"
using BlazorAppTemplate.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListPerson")]
    public partial class ListPerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ListPerson</h3>\r\n\r\n");
            __Blazor.BlazorAppTemplate.Pages.ListPerson.TypeInference.CreateDataList_0(__builder, 1, 2, 
#nullable restore
#line 5 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\Pages\ListPerson.razor"
                 People

#line default
#line hidden
#nullable disable
            , 3, (context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.AddContent(5, 
#nullable restore
#line 6 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\Pages\ListPerson.razor"
     context.Salutation

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(6, " ");
                __builder2.AddContent(7, 
#nullable restore
#line 6 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\Pages\ListPerson.razor"
                         context.FamilyName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(8, ", ");
                __builder2.AddContent(9, 
#nullable restore
#line 6 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\Pages\ListPerson.razor"
                                              context.GivenName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(10, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\test\other\BlazorAppTemplate\BlazorAppTemplate\Pages\ListPerson.razor"
       
    public IEnumerable<Person> People;
    //Person person = new Person();
    protected override void OnInitialized()
    {
        base.OnInitialized();

        People = new Person[]
        {
            new Person { Salutation = "Mr", GivenName = "Bob", FamilyName = "Geldof" },
            new Person { Salutation = "Mrs", GivenName = "Angela", FamilyName = "Rippon" },
            new Person { Salutation = "Mr", GivenName = "Freddie", FamilyName = "Mercury" }
            };
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorAppTemplate.Pages.ListPerson
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDataList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::BlazorAppTemplate.Pages.DataList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
