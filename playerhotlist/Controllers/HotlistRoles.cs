using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using playerhotlist.Models;

namespace playerhotlist.Controllers 
{
    public class HotlistRoleProvider : RoleProvider
    {
        HotlistContext ctx = new HotlistContext();

        public override bool IsUserInRole(string username, string roleName)
        {
            Account account = ctx.Accounts.SingleOrDefault(c => c.name == username);

            if (account != null)
            {
                if((ctx.Roles.SingleOrDefault(c => c.name == roleName) != null))
                {
                    return true;
                }
            }
            else
            {
                return false;
            }

            return false;
        }

        public override string[] GetRolesForUser(string username)
        {
            Account account = ctx.Accounts.SingleOrDefault(c => c.name == username);
            
            if(account != null)
            {
                switch(account.roleID)
                {
                    case 10:
                        return new string[] { "user" };
                    case 20:
                        return new string[] { "user", "moderator" };
                    case 40:
                        return new string[] { "user", "moderator", "admin" };
                    default:
                        return new string[] { };
                }

            }

            return new string[] { };
            
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}