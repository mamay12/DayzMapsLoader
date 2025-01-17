﻿using DayzMapsLoader.Application.Abstractions.Infrastructure.Repositories;
using DayzMapsLoader.Domain.Entities;
using DayzMapsLoader.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DayzMapsLoader.Infrastructure.Repositories
{
    public class MapProvidersRepository : BaseRepository<MapProvider>, IMapProvidersRepository
    {
        public MapProvidersRepository(DayzMapLoaderContext dayzMapLoaderContext)
            : base(dayzMapLoaderContext)
        {
        }

        public async Task<IEnumerable<MapProvider>> GetAllMapProvidersAsync()
            => await GetAll().ToListAsync();

        public async Task<MapProvider> GetProviderByIdAsync(int id)
            => (await GetAll().FirstOrDefaultAsync(x => x.Id == id))!;
    }
}