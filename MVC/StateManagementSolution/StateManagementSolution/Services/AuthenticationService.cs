using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StateManagementSolution.Services
{
    public class AuthenticationService
    {
        public List<ViewModel.UserVM> UserList = new List<ViewModel.UserVM>();
        public AuthenticationService()
        {
            UserList.Add(new ViewModel.UserVM("Ratnesh", "123"));
            UserList.Add(new ViewModel.UserVM("Hiren", "321"));
            UserList.Add(new ViewModel.UserVM("Ratnesh", "111"));
        }
        public ViewModel.UserVM AuthenticateUser(string username,string password)
        {
            for (int i=0;i<UserList.Count;i++)
            {
                if (UserList[i].Username==username && UserList[i].Password==password)
                {
                    return UserList[i];
                }
            }
            return null;
        }
       
    }
}