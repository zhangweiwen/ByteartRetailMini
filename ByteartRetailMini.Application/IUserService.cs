using System;
using System.Collections.Generic;
using ByteartRetailMini.Application.DataObjects;

namespace ByteartRetailMini.Application
{
    public interface IUserService
    {
        IList<UserDataObject> CreateUsers(IList<UserDataObject> userDataObjects);

        bool ValidateUser(string userName, string password);

        bool DisableUser(int userID);

        bool EnableUser(int userID);

        IList<UserDataObject> UpdateUsers(IList<UserDataObject> userDataObjects);

        void DeleteUsers(IList<int> userIDs);

        UserDataObject GetUserByKey(int id);

        UserDataObject GetUserByEmail(string email);

        UserDataObject GetUserByName(string userName);

        IList<UserDataObject> GetUsers();

        IList<RoleDataObject> GetRoles();

        RoleDataObject GetRoleByKey(int id);

        IList<RoleDataObject> CreateRoles(IList<RoleDataObject> roleDataObjects);

        IList<RoleDataObject> UpdateRoles(IList<RoleDataObject> roleDataObjects);

        void DeleteRoles(IList<int> roleIDs);

        void AssignRole(int userID, int roleID);

        void UnassignRole(int userID);

        RoleDataObject GetUserRole(string name);
    }
}