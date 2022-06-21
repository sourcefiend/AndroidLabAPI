using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Cars.Queries;

public record GetCarsQuery : IRequest<List<Car>>;
public class GetCarsQueryHandler : IRequestHandler<GetCarsQuery, List<Car>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetCarsQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<Car>> Handle(GetCarsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Cars.ToListAsync();
       
    }
}
