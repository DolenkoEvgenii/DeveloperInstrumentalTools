using System;
using FluentAssertions;
using NUnit.Framework;
using UnitTestsTarget;

namespace UnitTests {
    public class DayOfWeekServiceTests {
        private readonly DayOfWeekService mDayOfWeekService = new DayOfWeekService();

        [Test]
        public void IsWeekend() {
            var date = new DateTime(2020, 12, 20);
            mDayOfWeekService
                .IsWeekend(date)
                .Should()
                .Be(true);
        }

        [Test]
        public void IsWeekendFarAgo() {
            var date = new DateTime(2018, 1, 20);

            mDayOfWeekService
                .IsWeekend(date)
                .Should()
                .Be(true);
        }

        [Test]
        public void isNotWeekend() {
            var date = new DateTime(2020, 12, 21);

            mDayOfWeekService
                .IsWeekend(date)
                .Should()
                .Be(false);
        }

        [Test]
        public void isNotWeekendFarAgo() {
            var date = new DateTime(2017, 2, 17);

            mDayOfWeekService
                .IsWeekend(date)
                .Should()
                .Be(false);
        }
    }
}