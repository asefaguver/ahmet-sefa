#pragma checksum "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\BookDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dfd29bf60e3e4fe7e712d42913e3a82555b8eb2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
    public partial class BookDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BookDetail</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Book Name : ");
            __builder.AddContent(3, 
#nullable restore
#line 3 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\BookDetail.razor"
                BookName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(5, "<button @onclik=\"Tikla\" class=\"btn btn-primary\"> Kaydet </button>\r\n\r\n<hr>");
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\BookDetail.razor"
       
    [Parameter]
    public string BookName { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> Tikla { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
