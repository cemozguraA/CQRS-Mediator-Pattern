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
    public class UpdateGameHandler : IRequestHandler<UpdateGameRequest, UpdateGameResponse>
    {
        public async Task<UpdateGameResponse> Handle(UpdateGameRequest request, CancellationToken cancellationToken)
        {
            UpdateGameResponse response;
            var gameControl = GameDbContext.Games.Where(x => x.Id == request.Id).FirstOrDefault();
            if (gameControl != null)
            {
                gameControl.Description = request.Description;
                gameControl.Name = request.Name;
                gameControl.Price = request.Price;
                gameControl.UpdateTime = DateTime.Now;
                return response = new UpdateGameResponse() { IsSuccess = true };
            }
            else
                return response = new UpdateGameResponse() { IsSuccess = false };
        }
    }
}
