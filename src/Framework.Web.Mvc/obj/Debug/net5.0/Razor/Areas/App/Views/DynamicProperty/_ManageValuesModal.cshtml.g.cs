#pragma checksum "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cb91e33b50ed6fa28971d687ba7d07a8203f0b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_DynamicProperty__ManageValuesModal), @"mvc.1.0.view", @"/Areas/App/Views/DynamicProperty/_ManageValuesModal.cshtml")]
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
#line 1 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml"
using Framework.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml"
using Framework.Web.Areas.App.Models.Common.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml"
using Framework.Web.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb91e33b50ed6fa28971d687ba7d07a8203f0b7", @"/Areas/App/Views/DynamicProperty/_ManageValuesModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_DynamicProperty__ManageValuesModal : Framework.Web.Views.FrameworkRazorPage<Framework.DynamicEntityProperties.Dto.DynamicPropertyDto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml"
Write(await Html.PartialAsync("~/Areas/App/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(Model.Id == default ? @L("Add") + " " + @L("DynamicPropertyValue") : @L("Edit") + " " + @L("DynamicPropertyValue"))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12\">\r\n    <div id=\"portlet-dynamic-property-values\">\r\n\r\n        <div class=\"pt-5 px-5\" id=\"edit-values-area\" style=\"display:none\">\r\n            <input type=\"hidden\" name=\"id\"/>\r\n            <input type=\"hidden\" name=\"inputType\"");
            BeginWriteAttribute("value", " value=\"", 651, "\"", 675, 1);
#nullable restore
#line 12 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml"
WriteAttributeValue("", 659, Model.InputType, 659, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <input type=\"hidden\" name=\"dynamicPropertyId\"");
            BeginWriteAttribute("value", " value=\"", 737, "\"", 754, 1);
#nullable restore
#line 13 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml"
WriteAttributeValue("", 745, Model.Id, 745, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <div class=\"form-group mb-0 pb-0\">\r\n                <label for=\"propertyName\">");
#nullable restore
#line 15 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml"
                                     Write(L("Value"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                <div class=""input-group"">
                    <input type=""text"" name=""dynamicPropertyValue"" class=""form-control"">
                    <div class=""input-group-append"">
                        <button id=""save-value"" class=""btn btn-primary"" type=""button"">");
#nullable restore
#line 19 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml"
                                                                                 Write(L("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                    </div>
                </div>
            </div>
        </div>
        <div class=""align-items-center px-5"">
            <table id=""DynamicPropertyValuesTable"" class=""display table table-separate table-head-custom no-footer dtr-inline dt-responsive nowrap"">
                <thead>
                <tr>
                    <th>");
#nullable restore
#line 28 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml"
                   Write(L("Values"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                    <th class=""w-10px""></th>
                    <th class=""w-10px"">
                        <button id=""refresh-dynamic-property-values-btn"" class=""btn btn-outline-brand btn-sm btn-icon btn-icon-md"">
                            <i class=""flaticon2-refresh""></i>
                        </button>
");
#nullable restore
#line 34 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml"
                         if (IsGranted(AppPermissions.Pages_Administration_DynamicPropertyValue_Create))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button id=\"add-new-dynamic-property-value\" class=\"btn btn-outline-brand btn-sm btn-icon btn-icon-md\">\r\n                                <i class=\"flaticon2-plus\"></i>\r\n                            </button>\r\n");
#nullable restore
#line 39 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </th>\r\n                </tr>\r\n                </thead>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 47 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\DynamicProperty\_ManageValuesModal.cshtml"
Write(await Html.PartialAsync("~/Areas/App/Views/Common/Modals/_ModalFooterWithClose.cshtml"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Framework.DynamicEntityProperties.Dto.DynamicPropertyDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
