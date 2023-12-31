﻿using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand createProductCommand)
        {
            _context.Products.Add(new Product
            {
                Name = createProductCommand.Name,
                Description = createProductCommand.Description,
                Price = createProductCommand.Price,
                Stock = createProductCommand.Stock,
                Status = true
            });

            _context.SaveChanges();
        }
    }
}
