using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLibrary
{
    public class User
    {
        
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int groupId;

        public int GroupId
        {
            get { return groupId; }
            set { groupId = value; }
        }

        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }



    }

    public class UserInfo
    {
       
        private int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

       
    }

    public class Group
    {
        int id { get; set; }
        int roleId { get; set; }
        string name { get; set; }
        public int Id { get { return id; } set { id = value; } }
        public int RoleId { get { return roleId; } set { roleId = value; } }
        public string Name { get { return name; } set { name = value; } }

    }

    public class Role
    {
        int id;
        string name;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
    }
}
