using System.Collections.Generic;
using DigitalWare.Core.Entities;

namespace DigitalWare.Core.Interfaces
{
    public interface IClientRepository
    {
        public IEnumerable<Client> GetClients();
        public Client GetClientById(int id);
        public Client Create(Client client);
        public Client Update(Client client);
    }
}