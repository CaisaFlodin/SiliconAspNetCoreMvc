using Infrastructure.Entities;
using Infrastructure.Models;
using Infrastructure.Models.Account;

namespace Infrastructure.Factories;

public class AddressFactory
{
    public static AddressEntity Create()
    {
        try
        {
            return new AddressEntity();
        }
        catch { }
        return null!;
    }

    public static AddressEntity Create(string addressLine_1, string addressLine_2, string postalCode, string city)
    {
        try
        {
            return new AddressEntity
            {
                AddressLine_1 = addressLine_1,
                AddressLine_2 = addressLine_2,
                PostalCode = postalCode,
                City = city
            };
        }
        catch { }
        return null!;
    }

    //public static AddressEntity Create(string addressLine_1, string addressLine_2, string postalCode, string city)
    //{
    //    try
    //    {
    //        return new AddressEntity
    //        {
    //            StreetName = streetName,
    //            PostalCode = postalCode,
    //            City = city
    //        };
    //    }
    //    catch { }
    //    return null!;
    //}

    public static AddressModel Create(AddressEntity entity)
    {
        try
        {
            return new AddressModel
            {
                Id = entity.Id,
                AddressLine_1 = entity.AddressLine_1,
                AddressLine_2 = entity.AddressLine_2,
                PostalCode = entity.PostalCode,
                City = entity.City
            };
        }
        catch { }
        return null!;
    }
}

//using Infrastructure.Entities;
//using Infrastructure.Models;
//using Infrastructure.Repositories;

//namespace Infrastructure.Factories;

//public class AddressFactory(AddressRepository addressRepository)
//{
//    private readonly AddressRepository _addressRepository = addressRepository;

//    public async Task<AccountDetailsAddressInfoModel> PopulateAddressInfoForm(UserEntity userEntity)
//    {
//        var result = await _addressRepository.GetOneAsync(x => x.Id == userEntity.AddressId);
//        var addressEntity = (AddressEntity)result.ContentResult!;
//        var model = new AccountDetailsAddressInfoModel();

//        if (addressEntity != null)
//        {
//            model.AddressLine_1 = addressEntity.AddressLine_1;
//            model.AddressLine_2 = addressEntity.AddressLine_2;
//            model.PostalCode = addressEntity.PostalCode;
//            model.City = addressEntity.City;
//        }
//        return model;
//    }

//    public AddressEntity PopulateAddressEntity(AccountDetailsAddressInfoModel model)
//    {
//        var entity = new AddressEntity();

//        if (model != null)
//        {
//            entity.AddressLine_1 = model.AddressLine_1;
//            entity.AddressLine_2 = model.AddressLine_2;
//            entity.City = model.City;
//            entity.PostalCode = model.PostalCode;
//        }

//        return entity;
//    }
//}
