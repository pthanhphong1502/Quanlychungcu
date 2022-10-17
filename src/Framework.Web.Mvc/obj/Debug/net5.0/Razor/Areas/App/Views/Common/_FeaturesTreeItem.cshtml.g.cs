#pragma checksum "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c16f2f1df2db9649ab96e11ffa408775164b63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_Common__FeaturesTreeItem), @"mvc.1.0.view", @"/Areas/App/Views/Common/_FeaturesTreeItem.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
using Abp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
using Abp.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
using Framework.Web.Areas.App.Models.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c16f2f1df2db9649ab96e11ffa408775164b63", @"/Areas/App/Views/Common/_FeaturesTreeItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_Common__FeaturesTreeItem : Framework.Web.Views.FrameworkRazorPage<FeatureTreeItemModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
  
    var features = Model.EditModel.Features.Where(p => p.ParentName == Model.ParentName || (p.ParentName.IsNullOrEmpty() && Model.ParentName.IsNullOrEmpty())).ToList();
    if (features.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 11 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
             foreach (var feature in features)
                {
                    var featureValue = Model.EditModel.FeatureValues.FirstOrDefault(fv => fv.Name == feature.Name);
                    var value = featureValue == null ? feature.DefaultValue : featureValue.Value;
                    var isSelected = string.Equals(value, "true", StringComparison.OrdinalIgnoreCase);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("id", " id=\"", 761, "\"", 779, 1);
#nullable restore
#line 16 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
WriteAttributeValue("", 766, feature.Name, 766, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"jstree-open\" data-jstree=\'{\"selected\": ");
#nullable restore
#line 16 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
                                                                                Write(isSelected.ToString().ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("}\' data-feature=\'");
#nullable restore
#line 16 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
                                                                                                                                 Write(feature.ToJsonString(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' data-feature-value=\'");
#nullable restore
#line 16 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
                                                                                                                                                                                  Write(value.Replace("'","''"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
               Write(feature.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                    ");
#nullable restore
#line 18 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
               Write(await Html.PartialAsync("~/Areas/App/Views/Common/_FeaturesTreeItem.cshtml", new FeatureTreeItemModel(Model.EditModel, feature.Name)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 20 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 22 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Common\_FeaturesTreeItem.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeatureTreeItemModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
