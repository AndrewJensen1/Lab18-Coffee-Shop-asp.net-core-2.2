#pragma checksum "C:\Users\Jense\source\repos\Lab18 Coffee Shop\Lab18 Coffee Shop\Views\CoffeeHouse\UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c1bf01c29f0835bdc9a709f0ddfca8e019666f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoffeeHouse_UserInfo), @"mvc.1.0.view", @"/Views/CoffeeHouse/UserInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoffeeHouse/UserInfo.cshtml", typeof(AspNetCore.Views_CoffeeHouse_UserInfo))]
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
#line 1 "C:\Users\Jense\source\repos\Lab18 Coffee Shop\Lab18 Coffee Shop\Views\_ViewImports.cshtml"
using Lab18_Coffee_Shop;

#line default
#line hidden
#line 2 "C:\Users\Jense\source\repos\Lab18 Coffee Shop\Lab18 Coffee Shop\Views\_ViewImports.cshtml"
using Lab18_Coffee_Shop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c1bf01c29f0835bdc9a709f0ddfca8e019666f", @"/Views/CoffeeHouse/UserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452971e30ed6b77f581da40272c8557c731fae19", @"/Views/_ViewImports.cshtml")]
    public class Views_CoffeeHouse_UserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab18_Coffee_Shop.Models.RegisterUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Jense\source\repos\Lab18 Coffee Shop\Lab18 Coffee Shop\Views\CoffeeHouse\UserInfo.cshtml"
  
    ViewData["Title"] = "UserInfo";

#line default
#line hidden
            BeginContext(92, 41, true);
            WriteLiteral("\r\n<h1>UserInfo</h1>\r\n\r\n<p>\r\n   USERNAME: ");
            EndContext();
            BeginContext(134, 14, false);
#line 10 "C:\Users\Jense\source\repos\Lab18 Coffee Shop\Lab18 Coffee Shop\Views\CoffeeHouse\UserInfo.cshtml"
        Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(148, 28, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n   FIRST NAME: ");
            EndContext();
            BeginContext(177, 15, false);
#line 13 "C:\Users\Jense\source\repos\Lab18 Coffee Shop\Lab18 Coffee Shop\Views\CoffeeHouse\UserInfo.cshtml"
          Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(192, 27, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n   LAST NAME: ");
            EndContext();
            BeginContext(220, 14, false);
#line 16 "C:\Users\Jense\source\repos\Lab18 Coffee Shop\Lab18 Coffee Shop\Views\CoffeeHouse\UserInfo.cshtml"
         Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(234, 23, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n   EMAIL: ");
            EndContext();
            BeginContext(258, 11, false);
#line 19 "C:\Users\Jense\source\repos\Lab18 Coffee Shop\Lab18 Coffee Shop\Views\CoffeeHouse\UserInfo.cshtml"
     Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(269, 31, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n   Date of Birth: ");
            EndContext();
            BeginContext(301, 9, false);
#line 22 "C:\Users\Jense\source\repos\Lab18 Coffee Shop\Lab18 Coffee Shop\Views\CoffeeHouse\UserInfo.cshtml"
             Write(Model.DOB);

#line default
#line hidden
            EndContext();
            BeginContext(310, 8, true);
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab18_Coffee_Shop.Models.RegisterUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
