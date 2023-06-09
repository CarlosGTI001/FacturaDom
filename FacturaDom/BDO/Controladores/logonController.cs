using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturaDom.BDO.Modelos;
using FacturaDom.Data;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;


namespace FacturaDom.BDO.Controladores
{
    
    public class logonController
    {
        DBDataContext db = DBDataContext.Instance;
        public logonController()
        {
            db.Database.EnsureCreated();
            if (db.Usuarios.Select(a=>a).Count() < 1)
            {
                db.Usuarios.Add(new Usuario
                {
                    UserCode = "US0001",
                    UserName = "Admin",
                    UserPass = "Admin",
                    Nombre = "",
                    Apellido = "",
                    Cedula = "",
                    Direccion = "",
                    CreateDate = DateTime.Now,
                    NumeroTelefono = ""
                });
                db.SaveChanges();
            }
        }

        public Usuario verificar(string usuario, string contrasena)
        {
            db.Database.EnsureCreated();
            var ver = db.Usuarios.Where(a => a.UserName == usuario && a.UserPass == contrasena).FirstOrDefault();
            if(ver != null && ver.Habilitado)
            {
                var codigo = DateTime.Now.ToString("ddMMyyyymmsshh");
                db.Sesiones.Add(new Sesiones
                {
                    usuario = ver,
                    entrada = DateTime.Now,
                    SesionId = codigo
                });
                UserSession.Instance.SessionId = codigo;
                db.SaveChanges();
            }
            return ver;
        }

        public List<Usuario> leerUsuarios()
        {
            return db.Usuarios.ToList();
        }

        public List<Usuario> filtrarUsuarios(string nombre, string codigo)
        {
            return db.Usuarios.Where(a => a.Habilitado == true && a.UserName == nombre || a.Nombre == nombre || a.Apellido == nombre || a.UserCode == codigo ).ToList();
        }

        public bool ingresarUsuarios(Usuario user)
        {
            try
            {
                db.Usuarios.Add(user);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        internal bool eliminarUsuario(string text)
        {
            try
            {
                db.Usuarios.Find(text).Habilitado = false;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool cambiarContrasena(string codigo, string contrasena)
        {
            try
            {
                db.Usuarios.Find(codigo).UserPass = contrasena;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void cerrarSeccion() {
            var salida = db.Sesiones.Find(UserSession.Instance.SessionId);
            salida.salida = DateTime.Now;
            db.Update(salida);
            db.SaveChanges();
        }

        public List<SesionesUsuario> obtenerSesiones()
        {
            var sesiones = db.Sesiones.ToList();
            List<SesionesUsuario> listaUsuarios = new List<SesionesUsuario>();
            foreach (var Sesion in sesiones)
            {
                var usr = db.Usuarios.Find(Sesion.usuario.UserCode);
                listaUsuarios.Add(new SesionesUsuario
                {
                    SesionID = Sesion.SesionId,
                    entrada = Sesion.entrada,
                    salida = Sesion.salida,
                    UserCode = Sesion.usuario.UserCode,
                    Nombre = usr.Nombre,
                    Apellido = usr.Apellido,
                    UserName = usr.UserName
                });
            }
            return listaUsuarios;
        }


    }

    
}

