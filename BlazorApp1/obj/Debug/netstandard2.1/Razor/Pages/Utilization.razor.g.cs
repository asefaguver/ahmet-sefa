#pragma checksum "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\Utilization.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "906c9ae110d51263d9e6d9fb95a9e0fb9b40ea2a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/utilization")]
    public partial class Utilization : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"~/css/bootstrap/bootstrap.min.css\" rel=\"stylesheet\">\r\n");
            __builder.AddMarkupContent(1, "<h1>Utilization</h1>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", true);
            __builder.AddAttribute(6, "style", "float: left;display: inline-block;height: 200px;width: 215px;margin: 10px;color: #FF0000;");
            __builder.AddAttribute(7, "id", "div");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "select");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "selected", true);
            __builder.AddContent(14, "Open this select menu");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "option");
            __builder.AddContent(17, 
#nullable restore
#line 26 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\Utilization.razor"
                     machineArray[0]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "option");
            __builder.AddContent(20, 
#nullable restore
#line 27 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\Utilization.razor"
                     machineArray[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "option");
            __builder.AddContent(23, 
#nullable restore
#line 28 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\Utilization.razor"
                     machineArray[2]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "option");
            __builder.AddContent(26, 
#nullable restore
#line 29 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\Utilization.razor"
                     machineArray[3]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    <input type=\"checkbox\" id=\"vehicle1\" name=\"vehicle1\" value=\"Bıke\">\r\n    ");
            __builder.OpenElement(30, "label");
            __builder.AddAttribute(31, "for", "vehicle1");
            __builder.AddContent(32, " ");
            __builder.AddContent(33, 
#nullable restore
#line 33 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\Utilization.razor"
                            dayArray[0]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    <input type=\"checkbox\" id=\"vehicle2\" name=\"vehicle2\" value=\"Car\">\r\n    ");
            __builder.OpenElement(35, "label");
            __builder.AddAttribute(36, "for", "vehicle2");
            __builder.AddContent(37, " ");
            __builder.AddContent(38, 
#nullable restore
#line 35 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\Utilization.razor"
                            dayArray[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    <input type=\"checkbox\" id=\"vehicle3\" name=\"vehicle3\" value=\"Boat\">\r\n    ");
            __builder.OpenElement(40, "label");
            __builder.AddAttribute(41, "for", "vehicle3");
            __builder.AddContent(42, " ");
            __builder.AddContent(43, 
#nullable restore
#line 37 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\Utilization.razor"
                            dayArray[2]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "<br>\r\n    <input type=\"checkbox\" id=\"vehicle4\" name=\"vehicle4\" value=\"Bike\">\r\n    ");
            __builder.OpenElement(45, "label");
            __builder.AddAttribute(46, "for", "vehicle4");
            __builder.AddContent(47, " ");
            __builder.AddContent(48, 
#nullable restore
#line 39 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\Utilization.razor"
                            dayArray[3]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    <input type=\"checkbox\" id=\"vehicle5\" name=\"vehicle5\" value=\"Car\">\r\n    ");
            __builder.OpenElement(50, "label");
            __builder.AddAttribute(51, "for", "vehicle5");
            __builder.AddContent(52, " ");
            __builder.AddContent(53, 
#nullable restore
#line 41 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\Utilization.razor"
                            dayArray[4]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(55, "<label for=\"birthday\"> &emsp; &emsp; &emsp; &emsp;&emsp;&emsp;Date:</label>\r\n    <input type=\"date\" id=\"birthday\" name=\"birthday\">\r\n\r\n    <input id=\"Button1\" type=\"button\" value=\"Save\">\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\ahmet sefa\Desktop\örnek kodlar\BlazorApp1\BlazorApp1\Pages\Utilization.razor"
      
    string checkboxVal1 = "Monday";
    string[] dayArray = { "monday", "tuesday", "wednesday", "thursday", "friday" };
    string[] machineArray = { "skyreprer", "finisher", "forklift", "sondaj" };


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
