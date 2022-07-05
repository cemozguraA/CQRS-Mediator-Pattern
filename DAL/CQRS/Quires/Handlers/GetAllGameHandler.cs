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
    public class GetAllGameHandler : IRequestHandler<GetAllGameRequest, List<GetAllGameResponse>>
    {
        public async Task<List<GetAllGameResponse>> Handle(GetAllGameRequest request, CancellationToken cancellationToken)
        {
            return GameDbContext.Games.Select(game => new GetAllGameResponse
            {
                CreateTime = game.CreateTime,
                Description = game.Description,
                Id = game.Id,
                Name = game.Name,
                Price = game.Price,
                UpdateTime = game.UpdateTime
            }).ToList();
        }
    }
}
