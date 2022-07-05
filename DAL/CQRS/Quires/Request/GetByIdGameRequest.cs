using DAL.CQRS.Quires.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Quires.Request
{
    public class GetByIdGameRequest : IRequest<GetByIdGameResponse>
    {
        public Guid Id { get; set; }
    }
}
