#pragma checksum "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\DeleteTicket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1250534627629361f6bc40c4669f4f0df26ff890"
// <auto-generated/>
#pragma warning disable 1591
namespace Coursework.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Coursework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\_Imports.razor"
using Coursework.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\DeleteTicket.razor"
using Coursework.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeleteTicket/{Id}/{ProjectType}")]
    public partial class DeleteTicket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Delete Ticket</h2>\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Are you sure want to delete this?</h3>\r\n");
            __builder.OpenElement(2, "form");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", " col-md-8");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "<label>Id:</label>\r\n                ");
            __builder.OpenElement(10, "label");
            __builder.AddContent(11, 
#nullable restore
#line 15 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\DeleteTicket.razor"
                        obj.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "<label>Title:</label>\r\n                ");
            __builder.OpenElement(16, "label");
            __builder.AddContent(17, 
#nullable restore
#line 19 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\DeleteTicket.razor"
                        obj.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "<label>Description:</label>\r\n                ");
            __builder.OpenElement(22, "label");
            __builder.AddContent(23, 
#nullable restore
#line 23 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\DeleteTicket.razor"
                        obj.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group");
            __builder.AddMarkupContent(27, "<label>Status:</label>\r\n                ");
            __builder.OpenElement(28, "label");
            __builder.AddContent(29, 
#nullable restore
#line 27 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\DeleteTicket.razor"
                        obj.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "<label>Due Date:</label>\r\n                ");
            __builder.OpenElement(34, "label");
            __builder.AddContent(35, 
#nullable restore
#line 31 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\DeleteTicket.razor"
                        obj.DueDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-md-4");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "button");
            __builder.AddAttribute(45, "class", "btn btn-danger");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\DeleteTicket.razor"
                                                                       DeleteEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "btn btn-primary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\DeleteTicket.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Manul\Documents\IIT\4th year\enterprise\CW\cw2\final\Coursework\Coursework\Pages\DeleteTicket.razor"
       
    [Parameter]
    public String Id { get; set; }
    [Parameter]
    public String ProjectType { get; set; }

    Coursework.Data.Ticket.Ticket obj = new Coursework.Data.Ticket.Ticket();
    protected override async Task OnInitializedAsync()
    {
        obj = await Task.Run(() => ticketService.GetTicketAsync(Convert.ToInt32(Id)));
    }
    protected async void DeleteEmployee()
    {
        await ticketService.DeleteTicketAsync(obj);
        NavigationManager.NavigateTo($"/Dash/{obj.ProjectId}/{ProjectType}");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo($"/Dash/{obj.ProjectId}/{ProjectType}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Coursework.Data.Ticket.TicketService ticketService { get; set; }
    }
}
#pragma warning restore 1591
