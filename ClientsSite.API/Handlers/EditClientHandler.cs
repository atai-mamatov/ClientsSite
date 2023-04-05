using ClientsSite.Data.Database;
using ClientsSite.Data.Request;
using MediatR;

namespace ClientsSite.API.Handlers
{
    public class EditClientHandler : IRequestHandler<EditClientRequest, int>
    {
        private readonly AppDbContext _context;

        public EditClientHandler(AppDbContext context)
        {
            _context = context;
        }


        public async Task<int> Handle(EditClientRequest request, CancellationToken cancellationToken)
        {
            var client = await _context.Clients.FindAsync(request.Id);

            if (client == null)
            {
                return 0;
            }

            client.FirstName = request.FirstName;
            client.SecondName = request.SecondName;
            client.PhoneNum = request.PhoneNum;

            await _context.SaveChangesAsync();

            return client.Id;
        }


    }
}



