using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Models.Account;
using Infrastructure.Models.Auth;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Services;

//public class AddressService(AddressRepository repository)
//{
//    private readonly AddressRepository _repository = repository;

public class AddressService(DataContext context)
{
    private readonly DataContext _context = context;

    public async Task<AddressEntity> GetAddressAsync(string UserId)
    {
        var addressEntity = await _context.Addresses.FirstOrDefaultAsync(x => x.UserId == UserId);
        return addressEntity!;
    }

    public async Task<bool> CreateAddressAsync(AddressEntity entity)
    {
        _context.Addresses.Add(entity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateAddressAsync(AddressEntity entity)
    {
        var existing = await _context.Addresses.FirstOrDefaultAsync(x => x.UserId == entity.UserId);
        if (existing != null)
        {
            _context.Entry(existing).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        return false;
    }

    //public async Task<ResponseResult> GetOrCreateAddressAsync(string addressLine_1, string addressLine_2, string postalCode, string city)
    //{
    //    try
    //    {
    //        var result = await GetAddressAsync(addressLine_1, addressLine_2, postalCode, city);
    //        if (result.StatusCode == StatusCode.NOT_FOUND)
    //            result = await CreateAddressAsync(addressLine_1, addressLine_2, postalCode, city);

    //        return result;
    //    }
    //    catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    //}

    //public async Task<ResponseResult> GetAddressAsync(string userId)
    //{
    //    try
    //    {
    //        var result = await _repository.GetOneAsync(x => x.UserId == userId);
    //        if (result.StatusCode == StatusCode.OK)
    //        return ResponseFactory.Ok(result.ContentResult!, "Address found successfully");

    //        return ResponseFactory.NotFound("Address not found");
    //    }
    //    catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    //}



    //public async Task<ResponseResult> CreateAddressAsync(string addressLine_1, string addressLine_2, string postalCode, string city)
    //{
    //    try
    //    {
    //        var exists = await _repository.AlreadyExistsAsync(x => x.Addressline_1 == addressLine_1 && x.Addressline_2 == addressLine_2 && x.PostalCode == postalCode && x.City == city);
    //        if (exists == null)
    //        {
    //            var result = await _repository.CreateOneAsync(AddressFactory.Create(addressLine_1, addressLine_2, postalCode, city));
    //            if (result.StatusCode == StatusCode.OK)
    //                return ResponseFactory.Ok(AddressFactory.Create((AddressEntity)result.ContentResult!));

    //            return result;
    //        }

    //        return exists;
    //    }
    //    catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    //}


    //public async Task<ResponseResult> GetAddressAsync(string addressLine_1, string addressLine_2, string postalCode, string city)
    //{
    //    try
    //    {
    //        var result = await _repository.GetOneAsync(x => x.Addressline_1 == addressLine_1 && x.Addressline_2 == addressLine_2 && x.PostalCode == postalCode && x.City == city);
    //        return result;
    //    }
    //    catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    //}

    //public async Task<ResponseResult> UpdateAddressAsync(UseAddressModel addressModel)
    //{
    //    try
    //    {
    //        var existingAddress = await _repository.GetOneAsync(x => x.Us )
    //    }
    //    catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    //}
}

