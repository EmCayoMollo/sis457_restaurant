using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnRestaurant
{
 
        public class PlatillosCln
        {
            public static int insertar(Platillos platillos)
            {
                using (var context = new LabRestaurantEntities())
                {
                    context.Platillos.Add(platillos);
                    context.SaveChanges();
                    return platillos.id;
                }
            }

            public static int actualizar(Platillos platillos)
            {
                using (var context = new LabRestaurantEntities())
                {
                    var existente = context.Platillos.Find(platillos.id);
                    existente.codigo = platillos.codigo;
                    existente.nombre = platillos.nombre;
                    existente.precio = platillos.precio;
                    return context.SaveChanges();
                }
            }

            public static int eliminar(int id, string usuario)
            {
                using (var context = new LAbRestaurantEntities())
                {
                    var platillos = context.Platillos.Find(id);
                    platillos.estado = -1;
                    platillos.usuarioRegistro = usuario;
                    return context.SaveChanges();
                }
            }

            public static Platillos obtenerUno(int id)
            {
                using (var context = new LabRstaurantEntities())
                {
                    return context.Platillos.Find(id);
                }
            }

            public static List<Platillos> listar()
            {
                using (var context = new LabRestaurantEntities())
                {
                    return context.Platillos.Where(x => x.estado != -1).ToList();
                }
            }

            public static List<paProductoListar_Result> listarPa(string parametro)
            {
                using (var context = new LabRestaurantEntities())
                {
                    return context.paProductoListar(parametro).ToList();
                }
            }
        }
}
