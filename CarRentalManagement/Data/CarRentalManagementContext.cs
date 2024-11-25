﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore; 
using CarRentalManagement.Data; 
using CarRentalManagement.Configurations.Entities;
using CarRentalManagement.Domain; // shortens <CarRentalManagement.Domain.xxx> to <xxx>

namespace CarRentalManagement.Data 
{ 
    public class CarRentalManagementContext(DbContextOptions<CarRentalManagementContext> options) : 
IdentityDbContext<CarRentalManagementUser>(options) 
    { 
        public DbSet<Make> Make { get; set; } = default!; 
        public DbSet<Model> Model { get; set; } = default!; 
        public DbSet<Colour> Colour { get; set; } = default!; 
        public DbSet<Vehicle> Vehicle { get; set; } = default!; 
        public DbSet<Booking> Booking { get; set; } = default!; 
        public DbSet<CarRentalManagement.Domain.Customer> Customer { get; set; } = default!; 
        protected override void OnModelCreating(ModelBuilder builder) 
        { 
            base.OnModelCreating(builder); 
            builder.ApplyConfiguration(new ColourSeed()); 
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
        }
    } 
}