#pragma checksum "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b0a5801dec110754fc486d093b6574f5868e6d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Extend), @"mvc.1.0.view", @"/Views/Payment/Extend.cshtml")]
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
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
using Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
using Framework.Editions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
using Framework.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
using Framework.MultiTenancy.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
using Framework.MultiTenancy.Payments.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b0a5801dec110754fc486d093b6574f5868e6d6", @"/Views/Payment/Extend.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Payment_Extend : Framework.Web.Views.FrameworkRazorPage<Framework.Web.Models.Payment.ExtendEditionViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-src", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Views/Payment/Extend.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-href", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Views/Payment/Payment.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Framework.Web.TagHelpers.FrameworkScriptSrcTagHelper __Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Framework.Web.TagHelpers.FrameworkLinkHrefTagHelper __Framework_Web_TagHelpers_FrameworkLinkHrefTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
  
    Layout = "~/Views/Account/_Layout.cshtml";
    ViewBag.DisableTenantChange = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b0a5801dec110754fc486d093b6574f5868e6d66420", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 16 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4b0a5801dec110754fc486d093b6574f5868e6d68383", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Framework_Web_TagHelpers_FrameworkLinkHrefTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkLinkHrefTagHelper>();
                __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkLinkHrefTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 21 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 633, "\"", 706, 3);
                WriteAttributeValue("", 640, "/metronic/common/css/login-1", 640, 28, true);
#nullable restore
#line 22 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
WriteAttributeValue("", 668, CultureHelper.IsRtl ? ".rtl":"", 668, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 702, ".css", 702, 4, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"login-form\">\r\n    <div class=\"pb-13 pt-lg-0 pt-5\">\r\n    \t<h3 class=\"font-weight-bolder text-dark font-size-h4 font-size-h1-lg\">");
#nullable restore
#line 27 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                                         Write(L("PaymentInfo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    \t<p class=\"text-muted font-weight-bold font-size-h4\">(");
#nullable restore
#line 28 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                        Write(L(EditionPaymentType.Extend + "_Edition_Description", Model.Edition.DisplayName));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n    </div>\r\n    <div>\r\n        <input type=\"hidden\" name=\"EditionId\"");
            BeginWriteAttribute("value", " value=\"", 1111, "\"", 1136, 1);
#nullable restore
#line 31 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
WriteAttributeValue("", 1119, Model.Edition.Id, 1119, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"EditionPaymentType\"");
            BeginWriteAttribute("value", " value=\"", 1196, "\"", 1230, 1);
#nullable restore
#line 32 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
WriteAttributeValue("", 1204, EditionPaymentType.Extend, 1204, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"SubscriptionStartType\"");
            BeginWriteAttribute("value", " value=\"", 1293, "\"", 1328, 1);
#nullable restore
#line 33 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
WriteAttributeValue("", 1301, SubscriptionStartType.Paid, 1301, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"RecurringPaymentEnabled\" value=\"false\" />\r\n\r\n");
#nullable restore
#line 36 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
         if (ViewBag.ErrorMessage != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                <i class=\"fa fa-exclamation-triangle\"></i> ");
#nullable restore
#line 39 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                      Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 41 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"radio-inline mb-3\">\r\n");
#nullable restore
#line 44 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
             if (Model.Edition.DailyPrice.HasValue && Model.Edition.DailyPrice.Value > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label class=\"radio mb-5\">\r\n                    <input class=\"form-control\" type=\"radio\" name=\"PaymentPeriodType\"\r\n                           data-day-count=\"");
