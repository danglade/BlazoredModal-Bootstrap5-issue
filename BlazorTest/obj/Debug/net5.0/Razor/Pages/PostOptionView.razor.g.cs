#pragma checksum "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\PostOptionView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca7353c3b7e2beace2464733c3f1de6531330745"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class PostOptionView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "list-group text-center");
            __builder.AddAttribute(2, "style");
#nullable restore
#line 3 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\PostOptionView.razor"
     if (isCreator)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "li");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\PostOptionView.razor"
                       ()=> Submit(PostOptions.Delete)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "list-group-item text-danger fw-bold");
            __builder.AddContent(6, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\PostOptionView.razor"
                       ()=> Submit(PostOptions.LimitComments)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "class", "list-group-item");
            __builder.AddContent(11, "Limit Comment");
            __builder.CloseElement();
#nullable restore
#line 7 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\PostOptionView.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\PostOptionView.razor"
                       ()=> Submit(PostOptions.Report)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "list-group-item text-danger fw-bold");
            __builder.AddContent(15, "Report");
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\PostOptionView.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\PostOptionView.razor"
                   ()=> Submit(PostOptions.CopyLink)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "class", "list-group-item");
            __builder.AddContent(19, "Copy Link");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "li");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\PostOptionView.razor"
                   ()=> Cancel()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "list-group-item");
            __builder.AddContent(24, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\PostOptionView.razor"
       

    [Parameter]
    public bool isCreator { get; set; }
    [CascadingParameter]
    BlazoredModalInstance ModalInstance { get; set; }

    private PostOptions postOptions;

    async Task Cancel()
    {
        await ModalInstance.CancelAsync();
    }

    async Task Submit(PostOptions selectedPostOptions)
    {
        await ModalInstance.CloseAsync(ModalResult.Ok(selectedPostOptions));
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
