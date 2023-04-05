using ClientsSite.Data.Models.Entities;
using MediatR;

namespace ClientsSite.Controllers.Command.CreateClient
{
    public class ClientCreateCommand : IRequest<Client>
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int PhoneNum { get; set; }
    }
}
