using DAL.CQRS.Quires.Request;
using DAL.CQRS.Quires.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Quires.Handlers
{
    public class GetByIdGameHandler : IRequestHandler<GetByIdGameRequest, GetByIdGameResponse>
    {
        public async Task<GetByIdGameResponse> Handle(GetByIdGameRequest request, CancellationToken cancellationToken)
        {
            GetByIdGameResponse response;
            var gameControl = GameDbContext.Games.Where(a => a.Id == request.Id).FirstOrDefault();
            if (gameControl != null)
                response = new()
                {
                    CreateTime = gameControl.CreateTime,
                    Description = gameControl.Description,
                    Id = gameControl.Id,
                    Name = gameControl.Name,
                    Price = gameControl.Price,
                    UpdateTime = gameControl.UpdateTime
                };
            else
                response = new GetByIdGameResponse();
            return response;
        }
    }
}
