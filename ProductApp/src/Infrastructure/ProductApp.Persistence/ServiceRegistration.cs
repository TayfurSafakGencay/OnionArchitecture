﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Persistence.Context;
using ProductApp.Persistence.Repositories;

namespace ProductApp.Persistence;

public static class ServiceRegistration
{
  public static void AddPersistenceService(this IServiceCollection serviceCollection)
  {
    serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("MemoryDb"));

    serviceCollection.AddTransient<IProductRepository, ProductRepository>();  
  }
}