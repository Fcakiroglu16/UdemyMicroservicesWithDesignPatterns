using EventSourcing.API.Commands;
using EventSourcing.API.EventStores;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EventSourcing.API.Handlers
{
    public class ChangeProductNameCommandHandler : IRequestHandler<ChangeProducNameCommand>
    {
        private readonly ProductStream _productStream;

        public ChangeProductNameCommandHandler(ProductStream productStream)
        {
            _productStream = productStream;
        }

        public async Task<Unit> Handle(ChangeProducNameCommand request, CancellationToken cancellationToken)
        {
            _productStream.NameChanged(request.ChangeProductNameDto);

            await _productStream.SaveAsync();

            return Unit.Value;
        }
    }
}