#pragma checksum "C:\Users\retyn\Documents\University\ASPNet\Web_953503_Alshanikov\Web_953503_Alshanikov\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75779c64a42e7ef3edc7b3f51599bcd7e5b66b5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\retyn\Documents\University\ASPNet\Web_953503_Alshanikov\Web_953503_Alshanikov\Views\_ViewImports.cshtml"
using Web_953503_Alshanikov;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\retyn\Documents\University\ASPNet\Web_953503_Alshanikov\Web_953503_Alshanikov\Views\_ViewImports.cshtml"
using Web_953503_Alshanikov.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\retyn\Documents\University\ASPNet\Web_953503_Alshanikov\Web_953503_Alshanikov\Views\_ViewImports.cshtml"
using Web_953503_Alshanikov.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75779c64a42e7ef3edc7b3f51599bcd7e5b66b5b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f19d302d16d7914604d737a2d821c05be59a0511", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\retyn\Documents\University\ASPNet\Web_953503_Alshanikov\Web_953503_Alshanikov\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Главная Страница";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Лабораторная работа 1</h1>\r\n\r\n        <h1>Список</h1>\r\n        <ol type=\"A\">\r\n");
#nullable restore
#line 10 "C:\Users\retyn\Documents\University\ASPNet\Web_953503_Alshanikov\Web_953503_Alshanikov\Views\Home\Index.cshtml"
             for (int i = 1; i < 5; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>элемент ");
#nullable restore
#line 12 "C:\Users\retyn\Documents\University\ASPNet\Web_953503_Alshanikov\Web_953503_Alshanikov\Views\Home\Index.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" списка</li>\r\n");
#nullable restore
#line 13 "C:\Users\retyn\Documents\University\ASPNet\Web_953503_Alshanikov\Web_953503_Alshanikov\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ol>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75779c64a42e7ef3edc7b3f51599bcd7e5b66b5b5206", async() => {
                WriteLiteral(@" 
            <h1>Форма</h1>
            <div class=""form-group row"">
                <div class=""col-sm-2""></div>
                <div class=""col-sm-10"">
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" id=""gridCheck1"">
                        <label class=""form-check-label"" for=""gridCheck1"">
                            Чек-бокс 1
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" id=""gridCheck1"">
                        <label class=""form-check-label"" for=""gridCheck1"">
                            Чек-бокс 2
                        </label>
                    </div>
                </div>
            </div>
            <fieldset class=""form-group"">
                <div class=""row"">
                    <legend class=""col-form-label col-sm-2 pt-0""></legend>
                    <div class=""col-sm-1");
                WriteLiteral(@"0"">
                        <div class=""form-check form-check-inline"">
                            <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios1"" value=""option1"" checked>
                            <label class=""form-check-label"" for=""gridRadios1"">
                                Радио-1
                            </label>
                        </div>
                        <div class=""form-check form-check-inline"">
                            <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios2"" value=""option2"">
                            <label class=""form-check-label"" for=""gridRadios2"">
                                Радио-2
                            </label>
                        </div>
                        <div class=""form-check form-check-inline"">
                            <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios2"" value=""option2"">
                            <label class=""form-");
                WriteLiteral(@"check-label"" for=""gridRadios2"">
                                Радио-3
                            </label>
                        </div>
                    </div>
                </div>
            </fieldset>
            <div class=""form-group row"">
                <label for=""inputEmail3"" class=""col-sm-2 col-form-label"">Почта</label>
                <div class=""col-sm-10"">
                    <input type=""email"" class=""form-control"" id=""inputEmail3"" placeholder=""Введите логин"">
                </div>
            </div>
            <div class=""form-group row"">
                <label for=""inputPassword3"" class=""col-sm-2 col-form-label"">Пароль</label>
                <div class=""col-sm-10"">
                    <input type=""password"" class=""form-control"" id=""inputPassword3"" placeholder=""Введите пароль"">
                </div>
            </div>
            <div class=""form-group row"">
                <div class=""col-sm-10"">
                    <button type=""submit"" class=""btn btn-primar");
                WriteLiteral("y\">Отправить</button>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h2>");
#nullable restore
#line 79 "C:\Users\retyn\Documents\University\ASPNet\Web_953503_Alshanikov\Web_953503_Alshanikov\Views\Home\Index.cshtml"
Write(ViewData["Text"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75779c64a42e7ef3edc7b3f51599bcd7e5b66b5b10286", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 80 "C:\Users\retyn\Documents\University\ASPNet\Web_953503_Alshanikov\Web_953503_Alshanikov\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewData["Lst"] as SelectList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
