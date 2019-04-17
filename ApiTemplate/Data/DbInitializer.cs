using ApiTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiTemplate.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ITILContext context)
        {
            if (context.Usuarios.Any())
            {
                return;
            }

            Usuario usuario = new Usuario
            {
                Login = "admin",
                Senha = "admin",
                Nome = "Administrador",
                Email = "theusccs111@gmail.com",
            };

            context.Add(usuario);
            context.SaveChanges();
        }
    }
}
