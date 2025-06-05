

using CRUMVVM.Models;
using SQLite;

namespace CRUMVVM.Services
{
    public class EmpleadoService
    {
        private readonly SQLiteConnection _connection;

        public EmpleadoService()
        {
            // Inicializamos la conexion a la base de datos SQLite
            // dbPath es la ruta donde se almacenara la base de datos
            //path.Combine es un metodo que nos permite combinar rutas de archivos
            //getFolderPath es un metodo que nos permite obtener la ruta de una carpeta de forma dinamica
            // se vera mas o menos asi: /adroid/data/data/com.companyname.crumvvm/files/empleados.db3
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "empleados.db3");
            //inicializamos la conexion a la base de datos SQLite
            _connection = new SQLiteConnection(dbPath);
            //creamos la tabla Empleado si no existe
            _connection.CreateTable<Empleado>();
        }

        public List<Empleado> GetAll()
        {
            // esto es equivalente a un select * from empleados
            return _connection.Table<Empleado>().ToList();
        }
        //metodo para ingresar un registro
        public int Insert(Empleado empleado)
        {
            // esto es equivalente a un insert into empleados values (empleado)
            return _connection.Insert(empleado);
        }
        //metodo para actualizar un registro
        public int Update(Empleado empleado)
        {
            // esto es equivalente a un update empleados set nombre = empleado.Nombre, direccion = empleado.Direccion, email = empleado.Email where id = empleado.Id
            return _connection.Update(empleado);
        }
        //metodo para eliminar un registro
        public int Delete(Empleado empleado)
        {
            // esto es equivalente a un delete from empleados where id = empleado.Id
            return _connection.Delete(empleado);
        }
    }
}
