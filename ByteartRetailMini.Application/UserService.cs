using System;
using System.Collections.Generic;
using System.Linq;
using ByteartRetailMini.Application.DataObjects;
using ByteartRetailMini.Domain.Models;
using ByteartRetailMini.Domain.Services;
using NHibernate;
using NHibernate.Linq;

namespace ByteartRetailMini.Application
{
    public class UserService : IUserService
    {
        private readonly ISession _session;
        private readonly IDomainService _domainService;

        public UserService(ISession session, IDomainService domainService)
        {
            if (session == null)
                throw new ArgumentNullException("session");

            if (domainService == null)
                throw new ArgumentNullException("domainService");

            _session = session;
            _domainService = domainService;
        }

        public IList<UserDataObject> CreateUsers(IList<UserDataObject> userDataObjects)
        {
            var results = new List<UserDataObject>();
            foreach (var item in userDataObjects)
            {
                var domain = item.ToDomain();
                _session.Save(domain);
                results.Add(domain.ToData());
            }
            return results;
        }

        public bool ValidateUser(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
                throw new ArgumentNullException("userName");

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            return _session.Query<User>().Count(x => x.UserName == userName && x.Password == password) > 0;
        }

        public bool DisableUser(int userID)
        {
            var user = _session.Get<User>(userID);
            user.Disable();
            return user.IsDisabled;
        }

        public bool EnableUser(int userID)
        {
            var user = _session.Get<User>(userID);
            user.Enable();
            return user.IsDisabled;
        }

        public IList<UserDataObject> UpdateUsers(IList<UserDataObject> userDataObjects)
        {
            var results = new List<UserDataObject>();
            foreach (var item in userDataObjects)
            {
                var dbValue = _session.Get<User>(item.ID);
                if (!string.IsNullOrEmpty(item.Contact))
                    dbValue.Contact = item.Contact;
                if (!string.IsNullOrEmpty(item.PhoneNumber))
                    dbValue.PhoneNumber = item.PhoneNumber;
                if (item.ContactAddress != null)
                {
                    if (!string.IsNullOrEmpty(item.ContactAddress.City))
                        dbValue.ContactAddress.City = item.ContactAddress.City;
                    if (!string.IsNullOrEmpty(item.ContactAddress.Country))
                        dbValue.ContactAddress.Country = item.ContactAddress.Country;
                    if (!string.IsNullOrEmpty(item.ContactAddress.State))
                        dbValue.ContactAddress.State = item.ContactAddress.State;
                    if (!string.IsNullOrEmpty(item.ContactAddress.Street))
                        dbValue.ContactAddress.Street = item.ContactAddress.Street;
                    if (!string.IsNullOrEmpty(item.ContactAddress.Zip))
                        dbValue.ContactAddress.Zip = item.ContactAddress.Zip;
                }
                if (item.DeliveryAddress != null)
                {
                    if (!string.IsNullOrEmpty(item.DeliveryAddress.City))
                        dbValue.DeliveryAddress.City = item.DeliveryAddress.City;
                    if (!string.IsNullOrEmpty(item.DeliveryAddress.Country))
                        dbValue.DeliveryAddress.Country = item.DeliveryAddress.Country;
                    if (!string.IsNullOrEmpty(item.DeliveryAddress.State))
                        dbValue.DeliveryAddress.State = item.DeliveryAddress.State;
                    if (!string.IsNullOrEmpty(item.DeliveryAddress.Street))
                        dbValue.DeliveryAddress.Street = item.DeliveryAddress.Street;
                    if (!string.IsNullOrEmpty(item.DeliveryAddress.Zip))
                        dbValue.DeliveryAddress.Zip = item.DeliveryAddress.Zip;
                }
                if (item.DateLastLogon != null)
                    dbValue.DateLastLogon = item.DateLastLogon;
                if (item.DateRegistered != null)
                    dbValue.DateRegistered = item.DateRegistered.Value;
                if (!string.IsNullOrEmpty(item.Email))
                    dbValue.Email = item.Email;
                if (item.IsDisabled != null)
                {
                    if (item.IsDisabled.Value)
                        dbValue.Disable();
                    else
                        dbValue.Enable();
                }
                if (!string.IsNullOrEmpty(item.Password))
                    dbValue.Password = item.Password;

                results.Add(dbValue.ToData());
            }
            return results;
        }

        public void DeleteUsers(IList<int> userIDs)
        {
            foreach (var id in userIDs)
            {
                _session.Delete(new User { ID = id });
            }
        }

        public UserDataObject GetUserByKey(int id)
        {
            return _session.Get<User>(id).ToData();
        }

        public UserDataObject GetUserByEmail(string email)
        {
            return _session.Query<User>().FirstOrDefault(u => u.Email == email).ToData();
        }

        public UserDataObject GetUserByName(string userName)
        {
            return _session.Query<User>().FirstOrDefault(u => u.UserName == userName).ToData();
        }

        public IList<UserDataObject> GetUsers()
        {
            return _session.Query<User>().ToList().Select(u => u.ToData()).ToList();
        }

        public IList<RoleDataObject> GetRoles()
        {
            return _session.Query<Role>().ToList().Select(u => u.ToData()).ToList();
        }

        public RoleDataObject GetRoleByKey(int id)
        {
            return _session.Get<Role>(id).ToData();
        }

        public IList<RoleDataObject> CreateRoles(IList<RoleDataObject> roleDataObjects)
        {
            var results = new List<RoleDataObject>();
            foreach (var item in roleDataObjects)
            {
                var domain = item.ToDomain();
                _session.Save(domain);
                results.Add(domain.ToData());
            }
            return results;
        }

        public IList<RoleDataObject> UpdateRoles(IList<RoleDataObject> roleDataObjects)
        {
            var results = new List<RoleDataObject>();
            foreach (var item in roleDataObjects)
            {
                var dbValue = _session.Get<Role>(item.ID);
                if (!string.IsNullOrEmpty(item.Name))
                    dbValue.Name = item.Name;

                if (!string.IsNullOrEmpty(item.Description))
                    dbValue.Description = item.Description;

                results.Add(dbValue.ToData());
            }
            return results;
        }

        public void DeleteRoles(IList<int> roleIDs)
        {
            foreach (var id in roleIDs)
            {
                _session.Delete(new Role { ID = id });
            }
        }

        public void AssignRole(int userID, int roleID)
        {
            var user = _session.Get<User>(userID);
            var role = _session.Get<Role>(roleID);
            _domainService.AssignRole(user, role);
        }

        public void UnassignRole(int userID)
        {
            var user = _session.Get<User>(userID);
            _domainService.UnassignRole(user);
        }

        public RoleDataObject GetUserRole(string name)
        {
            var user = GetUserByName(name);
            if (user == null)
                return null;

            return _session.Query<Role>()
                .Join(_session.Query<UserRole>(), r => r.ID, u => u.RoleID, (r, ur) => new { r, ur })
                .Where(x => x.ur.UserID == user.ID)
                .Select(x => x.r)
                .FirstOrDefault().ToData();
        }
    }
}