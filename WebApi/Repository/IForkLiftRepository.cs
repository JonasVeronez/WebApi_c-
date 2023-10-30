
using forkLift.Model;

namespace forklift.Repository
{
    public interface IForkLiftRepository
    {
        Task<IEnumerable<ForkLift>> BuscarForkLift();
        Task<ForkLift> BuscarForkLift(int Id);
        void AdicionaForkLift(ForkLift forkLift);
        void AtualizaForkLift(ForkLift forkLift);
        void DeleteForkLift(ForkLift forkLift);

        Task<bool> SaveChangesAsync();
    }
}