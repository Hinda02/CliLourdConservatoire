using CliLourdConservatoire;
using CliLourdConservatoire.Model;

namespace TestConservatoire
{
    [TestClass]
    public class ConservatoireTest
    {
        [TestMethod]
        public void TestGestionDatesPaiement()
        {
            //Valeurs changeantes selon la date du jour
            DateTime date1 = new DateTime(0001, 12, 25);
            DateTime date2 = new DateTime(0001, 5, 31);
            DateTime date3 = new DateTime(0001, 6, 10);
            DateTime date4 = new DateTime(0001, 4, 10);

            bool result1 = Trimestre.compareDates(date1);
            Assert.IsFalse(result1);

            bool result2 = Trimestre.compareDates(date2);
            Assert.IsTrue(result2);

            bool result3 = Trimestre.compareDates(date3);
            Assert.IsFalse(result3);

            bool result4 = Trimestre.compareDates(date4);
            Assert.IsFalse(result4);

        }
    }
}