using FacturaDom.BDO.Modelos;
using FacturaDom.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDom.BDO.Controladores
{
    public class clienteController
    {
        DBDataContext db = DBDataContext.Instance;
        public List<Cliente> obtenerClientes()
        {
            return db.Clientes.Where(a => a.Habilitado == true).ToList();
        } 

        public Cliente obtenerCliente(string Cedula)
        {
            return db.Clientes.Where(a => a.Cedula == Cedula).FirstOrDefault();
        }

        public List<Cliente> buscarClientes(string busqueda)
        {
            return db.Clientes.Where(a => a.CodigoCliente.Contains(busqueda) || a.Nombre.Contains(busqueda) || a.Apellido.Contains(busqueda)).Where(a=>a.Habilitado == true).ToList();
        }

        public List<Cliente> obtenerReferidos(string CedulaReferido)
        {
            return db.Clientes.Where(a => a.ClienteReferido.Equals(CedulaReferido)).ToList();
        }

        public decimal obtenerComprasCliente(string CedulaCliente)
        {
            return db.Factura.Where(a => a.CodigoCliente == CedulaCliente).Sum(a=>a.TotalFactura);
        }

        public bool actualizarCompras(string Cliente)
        {
            try
            {
                var cliente = db.Clientes.Find(Cliente);
                cliente.ComprasTotales = db.Factura.Where(a => a.CodigoCliente == Cliente).Sum(a => a.TotalFactura);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ingresarCliente(Cliente cliente)
        {
            try
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool editarCliente(string cedula, Cliente cliente)
        {
            try
            {
                var _cliente = db.Clientes.Find(cedula);
                _cliente.Nombre = cliente.Nombre;
                _cliente.Apellido = cliente.Apellido;
                _cliente.NumeroTelefono = cliente.NumeroTelefono;
                _cliente.fechaNacimiento = cliente.fechaNacimiento;
                _cliente.Direccion = cliente.Direccion;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarCliente(string Cedula)
        {
            try
            {
                var cliente = db.Clientes.Find(Cedula);
                cliente.Habilitado = false;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }   
    }
}
