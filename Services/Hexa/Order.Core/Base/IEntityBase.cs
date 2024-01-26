using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Services.Order.Core.Base
{
    public interface IEntityBase<T>
    {
        T Id { get; }
    }
}