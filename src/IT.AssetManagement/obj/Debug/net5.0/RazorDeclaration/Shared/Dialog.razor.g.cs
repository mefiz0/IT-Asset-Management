// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace IT.AssetManagement.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using IT.AssetManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using IT.AssetManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/mefiz/Projects/dotNet/IT.AssetManagement/_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
    public partial class Dialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Shared/Dialog.razor"
       
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    [Parameter] public string ContentText { get; set; }

    [Parameter] public string ButtonText { get; set; }

    [Parameter] public Color Color { get; set; }

    void Submit() => MudDialog.Close(DialogResult.Ok(true));
    void Cancel() => MudDialog.Cancel();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
