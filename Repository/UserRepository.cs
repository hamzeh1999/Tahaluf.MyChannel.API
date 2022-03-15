using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.MyChannel.core.data;
using Tahaluf.MyChannel.Core.DTO;
using Tahaluf.MyChannel.Core.Repository;

namespace Tahaluf.MyChannel.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool CREATEuser(User_ user)
        {
            throw new NotImplementedException();
        }

        public bool DELETEuser(int userId)
        {
            throw new NotImplementedException();
        }

        public List<User_> GETALLusers()
        {
            throw new NotImplementedException();
        }

        public List<NumOfRegisterUserDTO> NumOfRegisterUsers()
        {
            throw new NotImplementedException();
        }

        public List<NumOfRegisterUserDTO> SearchingNumberOFUser(SearchingNumberOfUserCall date)
        {
            throw new NotImplementedException();
        }

        public bool UPDATEuser(User_ user)
        {
            throw new NotImplementedException();
        }

        public List<UserLoginDTO> UserLogin(UserLoginCallDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
