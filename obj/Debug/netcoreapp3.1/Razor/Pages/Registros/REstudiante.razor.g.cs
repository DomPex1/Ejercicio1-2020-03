#pragma checksum "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e971eeb0bf180981a37c0b4ca5f1f67a2ae0475"
// <auto-generated/>
#pragma warning disable 1591
namespace Ejercicio1_2020_03.Pages.Registros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Prog. Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Prog. Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Prog. Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Prog. Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Prog. Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Prog. Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Prog. Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Prog. Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Ejercicio1_2020_03;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Prog. Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Ejercicio1_2020_03.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Estudiantes")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Estudiantes/{EstudianteId:int}")]
    public partial class REstudiante : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor"
                 Estudiantes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor"
                                             Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<div class=\"card-header\">\r\n            <h3>Registro de Estudiantes</h3>\r\n        </div>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-body");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "form");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-row align-items-center");
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col");
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.AddMarkupContent(25, "<label>EstudianteId</label>\r\n                            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "input-group");
                __builder2.AddMarkupContent(28, "\r\n                                ");
                __Blazor.Ejercicio1_2020_03.Pages.Registros.REstudiante.TypeInference.CreateInputNumber_0(__builder2, 29, 30, "form-control col-4", 31, 
#nullable restore
#line 20 "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor"
                                                          Estudiantes.EstudianteId

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Estudiantes.EstudianteId = __value, Estudiantes.EstudianteId)), 33, () => Estudiantes.EstudianteId);
                __builder2.AddMarkupContent(34, "\r\n                                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "input-group-append");
                __builder2.AddMarkupContent(37, "\r\n                                    ");
                __builder2.OpenElement(38, "button");
                __builder2.AddAttribute(39, "type", "button");
                __builder2.AddAttribute(40, "class", "btn btn-primary input-group-text");
                __builder2.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor"
                                                                                                             Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(42, "Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n                ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.AddMarkupContent(52, "<label>Nombres</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor"
                                            Estudiantes.Nombres

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Estudiantes.Nombres = __value, Estudiantes.Nombres))));
                __builder2.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Estudiantes.Nombres));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n                    ");
                __Blazor.Ejercicio1_2020_03.Pages.Registros.REstudiante.TypeInference.CreateValidationMessage_1(__builder2, 59, 60, 
#nullable restore
#line 33 "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor"
                                              () => Estudiantes.Nombres

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(61, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n                ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.AddMarkupContent(66, "<label>Semestre</label>\r\n                    ");
                __Blazor.Ejercicio1_2020_03.Pages.Registros.REstudiante.TypeInference.CreateInputNumber_2(__builder2, 67, 68, "form-control", 69, 
#nullable restore
#line 39 "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor"
                                              Estudiantes.Semestre

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Estudiantes.Semestre = __value, Estudiantes.Semestre)), 71, () => Estudiantes.Semestre);
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __Blazor.Ejercicio1_2020_03.Pages.Registros.REstudiante.TypeInference.CreateValidationMessage_3(__builder2, 73, 74, 
#nullable restore
#line 41 "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor"
                                              () => Estudiantes.Semestre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "    \r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "card-footer");
                __builder2.AddMarkupContent(81, "\r\n                    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group text-center");
                __builder2.AddAttribute(84, "display:", true);
                __builder2.AddAttribute(85, "inline-block", true);
                __builder2.AddMarkupContent(86, "\r\n                    ");
                __builder2.OpenElement(87, "button");
                __builder2.AddAttribute(88, "type", "button");
                __builder2.AddAttribute(89, "class", "btn btn-lg btn-primary");
                __builder2.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor"
                                                                                   Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(91, "Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                    ");
                __builder2.AddMarkupContent(93, "<button type=\"submit\" class=\"btn btn-lg btn-success\">Guardar</button>\r\n                    ");
                __builder2.OpenElement(94, "button");
                __builder2.AddAttribute(95, "type", "button");
                __builder2.AddAttribute(96, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor"
                                                                                  Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(98, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor"
       
    [Parameter]
    public int EstudianteId { get; set; }
    private Estudiantes Estudiantes = new Estudiantes();
    protected override void OnInitialized()
    {
        Nuevo();

        Buscar();
    }

    public void Nuevo()
    {
        Estudiantes = new Estudiantes();
    }

    private void Buscar()
    {
        if (Estudiantes.EstudianteId > 0)
        {
            var encontrado = Ejercicio1_2020_03.BLL.EstudiantesBLL.Buscar(Estudiantes.EstudianteId);

            if (encontrado != null)
                this.Estudiantes = encontrado;
            else
                toast.ShowWarning("No encontrado");
        }
    }

    public void Guardar()
    {
        bool guardo;
        guardo = Ejercicio1_2020_03.BLL.EstudiantesBLL.Guardar(Estudiantes);

        if (guardo)
        {
            Nuevo();
            toast.ShowSuccess("Guardado correctamente");
        }
        else
            toast.ShowError("No fue posible guardar");
    }

    public void Eliminar()
    {
        bool elimino;

        elimino = Ejercicio1_2020_03.BLL.EstudiantesBLL.Eliminar(Estudiantes.EstudianteId);

        if (elimino)
        {
            Nuevo();
            toast.ShowSuccess("Eliminado correctamente");
        }
        else
            toast.ShowError("No fue posible eliminar");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.Toast.Services.IToastService toast { get; set; }
    }
}
namespace __Blazor.Ejercicio1_2020_03.Pages.Registros.REstudiante
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
