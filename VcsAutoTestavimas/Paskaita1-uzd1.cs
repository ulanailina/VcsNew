using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VcsAutoTestavimas
{
    public class Paskaita1uzd1
    {
        [Test]

        public static void TestIf4IsEven()
        {
            int leftover = 4 % 2;
            Assert.AreEqual(0, leftover, "4 is not even");
        }

        [Test]

        public static void TestNowIs19()
        {
            DateTime CurrentTime = DateTime.Now;
            Assert.IsTrue(CurrentTime.Hour.Equals(19), "Dabar ne 19 valanda.");
        }

        [Test]
        public static void TestArDalijasiIs3()
        {
            int dalmuo = 995 % 3;
            Assert.AreEqual(0, dalmuo, "995 nesidalija is 3");
        }

        [Test]
        public static void TestIfTodayIsMonday()
        {
            DayOfWeek Today = DayOfWeek.Monday;
            Assert.IsTrue(DayOfWeek.Monday.Equals(Today), "Siandien ne pirmadienis");
        }

        [Test]
        public static void TestPalaukia5sekundes()
        {
            Thread.Sleep(5000);
        }
    }
}
