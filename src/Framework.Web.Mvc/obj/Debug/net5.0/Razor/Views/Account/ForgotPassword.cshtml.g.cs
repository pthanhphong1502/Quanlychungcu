#pragma checksum "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Views\Account\ForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b84be42ce11cd1d9605c5a1e54f268ee38a75a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ForgotPassword), @"mvc.1.0.view", @"/Views/Account/ForgotPassword.cshtml")]
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
#line 1 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Views\Account\ForgotPassword.cshtml"
using Abp.Authorization.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Views\Account\ForgotPassword.cshtml"
using Framework.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b84be42ce11cd1d9605c5a1e54f268ee38a75a4", @"/Views/Account/ForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_ForgotPassword : Framework.Web.Views.FrameworkRazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-src", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Views/Account/ForgotPassword.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form forget-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendPasswordResetLink", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b84be42ce11cd1d9605c5a1e54f268ee38a75a45727", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper = CreateTagHelper<global::Framework.Web.TagHelpers.FrameworkScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__Framework_Web_TagHelpers_FrameworkScriptSrcTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 5 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Views\Account\ForgotPassword.cshtml"
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
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 221, "\"", 294, 3);
                WriteAttributeValue("", 228, "/metronic/common/css/login-1", 228, 28, true);
#nullable restore
#line 8 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Views\Account\ForgotPassword.cshtml"
WriteAttributeValue("", 256, CultureHelper.IsRtl ? ".rtl":"", 256, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 290, ".css", 290, 4, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
            }
            );
            WriteLiteral("<div class=\"login-form\">\r\n    <div class=\"pb-13 pt-lg-0 pt-5\">\r\n    \t<h3 class=\"font-weight-bolder text-dark font-size-h4 font-size-h1-lg\">");
#nullable restore
#line 12 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Views\Account\ForgotPassword.cshtml"
                                                                         Write(L("ForgotPassword"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b84be42ce11cd1d9605c5a1e54f268ee38a75a48851", async() => {
                WriteLiteral("\r\n        <p>\r\n            ");
#nullable restore
#line 16 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Views\Account\ForgotPassword.cshtml"
       Write(L("SendPasswordResetLink_Information"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n        <div class=\"form-group\">\r\n            <input class=\"form-control placeholder-no-fix form-control-solid h-auto py-7 px-6 rounded-lg font-size-h6\" type=\"email\" autocomplete=\"new-password\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 857, "\"", 889, 1);
#nullable restore
#line 19 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Views\Account\ForgotPassword.cshtml"
WriteAttributeValue("", 871, L("EmailAddress"), 871, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"EmailAddress\" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 919, "\"", 965, 1);
#nullable restore
#line 19 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Views\Account\ForgotPassword.cshtml"
WriteAttributeValue("", 931, AbpUserBase.MaxEmailAddressLength, 931, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"pb-lg-0 pb-5\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b84be42ce11cd1d9605c5a1e54f268ee38a75a410602", async() => {
                    WriteLiteral("\r\n                <button type=\"button\" id=\"back-btn\" class=\"btn btn-light-primary font-weight-bolder font-size-h6 px-8 py-4 my-3\">");
#nullable restore
#line 23 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Views\Account\ForgotPassword.cshtml"
                                                                                                                            Write(L("Back"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-primary font-weight-bolder font-size-h6 px-8 py-4 my-3 mr-3\">");
#nullable restore
#line 25 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Views\Account\ForgotPassword.cshtml"
                                                                                                         Write(L("Submit"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
