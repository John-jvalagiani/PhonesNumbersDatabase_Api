using Aplication.Core.Data;
using Aplication.Core.Entities;
using Aplication.Core.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Core.Services.Implementation
{
    public class PhoneBaseService:Repository<PhoneNumber>, IPhoneBaseService
    {

        public PhoneBaseService(AplicationDbContext context):base(context)
        {
           
        }


        public async Task<IEnumerable<string>> GetPhoneNumberOwnerNames(string phone)
        {

            return await Task.FromResult(_set
                .Where(e => e.Phone.Equals(phone))
                .Select(e => e.OwnerName)
                .AsEnumerable());
        }

        public override async Task<bool> AddManyEntityAsync(IEnumerable<PhoneNumber> entities)
        {

            foreach (var item in entities)
            {

                await _set.AddAsync(item);
                
            }

              return  await  SaveChanges();

        }
    }
}
