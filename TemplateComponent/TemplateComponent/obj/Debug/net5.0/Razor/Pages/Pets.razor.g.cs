#pragma checksum "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\Pages\Pets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2434798404050302e7cfe8a856488bc00886680"
// <auto-generated/>
#pragma warning disable 1591
namespace TemplateComponent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\_Imports.razor"
using TemplateComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\_Imports.razor"
using TemplateComponent.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pets")]
    public partial class Pets : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Pets</h1>\r\n\r\n");
            __Blazor.TemplateComponent.Pages.Pets.TypeInference.CreateTableTemplate_0(__builder, 1, 2, 
#nullable restore
#line 5 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\Pages\Pets.razor"
                      pets

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.AddMarkupContent(4, "<th>ID</th>\r\n        ");
                __builder2.AddMarkupContent(5, "<th>Name</th>\r\n        ");
                __builder2.AddMarkupContent(6, "<th>Pet Type</th>");
            }
            , 7, (pet) => (__builder2) => {
                __builder2.OpenElement(8, "td");
                __builder2.AddContent(9, 
#nullable restore
#line 12 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\Pages\Pets.razor"
             pet.PetId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "td");
                __builder2.AddContent(12, 
#nullable restore
#line 13 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\Pages\Pets.razor"
             pet.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "td");
                __builder2.AddContent(15, 
#nullable restore
#line 14 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\Pages\Pets.razor"
             pet.PetType

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Administrator\Documents\GitHub\BlazorAppTemplate\TemplateComponent\TemplateComponent\Pages\Pets.razor"
       
    private List<Pet> pets = new()
    {
        new Pet { PetId = 2, Name = "Mr. Bigglesworth", PetType="Dog" },
        new Pet { PetId = 4, Name = "Salem Saberhagen", PetType = "Dog" },
        new Pet { PetId = 7, Name = "K-9", PetType = "Cat" }
    };

    private class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public string PetType { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TemplateComponent.Pages.Pets
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTableTemplate_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IReadOnlyList<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::TemplateComponent.Shared.TableTemplate<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "TableHeader", __arg1);
        __builder.AddAttribute(__seq2, "RowTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
