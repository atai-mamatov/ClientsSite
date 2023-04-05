using ClientsSite.Data.Database;
using ClientsSite.Data.Request;
using MediatR;

namespace ClientsSite.API.Handlers
{

    public class DeleteClientHandler : IRequestHandler<DeleteClientRequest, int>
    {
        private readonly AppDbContext _context;

        public DeleteClientHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteClientRequest request, CancellationToken cancellationToken)
        {
            var client = await _context.Clients.FindAsync(request.Id);

            if (client == null)
            {
                return 0;
            }

            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();

            return client.Id;
        }
    }

}
