using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forklift.Repository;
using forkLift.Data;
using forkLift.Model;

namespace WebApi.Repository
{
    public class ForkLiftRepository : IForkLiftRepository
    {
        public ForkLiftContext _context;

        public ForkLiftRepository(ForkLiftContext context)
        {
            _context = context;
            
        }
         public Task<IEnumerable<ForkLift>> BuscarForkLift()
        {
            throw new NotImplementedException();
        }
        
        public Task<ForkLift> BuscarForkLift(int Id)
        {
            throw new NotImplementedException();
        }
        public void AdicionaForkLift(ForkLift forkLift)
        {
            _context.Add(forkLift);
        }

        public void AtualizaForkLift(ForkLift forkLift)
        {
            throw new NotImplementedException();
        }




        public void DeleteForkLift(ForkLift forkLift)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return  await _context.SaveChangesAsync() > 0;
        }
    }
}