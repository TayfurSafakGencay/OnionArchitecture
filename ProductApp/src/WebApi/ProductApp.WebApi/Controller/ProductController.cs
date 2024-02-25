﻿using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.WebApi.Controller;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
  private readonly IProductRepository productRepository;

  public ProductController(IProductRepository _productRepository)
  {
    productRepository = _productRepository;
  }

  [HttpGet]
  public async Task<IActionResult> Get()
  {
    var allList = await productRepository.GetAllAsync();
    var result = allList.Select(i => new ProductViewDto()
    {
      Id = i.Id,
      Name = i.Name
    }).ToList();

    return Ok(result);
  }
}