#nullable restore
#line 48 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                       Write((int) PaymentPeriodType.Daily);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                           data-payment-period-type-amount=\"");
#nullable restore
#line 49 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                        Write(Model.Edition.DailyPrice.Value.ToString("0.00", CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("value", "\r\n                           value=\"", 2127, "\"", 2187, 1);
#nullable restore
#line 50 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
WriteAttributeValue("", 2163, PaymentPeriodType.Daily, 2163, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 52 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
               Write(L("DailyPrice"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 52 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                 Write(FrameworkConsts.CurrencySign);

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                              Write(Model.Edition.DailyPrice.Value.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n");
#nullable restore
#line 54 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
             if (Model.Edition.WeeklyPrice.HasValue && Model.Edition.WeeklyPrice.Value > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label class=\"radio mb-5\">\r\n                    <input class=\"form-control\" type=\"radio\" name=\"PaymentPeriodType\"\r\n                           data-day-count=\"");
#nullable restore
#line 59 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                       Write((int) PaymentPeriodType.Weekly);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                           data-payment-period-type-amount=\"");
#nullable restore
#line 60 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                        Write(Model.Edition.WeeklyPrice.Value.ToString("0.00", CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("value", "\r\n                           value=\"", 2844, "\"", 2905, 1);
#nullable restore
#line 61 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
WriteAttributeValue("", 2880, PaymentPeriodType.Weekly, 2880, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 63 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
               Write(L("WeeklyPrice"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 63 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                  Write(FrameworkConsts.CurrencySign);

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                               Write(Model.Edition.WeeklyPrice.Value.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n");
#nullable restore
#line 65 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
             if (Model.Edition.MonthlyPrice.HasValue && Model.Edition.MonthlyPrice.Value > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label class=\"radio mb-5\">\r\n                    <input class=\"form-control\" type=\"radio\" name=\"PaymentPeriodType\"\r\n                           data-day-count=\"");
#nullable restore
#line 70 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                       Write((int) PaymentPeriodType.Monthly);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                           data-payment-period-type-amount=\"");
#nullable restore
#line 71 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                        Write(Model.Edition.MonthlyPrice.Value.ToString("0.00", CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("value", "\r\n                           value=\"", 3568, "\"", 3630, 1);
#nullable restore
#line 72 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
WriteAttributeValue("", 3604, PaymentPeriodType.Monthly, 3604, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 74 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
               Write(L("MonthlyPrice"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 74 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                   Write(FrameworkConsts.CurrencySign);

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                                Write(Model.Edition.MonthlyPrice.Value.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n");
#nullable restore
#line 76 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
             if (Model.Edition.AnnualPrice.HasValue && Model.Edition.AnnualPrice.Value > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label class=\"radio mb-5\">\r\n                    <input class=\"form-control\" type=\"radio\" name=\"PaymentPeriodType\"\r\n                           data-day-count=\"");
#nullable restore
#line 82 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                       Write((int) PaymentPeriodType.Annual);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                           data-payment-period-type-amount=\"");
#nullable restore
#line 83 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                        Write(Model.Edition.AnnualPrice.Value.ToString("0.00", CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("value", "\r\n                           value=\"", 4292, "\"", 4353, 1);
#nullable restore
#line 84 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
WriteAttributeValue("", 4328, PaymentPeriodType.Annual, 4328, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                    <span></span>\r\n                    ");
#nullable restore
#line 86 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
               Write(L("AnnualPrice"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 86 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                  Write(FrameworkConsts.CurrencySign);

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                               Write(Model.Edition.AnnualPrice.Value.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n");
#nullable restore
#line 88 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 92 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
     foreach (var paymentGateway in Model.PaymentGateways)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            <button data-gateway=\"");
#nullable restore
#line 95 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                             Write(paymentGateway.GatewayType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-supports-subscription=\"");
#nullable restore
#line 95 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                                                      Write(paymentGateway.SupportsRecurringPayments.ToString().ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-success btn-block checkout\">");
#nullable restore
#line 95 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
                                                                                                                                                                                                 Write(L("CheckoutWith" + paymentGateway.GatewayType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n        </div>\r\n");
#nullable restore
#line 97 "C:\Users\Admin\Source\Repos\backend\src\Framework.Web.Mvc\Views\Payment\Extend.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Framework.Web.Models.Payment.ExtendEditionViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
