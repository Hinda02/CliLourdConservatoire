using CliLourdConservatoire;
using CliLourdConservatoire.DAL;
using CliLourdConservatoire.Model;

namespace TestConservatoire
{
    [TestClass]
    public class ConservatoireTest
    {
        [TestMethod]
        public void TestAuthentification()
        {
            bool result1 = EmployeDAO.Authentifier("testlogin", "testpwd");
            Assert.Equals(false, result1);

            /*bool result2 = EmployeDAO.Authentifier("david123", "mdp1");
            Assert.IsTrue(result2);*/
        }
    }
}