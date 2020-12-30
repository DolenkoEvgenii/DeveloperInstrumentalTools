using System;
using FluentAssertions;
using NUnit.Framework;
using UnitTestsTarget;

namespace UnitTests {
    public class DayShiftServiceTests {
        private readonly DayShiftService mDayShiftService = new DayShiftService(new DayOfWeekService());

        [Test]
        public void SubtractDaysOfYear() {
            var startDate = new DateTime(2020, 11, 11);
            var endDate = new DateTime(2019, 4, 25);
            var daysToSubtract = -200;

            mDayShiftService
           		.GetShiftBusinessDay(startDate, daysToSubtract)
           	    .Should()
          	    .Be(endDate);
        }

        [Test]
        public void AddDaysOfYear() {
            var startDate = new DateTime(2019, 8, 20);
            var endDate = new DateTime(2020, 2, 14);
            var daysToAdd = 178;

            mDayShiftService
            	.GetShiftBusinessDay(startDate, daysToAdd)
            	.Should()
            	.Be(endDate);
        }

        [Test]
        public void AddZeroBusinessDay() {
            var startDate = new DateTime(2020, 11, 11);
            var endDate = new DateTime(2020, 11, 11);

            mDayShiftService
            	.GetShiftBusinessDay(startDate, 0)
            	.Should()
            	.Be(endDate);
        }

        [Test]
        public void AddOneBusinessDay() {
            var startDate = new DateTime(2020, 11, 11);
            var endDate = new DateTime(2020, 11, 12);

            mDayShiftService
            	.GetShiftBusinessDay(startDate, 1)
            	.Should()
            	.Be(endDate);
        }

        [Test]
        public void SubtractOneBusinessDay() {
            var startDate = new DateTime(2020, 11, 11);
            var endDate = new DateTime(2020, 11, 10);

            mDayShiftService
            	.GetShiftBusinessDay(startDate, -1)
            	.Should()
            	.Be(endDate);
        }
    }
}
