using ClientsSite.Data.Database;
using ClientsSite.Data.Models.Entities;
using ClientsSite.Data.Repository;
using ClientsSite.Data.Request;
using MediatR;

namespace ClientsSite.API.Handlers
{
    public class CreateClientHandler : IRequestHandler<CreateClientRequest, int>
    {

        private readonly AppDbContext _context;

        public CreateClientHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateClientRequest request, CancellationToken cancellationToken)
        {
            var client = new Client
            {
                FirstName = request.FirstName,
                SecondName = request.SecondName,
                PhoneNum = request.PhoneNum,
            };

            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();

            return client.Id;
        }

    }
}
