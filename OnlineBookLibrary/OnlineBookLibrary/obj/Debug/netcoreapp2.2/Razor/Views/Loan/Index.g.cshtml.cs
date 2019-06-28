#pragma checksum "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\Loan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49c170c402bf1f99250372397077cf6e179a4c9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loan_Index), @"mvc.1.0.view", @"/Views/Loan/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Loan/Index.cshtml", typeof(AspNetCore.Views_Loan_Index))]
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
#line 1 "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\_ViewImports.cshtml"
using OnlineBookLibrary;

#line default
#line hidden
#line 2 "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\_ViewImports.cshtml"
using OnlineBookLibrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49c170c402bf1f99250372397077cf6e179a4c9c", @"/Views/Loan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c9c808d0f14d1988439e783d92f2e636d5ba8e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Loan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.LoanListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\Loan\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(79, 332, true);
            WriteLiteral(@"
<h2>Loans</h2>
<br>

<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Book</th>
            <th>UserName</th>
            <th>Date Loaned</th>
            <th>Date Returned</th>
            <th>Status</th>
            <th>Fine Paid</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 22 "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\Loan\Index.cshtml"
           
            foreach (var loan in Model.AllLoans)
            {

#line default
#line hidden
            BeginContext(489, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(536, 7, false);
#line 26 "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\Loan\Index.cshtml"
                   Write(loan.Id);

#line default
#line hidden
            EndContext();
            BeginContext(543, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(575, 14, false);
#line 27 "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\Loan\Index.cshtml"
                   Write(loan.Book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(589, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(621, 15, false);
#line 28 "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\Loan\Index.cshtml"
                   Write(loan.User.Email);

#line default
#line hidden
            EndContext();
            BeginContext(636, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(668, 13, false);
#line 29 "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\Loan\Index.cshtml"
                   Write(loan.LoanDate);

#line default
#line hidden
            EndContext();
            BeginContext(681, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(713, 17, false);
#line 30 "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\Loan\Index.cshtml"
                   Write(loan.DateReturned);

#line default
#line hidden
            EndContext();
            BeginContext(730, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(762, 11, false);
#line 31 "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\Loan\Index.cshtml"
                   Write(loan.Status);

#line default
#line hidden
            EndContext();
            BeginContext(773, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(805, 13, false);
#line 32 "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\Loan\Index.cshtml"
                   Write(loan.FinePaid);

#line default
#line hidden
            EndContext();
            BeginContext(818, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Nikola\source\repos\OnlineBookLibrary\OnlineBookLibrary\Views\Loan\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(874, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.LoanListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591