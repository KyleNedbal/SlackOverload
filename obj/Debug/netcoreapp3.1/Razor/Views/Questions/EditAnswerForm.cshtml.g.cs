#pragma checksum "C:\Users\knedbal\dev\Week12\SlackOverload\Views\Questions\EditAnswerForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a11a63e2a058ec05369d072e377618e1ad5adb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_EditAnswerForm), @"mvc.1.0.view", @"/Views/Questions/EditAnswerForm.cshtml")]
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
#line 1 "C:\Users\knedbal\dev\Week12\SlackOverload\Views\_ViewImports.cshtml"
using SlackOverload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\knedbal\dev\Week12\SlackOverload\Views\_ViewImports.cshtml"
using SlackOverload.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a11a63e2a058ec05369d072e377618e1ad5adb5", @"/Views/Questions/EditAnswerForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc81ec1186c9ee2fd540ead68492bd203ae901", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_EditAnswerForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Answers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/questions/editanswer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\knedbal\dev\Week12\SlackOverload\Views\Questions\EditAnswerForm.cshtml"
  
    ViewData["Title"] = "EditAnswerForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit Answer</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a11a63e2a058ec05369d072e377618e1ad5adb54143", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 169, "\"", 186, 1);
#nullable restore
#line 9 "C:\Users\knedbal\dev\Week12\SlackOverload\Views\Questions\EditAnswerForm.cshtml"
WriteAttributeValue("", 177, Model.id, 177, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 226, "\"", 249, 1);
#nullable restore
#line 10 "C:\Users\knedbal\dev\Week12\SlackOverload\Views\Questions\EditAnswerForm.cshtml"
WriteAttributeValue("", 234, Model.username, 234, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n    Username <label> ");
#nullable restore
#line 11 "C:\Users\knedbal\dev\Week12\SlackOverload\Views\Questions\EditAnswerForm.cshtml"
                Write(Model.username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n    <br />\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 347, "\"", 372, 1);
#nullable restore
#line 13 "C:\Users\knedbal\dev\Week12\SlackOverload\Views\Questions\EditAnswerForm.cshtml"
WriteAttributeValue("", 355, Model.questionid, 355, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"questionid\" />\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 420, "\"", 441, 1);
#nullable restore
#line 14 "C:\Users\knedbal\dev\Week12\SlackOverload\Views\Questions\EditAnswerForm.cshtml"
WriteAttributeValue("", 428, Model.posted, 428, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"posted\" />\r\n    <label> ");
#nullable restore
#line 15 "C:\Users\knedbal\dev\Week12\SlackOverload\Views\Questions\EditAnswerForm.cshtml"
       Write(Model.posted);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n    <br />\r\n    Detail\r\n    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 542, "\"", 563, 1);
#nullable restore
#line 18 "C:\Users\knedbal\dev\Week12\SlackOverload\Views\Questions\EditAnswerForm.cshtml"
WriteAttributeValue("", 550, Model.detail, 550, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"detail\" />\r\n    <input type=\"submit\" value=\"Save\" />\r\n    <br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Answers> Html { get; private set; }
    }
}
#pragma warning restore 1591
