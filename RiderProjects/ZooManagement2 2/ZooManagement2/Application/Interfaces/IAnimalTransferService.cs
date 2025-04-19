using ZooManagement2.Domain.ValueObjects;

namespace ZooManagement2.Application.Interfaces
{
    public interface IAnimalTransferService
    {
        void Transfer(AnimalId animalId, EnclosureId toEnclosureId);
    }
}