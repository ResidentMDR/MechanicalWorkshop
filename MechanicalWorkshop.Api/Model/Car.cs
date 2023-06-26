﻿namespace MechanicalWorkshop.Api.Model
{
    public record Car
    {
        public int Id { get; init; }
        public string? VIN { get; init; }
        public string? BrandName { get; init; }
        public string? ModelName { get; init; }
    }
}