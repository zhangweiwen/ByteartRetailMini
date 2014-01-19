using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Autofac;
using ByteartRetailMini.Application;
using ByteartRetailMini.Application.DataObjects;

namespace ByteartRetailMini.Services
{
    [ServiceContract(Namespace = "zhww@outlook.com")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UserService
    {
        private readonly IUserService _userAppService;

        public UserService()
        {
            _userAppService = IocHelper.Container.Resolve<IUserService>();
        }

        [OperationContract]
        public IList<UserDataObject> CreateUsers(IList<UserDataObject> userDataObjects)
        {
            return _userAppService.CreateUsers(userDataObjects);
        }

        [OperationContract]
        public bool ValidateUser(string userName, string password)
        {
            return _userAppService.ValidateUser(userName,password);
            
        }

        [OperationContract]
        public bool DisableUser(Guid userID)
        {
            return _userAppService.DisableUser(userID);            
        }

        [OperationContract]
        public bool EnableUser(Guid userID)
        {
            return _userAppService.EnableUser(userID);                        
        }

        [OperationContract]
        public IList<UserDataObject> UpdateUsers(IList<UserDataObject> userDataObjects)
        {
            return _userAppService.UpdateUsers(userDataObjects);                        
            
        }

        [OperationContract]
        public void DeleteUsers(IList<Guid> userIDs)
        {
            _userAppService.DeleteUsers(userIDs);
        }

        [OperationContract]
        public UserDataObject GetUserByKey(Guid id)
        {
            return _userAppService.GetUserByKey(id);
        }

        [OperationContract]
        public UserDataObject GetUserByEmail(string email)
        {
            return _userAppService.GetUserByEmail(email);            
        }

        [OperationContract]
        public UserDataObject GetUserByName(string userName)
        {
            return _userAppService.GetUserByName(userName);                        
        }

        [OperationContract]
        public IList<UserDataObject> GetUsers()
        {
            return _userAppService.GetUsers();                                    
        }

        [OperationContract]
        public IList<RoleDataObject> GetRoles()
        {
            return _userAppService.GetRoles();                                                
        }

        [OperationContract]
        public RoleDataObject GetRoleByKey(Guid id)
        {
            return _userAppService.GetRoleByKey(id);                                                            
        }

        [OperationContract]
        public IList<RoleDataObject> CreateRoles(IList<RoleDataObject> roleDataObjects)
        {
            return _userAppService.CreateRoles(roleDataObjects);                                                                        
        }

        [OperationContract]
        public IList<RoleDataObject> UpdateRoles(IList<RoleDataObject> roleDataObjects)
        {
            return _userAppService.UpdateRoles(roleDataObjects);                                                                                    
        }

        [OperationContract]
        public void DeleteRoles(IList<Guid> roleIDs)
        {
            _userAppService.DeleteRoles(roleIDs);
        }

        [OperationContract]
        public void AssignRole(Guid userID, Guid roleID)
        {
            _userAppService.AssignRole(userID, roleID);            
        }

        [OperationContract]
        public void UnassignRole(Guid userID)
        {
            _userAppService.UnassignRole(userID);                        
        }

        [OperationContract]
        public RoleDataObject GetUserRole(Guid userId)
        {
            return _userAppService.GetUserRole(userId);                                                                                                
        }
    }
}