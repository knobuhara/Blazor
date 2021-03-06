#pragma checksum "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/Pages/Upload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54b110ce4445d6c6ee0a2f2066685e016ad5c6ef"
// <auto-generated/>
#pragma warning disable 1591
namespace EgaoBlazorProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using EgaoBlazorProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using EgaoBlazorProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using EgaoBlazorProject.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using ClosedXML;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using ClosedXML.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Upload")]
    public partial class Upload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Excel file upload test</h1>\n\n<hr>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(1);
            __builder.AddAttribute(2, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 7 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/Pages/Upload.razor"
                      FileUpload

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n<hr>\n\n\n");
            __builder.AddMarkupContent(4, "<h4>???????????????Excel?????????????????????</h4>\n");
            __builder.OpenElement(5, "div");
#nullable restore
#line 14 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/Pages/Upload.razor"
     foreach (var result in _ResultList)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, 
#nullable restore
#line 16 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/Pages/Upload.razor"
         result

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "<br>");
#nullable restore
#line 18 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/Pages/Upload.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 20 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/Pages/Upload.razor"
 if (flag)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<EgaoBlazorProject.Pages.Shift>(8);
            __builder.CloseComponent();
#nullable restore
#line 23 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/Pages/Upload.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Volumes/Data/src/visualStudio/EgaoBlazorProject/EgaoBlazorProject/Pages/Upload.razor"
       
    private List<string> _ResultList = new List<string>();

    private List<IBrowserFile> _BrowserFileList = new List<IBrowserFile>();

    private bool flag = false;

    private async Task FileUpload(InputFileChangeEventArgs e)
    {
        try
        {
            _BrowserFileList.Clear();
            foreach (var file in e.GetMultipleFiles())
            {
                _BrowserFileList.Add(file);
            }

            _ResultList = new();
            foreach (var file in _BrowserFileList)
            {
                _ResultList.Add(file.Name + "???" + file.Size.ToString() + "byte");

                var excelFileData = new byte[file.Size];
                await file.OpenReadStream(file.Size).ReadAsync(excelFileData);

                //???????????????????????????Excel??????????????????WEB???????????????????????????
                var tempFilePath = Path.GetTempFileName() + ".xlsx";

                //???????????????????????????Excel??????????????????WEB???????????????????????????
                using (var fileStream = new FileStream(tempFilePath, FileMode.Create))
                using (var binaryWriter = new BinaryWriter(fileStream))
                {
                    binaryWriter.Write(excelFileData);
                }

                // ???????????????????????????
                var worksheetNameList = new List<string>();
                using (var workbook = new XLWorkbook(tempFilePath))
                {
                    foreach (var worksheet in workbook.Worksheets)
                    {
                        // Excel?????????????????????????????????????????????????????????
                        worksheetNameList.Add(worksheet.Name);
                        _ResultList.Add("????????????????????????" + worksheet.Name);
                        _ResultList.Add("A1?????? ????????????" + worksheet.Cell("A1").GetString());
                    }
                }

                flag = true;
                File.Delete(tempFilePath);
            }
        }
        catch (Exception ex)
        {
            var a = ex.Message;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
