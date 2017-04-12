using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BitBookWebApplication.Models;
using BitBookWebApplication.Models.Entity;

namespace BitBookWebApplication.DAL
{
    public class UserGateway
    {
        BBWAContext _db=new BBWAContext();
        
        public List<Gender> GetAllGenders()
        {
            return _db.Genders.ToList();
        }

        public bool IsUserEmailExist(User user)
        {
            return _db.Users.Any(x => x.Email.ToLower()==user.Email.ToLower());
        }
        public int AddUser(User user)
        {
            _db.Users.Add(user);
            return _db.SaveChanges();
        }

        public int AddAdditionalInformation(AdditionInformationOfUser additionInformationOfUser)
        {
            _db.AdditionInformationOfUsers.Add(additionInformationOfUser);
            return _db.SaveChanges();
        }
        public int UpdateAdditionalInformation(AdditionInformationOfUser additionInformationOfUser)
        {
            AdditionInformationOfUser newAdditionInformationOfUser = _db.AdditionInformationOfUsers.FirstOrDefault(x => x.Id == additionInformationOfUser.Id);
            if (newAdditionInformationOfUser != null)
            {
                newAdditionInformationOfUser.ProfilePhotoId = additionInformationOfUser.ProfilePhotoId;
                newAdditionInformationOfUser.CoverPhotoId = additionInformationOfUser.CoverPhotoId;
            }
            return _db.SaveChanges();
        }

        public int AddProfilePhoto(ProfilePhoto profilePhoto)
        {
            _db.ProfilePhotos.Add(profilePhoto);
            return _db.SaveChanges();
        }

        public int AddCoverPhoto(CoverPhoto coverPhoto)
        {
            _db.CoverPhotos.Add(coverPhoto);
            return _db.SaveChanges();
        }
    }
}