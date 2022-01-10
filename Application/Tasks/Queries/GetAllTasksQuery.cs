using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tasks.Queries
{
    public class GetAllTasksQuery : IRequest<List<TaskItem>>
    {

    }

    public class GetAllTasksHandler : IRequestHandler<GetAllTasksQuery, List<TaskItem>>
    {
        private readonly IAppDbContext _context;

        public GetAllTasksHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaskItem>> Handle(GetAllTasksQuery request, CancellationToken cancellationToken)
        {
            return await _context.Tasks.ToListAsync(cancellationToken);
        }
    }
}
