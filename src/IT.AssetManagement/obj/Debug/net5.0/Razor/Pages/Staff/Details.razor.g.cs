#pragma checksum "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbed623a3bb31c69b02646a85e255e4b3aa9312c"
// <auto-generated/>
#pragma warning disable 1591
namespace IT.AssetManagement.Pages.Staff
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 3 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
using Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
using Domain.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/staff/{id:int}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudCard>(0);
            __builder.AddAttribute(1, "class", "mt-5 ml-5 mb-5 mr-5");
            __builder.AddAttribute(2, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                                5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardHeader>(4);
                __builder2.AddAttribute(5, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(6);
                    __builder3.AddAttribute(7, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 16 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(9, "Staff Details");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudCardContent>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(13);
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(15);
                        __builder4.AddAttribute(16, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                         12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                 3

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudField>(19);
                            __builder5.AddAttribute(20, "T", "string");
                            __builder5.AddAttribute(21, "Label", "Staff Number");
                            __builder5.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(23, 
#nullable restore
#line 22 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                                           staff.StaffNumber

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(24, "\n\n            ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(25);
                        __builder4.AddAttribute(26, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                         12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                 3

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudField>(29);
                            __builder5.AddAttribute(30, "T", "string");
                            __builder5.AddAttribute(31, "Label", "Name");
                            __builder5.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(33, 
#nullable restore
#line 26 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                                   staff.Name

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(34, "\n\n            ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(35);
                        __builder4.AddAttribute(36, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                         12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(37, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                 3

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudField>(39);
                            __builder5.AddAttribute(40, "T", "string");
                            __builder5.AddAttribute(41, "Label", "National ID Number");
                            __builder5.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(43, 
#nullable restore
#line 30 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                                                 staff.NationalIdentificationNumber

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(44, "\n\n            ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(45);
                        __builder4.AddAttribute(46, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                         12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(47, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                 3

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudField>(49);
                            __builder5.AddAttribute(50, "T", "string");
                            __builder5.AddAttribute(51, "Label", "Department");
                            __builder5.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(53, 
#nullable restore
#line 34 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                                         staff.Department.Name

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 40 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
 if (staff.Assets.Any() != false)
{

#line default
#line hidden
#nullable disable
            __Blazor.IT.AssetManagement.Pages.Staff.Details.TypeInference.CreateMudTable_0(__builder, 54, 55, "mt-5 ml-5 mb-5 mr-5", 56, 
#nullable restore
#line 42 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                                      5

#line default
#line hidden
#nullable disable
            , 57, 
#nullable restore
#line 42 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                                                 history

#line default
#line hidden
#nullable disable
            , 58, 
#nullable restore
#line 42 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
            , 59, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(60);
                __builder2.AddAttribute(61, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 45 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(63, "Assigned Assets");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudToolBarSpacer>(65);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\n\n        ");
                __Blazor.IT.AssetManagement.Pages.Staff.Details.TypeInference.CreateMudTextField_1(__builder2, 67, 68, "Enter search term and press enter", 69, 
#nullable restore
#line 48 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                                                                                            Adornment.Start

#line default
#line hidden
#nullable disable
                , 70, 
#nullable restore
#line 49 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                            Icons.Material.Search

#line default
#line hidden
#nullable disable
                , 71, 
#nullable restore
#line 49 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                                             Size.Medium

#line default
#line hidden
#nullable disable
                , 72, "mt-0 mr-5", 73, 
#nullable restore
#line 48 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                   searchString

#line default
#line hidden
#nullable disable
                , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString = __value, searchString)));
            }
            , 75, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(76);
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(78, "Asset Number");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(80);
                __builder2.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(82, "Type");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(84);
                __builder2.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(86, "Current Status");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(88);
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(90, "Assigned Date");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(92);
                __builder2.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(94, "Unassigned Date");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(95, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(96);
                __builder2.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(98, "Actions");
                }
                ));
                __builder2.CloseComponent();
            }
            , 99, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(100);
                __builder2.AddAttribute(101, "DataLabel", "Asset Number");
                __builder2.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(103, 
#nullable restore
#line 62 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                          context.Asset.AssetNumber

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, " \n         ");
                __builder2.OpenComponent<MudBlazor.MudTd>(105);
                __builder2.AddAttribute(106, "DataLabel", "Type");
                __builder2.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(108, 
#nullable restore
#line 63 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                  context.Asset.Type.Name

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, " \n         ");
                __builder2.OpenComponent<MudBlazor.MudTd>(110);
                __builder2.AddAttribute(111, "DataLabel", "Type");
                __builder2.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(113, 
#nullable restore
#line 64 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                  context.Asset.Status

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, " \n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(115);
                __builder2.AddAttribute(116, "DataLabel", "Assigned Date");
                __builder2.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(118, 
#nullable restore
#line 65 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                          context.AssignedDate

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, " \n         ");
                __builder2.OpenComponent<MudBlazor.MudTd>(120);
                __builder2.AddAttribute(121, "DataLabel", "Unassigned Date");
                __builder2.AddAttribute(122, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(123, 
#nullable restore
#line 66 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                             context.UnAssignedDate

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(124, " \n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(125);
                __builder2.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 68 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
             if (context.Asset.Status!= AssetStatus.Discarded)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudIcon>(127);
                    __builder3.AddAttribute(128, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 70 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                          Icons.Material.RemoveCircle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(129, "class", "action-btn");
                    __builder3.AddAttribute(130, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
                                                                                                    () => Unassign(context)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 71 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            , 131, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(132);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 80 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "/home/mefiz/Projects/dotNet/IT.AssetManagement/Pages/Staff/Details.razor"
       
    [Parameter]
    public int Id { get; set; }

    private string searchString = "";

    private Staff staff = null;
    private ICollection<AssetHistory> history = null;
    
    protected override async Task OnInitializedAsync()
    {
        staff = await StaffsService.GetStaffDetails(Id);
        history = await StaffsService.GetAssetHistoryAsync(staff);
    }

    private async void Unassign(AssetHistory asset) {
        var parameters = new DialogParameters();
        parameters.Add("ContentText", "Do you really want to unassign this asset?");
        parameters.Add("ButtonText", "Unassign");
        parameters.Add("Color", Color.Error);

        var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };
        
        var dialog = Dialog.Show<Dialog>("Delete", parameters, options);
        
        var result = await dialog.Result;

        if (!result.Cancelled)
        {   
            Snackbar.Add("Unassigned successfully!", Severity.Warning);
           await StaffsService.Unassign(asset); 
           history.Clear();
           history = await StaffsService.GetAssetHistoryAsync(staff);
        }
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService Dialog { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAssetsService AssetsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStaffsService StaffsService { get; set; }
    }
}
namespace __Blazor.IT.AssetManagement.Pages.Staff.Details
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Int32 __arg1, int __seq2, global::System.Collections.Generic.IEnumerable<T> __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Elevation", __arg1);
        __builder.AddAttribute(__seq2, "Items", __arg2);
        __builder.AddAttribute(__seq3, "Hover", __arg3);
        __builder.AddAttribute(__seq4, "ToolBarContent", __arg4);
        __builder.AddAttribute(__seq5, "HeaderContent", __arg5);
        __builder.AddAttribute(__seq6, "RowTemplate", __arg6);
        __builder.AddAttribute(__seq7, "PagerContent", __arg7);
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