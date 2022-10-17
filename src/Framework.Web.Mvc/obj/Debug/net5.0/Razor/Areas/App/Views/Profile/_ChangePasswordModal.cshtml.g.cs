#pragma checksum "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Profile\_ChangePasswordModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17bb225a5332daa177a4014e44d25993821ea04d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_App_Views_Profile__ChangePasswordModal), @"mvc.1.0.view", @"/Areas/App/Views/Profile/_ChangePasswordModal.cshtml")]
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
#line 1 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Profile\_ChangePasswordModal.cshtml"
using Framework.Web.Areas.App.Models.Common.Modals;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bb225a5332daa177a4014e44d25993821ea04d", @"/Areas/App/Views/Profile/_ChangePasswordModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20bbeaa1d11091d924fd236e62f323626bfed2fa", @"/Areas/App/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_App_Views_Profile__ChangePasswordModal : Framework.Web.Views.FrameworkRazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("ChangePasswordModalForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Profile\_ChangePasswordModal.cshtml"
Write(await Html.PartialAsync("~/Areas/App/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("ChangePassword"))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"modal-body\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17bb225a5332daa177a4014e44d25993821ea04d4611", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label for=\"CurrentPassword\">");
#nullable restore
#line 7 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Profile\_ChangePasswordModal.cshtml"
                                    Write(L("CurrentPassword"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <input id=\"CurrentPassword\" type=\"password\" autocomplete=\"new-password\" name=\"CurrentPassword\" class=\"form-control\" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 507, "\"", 577, 1);
#nullable restore
#line 8 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Profile\_ChangePasswordModal.cshtml"
WriteAttributeValue("", 519, Framework.Authorization.Users.User.MaxPlainPasswordLength, 519, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <span class=\"form-text text-muted\">");
#nullable restore
#line 9 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Profile\_ChangePasswordModal.cshtml"
                                          Write(Html.Raw(L("PasswordChangeDontRememberMessage", "<a href=\"" + Url.Action("ForgotPassword", "Account", new {area = ""}) + "\">" + L("ClickHere") + "</a>")));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"NewPassword\">");
#nullable restore
#line 12 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Profile\_ChangePasswordModal.cshtml"
                                Write(L("NewPassword"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <input id=\"NewPassword\" type=\"password\" autocomplete=\"new-password\" name=\"NewPassword\" class=\"form-control\" required>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"NewPasswordRepeat\">");
#nullable restore
#line 16 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Profile\_ChangePasswordModal.cshtml"
                                      Write(L("NewPasswordRepeat"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <input id=\"NewPasswordRepeat\" type=\"password\" autocomplete=\"new-password\" name=\"NewPasswordRepeat\" class=\"form-control\" required equalto=\"#NewPassword\">\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 22 "C:\LoTriThong\Studying\SE214 Projects\Repos\backend\src\Framework.Web.Mvc\Areas\App\Views\Profile\_ChangePasswordModal.cshtml"
Write(await Html.PartialAsync("~/Areas/App/Views/Common/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
