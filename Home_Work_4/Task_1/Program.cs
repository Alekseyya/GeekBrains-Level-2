using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UserLibrary;

namespace Task_1
{
    class Program
    {
        static List<Role> roles;
        static List<Group> groups;
        static List<UserInfo> userinf;
        static List<User> users;

        

        static Action runfunction;

        static MyProp<object> CountUsersInGroups { get; set; }
        static MyProp<object> CoutUsersInGroupsWhereAgeMore25 { get; set; }

        static MyProp<object> GroupsUsersMore25 { get; set; }
        static MyProp<object> GroupOnRole { get; set; }

        static void Main(string[] args)
        {


            //Добавляем функции в делегат
            AddFunctionInDelegate();
            //Стартуем делегат
            runfunction();

            //Пытался с помощью рефлексии вызвать все свойства и передать на печать, но не получилось
            //Program pr = new Program();
            //PropertyInfo[] properties = typeof(Program).GetProperties();

            //foreach (PropertyInfo property in properties)
            //{
            //    print(property.GetValue());
            //}

            Print();
            Console.ReadKey();
           
                       
        }

        static void AddFunctionInDelegate()
        {
            runfunction += Write;
            runfunction += CountUsersIngroups;
            runfunction += GetUsersInGroupsWhereAgeMore25;
            runfunction += GetGroupsUsersMore25;
            runfunction += GetGroupOnRole;

            
        }

        static void Print()
        {
            Console.WriteLine("a. Выведите все группы и количество пользователей в этих группах");
            foreach (KeyValuePair<string, int> i in (Dictionary<string, int>)CountUsersInGroups.Value)
            {
                Console.WriteLine($"{i.Key}  {i.Value}");
            }
            Console.WriteLine("/////////////////");

            Console.WriteLine("b. Выведите все группы и количество пользователей в этих группах, возраст которых больше 25");

            foreach (KeyValuePair<string, int> i in (Dictionary<string, int>)CoutUsersInGroupsWhereAgeMore25.Value)
            {
                Console.WriteLine($"{i.Key}  {i.Value}");
            }
            Console.WriteLine("///////////////////");
            Console.WriteLine("c. Выведите все группы и количество пользователей в этих группах, возраст которых больше 25 и роль которых, например, администратор");

            foreach (KeyValuePair<string, int> i in (Dictionary<string, int>)GroupsUsersMore25.Value)
            {
                Console.WriteLine($"{i.Key}  {i.Value}");
            }
            Console.WriteLine("////////////////");
            Console.WriteLine("d. Выведите все группы, при этом в каждой группе нужно сгруппировать всех пользователей по ролям");
            foreach (var i in (List<Tuple<string, string, int>>)GroupOnRole.Value)
            {
                Console.WriteLine($"{i.Item1} {i.Item2} {i.Item3}");
            }
        }

        

        //a. Выведите все группы и количество пользователей в этих группах\
        static void CountUsersIngroups()
        {
            Dictionary<string, int> grp = new Dictionary<string, int>();
            var coutUsersInGroup = (from gr in groups

                     join us in users on gr.Id equals us.GroupId

                     group gr by new { gr.Name } into g

                     select new { GroupName = g.Key.Name, CountUsers = g.Count() }).ToList();
            foreach(var users in coutUsersInGroup)
            {
                grp.Add(users.GroupName, users.CountUsers);
            }
            CountUsersInGroups = grp;
            
        }

        //b.Выведите все группы и количество пользователей в этих группах, возраст которых больше 25
        static void GetUsersInGroupsWhereAgeMore25()
        {
            Dictionary<string, int> grp = new Dictionary<string, int>();
            var coutUsersInGroupsWhereAgeMore25 = (from gr in groups

                     join us in users on gr.Id equals us.GroupId
                     join usinf in userinf on us.Id equals usinf.UserId
                     where usinf.Age > 25
                     group gr by new { gr.Name } into g

                     select new { GroupName = g.Key.Name, CountUsers = g.Count() }).ToList();

            foreach (var users in coutUsersInGroupsWhereAgeMore25)
            {
                grp.Add(users.GroupName, users.CountUsers);
            }
            CoutUsersInGroupsWhereAgeMore25 = grp;

        }


        //с.Выведите все группы и количество пользователей в этих группах, возраст которых больше 25 
        //и роль которых, например, администратор
        static void GetGroupsUsersMore25()
        {
            Dictionary<string, int> grp = new Dictionary<string, int>();
            var groupsUsersMore25 = (from gr in groups

                     join us in users on gr.Id equals us.GroupId
                     join usinf in userinf on us.Id equals usinf.UserId
                     join role in roles on gr.RoleId equals role.Id
                     where usinf.Age > 25 & role.Id == 1
                     group gr by new { gr.Name } into g

                     select new { GroupName = g.Key.Name, CountUsers = g.Count() }).ToList();

            foreach (var users in groupsUsersMore25)
            {
                grp.Add(users.GroupName, users.CountUsers);
            }
            GroupsUsersMore25 = grp;
        }

        //d.Выведите все группы, при этом в каждой группе нужно сгруппировать всех пользователей по ролям

        static void GetGroupOnRole()
        {
            List<Tuple<string, string, int>> grp = new List<Tuple<string, string, int>>();
            var groupOnRole = (from gr in groups

                     join us in users on gr.Id equals us.GroupId
                     join usinf in userinf on us.Id equals usinf.UserId
                     join role in roles on gr.RoleId equals role.Id
                     group gr by new { gr, role } into g

                     select new { GroupName = g.Key.gr.Name, RoleName = g.Key.role.Name, Users = g.Count() }).ToList();

            foreach (var users in groupOnRole)
            {
                grp.Add(new Tuple<string, string, int>(users.GroupName, users.RoleName, users.Users));
            }

            GroupOnRole = grp;
        }
        


        static void Write()
        {
            roles = new List<Role>
            {
                new Role {Id = 1, Name ="Администратор"},
                new Role {Id = 2, Name ="Пользователь"},
                new Role {Id = 3, Name ="Гость"},
                new Role {Id = 4, Name ="Репликатор"}
            };

            groups = new List<Group>
            {
                new Group {Id =1, RoleId=1, Name="Крутые перцы" },
                new Group {Id =2, RoleId=2, Name="Пользователи" },
                new Group {Id =3, RoleId=3, Name="Гости и другие" },
            };

            userinf = new List<UserInfo>
            {
                new UserInfo {UserId = 1, Name="Алексей", Age=23, Salary=100000 },
                new UserInfo {UserId = 2, Name="Вася", Age=27, Salary=50000 },
                new UserInfo {UserId = 3, Name="Гриша", Age=19, Salary=20000 },
                new UserInfo {UserId = 4, Name="Лена", Age=13, Salary=5000 },
                new UserInfo {UserId = 5, Name="Катя", Age=43, Salary=21000 }
            };

            users = new List<User>
            {
                new User {Id =1, GroupId= 1, Login="Fokiruna"},
                new User {Id =2, GroupId= 1, Login="Levoxt"},
                new User {Id =3, GroupId= 2, Login="Moloco"},
                new User {Id =4, GroupId= 3, Login="Golimo"},
                new User {Id =5, GroupId= 3, Login="Golimo"}
            };

        }



        

    }
}
