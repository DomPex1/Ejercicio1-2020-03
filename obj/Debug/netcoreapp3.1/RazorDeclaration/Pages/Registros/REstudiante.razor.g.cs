#pragma checksum "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7abfc238aba4de3a872c702ceb4b9c851db14cf0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Prog. Aplicada2\Ejercicio1-2020-03\Pages\Registros\REstudiante.razor"
       
    [Parameter]
    public int EstudianteId { get; set; }
    private Estudiantes estudiante = new Estudiantes();
    protected override void OnInitialized()
    {
        Nuevo();

        Buscar();
    }

    public void Nuevo()
    {
        estudiante = new Estudiantes();
    }

    private void Buscar()
    {
        if (estudiante.EstudianteId > 0)
        {
            var encontrado = Ejercicio1_2020_03.BLL.EstudiantesBLL.Buscar(estudiante.EstudianteId);

            if (encontrado != null)
                this.estudiante = encontrado;
            else
                toast.ShowWarning("No encontrado");
        }
    }

    public void Guardar()
    {
        bool guardo;
        guardo = Ejercicio1_2020_03.BLL.EstudiantesBLL.Guardar(estudiante);

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

        elimino = Ejercicio1_2020_03.BLL.EstudiantesBLL.Eliminar(estudiante.EstudianteId);

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
#pragma warning restore 1591
