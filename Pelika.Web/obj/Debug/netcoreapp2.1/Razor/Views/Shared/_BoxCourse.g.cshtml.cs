#pragma checksum "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Shared\_BoxCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de9dcc6ca337eaef2a01f764d16e42b2bbc6d164"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BoxCourse), @"mvc.1.0.view", @"/Views/Shared/_BoxCourse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_BoxCourse.cshtml", typeof(AspNetCore.Views_Shared__BoxCourse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de9dcc6ca337eaef2a01f764d16e42b2bbc6d164", @"/Views/Shared/_BoxCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BoxCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pelika.Core.DTOs.Course.ShowCourseListItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 102, true);
            WriteLiteral("\r\n<!-- col -->\r\n<div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col\">\r\n    <article>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 162, "\"", 196, 2);
            WriteAttributeValue("", 169, "/ShowCourse/", 169, 12, true);
#line 6 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Shared\_BoxCourse.cshtml"
WriteAttributeValue("", 181, Model.CourseId, 181, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(197, 19, true);
            WriteLiteral(" class=\"img-layer\">");
            EndContext();
            BeginContext(216, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "16543d94e7ec4d30a7579c65e249f0f8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 248, "~/Course/thumb/", 248, 15, true);
#line 6 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Shared\_BoxCourse.cshtml"
AddHtmlAttributeValue("", 263, Model.ImageName, 263, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(281, 20, true);
            WriteLiteral("</a>\r\n        <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 301, "\"", 335, 2);
            WriteAttributeValue("", 308, "/ShowCourse/", 308, 12, true);
#line 7 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Shared\_BoxCourse.cshtml"
WriteAttributeValue("", 320, Model.CourseId, 320, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(336, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(339, 11, false);
#line 7 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Shared\_BoxCourse.cshtml"
                                              Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(350, 26, true);
            WriteLiteral("</a></h2>\r\n        <span> ");
            EndContext();
            BeginContext(378, 53, false);
#line 8 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Shared\_BoxCourse.cshtml"
           Write((Model.Price==0)?"رایگان":Model.Price.ToString("#,0"));

#line default
#line hidden
            EndContext();
            BeginContext(432, 21, true);
            WriteLiteral(" </span>\r\n        <i>");
            EndContext();
            BeginContext(454, 15, false);
#line 9 "D:\asp.net_code_train\pelika\Pelika\Pelika.Web\Views\Shared\_BoxCourse.cshtml"
      Write(Model.TotalTime);

#line default
#line hidden
            EndContext();
            BeginContext(469, 46, true);
            WriteLiteral("</i>\r\n    </article>\r\n</div>\r\n<!-- /col -->   ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pelika.Core.DTOs.Course.ShowCourseListItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
