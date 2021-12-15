using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Tasks.Commands
{
    public class CreateTaskCommand : IRequest<int>
    {
        public TaskItem TaskItem { get; set; }
        public CreateTaskCommand(TaskItem taskItem)
        {
            TaskItem = taskItem;
        }
    }
    public class CreateProductHandler : IRequestHandler<CreateTaskCommand, int>
    {
        private readonly IAppDbContext _context;

        public CreateProductHandler(IAppDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            _context.Tasks.Add(request.TaskItem);
            return await _context.SaveChangesAsync(cancellationToken);            
        }
    }
}
