﻿using LibClass;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Class1 : ICapaDatos
    {

        private List<Usuario> usuarios = new List<Usuario>();
        private List<Entrada> entradas = new List<Entrada>();

        public bool borrarEntrada(int idEntrada)
        {
            foreach (Entrada entrada in entradas)
            {
                if (entrada.IdEntrada == idEntrada)
                {
                    return entradas.Remove(entrada);
                }
            }
            return false;
        }

        public bool borrarEntradasDeUsuario(Usuario usuario)
        {
            bool hayEntradasEncontradas = false;
            foreach (Entrada entrada in entradas)
            {
                if (entrada.Usuario == usuario)
                {
                    entradas.Remove(entrada);
                    hayEntradasEncontradas = true;
                }
            }
            return hayEntradasEncontradas;
        }

        public bool BorraUsuario(int idUsuario)
        {
            foreach (Usuario usuario in usuarios) {
                if (usuario.IdUsuario == idUsuario) {
                    BorrarAcesosUsuario(usuario);
                    borrarEntradasDeUsuario(usuario);
                    return usuarios.Remove(usuario);
                }
            }
            return false;
        }

        private void BorrarAcesosUsuario(Usuario usuario)
        {
            foreach(Entrada entrada in entradas)
            {
                entrada.eleminarAccesoAUsuario(usuario);
            }
        }

        public bool BorraUsuario(string nombre)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nombre == nombre){
                    return usuarios.Remove(usuario);
                }
            }
            return false;
        }

        public Usuario getUsuario(string nombre)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nombre == nombre)
                {
                    return usuario;
                }
            }
            return null;
        }

        public Usuario getUsuario(int idUsuario)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.IdUsuario == idUsuario)
                {
                    return usuario;
                }
            }
            return null;
        }

        public int NumeroUsuarios()
        {
            return usuarios.Count;
        }

        public void anadirUsuario(Usuario usuario) {
            usuarios.Add(usuario);
        }

        bool ICapaDatos.anadirUsuario(string nombre, string email, bool esGestor, string contrasena)
        {
            if (!new EmailAddressAttribute().IsValid(email))
                return false;
            if (existeUsuario(email))
                return false;
            if (!Util.comprobarContrasena(contrasena))
                return false;

            usuarios.Add(new Usuario(usuarios.Count, nombre, email, esGestor, Util.Encriptar(contrasena)));
            return true;
        }

        private bool existeUsuario(int idUsuario) {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.IdUsuario == idUsuario)
                {
                    return true;
                }
            }
            return false;
        }

        private bool existeUsuario(string email)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
    }


}