using FacturaDom.BDO.Modelos;
using FacturaDom.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Controladores
{
    public class articulosController
    {
        DBDataContext context = DBDataContext.Instance;

        public List<Articulo> obtenerArticulos()
        {
            return context.Articulo.ToList();
        }

        public List<Articulo> filtrarArticulosNombre(string nombre)
        {
            var articulo = context.Articulo
                .Where(a => a.Nombre.Contains(nombre))
                .ToList();

            return articulo;
        }

        public List<Articulo> filtrarArticulosCodigo(string Codigo)
        {
            var articulo = context.Articulo
                .Where(a => a.Codigo.Contains(Codigo))
                .ToList();

            return articulo;
        }

        public bool usarProducto(string codigo, int cantidad)
        {
            var articulo = context.Articulo.FirstOrDefault(a => a.Codigo == codigo);
            var usuario = context.Usuarios.Find(UserSession.Instance.UserCode);
            if (articulo != null && articulo.Stock >= cantidad)
            {
                articulo.Stock -= cantidad;
                context.SaveChanges();
                var movimiento = new Movimientos
                {
                    MovimientoId = DateTime.Now.ToString("ddmmyyMMhhss"),
                    Articulo = articulo,
                    Usuario = usuario,
                    FechaMovimiento = DateTime.Now,
                    Cantidad = cantidad,
                    Tipo = "Salida"
                };
                context.Movimientos.Add(movimiento);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool anadirProducto(string codigo, decimal cantidad)
        {
            var articulo = context.Articulo.FirstOrDefault(a => a.Codigo == codigo);
            var usuario = context.Usuarios.Find(UserSession.Instance.UserCode);
            if (articulo != null)
            {
                articulo.Stock += cantidad;
                context.SaveChanges();
                var movimiento = new Movimientos
                {
                    MovimientoId = DateTime.Now.ToString("ddmmyyMMhhss"),
                    Articulo = articulo,
                    Usuario = usuario,
                    FechaMovimiento = DateTime.Now,
                    Cantidad = cantidad,
                    Tipo = "Entrada"
                };
                context.Movimientos.Add(movimiento);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool anadirProducto(string codigo, decimal cantidad, decimal precio)
        {
            var usuario = context.Usuarios.Find(UserSession.Instance.UserCode);
            var articulo = context.Articulo.FirstOrDefault(a => a.Codigo == codigo);
            if (articulo != null)
            {
                articulo.Stock += cantidad;
                articulo.Precio = precio;
                context.SaveChanges();
                var movimiento = new Movimientos
                {
                    MovimientoId = DateTime.Now.ToString("ddmmyyMMhhss"),
                    Articulo = articulo,
                    Usuario = usuario,
                    FechaMovimiento = DateTime.Now,
                    Cantidad = cantidad,
                    Tipo = "Precio y Entrada"
                };
                context.Movimientos.Add(movimiento);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool cambiarPrecio(string codigo, decimal precio)
        {
            var usuario = context.Usuarios.Find(UserSession.Instance.UserCode);
            var articulo = context.Articulo.FirstOrDefault(a => a.Codigo == codigo);
            if (articulo != null)
            {
                articulo.Precio = precio;
                context.SaveChanges();
                var movimiento = new Movimientos
                {
                    MovimientoId = DateTime.Now.ToString("ddmmyyMMhhss"),
                    Articulo = articulo,
                    Usuario = usuario,
                    FechaMovimiento = DateTime.Now,
                    Cantidad = precio,
                    Tipo = "Precio"
                };
                context.Movimientos.Add(movimiento);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ingresarProducto(Articulo articulo, string UserCode, decimal cantidad, string tipo)
        {
            var usuario = context.Usuarios.FirstOrDefault(u => u.UserCode == UserCode);
            if (usuario != null)
            {
                context.Articulo.Add(articulo);
                context.SaveChanges();
                var movimiento = new Movimientos
                {
                    MovimientoId = DateTime.Now.ToString("ddmmyyMMttss"),
                    Articulo = articulo,
                    Usuario = usuario,
                    FechaMovimiento = DateTime.Now,
                    Cantidad = cantidad,
                    Tipo = tipo
                };
                context.Movimientos.Add(movimiento);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<MovimientoInventario> obtenerHistorial()
        {
            var movimientos = context.Movimientos.ToList();
            List<MovimientoInventario> movimientoInventarios = new List<MovimientoInventario>();
            foreach(var movimiento in movimientos)
            {
                movimientoInventarios.Add(
                    new MovimientoInventario
                    {
                        Codigo = movimiento.Articulo.Codigo,
                        Nombre = movimiento.Articulo.Nombre,
                        UserCode = movimiento.Usuario.UserCode,
                        UserName = movimiento.Usuario.UserName,
                        Cantidad = movimiento.Cantidad,
                        Tipo = movimiento.Tipo,
                        FechaMovimiento = movimiento.FechaMovimiento,
                        MovimientoId = movimiento.MovimientoId,
                    });
            }
            return movimientoInventarios;
        }
    }
}
