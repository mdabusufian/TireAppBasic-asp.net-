using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    public class TestRepo
    {
        static EmpContext empContext;
        public TestRepo()
        {
            empContext = new EmpContext();
        }

        public static List<Test> Get()
        {
            return empContext.Tests.ToList();
        }

        public static Test Get(int id)
        {
            return empContext.Tests.Find(id);
        }



    }
}
