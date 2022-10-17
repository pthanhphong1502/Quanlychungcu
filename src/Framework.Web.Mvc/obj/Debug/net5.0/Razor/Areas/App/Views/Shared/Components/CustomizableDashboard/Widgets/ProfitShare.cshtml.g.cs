#pragma checksum "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\CustomizableDashboard\Widgets\ProfitShare.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e7357bf02fbb238616c33a04e9497286380ea96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_Shared_Components_CustomizableDashboard_Widgets_ProfitShare), @"mvc.1.0.view", @"/Areas/App/Views/Shared/Components/CustomizableDashboard/Widgets/ProfitShare.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\CustomizableDashboard\Widgets\ProfitShare.cshtml"
using Framework.Web.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e7357bf02fbb238616c33a04e9497286380ea96", @"/Areas/App/Views/Shared/Components/CustomizableDashboard/Widgets/ProfitShare.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_Shared_Components_CustomizableDashboard_Widgets_ProfitShare : Framework.Web.Views.FrameworkRazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Shared\Components\CustomizableDashboard\Widgets\ProfitShare.cshtml"
  
    WebResourceManager.AddScript(ApplicationPath + "view-resources/Areas/App/Views/_Bundles/morris.min.js");
    WebResourceManager.AddScript(ApplicationPath + "view-resources/Areas/App/Views/_Bundles/raphael.min.js");
    WebResourceManager.AddScript(ApplicationPath + "view-resources/Areas/App/Views/_Bundles/jquery.flot.min.js");
    WebResourceManager.AddScript(ApplicationPath + "view-resources/Areas/App/Views/_Bundles/jquery.waypoints.min.js");
    WebResourceManager.AddScript(ApplicationPath + "view-resources/Areas/App/Views/_Bundles/jquery.counterup.min.js");
    WebResourceManager.AddScript(ApplicationPath + "view-resources/Areas/App/Views/_Bundles/topojson.min.js");
    WebResourceManager.AddScript(ApplicationPath + "view-resources/Areas/App/Views/_Bundles/jquery.easypiechart.min.js");
    WebResourceManager.AddScript(ApplicationPath + "view-resources/Areas/App/Views/_Bundles/chartist.min.js");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card card-custom ProfitShareContainer h-100"">
    <div class=""card-header align-items-center border-0 mt-4"">
        <h3 class=""card-title align-items-start flex-column"">
            <span class=""font-weight-bolder text-dark""> Profit Share</span>
            <small>Profit Share between customers</small>
        </h3>
        <div class=""card-toolbar"">
            <div class=""dropdown dropdown-inline"" data-toggle=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 1456, "\"", 1464, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-placement=""left"" data-original-title=""Quick actions"">
                <a href=""#"" class=""btn btn-hover-light-primary btn-sm btn-icon"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true"">
                    <i class=""ki ki-bold-more-hor ""></i>
                </a>
                <div class=""dropdown-menu p-0 m-0 dropdown-menu-md dropdown-menu-right"" style=""position: absolute; will-change: transform; top: 0px; left: 0px; transform: translate3d(-217px, 33px, 0px);"" x-placement=""bottom-end"">
                    <!--begin::Navigation-->
                    <ul class=""navi navi-hover"">
                        <li class=""navi-header font-weight-bold py-4"">
                            <span class=""font-size-lg"">Choose Label:</span>
                            <i class=""flaticon2-information icon-md text-muted"" data-toggle=""tooltip"" data-placement=""right""");
            BeginWriteAttribute("title", " title=\"", 2353, "\"", 2361, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-original-title=""Click to learn more...""></i>
                        </li>
                        <li class=""navi-separator mb-3 opacity-70""></li>
                        <li class=""navi-item"">
                            <a href=""#"" class=""navi-link"">
                                <span class=""navi-text"">
                                    <span class=""label label-xl label-inline label-light-success"">Customer</span>
                                </span>
                            </a>
                        </li>
                        <li class=""navi-item"">
                            <a href=""#"" class=""navi-link"">
                                <span class=""navi-text"">
                                    <span class=""label label-xl label-inline label-light-dark"">Staff</span>
                                </span>
                            </a>
                        </li>
                        <li class=""navi-separator mt-3 opacity-70""></li>
                        <");
            WriteLiteral(@"li class=""navi-footer py-4"">
                            <a class=""btn btn-clean font-weight-bold btn-sm"" href=""#"">
                                <i class=""ki ki-plus icon-sm""></i>
                                Add new
                            </a>
                        </li>
                    </ul>
                    <!--end::Navigation-->
                </div>
            </div>
        </div>
    </div>

    <div class=""card-body"">
        <div class=""row align-items-center"">
            <div class=""col"">
                <div id=""kt_chart_profit_share"" class=""kt-widget14__chart kt_chart_profit_share"" style=""height: 160px"">
                    <div class=""kt-widget14__stat"">
                        45
                    </div>
                </div>
            </div>
            <div class=""col"">
                <div class=""kt-widget14__legend"">
                    <div class=""kt-widget14__legend"">
                        <span class=""kt-widget14__legend-bullet m--bg-");
            WriteLiteral(@"accent""></span>
                        <span class=""kt-widget14__legend-text"">
                        </span>
                    </div>
                    <div class=""kt-widget14__legend"">
                        <span class=""kt-widget14__legend-bullet m--bg-warning""></span>
                        <span class=""kt-widget14__legend-text"">
                        </span>
                    </div>
                    <div class=""kt-widget14__legend"">
                        <span class=""kt-widget14__legend-bullet m--bg-brand""></span>
                        <span class=""kt-widget14__legend-text"">
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWebResourceManager WebResourceManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
