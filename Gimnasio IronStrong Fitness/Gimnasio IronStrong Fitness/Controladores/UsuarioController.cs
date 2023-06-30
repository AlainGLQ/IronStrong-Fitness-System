using Gimnasio_IronStrong_Fitness.Context;
using Gimnasio_IronStrong_Fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio_IronStrong_Fitness.Controladores
{
    internal class UsuarioController
    {
        //CRUD y Login
        ModelGimnasio _context= new ModelGimnasio();

        public bool Login(string usuario, string password)
        {
            var UsuarioLogin = _context.Usuario.Where(x => x.CuentaUsuario == usuario
                    && x.PasswordUsuario == password).SingleOrDefault();
            if (UsuarioLogin != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //CRUD
        //Para que devuelva todos los usuarios
        public List<Usuario> GetAll() 
        {
            return _context.Usuario.ToList();
        }

        //Para que devuelva solo un usuario a traves del primary key
        public Usuario Get(String NombreUsuario)
        {
            return _context.Usuario.Find(NombreUsuario); 
        }

        //Buscar
        public List<Usuario> Search(String par,bool op) {
            if (String.IsNullOrEmpty(par))
            {
                return GetAll();
            }
            else
            {
                if (op==false) //Si esta seleccionado Nombre
                {
                    //devuelve cualquier dato que minimamente coincida con la cadena ingresada
                    return _context.Usuario.Where(x => x.NombreUsuario.Contains(par) ||
                        x.NombreUsuario.Contains(par)).ToList();
                }
                else
                    return _context.Usuario.Where(x => x.CuentaUsuario.Contains(par) ||
                        x.CuentaUsuario.Contains(par)).ToList();
            }
        }

        //Crear, Actualizar y Eliminar
        public bool Create(Usuario usuario)
        {
            _context.Usuario.Add(usuario); //agregando la tabla de usuario
            return _context.SaveChanges() > 0; //guardando en la base de datos
        }

        public bool Update(Usuario usuario)
        {
            _context.Usuario.Attach(usuario); //busca en la tabla de usuario
            _context.Entry(usuario).State = System.Data.Entity.EntityState.Modified; //modifique al usuario en la base de datos
            return _context.SaveChanges() > 0; //guardando en la base de datos
        }

        public bool Delete(Usuario usuario) 
        {
            _context.Usuario.Remove(usuario); //lo busca y lo elimina en la base de datos
            return _context.SaveChanges() > 0; //guardando cambios en la base de datos
        }
    }
}
