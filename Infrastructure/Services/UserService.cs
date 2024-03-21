using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Models.Auth;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class UserService(UserRepository repository, UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
{
    private readonly UserRepository _repository = repository;
    private readonly UserManager<UserEntity> _userManager = userManager;
    private readonly SignInManager<UserEntity> _signInManager = signInManager;


    public async Task<ResponseResult> SignInUserAsync(SignInModel model)
    {
        try
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if (result.Succeeded)
                return ResponseFactory.Ok();

            return ResponseFactory.Error("Incorrect email or password");
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }

    public async Task<ResponseResult> CreateUserAsync(SignUpModel model)
    {
        try
        {
            var exists = await _userManager.Users.AnyAsync(x => x.Email == model.Email);
            if (exists)
                return ResponseFactory.Exists();
            else
            {
                var newUserEntity = UserFactory.Create(model);
                var result = await _userManager.CreateAsync(newUserEntity, model.Password);

                if (result.Succeeded)
                    return ResponseFactory.Ok("User was created successfully");
            }

            return ResponseFactory.Error("Something went wrong");
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }
}
