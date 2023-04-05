using ClientsSite.Data.Models.Common;
using ClientsSite.Data.Models.Entities;
using MediatR;

namespace ClientsSite.Data.Request
{
    public class CreateClientRequest : BaseEntity, IRequest<int>
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int PhoneNum { get; set; }
    }
}
