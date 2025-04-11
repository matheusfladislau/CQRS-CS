﻿using CQRSCS.Domain.Entities;
using MediatR;

namespace CQRSCS.Application.Products.Commands; 
public abstract class ProductCommand : IRequest<Product> {
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}
