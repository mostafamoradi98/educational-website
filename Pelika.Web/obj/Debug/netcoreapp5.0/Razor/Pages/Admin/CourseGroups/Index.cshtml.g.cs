#pragma checksum "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b296082913b64f18fdec5a4fd272fa8af01f24f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_CourseGroups_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/CourseGroups/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b296082913b64f18fdec5a4fd272fa8af01f24f", @"/Pages/Admin/CourseGroups/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_CourseGroups_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-Page", "CreateGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">لیست گروه ها</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                لیست گروه های سایت
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">

                        <div class=""col-md-12"" style=""margin: 10px 0px"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b296082913b64f18fdec5a4fd272fa8af01f24f4334", async() => {
                WriteLiteral("افزودن گروه جدید");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                            <thead>
                                <tr>
                                    <th>عنوان نقش</th>
                                    <th>زیر گروه ها</th>
                                    <th>دستورات</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 35 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                 foreach (var group in Model.CourseGroups.Where(g => g.ParentId == null))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 38 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                       Write(group.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 40 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                             if (group.CourseGroups.Any())
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <ul>\r\n");
#nullable restore
#line 43 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                                     foreach (var sub in group.CourseGroups)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <li>\r\n                                                            ");
#nullable restore
#line 46 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                                       Write(sub.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - <a");
            BeginWriteAttribute("href", " href=\"", 2188, "\"", 2237, 2);
            WriteAttributeValue("", 2195, "/Admin/CourseGroups/EditGroup/", 2195, 30, true);
#nullable restore
#line 46 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 2225, sub.GroupId, 2225, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline btn-warning btn-xs\">\r\n                                                                ویرایش\r\n                                                            </a>\r\n                                                        </li>\r\n");
#nullable restore
#line 50 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </ul>\r\n");
#nullable restore
#line 52 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2783, "\"", 2836, 2);
            WriteAttributeValue("", 2790, "/Admin/CourseGroups/CreateGroup/", 2790, 32, true);
#nullable restore
#line 56 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 2822, group.GroupId, 2822, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">\r\n                                                زیرگروه\r\n                                            </a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3021, "\"", 3072, 2);
            WriteAttributeValue("", 3028, "/Admin/CourseGroups/EditGroup/", 3028, 30, true);
#nullable restore
#line 59 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 3058, group.GroupId, 3058, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\r\n                                                ویرایش\r\n                                            </a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3259, "\"", 3312, 2);
            WriteAttributeValue("", 3266, "/Admin/CourseGroups/DeleteGroup/", 3266, 32, true);
#nullable restore
#line 62 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 3298, group.GroupId, 3298, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\r\n                                                حذف\r\n                                            </a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 67 "H:\web\asp.net_code_train\pelika\Pelika\Pelika.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
                <!-- /.table-responsive -->

            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pelika.Web.Pages.Admin.CourseGroups.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pelika.Web.Pages.Admin.CourseGroups.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pelika.Web.Pages.Admin.CourseGroups.IndexModel>)PageContext?.ViewData;
        public Pelika.Web.Pages.Admin.CourseGroups.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
