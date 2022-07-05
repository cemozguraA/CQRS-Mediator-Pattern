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
    public class CreataGameHandler : IRequestHandler<CreateGameRequest, CreateGameResponse>
    {
        public async Task<CreateGameResponse> Handle(CreateGameRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            GameDbContext.Games.Add(new DATA.Game()
            {
                CreateTime = DateTime.Now,
                Description = request.Description,
                Name = request.Name,
                Id = id,
                Price = request.Price
            });
            return new CreateGameResponse() { Id = id, IsSuccess = true };
        }
    }
}
