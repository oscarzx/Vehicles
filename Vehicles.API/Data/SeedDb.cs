﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeddAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckVehiclesTypeAsync();
            await CheckBrandsTypeAsync();
            await CheckDocumentTypeAsync();
            await CheckProceduresTypeAsync();
        }

        private async Task CheckProceduresTypeAsync()
        {
            if (!_context.Procedures.Any())
            {
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Alineación" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Lubricación de suspención delantera" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Lubricación de suspención trasera" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Frenos delanteros" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Frenos traseros" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Líquido de frenos delanteros" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Líquido de frenos traseros" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Calibración de válvulas" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Alineación carburador" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Aceite motor" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Aceite caja" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Filtro de aire" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Sistema electrico" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Guayas" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio llanta delantera" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio llanta trasera" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Reparación de motor" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Kit arrastre" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Banda transmisión" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio batería" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Lavado sistema de inyección" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Lavada de tanque" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio de bujia" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio rodamiento delantero" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio rodamiento trasero" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Accesorios" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckDocumentTypeAsync()
        {
            if (!_context.DocumentTypes.Any())
            {
                _context.DocumentTypes.Add(new DocumentType { Description = "Cédula" });
                _context.DocumentTypes.Add(new DocumentType { Description = "Nit" });
                _context.DocumentTypes.Add(new DocumentType { Description = "Pasaporte" });
                _context.DocumentTypes.Add(new DocumentType { Description = "Tarjeta de Identidad" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckBrandsTypeAsync()
        {
            if (!_context.Brands.Any())
            {
                _context.Brands.Add(new Brand { Description = "Ducati" });
                _context.Brands.Add(new Brand { Description = "Harley Davidson" });
                _context.Brands.Add(new Brand { Description = "KTM" });
                _context.Brands.Add(new Brand { Description = "BMW" });
                _context.Brands.Add(new Brand { Description = "Triumph" });
                _context.Brands.Add(new Brand { Description = "Victoria" });
                _context.Brands.Add(new Brand { Description = "Honda" });
                _context.Brands.Add(new Brand { Description = "Suzuki" });
                _context.Brands.Add(new Brand { Description = "Kawasaki" });
                _context.Brands.Add(new Brand { Description = "TVS" });
                _context.Brands.Add(new Brand { Description = "Bajaj" });
                _context.Brands.Add(new Brand { Description = "AKT" });
                _context.Brands.Add(new Brand { Description = "Yamaha" });
                _context.Brands.Add(new Brand { Description = "Chevrolet" });
                _context.Brands.Add(new Brand { Description = "Mazda" });
                _context.Brands.Add(new Brand { Description = "Renault" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckVehiclesTypeAsync()
        {
            if (!_context.VehicleTypes.Any())
            {
                _context.VehicleTypes.Add(new VehicleType { Description = "Carro" });
                _context.VehicleTypes.Add(new VehicleType { Description = "Moto" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
