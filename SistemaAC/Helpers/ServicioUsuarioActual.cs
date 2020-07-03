﻿using Microsoft.AspNetCore.Http;
using System;

namespace ACTI.Helpers
{
    public class ServicioUsuarioActual : IServicioUsuarioActual
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public ServicioUsuarioActual(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }
        public string ObtenerNombreUsuarioActual()
        {
            return httpContextAccessor.HttpContext.User.Identity.Name;
        }
    }
}
