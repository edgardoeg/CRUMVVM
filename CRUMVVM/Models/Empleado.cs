//aqui vamos a crear como una tabla, la vamos a necesitar como un objeto
//para almacenar la informacion como un objeto y poder manipularla

using SQLite;

namespace CRUMVVM.Models
{
    public class Empleado
    {
        // al abrir el primer corchete llamamos la libreria de SQLite
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        // queremos que el nombre sea obligatorio ponemos not null
        [NotNull]
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Email { get; set; }

    }
}
