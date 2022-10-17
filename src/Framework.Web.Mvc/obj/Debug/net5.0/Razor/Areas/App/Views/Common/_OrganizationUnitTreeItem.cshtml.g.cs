#pragma checksum "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_OrganizationUnitTreeItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e17decefe0d5c9a6b30b05b12e9bb98a1e7cc9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_Common__OrganizationUnitTreeItem), @"mvc.1.0.view", @"/Areas/App/Views/Common/_OrganizationUnitTreeItem.cshtml")]
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
#line 1 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_OrganizationUnitTreeItem.cshtml"
using Framework.Web.Areas.App.Models.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e17decefe0d5c9a6b30b05b12e9bb98a1e7cc9d", @"/Areas/App/Views/Common/_OrganizationUnitTreeItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_Common__OrganizationUnitTreeItem : Framework.Web.Views.FrameworkRazorPage<OrganizationUnitTreeItemModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_OrganizationUnitTreeItem.cshtml"
  
    var organizationUnits = Model.EditModel.AllOrganizationUnits.Where(p => p.ParentId == Model.ParentId || (!p.ParentId.HasValue && !Model.ParentId.HasValue)).ToList();
    if (organizationUnits.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 8 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_OrganizationUnitTreeItem.cshtml"
             foreach (var organizationUnit in organizationUnits)
            {
                var selected = Model.EditModel.MemberedOrganizationUnits.Contains(organizationUnit.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("id", " id=\"", 521, "\"", 546, 1);
#nullable restore
#line 11 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_OrganizationUnitTreeItem.cshtml"
WriteAttributeValue("", 526, organizationUnit.Id, 526, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"jstree-open\" data-jstree=\'{\"selected\": ");
#nullable restore
#line 11 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_OrganizationUnitTreeItem.cshtml"
                                                                                       Write(selected.ToString().ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("}\'>\r\n                    ");
#nullable restore
#line 12 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_OrganizationUnitTreeItem.cshtml"
               Write(organizationUnit.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 13 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_OrganizationUnitTreeItem.cshtml"
               Write(await Html.PartialAsync("~/Areas/App/Views/Common/_OrganizationUnitTreeItem.cshtml", new OrganizationUnitTreeItemModel(Model.EditModel, organizationUnit.Id)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 15 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_OrganizationUnitTreeItem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 17 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_OrganizationUnitTreeItem.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrganizationUnitTreeItemModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
