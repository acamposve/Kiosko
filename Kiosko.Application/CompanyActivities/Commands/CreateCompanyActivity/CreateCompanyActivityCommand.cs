using Kiosko.Application.Common.Interfaces;
using Kiosko.Domain.Entities;
using Kiosko.Domain.Events;
using MediatR;

namespace Kiosko.Application.CompanyActivities.Commands.CreateCompanyActivity
{
    public record CreateCompanyActivityCommand : IRequest<int>
    {
        public string? ActivityName { get; init; }

        public string? ActivityDescription { get; init; }
    }

    public class CreateCompanyActivityCommandHandler : IRequestHandler<CreateCompanyActivityCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateCompanyActivityCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateCompanyActivityCommand request, CancellationToken cancellationToken)
        {
            var entity = new CompanyActivity
            {
                ActivityName = request.ActivityName,
                ActivityDescription = request.ActivityDescription
            };

            entity.AddDomainEvent(new CompanyActivityCreatedEvent(entity));

            _context.CompanyActivities.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }

}
