using ClientsSite.Data.Models.Common;
using ClientsSite.Data.Models.Entities;
using MediatR;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsSite.Data.Request 
{
    public class EditClientRequest : BaseEntity, IRequest<int>
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int PhoneNum { get; set; }
    }
}
