#pragma checksum "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aeba19b6b1c4e796dfc0574430098a6d9cea9dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RazorDemo), @"mvc.1.0.view", @"/Views/Home/RazorDemo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aeba19b6b1c4e796dfc0574430098a6d9cea9dc", @"/Views/Home/RazorDemo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fa67a6e796651e81a8dde168857e16841b36e53", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RazorDemo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<udemy_deneme1.EmployeeListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aeba19b6b1c4e796dfc0574430098a6d9cea9dc3587", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>RazorDemo</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aeba19b6b1c4e796dfc0574430098a6d9cea9dc4650", async() => {
                WriteLiteral("\r\n    <p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aeba19b6b1c4e796dfc0574430098a6d9cea9dc4927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Name</th>\r\n                <th>Surname</th>\r\n                <th>Number</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
             foreach (var item in Model.Employee)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
                   Write(item.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
                   Write(item.Number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <br />\r\n    hello I am serhat and I am ");
                WriteLiteral("@home\r\n    <br />\r\n    <p>");
#nullable restore
#line 42 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
  Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 43 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
      
        var date = DateTime.Now - TimeSpan.FromDays(3);
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <p>3 days ago was ");
#nullable restore
#line 46 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
                 Write(date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 47 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
      
        var number = 20;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <p>");
#nullable restore
#line 50 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
  Write(number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 52 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
     if (number < 10)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>The number is less than 10 </p>\r\n");
#nullable restore
#line 55 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
    }

    else if (number == 10)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>The number is equal to 10 </p>\r\n");
#nullable restore
#line 60 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>The number is greater than 10 </p>\r\n");
#nullable restore
#line 64 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
     for (int i = 0; i < Model.Employee.Count; i++)
     {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br /><b>");
#nullable restore
#line 67 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
            Write(Model.Employee[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b> \r\n");
#nullable restore
#line 68 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
     try
    {

    }
    catch (ArgumentNullException ex)
    {

        throw;
    }
    catch (Exception e)
    {
        throw;
    }
    finally
    {

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("         <input type=\"text\",");
                BeginWriteAttribute("id", " id=\"", 1700, "\"", 1705, 0);
                EndWriteAttribute();
                WriteLiteral(",");
                BeginWriteAttribute("name", " name=\"", 1707, "\"", 1714, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n         <button type=\"submit\"></button>\r\n");
#nullable restore
#line 91 "C:\Users\Nilvera\source\repos\udemy_deneme1\udemy_deneme1\Views\Home\RazorDemo.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<udemy_deneme1.EmployeeListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
