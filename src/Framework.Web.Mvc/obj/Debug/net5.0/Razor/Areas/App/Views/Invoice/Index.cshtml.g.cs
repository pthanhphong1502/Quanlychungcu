#pragma checksum "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e712be528bd92627921428276dfa7c37ab07dff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_Invoice_Index), @"mvc.1.0.view", @"/Areas/App/Views/Invoice/Index.cshtml")]
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
#line 1 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
using Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
using Framework.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
using Framework.Web.Areas.App.Models.Accounting;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e712be528bd92627921428276dfa7c37ab07dff1", @"/Areas/App/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_Invoice_Index : Framework.Web.Views.FrameworkRazorPage<InvoiceViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n        .header-fixed.subheader-fixed.subheader-enabled .wrapper{\r\n            padding-top:65px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""content d-flex flex-column flex-column-fluid"" id=""kt_content"">
    <div class=""d-flex flex-column-fluid"">
        <div class=""container-fluid"">
            <div class=""card card-custom overflow-hidden"">
                <div class=""card-body p-0"">
                    <div class=""row justify-content-center py-8 px-8 py-md-27 px-md-0"">
                        <div class=""col-md-9"">
                            <div class=""d-flex justify-content-between pb-10 pb-md-20 flex-column flex-md-row"">
                                <h1 class=""display-4 font-weight-boldest mb-10"">");
#nullable restore
#line 22 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                                           Write(L("Invoice"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                <div class=""d-flex flex-column align-items-md-end px-0"">
                                    <!--begin::Logo-->
                                    <a href=""#"" class=""mb-5"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 1168, "\"", 1227, 2);
#nullable restore
#line 26 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 1174, ApplicationPath, 1174, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1192, "Common/Images/app-logo-on-light.svg", 1192, 35, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1228, "\"", 1234, 0);
            EndWriteAttribute();
            WriteLiteral("/>\r\n                                    </a>\r\n                                    <!--end::Logo-->\r\n                                    <span class=\"d-flex flex-column align-items-md-end opacity-70\">\r\n                                        <span>");
#nullable restore
#line 30 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                         Write(Model.Invoice.HostLegalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 31 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                         foreach (var line in Model.Invoice.HostAddress)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 33 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                             Write(line);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 34 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </span>
                                </div>
                            </div>
                            <div class=""border-bottom w-100""></div>
                            <div class=""d-flex justify-content-between pt-6"">
                                <div class=""d-flex flex-column flex-root"">
                                    <span class=""font-weight-bolder mb-2"">");
#nullable restore
#line 41 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                                     Write(L("Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"opacity-70\">");
#nullable restore
#line 42 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                        Write(Model.Invoice.InvoiceDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"d-flex flex-column flex-root\">\r\n                                    <span class=\"font-weight-bolder mb-2\">");
#nullable restore
#line 45 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                                     Write(L("Invoice"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"opacity-70\">#");
#nullable restore
#line 46 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                         Write(Model.Invoice.InvoiceNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"d-flex flex-column flex-root\">\r\n                                    <span class=\"font-weight-bolder mb-2\">");
#nullable restore
#line 49 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                                     Write(L("InvoiceTo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"opacity-70\">\r\n                                        ");
#nullable restore
#line 51 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                   Write(Model.Invoice.TenantLegalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                         foreach (var line in Model.Invoice.TenantAddress)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <br/>\r\n");
#nullable restore
#line 55 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                       Write(line);

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                 
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <br/>");
#nullable restore
#line 57 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                        Write(L("Tax/VatNo"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 57 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                         Write(Model.Invoice.TenantTaxNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row justify-content-center py-8 px-8 py-md-10 px-md-0"">
                        <div class=""col-md-9"">
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead>
                                    <tr>
                                        <th class=""pl-0 font-weight-bold text-muted text-uppercase"">#</th>
                                        <th class=""text-right font-weight-bold text-muted text-uppercase"">");
#nullable restore
#line 70 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                                                                     Write(L("Edition"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th class=\"text-right font-weight-bold text-muted text-uppercase\">");
#nullable restore
#line 71 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                                                                     Write(L("Amount"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                    </tr>
                                    </thead>
                                    <tbody>
                                    <tr>
                                        <td class=""pl-0 pt-7"">1</td>
                                        <td class=""pl-0 pt-7"">");
#nullable restore
#line 77 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                         Write(Model.Invoice.EditionDisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-right pl-0 pt-7\">");
#nullable restore
#line 78 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                                    Write(FrameworkConsts.CurrencySign);

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                                                                 Write(Model.Invoice.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                                    </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class=""row justify-content-center bg-gray-100 py-8 px-8 py-md-10 px-md-0"">
                        <div class=""col-md-9"">
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead>
                                    <tr>
                                        <th class=""pl-0 font-weight-bold text-muted  text-uppercase"">&nbsp;</th>
                                        <th class=""font-weight-bold text-muted text-uppercase"">&nbsp;</th>
                                        <th class=""font-weight-bold text-muted text-uppercase"">&nbsp;</th>
                                        <th class=""text-right pr-0 font-weight-bold text-muted text-uppercas");
            WriteLiteral("e\">");
#nullable restore
#line 94 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                                                                          Write(L("Total"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                    </tr>
                                    </thead>
                                    <tbody>
                                    <tr class=""font-weight-bolder"">
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td class=""text-danger text-right font-size-h3 font-weight-boldest"">");
#nullable restore
#line 102 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                                                                       Write(FrameworkConsts.CurrencySign);

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                                                                                                    Write(Model.Invoice.Amount.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class=""row justify-content-center py-8 px-8 py-md-10 px-md-0"">
                        <div class=""col-md-9"">
                            <div class=""d-flex justify-content-between"">
                                <button type=""button"" class=""btn btn-primary font-weight-bold"" onclick=""window.print();"">");
#nullable restore
#line 112 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Invoice\Index.cshtml"
                                                                                                                    Write(L("Print"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
