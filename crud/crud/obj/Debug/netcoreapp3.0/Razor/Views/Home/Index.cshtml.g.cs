#pragma checksum "D:\proyecto\pruebaRepos2022\crud\crud\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e3507f3d9afea456988caad7c5a7ebaddfe6128"
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
#line 1 "D:\proyecto\pruebaRepos2022\crud\crud\Views\_ViewImports.cshtml"
using crud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\proyecto\pruebaRepos2022\crud\crud\Views\_ViewImports.cshtml"
using crud.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e3507f3d9afea456988caad7c5a7ebaddfe6128", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2c8bffb20ac4f86ad95d459398e060b917a66b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-on:submit.prevent", new global::Microsoft.AspNetCore.Html.HtmlString("agregarNuevo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\proyecto\pruebaRepos2022\crud\crud\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Parking Serpost</h1>
    <p>Acerca de nosotros <a href=""https://docs.microsoft.com/aspnet/core"">Serpost.com</a>.</p>
</div>
<!-- CSS only -->
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
<script src=""https://cdn.jsdelivr.net/npm/vue@2.6.12/dist/vue.js""></script>

<div id=""crud"" class=""d-flex justify-content-between d-flex align-items-center"" >
   
    <div  class=""col-md-3 card border-secondary mb-3 "" >
        <br />
        <div class=""card text-white bg-dark mb-3"">
            <h2 class=""card-header"">Ingrese sus datos</h2>
        </div>
        <br />
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e3507f3d9afea456988caad7c5a7ebaddfe61284530", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <div>         
                    <label for=""formGroupExampleInput"">Propietario</label>
                    <input type=""text"" v-model=""nombre"" class=""form-control"" id=""formGroupExampleInput"" placeholder=""Juan"" v-on:keyup=""validar()"">
                </div>
                <div v-if=""alerta"">
                    <div class=""alert alert-danger"" role=""alert"" >
                        Este campo es necesario
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <div>
                    <label for=""formGroupExampleInput"">Vehiculo</label>
                    <input type=""text"" v-model=""vehiculo"" class=""form-control"" id=""formGroupExampleInput"" placeholder=""Toyota"">
                </div>
                <div v-if=""alerta"">
                    <div class=""alert alert-danger"" role=""alert"">
                        Este campo es necesario
                    </div>
          ");
                WriteLiteral(@"      </div>
            </div>
            <div class=""form-group"">
                <div>
                    <label for=""formGroupExampleInput"">Numero de placa</label>
                <input type=""text"" v-model=""matricula"" class=""form-control"" id=""formGroupExampleInput"" placeholder=""BO-9958"">
                </div>
                <div v-if=""alerta"">
                    <div class=""alert alert-danger"" role=""alert"">
                        Este campo es necesario
                    </div>
                </div>
            </div>
            <div>
                <button type=""submit"" value=""Agregar"" class=""btn btn-primary"" v-on:click=""contador++"">Agregar</button>
            </div>
            <br />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n   \r\n");
            WriteLiteral("    <div  class=\"col-md-9\" >\r\n");
            WriteLiteral(@"        <div class=""d-flex justify-content-end"" >
            <div class=""col"">
                <input type=""text"" class=""form-control"" placeholder=""Buscar..."">
            </div>
            <button class=""btn btn-dark"">Buscar</button>
        </div>
        <br />
");
            WriteLiteral(@"        <h2>Usuarios</h2>
        <table  class=""table table table-striped"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Indice</th>
                    <th scope=""col"">Propietario</th>
                    <th scope=""col"">Vehiculo</th>
                    <th scope=""col"">Matricula</th>
                    <th scope=""col"" class=""d-flex justify-content-center"" >Acci??n</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for=""(usuario,index) in usuarios"">
                    <td>{{index}}</td>
                    <td>
                        <span v-if=""formActualizar  && idActualizar == index"">
                            <input type=""text"" name=""name""");
            BeginWriteAttribute("value", " value=\"", 3818, "\"", 3826, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-model=""nombreActualizar"" />
                        </span>
                        <span v-else>
                            {{usuario.nombre}}
                        </span>
                    </td>
                    <td>
                        <span v-if=""formActualizar && idActualizar == index"">
                            <input type=""text"" name=""name""");
            BeginWriteAttribute("value", " value=\"", 4202, "\"", 4210, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-model=""vehiculoActualizar"" />
                        </span>
                        <span v-else>
                            {{usuario.vehiculo}}
                        </span>
                    </td>
                    <td>
                        <span v-if=""formActualizar && idActualizar == index"">
                            <input type=""text"" name=""name""");
            BeginWriteAttribute("value", " value=\"", 4590, "\"", 4598, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-model=""matriculaActualizar"" />
                        </span>    
                        <span v-else>
                            {{usuario.matricula}}
                        </span>
                    </td>

                    <td class=""d-flex justify-content-center"">
                        <span v-if=""formActualizar && idActualizar == index"">
                            <button v-on:click=""modificarUsuario(index)"" class=""btn btn-success"">Guardar</button>
                        </span>
                        <span v-else>
                            <button v-on:click=""borrarUsuario(index),contador--"" class=""btn btn-danger"">Eliminar</button>
                            <button v-on:click=""verFormulario(index)"" class=""btn btn-warning"">Modificar</button>
                        </span>
                       

                    </td>
                </tr>
                <tr>
                </tr>
            </tbody>
        </table>
");
            WriteLiteral(@"        <div>
            <h3>Espacio Ocupados</h3>
            <div class=""progress"">
                <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 20%"" aria-valuenow=""10"" aria-valuemin=""0"" aria-valuemax=""100"">{{contador}}%</div>
            </div>
        </div>
    </div>

</div>

<script>
    var app = new Vue({
        el: '#crud',
        data: {
            nombre: '',
            matricula: '',
            formActualizar: false,
            nombreActualizar: '',
            vehiculoActualizar:'',
            matriculaActualizar: '',
            idActualizar: -1,
            alerta: false,
            contador:3,
            usuarios: [{
                nombre: 'Juan',
                vehiculo:'Toyota',
                matricula: 'BO-9958'
            }, {
                nombre: 'Kevin',
                vehiculo:'Porshe',
                matricula: 'BX-666'
                },
                {
                nombre: 'Michael',
      ");
            WriteLiteral(@"          vehiculo:'Nissan',
                matricula: 'AF-849'
                }]
        },
        methods: {
             agregarNuevo: function (e) {
                if (this.nombre == '' || this.vehiculo =='' || this.matricula =='' ) {
                    this.alerta = true;
                    e.preventDefault();
                } else {
                    this.alerta = false;
                    this.usuarios.push({
                    nombre: this.nombre,
                    vehiculo:this.vehiculo,
                    matricula: this.matricula
                })
                this.nombre = '';
                this.vehiculo = '';
                this.matricula = '';
                }
                
            },
            borrarUsuario: function (index) {
                this.usuarios.splice(index, 1)
            },
            //ver los datos en el formulario
            verFormulario: function (index) {
                this.idActualizar=index,
                thi");
            WriteLiteral(@"s.nombreActualizar = this.usuarios[index].nombre;
                this.vehiculoActualizar = this.usuarios[index].vehiculo;
                this.matriculaActualizar = this.usuarios[index].matricula;
                this.formActualizar=true
            },
            modificarUsuario: function (index) {
                    this.formActualizar=false,
                    this.usuarios[index].nombre = this.nombreActualizar,
                    this.usuarios[index].vehiculo = this.vehiculoActualizar,
                    this.usuarios[index].matricula = this.matriculaActualizar
            }      
        }
        //computed: {
        //    usuarios() {
        //        return this.usuarios.filter (u =>u.nombre.includes(this.filtrar))
        //    }
        //}
    })
</script>
<!-- JavaScript Bundle with Popper -->
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" cros");
            WriteLiteral("sorigin=\"anonymous\"></script>");
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
