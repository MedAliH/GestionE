#pragma checksum "C:\Users\moham\source\repos\blazorApp\blazorApp\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "811269b42dfc2cad7faaa5a9e762e6bb3d04ebc6"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\moham\source\repos\blazorApp\blazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\moham\source\repos\blazorApp\blazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\moham\source\repos\blazorApp\blazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\moham\source\repos\blazorApp\blazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\moham\source\repos\blazorApp\blazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\moham\source\repos\blazorApp\blazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\moham\source\repos\blazorApp\blazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\moham\source\repos\blazorApp\blazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\moham\source\repos\blazorApp\blazorApp\_Imports.razor"
using blazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\moham\source\repos\blazorApp\blazorApp\_Imports.razor"
using blazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\moham\source\repos\blazorApp\blazorApp\Pages\EmployeeList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EmployeeList")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EmployeeList</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-deck");
#nullable restore
#line 9 "C:\Users\moham\source\repos\blazorApp\blazorApp\Pages\EmployeeList.razor"
     foreach (var employee in Employees)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card m-3");
            __builder.AddAttribute(5, "style", "min-width: 18rem; max-width:30.5%;");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-header");
            __builder.OpenElement(8, "h3");
            __builder.AddContent(9, 
#nullable restore
#line 13 "C:\Users\moham\source\repos\blazorApp\blazorApp\Pages\EmployeeList.razor"
                             employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " ");
            __builder.AddContent(11, 
#nullable restore
#line 13 "C:\Users\moham\source\repos\blazorApp\blazorApp\Pages\EmployeeList.razor"
                                                 employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 15 "C:\Users\moham\source\repos\blazorApp\blazorApp\Pages\EmployeeList.razor"
                                                                   employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-footer text-center");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 17 "C:\Users\moham\source\repos\blazorApp\blazorApp\Pages\EmployeeList.razor"
                                   $"EmployeeDetails/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "class", "btn btn-primary m-1");
            __builder.AddContent(22, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", 
#nullable restore
#line 18 "C:\Users\moham\source\repos\blazorApp\blazorApp\Pages\EmployeeList.razor"
                                   $"EditEmployee/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "class", "btn btn-primary m-1");
            __builder.AddContent(27, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.AddMarkupContent(29, "<a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\moham\source\repos\blazorApp\blazorApp\Pages\EmployeeList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
