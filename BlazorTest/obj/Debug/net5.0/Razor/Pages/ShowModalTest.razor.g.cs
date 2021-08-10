#pragma checksum "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\ShowModalTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec82eeac193d51e770c812d5aeed6df82674374a"
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
    public partial class ShowModalTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\ShowModalTest.razor"
 for (int i = 1000 - 1; i >= 0 ; i--)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\ShowModalTest.razor"
              Show

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "Test");
            __builder.CloseElement();
#nullable restore
#line 7 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\ShowModalTest.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\danglade\source\repos\BlazorTest\BlazorTest\Pages\ShowModalTest.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }

    void Show()
    {
        bool isCreator = false;

        if (1 == 2)
        {
            isCreator = true;
        }

        var options = new ModalOptions()
        {
            HideCloseButton = true,
            HideHeader = true,
            Position = ModalPosition.Center,
            FocusFirstElement = true,

        };

        var PostOptionsViewParameters = new ModalParameters();
        PostOptionsViewParameters.Add(nameof(PostOptionView.isCreator), isCreator);

        Modal.Show<PostOptionView>("", PostOptionsViewParameters, options);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
