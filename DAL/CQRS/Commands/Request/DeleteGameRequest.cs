using DAL.CQRS.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Commands.Request
{
    public class DeleteGameRequest : IRequest<DeleteGameResponse>
    {
        public Guid Id { get; set; }
    }
}
