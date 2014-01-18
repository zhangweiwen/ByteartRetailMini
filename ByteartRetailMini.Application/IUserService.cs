using System;
using System.Collections.Generic;
using ByteartRetailMini.Application.DataObjects;

namespace ByteartRetailMini.Application
{
    public interface IUserService
    {
        IList<UserDataObject> CreateUsers(IList<UserDataObject> userDataObjects);

        bool ValidateUser(string userName, string password);

        bool DisableUser(Guid userID);

        bool EnableUser(Guid userID);

        IList<UserDataObject> UpdateUsers(IList<UserDataObject> userDataObjects);

        void DeleteUsers(IList<Guid> userIDs);

        UserDataObject GetUserByKey(Guid id);

        UserDataObject GetUserByEmail(string email);

        UserDataObject GetUserByName(string userName);

        IList<UserDataObject> GetUsers();

        IList<RoleDataObject> GetRoles();

        RoleDataObject GetRoleByKey(Guid id);

        IList<RoleDataObject> CreateRoles(IList<RoleDataObject> roleDataObjects);

        IList<RoleDataObject> UpdateRoles(IList<RoleDataObject> roleDataObjects);

        void DeleteRoles(IList<Guid> roleIDs);

        void AssignRole(Guid userID, Guid roleID);

        void UnassignRole(Guid userID);

        RoleDataObject GetUserRoleByUserName(string userName);
    }
}