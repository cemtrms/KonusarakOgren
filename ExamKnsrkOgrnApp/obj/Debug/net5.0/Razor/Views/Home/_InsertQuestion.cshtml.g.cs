#pragma checksum "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3516e7266af742ecf4303cf510fd5a8fc6b69916"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__InsertQuestion), @"mvc.1.0.view", @"/Views/Home/_InsertQuestion.cshtml")]
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
#line 1 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\_ViewImports.cshtml"
using ExamKnsrkOgrnApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\_ViewImports.cshtml"
using ExamKnsrkOgrnApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3516e7266af742ecf4303cf510fd5a8fc6b69916", @"/Views/Home/_InsertQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c6394de950de2350e982e0c63f541cdc0c20fc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__InsertQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/createquestion.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modal-content\">\n\n    <div class=\"modal-header\">\n        <h2 class=\"modal-title\">Create Exam</h2>\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">×</span></button>\n    </div>\n    ");
#nullable restore
#line 8 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3516e7266af742ecf4303cf510fd5a8fc6b699166691", async() => {
                WriteLiteral("\n        <div class=\"modal-body form-horizontal\">\n            <div class=\"form-group row\">\n\n                ");
#nullable restore
#line 13 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
           Write(Html.LabelFor(model => model.Article.Title, new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                <div class=\"col-sm-12\">\n                    ");
#nullable restore
#line 15 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
               Write(Html.DropDownList("ArticleTitle"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n            </div>\n            <div id=\"textId\">\n                <span>");
#nullable restore
#line 19 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
                 Write(Model.Article.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n            </div>\n");
#nullable restore
#line 21 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
              int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
             foreach (var item in Model.Questions)
            {
                i++;

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-group row\">\n            <b> ");
#nullable restore
#line 26 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
           Write(Html.LabelFor(model => item.Question, new { @class = "col-sm-10 col-form-label" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
                                                                                               Write(" " + i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\n            <div class=\"col-sm-12\">\n                ");
#nullable restore
#line 28 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
           Write(Html.TextAreaFor(model => item.Question, new { @class = "col-sm-12 col-form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n        </div> ");
#nullable restore
#line 30 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
               foreach (var choice in item.Choices)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-group row\">\n            <div class=\"col-sm-12\">\n\n                <b>");
#nullable restore
#line 35 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
              Write(choice.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3516e7266af742ecf4303cf510fd5a8fc6b6991610218", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 35 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => choice.Text);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </div>\n        </div> ");
#nullable restore
#line 37 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
               }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
   Write(Html.DropDownList("Choices"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\cemt\Desktop\ExamKnsrkOgrn\ExamKnsrkOgrnApp\Views\Home\_InsertQuestion.cshtml"
                                     }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <!--Modal Footer Start-->
            <div class=""modal-footer"">
                <button data-dismiss=""modal"" id=""cancel"" class=""btn btn-default"" type=""button"">Cancel</button>
                <button class=""btn btn-success relative"" id=""btnSubmit"" type=""submit"">
                    <i class=""loader""></i>
                    Submit
                </button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3516e7266af742ecf4303cf510fd5a8fc6b6991614873", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
