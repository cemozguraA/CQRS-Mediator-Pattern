using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Commands.Handlers
{
    internal class DeleteGameHandler : IRequestHandler<DeleteGameRequest, DeleteGameResponse>
    {
        public async Task<DeleteGameResponse> Handle(DeleteGameRequest request, CancellationToken cancellationToken)
        {
            var dataControl = GameDbContext.Games.Where(a => a.Id == request.Id).FirstOrDefault();
            var response = new DeleteGameResponse();
            if(dataControl != null)
            {
                GameDbContext.Games.Remove(dataControl);
                response.IsSuccess = true;
                return response;
            }
            else
            {
                response.IsSuccess = false;
                return response;
            }
        }
    }
}
