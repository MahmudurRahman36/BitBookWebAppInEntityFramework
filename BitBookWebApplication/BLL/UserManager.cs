using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using BitBookWebApplication.DAL;
using BitBookWebApplication.Models.Entity;

namespace BitBookWebApplication.BLL
{
    public class UserManager
    {
        UserGateway _userGateway=new UserGateway();

        public List<Gender> GetAllGenders()
        {
            return _userGateway.GetAllGenders();
        }

        public bool IsUserEmailExist(User user)
        {
            return _userGateway.IsUserEmailExist(user);
        }
        public int AddUser(User user)
        {
            return _userGateway.AddUser(user);
        }

        public byte[] GetPhotoInByte(HttpPostedFileBase photo)
        {
            if (photo != null)
            {
                string fileName = Path.GetFileName(photo.FileName);
                string fileExtension = Path.GetExtension(fileName);

                if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".bmp" ||
                    fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png")
                {
                    Stream stream = photo.InputStream;
                    BinaryReader binaryReader = new BinaryReader(stream);
                    byte[] bytes = binaryReader.ReadBytes((int)stream.Length);
                    return bytes;
                }
            }
            return null;
        }

        public int AddAdditionalInformation(AdditionInformationOfUser additionInformationOfUser)
        {
            additionInformationOfUser.Id = 1;
            _userGateway.AddAdditionalInformation(additionInformationOfUser);

            if (additionInformationOfUser.ProfilePhoto!=null)
            {
                ProfilePhoto profilePhoto = new ProfilePhoto();
                profilePhoto.TypeNo = 1;
                profilePhoto.PhotoInByte = GetPhotoInByte(additionInformationOfUser.ProfilePhoto);
                profilePhoto.AdditionInformationOfUserId = additionInformationOfUser.Id;
                profilePhoto.DateTimeNow = DateTime.Now;
                if (profilePhoto.PhotoInByte!=null)
                {
                    _userGateway.AddProfilePhoto(profilePhoto);
                }
                additionInformationOfUser.ProfilePhotoId = profilePhoto.Id;
            }

            if (additionInformationOfUser.CoverPhoto!=null)
            {
                CoverPhoto coverPhoto = new CoverPhoto();
                coverPhoto.TypeNo = 2;
                coverPhoto.PhotoInByte = GetPhotoInByte(additionInformationOfUser.CoverPhoto);
                coverPhoto.AdditionInformationOfUserId = additionInformationOfUser.Id;
                coverPhoto.DateTimeNow = DateTime.Now;
                if (coverPhoto.PhotoInByte!=null)
                {
                    _userGateway.AddCoverPhoto(coverPhoto);
                }
                additionInformationOfUser.CoverPhotoId = coverPhoto.Id;
            }
                                 
            return _userGateway.UpdateAdditionalInformation(additionInformationOfUser);
        }
    }
}