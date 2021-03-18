using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public abstract class BaseRequest<TResponse> : IRequest<TResponse>
    {
        [JsonIgnore]
        public abstract string CacheKey { get; }

        [JsonIgnore]
        public virtual TimeSpan CacheTime { get; set; } = new (0, 30, 0);
    }
}
