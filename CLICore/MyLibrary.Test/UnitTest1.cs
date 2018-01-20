using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            #region Arrange 排列
            MyClass fooMyLibrary = new MyClass();

            int expected = 5;
            #endregion

            #region Act 作用
            int actual = fooMyLibrary.Sum(2,3);
            #endregion

            #region Asset 判斷提示
            Assert.AreEqual(expected, actual);
            #endregion
        }
    }
}
