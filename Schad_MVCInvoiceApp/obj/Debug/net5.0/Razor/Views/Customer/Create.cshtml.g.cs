#pragma checksum "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79be437250d849c1dcd130f976a5b9565f58697e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Create), @"mvc.1.0.view", @"/Views/Customer/Create.cshtml")]
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
#line 1 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\_ViewImports.cshtml"
using Schad_MVCInvoiceApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\_ViewImports.cshtml"
using Schad_MVCInvoiceApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79be437250d849c1dcd130f976a5b9565f58697e", @"/Views/Customer/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12790e5e35d9f59773084d4a0f4e212b3351e240", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Schad_MVCInvoiceApp.Entitades.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
  
    ViewBag.Title = "Create new Customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"viewbag-style\"><i>");
#nullable restore
#line 7 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
                        Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></h2>\r\n<div class=\"container\">\r\n");
#nullable restore
#line 9 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
     using (Html.BeginForm("Create", "Customer", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"form-group col-md-12\">\r\n                ");
#nullable restore
#line 13 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
           Write(Html.Label("Customer name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 14 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
           Write(Html.EditorFor(model => model.CustName, new { htmlAttributes = new { @class = "form-control", placeholder = "Write customer name." } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.CustName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                ");
#nullable restore
#line 18 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
           Write(Html.LabelFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 19 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
           Write(Html.EditorFor(model => model.Adress, new { htmlAttributes = new { @class = "form-control", placeholder = "Write customer adress." } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Adress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <div class=\"row\">\r\n                    <div class=\"form-group col-md-12\">\r\n                        ");
#nullable restore
#line 25 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
                   Write(Html.Label("Customer type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 26 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
                   Write(Html.DropDownListFor(model => model.CustomerTypeId, @ViewBag.CustomerTypeList as List<SelectListItem>, "Select Type", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 27 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.CustomerTypeId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-md-12\">\r\n                        ");
#nullable restore
#line 30 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
                   Write(Html.Label("Active"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 31 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
                   Write(Html.EditorFor(model => model.Status, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 32 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""form-group col-md-12"">
                <input type=""submit"" value=""Save Customer"" class=""btn btn-success btn-lg btn-block"" />
            </div>
        </div>
");
#nullable restore
#line 40 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        ");
#nullable restore
#line 44 "C:\Users\ingda\source\repos\Schad_MVC_Project\Schad_MVCInvoiceApp\Views\Customer\Create.cshtml"
   Write(Html.ActionLink("Atras", "Index", "Customer", new { id = "btnAtras" }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Schad_MVCInvoiceApp.Entitades.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
