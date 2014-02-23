using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using ByteartRetailMini.Application.DataObjects;
using ByteartRetailMini.Services.Core;

namespace ByteartRetailMini.Services
{
    [IocServiceBehavior]
    [ServiceContract(Namespace = "zhww@outlook.com")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UserService : BaseService
    {
        [OperationContract]
        public virtual IList<UserDataObject> CreateUsers(IList<UserDataObject> userDataObjects)
        {
            return UserAppService.CreateUsers(userDataObjects);
        }

        [OperationContract]
        public virtual bool ValidateUser(string userName, string password)
        {
            return UserAppService.ValidateUser(userName,password);
        }

        [OperationContract]
        public virtual bool DisableUser(int userID)
        {
            return UserAppService.DisableUser(userID);            
        }

        [OperationContract]
        public virtual bool EnableUser(int userID)
        {
            return UserAppService.EnableUser(userID);                        
        }

        [OperationContract]
        public virtual IList<UserDataObject> UpdateUsers(IList<UserDataObject> userDataObjects)
        {
            return UserAppService.UpdateUsers(userDataObjects);                        
            
        }

        [OperationContract]
        public virtual void DeleteUsers(IList<int> userIDs)
        {
            UserAppService.DeleteUsers(userIDs);
        }

        [OperationContract]
        public virtual UserDataObject GetUserByKey(int id)
        {
            return UserAppService.GetUserByKey(id);
        }

        [OperationContract]
        public virtual UserDataObject GetUserByEmail(string email)
        {
            return UserAppService.GetUserByEmail(email);            
        }

        [OperationContract]
        public virtual UserDataObject GetUserByName(string userName)
        {
            return UserAppService.GetUserByName(userName);                        
        }

        [OperationContract]
        public virtual IList<UserDataObject> GetUsers()
        {
            return UserAppService.GetUsers();                                    
        }

        [OperationContract]
        public virtual IList<RoleDataObject> GetRoles()
        {
            return UserAppService.GetRoles();                                                
        }

        [OperationContract]
        public virtual RoleDataObject GetRoleByKey(int id)
        {
            return UserAppService.GetRoleByKey(id);                                                            
        }

        [OperationContract]
        public virtual IList<RoleDataObject> CreateRoles(IList<RoleDataObject> roleDataObjects)
        {
            return UserAppService.CreateRoles(roleDataObjects);                                                                        
        }

        [OperationContract]
        public virtual IList<RoleDataObject> UpdateRoles(IList<RoleDataObject> roleDataObjects)
        {
            return UserAppService.UpdateRoles(roleDataObjects);                                                                                    
        }

        [OperationContract]
        public virtual void DeleteRoles(IList<int> roleIDs)
        {
            UserAppService.DeleteRoles(roleIDs);
        }

        [OperationContract]
        public virtual void AssignRole(int userID, int roleID)
        {
            UserAppService.AssignRole(userID, roleID);            
        }

        [OperationContract]
        public virtual void UnassignRole(int userID)
        {
            UserAppService.UnassignRole(userID);                        
        }

        [OperationContract]
        public virtual RoleDataObject GetUserRole(string name)
        {
            return UserAppService.GetUserRole(name);                                                                                                
        }
    }
}