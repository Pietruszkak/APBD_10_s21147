﻿using APBD_10_s21147.Models;

namespace APBD_10_s21147.ResponseModels;

public class GetAccountResponseModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public string Role { get; set; }
    public IEnumerable<ShoppingCartResponseModel> Cart { get; set; } = [];
}