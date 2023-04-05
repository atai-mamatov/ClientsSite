using ClientsSite.Data.Database;
using ClientsSite.Data.Models.Entities;
using MediatR;

namespace ClientsSite.Controllers.Command.CreateClient
{
    public class CreateClientCommandHandler 
        :IRequestHandler<ClientCreateCommand, Client>
    {
        private readonly AppDbContext _dbContext;

        public CreateClientCommandHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Client> Handle(ClientCreateCommand request,
            CancellationToken cancellationToken)
        {
            var client = new Client
            {
                FirstName = request.FirstName,
                SecondName = request.SecondName,
                PhoneNum = request.PhoneNum,
            };

            await _dbContext.Clients.AddAsync(client);
            await _dbContext.SaveChangesAsync();

            return client;

        }





    }












}
