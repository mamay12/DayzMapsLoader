﻿using DayzMapsLoader.Application.Abstractions.Infrastructure.Repositories;
using DayzMapsLoader.Domain.Entities;
using DayzMapsLoader.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DayzMapsLoader.Infrastructure.Repositories
{
    public class MapsRepository : BaseRepository<Map>, IMapsRepository
    {
        public MapsRepository(DayzMapLoaderContext dayzMapLoaderContext)
            : base(dayzMapLoaderContext)
        {
        }

        public async Task<IEnumerable<Map>> GetAllMapsAsync()
            => await GetAll().ToListAsync();

        public async Task<Map> GetMapByIdAsync(int id)
            => (await GetAll().FirstOrDefaultAsync(x => x.Id == id))!;
    }
}