#pragma checksum "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9081bd4ad29f6830ab49b2f27d91b2b4392a1c97"
// <auto-generated/>
#pragma warning disable 1591
namespace IT.AssetManagement.Pages.Index
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
#nullable restore
#line 2 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
using Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
using Domain.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.IT.AssetManagement.Pages.Index.Index.TypeInference.CreateMudTable_0(__builder, 0, 1, "mt-5 ml-5 mb-5 mr-5", 2, 
#nullable restore
#line 10 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                                  5

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 10 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                                             assets

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 10 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                                                            true

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 10 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                                                                          new Func<Asset,bool>(FilterFunc)

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 11 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                        selectedAsset

#line default
#line hidden
#nullable disable
            , 7, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedAsset = __value, selectedAsset)), 8, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(9);
                __builder2.AddAttribute(10, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 14 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(12, "Assets");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudToolBarSpacer>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n        ");
                __Blazor.IT.AssetManagement.Pages.Index.Index.TypeInference.CreateMudTextField_1(__builder2, 16, 17, "Enter search term and press enter", 18, 
#nullable restore
#line 17 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                                                                                            Adornment.Start

#line default
#line hidden
#nullable disable
                , 19, 
#nullable restore
#line 18 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                            Icons.Material.Search

#line default
#line hidden
#nullable disable
                , 20, 
#nullable restore
#line 18 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                                             Size.Medium

#line default
#line hidden
#nullable disable
                , 21, "mt-0 mr-5", 22, 
#nullable restore
#line 17 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                   searchString

#line default
#line hidden
#nullable disable
                , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString = __value, searchString)));
                __builder2.AddMarkupContent(24, "\r\n\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(25);
                __builder2.AddAttribute(26, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 20 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                            Variant.Outlined

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 20 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                                     Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "class", "mr-3 ml-3");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                                                                                OpenNewAssetDialog

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIcon>(31);
                    __builder3.AddAttribute(32, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                      Icons.Material.Add

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "Add Asset\r\n        ");
                }
                ));
                __builder2.CloseComponent();
            }
            , 34, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(35);
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, "Asset Number");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(39);
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(41, "Type");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(43);
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(45, "Status");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(47);
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(49, "Purchased Date");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(51);
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(53, "Last Assigned Date");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(55);
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(57, "Discarded Date");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(59);
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(61, "Actions");
                }
                ));
                __builder2.CloseComponent();
            }
            , 62, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(63);
                __builder2.AddAttribute(64, "DataLabel", "Asset Number");
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(66, 
#nullable restore
#line 36 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                         context.AssetNumber

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(68);
                __builder2.AddAttribute(69, "DataLabel", "Type");
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(71, 
#nullable restore
#line 37 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                 context.Type.Name

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(73);
                __builder2.AddAttribute(74, "DataLabel", "Status");
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(76, 
#nullable restore
#line 38 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                   context.Status

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(78);
                __builder2.AddAttribute(79, "DataLabel", "Purchased Date");
                __builder2.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(81, 
#nullable restore
#line 39 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                           context.PurchasedDate

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(83);
                __builder2.AddAttribute(84, "DataLabel", "Last Assigned Date");
                __builder2.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(86, 
#nullable restore
#line 40 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                               context.LastAssignedDate

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(88);
                __builder2.AddAttribute(89, "DataLabel", "Discarded Date");
                __builder2.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(91, 
#nullable restore
#line 41 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                           context.DiscardedDate

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(93);
                __builder2.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 43 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
             if (context.Status != AssetStatus.Discarded)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudIcon>(95);
                    __builder3.AddAttribute(96, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                          Icons.Material.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(97, "class", "action-btn");
                    __builder3.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                                                                            () => OpenAssignAssetDialog(context)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, " \r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudIcon>(100);
                    __builder3.AddAttribute(101, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                          Icons.Material.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(102, "class", "action-btn");
                    __builder3.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
                                                                                              () => DiscardAsset(context)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 47 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            , 104, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(105);
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Index/Index.razor"
       
    private string searchString = "";
    private Asset selectedAsset = null;
    private ICollection<Asset> assets = null;
    private HashSet<Asset> selectedAssets = new HashSet<Asset>();

    protected override async Task OnInitializedAsync()
    {   
        assets = await AssetsService.GetAssetsAsync();
    }

    private bool FilterFunc(Asset asset)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (asset.AssetNumber.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (asset.Status.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (asset.Type.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (asset.PurchasedDate.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (asset.LastAssignedDate.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (asset.DiscardedDate.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }

    private async void OpenNewAssetDialog() {
        var dialog = Dialog.Show<NewAsset_Dialog>("New Asset", new DialogOptions() { MaxWidth = MaxWidth.Medium, FullWidth = true });
        var result = await dialog.Result;

        if (!result.Cancelled)
        {
           assets.Clear();
           assets = await AssetsService.GetAssetsAsync();
        }
        this.StateHasChanged();
    }

    private async void OpenAssignAssetDialog(Asset asset) {
        var parameters = new DialogParameters();
        parameters.Add("selectedAsset", asset);

        var dialog = Dialog.Show<AssignAsset_Dialog>("Assign Asset", parameters, new DialogOptions() { MaxWidth = MaxWidth.Medium, FullWidth = true });
        var result = await dialog.Result;

        if (!result.Cancelled)
        {
           assets.Clear();
           assets = await AssetsService.GetAssetsAsync();
        }
        this.StateHasChanged();  
    }

    private async void DiscardAsset(Asset asset) {
        var parameters = new DialogParameters();
        parameters.Add("ContentText", "Do you really want to discard this asset? This process cannot be undone.");
        parameters.Add("ButtonText", "Delete");
        parameters.Add("Color", Color.Error);

        var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };
        
        var dialog = Dialog.Show<Dialog>("Delete", parameters, options);
        
        var result = await dialog.Result;

        if (!result.Cancelled)
        {   
            Snackbar.Add("Asset deletd successfully!", Severity.Warning);
           await AssetsService.DiscardAssetAsync(asset); 
           assets.Clear();
           assets = await AssetsService.GetAssetsAsync();
        }
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService Dialog { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAssetsService AssetsService { get; set; }
    }
}
namespace __Blazor.IT.AssetManagement.Pages.Index.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Int32 __arg1, int __seq2, global::System.Collections.Generic.IEnumerable<T> __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Func<T, global::System.Boolean> __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Elevation", __arg1);
        __builder.AddAttribute(__seq2, "Items", __arg2);
        __builder.AddAttribute(__seq3, "Hover", __arg3);
        __builder.AddAttribute(__seq4, "Filter", __arg4);
        __builder.AddAttribute(__seq5, "SelectedItem", __arg5);
        __builder.AddAttribute(__seq6, "SelectedItemChanged", __arg6);
        __builder.AddAttribute(__seq7, "ToolBarContent", __arg7);
        __builder.AddAttribute(__seq8, "HeaderContent", __arg8);
        __builder.AddAttribute(__seq9, "RowTemplate", __arg9);
        __builder.AddAttribute(__seq10, "PagerContent", __arg10);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Adornment __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Size __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Adornment", __arg1);
        __builder.AddAttribute(__seq2, "AdornmentIcon", __arg2);
        __builder.AddAttribute(__seq3, "IconSize", __arg3);
        __builder.AddAttribute(__seq4, "Class", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591