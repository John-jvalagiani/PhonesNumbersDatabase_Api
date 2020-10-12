using Aplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Core.Services.Abstraction
{
   public interface IPhoneBaseService
    {

        Task<IEnumerable<string>> GetPhoneNumberOwnerNames(string phone);

    }
}
