#pragma checksum "C:\Users\Cruz Badillo\Documents\proyectos\gil\EstudiantesAppWeb\AppWebEstudiantes\AppWebEstudiantes\Views\Carrera\IndexCarrera.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bfb69358e170fb23bd80580429d2e295af98e75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrera_IndexCarrera), @"mvc.1.0.view", @"/Views/Carrera/IndexCarrera.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carrera/IndexCarrera.cshtml", typeof(AspNetCore.Views_Carrera_IndexCarrera))]
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
#line 1 "C:\Users\Cruz Badillo\Documents\proyectos\gil\EstudiantesAppWeb\AppWebEstudiantes\AppWebEstudiantes\Views\_ViewImports.cshtml"
using AppWebEstudiantes;

#line default
#line hidden
#line 2 "C:\Users\Cruz Badillo\Documents\proyectos\gil\EstudiantesAppWeb\AppWebEstudiantes\AppWebEstudiantes\Views\_ViewImports.cshtml"
using AppWebEstudiantes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bfb69358e170fb23bd80580429d2e295af98e75", @"/Views/Carrera/IndexCarrera.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a658f66b2b01a14cc31408380594a4d991127d51", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrera_IndexCarrera : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Carrera>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Carrera/InsertarCarrera"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Cruz Badillo\Documents\proyectos\gil\EstudiantesAppWeb\AppWebEstudiantes\AppWebEstudiantes\Views\Carrera\IndexCarrera.cshtml"
  
    ViewData["Title"] = "IndexCarrera";

#line default
#line hidden
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(75, 803, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bfb69358e170fb23bd80580429d2e295af98e755198", async() => {
                BeginContext(81, 151, true);
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Carreras</h1>\r\n        <br />\r\n    </div>\r\n\r\n    <div class=\"row text-center\">\r\n        ");
                EndContext();
                BeginContext(232, 625, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bfb69358e170fb23bd80580429d2e295af98e755748", async() => {
                    BeginContext(287, 563, true);
                    WriteLiteral(@"
            <table border=""0"" class="" table table-borderless"">
                <tr>
                    <th>Carrera</th>
                    <th>Clave</th>
                    <th>Accion</th>
                </tr>
                <tr>
                    <td><input type=""text"" name=""nombreCarrera"" required /></td>
                    <td><input type=""text"" name=""clave"" required /></td>
                    <td><input type=""submit"" class=""btn btn-outline-success btn-sm"" value=""Insertar"" /></td>
                </tr>
            </table>
        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(857, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(878, 309, true);
            WriteLiteral(@"



<div class=""row text-center"">
    <table class="" table table-bordered"">
        <thead class=""thead-dark"">
            <tr>
                <th>Clave</th>
                <th>Carrera</th>
                <th>Accion</th>
            </tr>
        </thead>
        <tbody id=""tbody-carreras"">
");
            EndContext();
#line 43 "C:\Users\Cruz Badillo\Documents\proyectos\gil\EstudiantesAppWeb\AppWebEstudiantes\AppWebEstudiantes\Views\Carrera\IndexCarrera.cshtml"
             foreach (var i in Model)
            {

#line default
#line hidden
            BeginContext(1241, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1288, 14, false);
#line 46 "C:\Users\Cruz Badillo\Documents\proyectos\gil\EstudiantesAppWeb\AppWebEstudiantes\AppWebEstudiantes\Views\Carrera\IndexCarrera.cshtml"
                   Write(i.claveCarrera);

#line default
#line hidden
            EndContext();
            BeginContext(1302, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1334, 15, false);
#line 47 "C:\Users\Cruz Badillo\Documents\proyectos\gil\EstudiantesAppWeb\AppWebEstudiantes\AppWebEstudiantes\Views\Carrera\IndexCarrera.cshtml"
                   Write(i.nombreCarrera);

#line default
#line hidden
            EndContext();
            BeginContext(1349, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
            BeginContext(1515, 76, true);
            WriteLiteral("                        <button class=\"btn btn-danger btn-lg\" data-carrera=\"");
            EndContext();
            BeginContext(1592, 14, false);
#line 50 "C:\Users\Cruz Badillo\Documents\proyectos\gil\EstudiantesAppWeb\AppWebEstudiantes\AppWebEstudiantes\Views\Carrera\IndexCarrera.cshtml"
                                                                       Write(i.claveCarrera);

#line default
#line hidden
            EndContext();
            BeginContext(1606, 65, true);
            WriteLiteral("\" id=\"boton-eliminar\">Eliminar</button>\r\n                        ");
            EndContext();
            BeginContext(1671, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bfb69358e170fb23bd80580429d2e295af98e7511514", async() => {
                BeginContext(1775, 10, true);
                WriteLiteral("Actualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1680, "~/Carrera/IndexActualizarCarrera?guid=", 1680, 38, true);
#line 51 "C:\Users\Cruz Badillo\Documents\proyectos\gil\EstudiantesAppWeb\AppWebEstudiantes\AppWebEstudiantes\Views\Carrera\IndexCarrera.cshtml"
AddHtmlAttributeValue("", 1718, i.GUIDCarrera, 1718, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1789, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 54 "C:\Users\Cruz Badillo\Documents\proyectos\gil\EstudiantesAppWeb\AppWebEstudiantes\AppWebEstudiantes\Views\Carrera\IndexCarrera.cshtml"
            }

#line default
#line hidden
            BeginContext(1856, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Carrera>> Html { get; private set; }
    }
}
#pragma warning restore 1591
