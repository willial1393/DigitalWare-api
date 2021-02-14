using System.Collections.Generic;
using System.Linq;
using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using DigitalWare.Infrastructure.Data;

namespace DigitalWare.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext _context;

        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        public Client GetClientById(int id)
        {
            return _context.Clients.Find(id);
        }

        public Client Create(Client client)
        {
            _context.Add(client);
            _context.SaveChanges();
            return client;
        }

        public Client Update(Client client)
        {
            _context.Update(client);
            _context.SaveChanges();
            return client;
        }
    }
}