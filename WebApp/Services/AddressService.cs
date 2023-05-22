﻿using WebApp.Models.Entities;
using WebApp.Models.Identity;
using WebApp.Repositories.forUserContext;

namespace WebApp.Services
{
    public class AddressService
    {


        private readonly AddressRepository _addressRepo;
        private readonly UserAddressRepository _userAddressRepo;
        public AddressService(AddressRepository addressRepo, UserAddressRepository userAddressRepo)
        {
            _addressRepo = addressRepo;
            _userAddressRepo = userAddressRepo;
        }




        ////www.youtube.com/watch?v=yGpybKyQlHo 02:22
        public async Task<AddressEntity> GetOrCreateAsync(AddressEntity addressEntity)
        {
            var entity = await _addressRepo.GetAsync(x =>
                x.StreetName == addressEntity.StreetName &&
                x.PostalCode == addressEntity.PostalCode &&
                x.City == addressEntity.City
            );

                entity ??= await _addressRepo.AddAsync(addressEntity);
                return entity;
        }





        public async Task AddAddressAsync(AppUser user, AddressEntity addressEntity)
        {
            await _userAddressRepo.AddAsync(new UserAddressEntity
            {
                UserId = user.Id,
                AddressId = addressEntity.Id
            });
        }
    }
}
