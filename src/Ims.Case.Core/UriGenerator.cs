﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ims.Case.Entities;
using Ims.Case.Models;
using Ims.Case.Utilities;
using Microsoft.AspNetCore.Http;

namespace Ims.Case
{

    public class UriGenerator
    {
        private readonly IHttpContextAccessor _accessor;
        public UriGenerator(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string Generate<TEntity>(TEntity entity) where TEntity : ICFEntityType
        {
            var baseUrl = _accessor.BaseUrl();
            var identifier = entity.UUID();
            var name = typeof(TEntity).Name;
            return $"{baseUrl}/ims/case/v1p0/{name}/{identifier}";
        }
    }
}
