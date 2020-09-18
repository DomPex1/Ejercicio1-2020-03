using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
public class Estudiantes{
    [Key]
    public int EstudianteId{get; set;}

    [Required(ErrorMessage ="Es obligatorio introducir el nombre")]
    public string Nombres{get; set;}
    public int Semestre{get; set;}

            [ForeignKey("EstudianteId")]
        public virtual List<EstudiantesDetalle> EstudiantesDetalle { get; set; } = new List<EstudiantesDetalle>();
}

public class EstudiantesDetalle
    {
        [Key]
        public int  Id { get; set; }
 
        public int EstudianteId { get; set; }
    }