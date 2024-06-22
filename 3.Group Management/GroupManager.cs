using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Group_Management
{
    public class GroupManager
    {
        private List<Group> groups = new List<Group>();

        public void AddGroup(string groupName)
        {
            if (!groups.Exists(g => g.Name == groupName))
            {
                groups.Add(new Group { Name = groupName });
                Console.WriteLine($"Group '{groupName}' added.");
            }
            else
            {
                Console.WriteLine($"Group '{groupName}' already exists.");
            }
        }

        public void ListGroups()
        {
            foreach (var group in groups)
            {
                Console.WriteLine(group.Name);
            }
        }
    }
}