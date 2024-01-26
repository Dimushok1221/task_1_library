using task_1_library;

namespace test_DataTimeLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]      
        public void test_date_dif_1()
        {
            DateTimeLib dtl = new DateTimeLib();

            DateTime date1 = new DateTime(2024, 11, 23, 22, 45, 30);
            DateTime date2 = new DateTime(2023, 9, 10, 15, 42, 20);
            DateTime exp = new DateTime(2, 3, 17, 7, 3, 10);

            DateTime result = dtl.date_dif(date1, date2);

            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void test_date_dif_2()
        {
            DateTimeLib dtl = new DateTimeLib();

            DateTime date1 = new DateTime(2024, 11, 23, 22, 45, 30);
            DateTime date2 = new DateTime(2023, 9, 10, 15, 42, 20);
            DateTime exp = new DateTime(2, 3, 17, 7, 3, 10);

            DateTime result = dtl.date_dif(date2, date1); // ћен€ем местами аргументы

            Assert.AreEqual(exp, result);
        }
        
        [TestMethod]
        public void test_isYearLeap_true()
        {
            DateTimeLib dtl = new DateTimeLib();

            DateTime date1 = new DateTime(2024, 11, 23, 22, 45, 30);
            bool exp = true;

            bool result = dtl.isYearLeap(date1.Year); 

            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void test_isYearLeap_false()
        {
            DateTimeLib dtl = new DateTimeLib();

            DateTime date1 = new DateTime(2023, 11, 23, 22, 45, 30);
            bool exp = false;

            bool result = dtl.isYearLeap(date1.Year);

            Assert.AreEqual(exp, result);
        }        
        
        [TestMethod]
        public void test_timesOfDay_night()
        {
            DateTimeLib dtl = new DateTimeLib();

            DateTime date1 = new DateTime(2023, 11, 23, 2, 45, 30);
            string exp = "ночь";

            string result = dtl.timesOfDay(date1);

            Assert.AreEqual(exp, result);
        }        
        
        [TestMethod]
        public void test_formatDate()
        {
            DateTimeLib dtl = new DateTimeLib();

            DateTime date1 = new DateTime(2024, 11, 23, 22, 45, 30);
            string exp = "23 но€бр€ 2024 г. 22:45";

            string result = dtl.formatDate(date1, "f");

            Assert.AreEqual(exp, result);
        }
    }
}