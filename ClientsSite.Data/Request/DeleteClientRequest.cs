using ClientsSite.Data.Models.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsSite.Data.Request
{
    public class DeleteClientRequest : BaseEntity, IRequest<int>
    {
        public int Id { get; set; }
    }
}
