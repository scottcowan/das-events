﻿using System;
using System.Threading.Tasks;
using FluentValidation;
using NUnit.Framework;
using SFA.DAS.Events.Application.UnitTests.Builders;

namespace SFA.DAS.Events.Application.UnitTests.Queries.GetAgreementEventsTests
{
    [TestFixture]
    public class WhenIValidateTheRequest : GetAgreementEventsTestBase
    {
        [Test]
        public async Task AndTheFromDateIsAfterTheToDateThenValidationFails()
        {
            var request = new GetAgreementEventsRequestBuilder().WithFromDate(DateTime.Now.AddDays(-1)).WithToDate(DateTime.Now.AddDays(-2)).Build();

            Assert.ThrowsAsync<ValidationException>(() => Handler.Handle(request));
        }

        [Test]
        public async Task AndThePageNumberIsLessThanOneThenValidationFails()
        {
            var request = new GetAgreementEventsRequestBuilder().WithPageNumber(0).Build();

            Assert.ThrowsAsync<ValidationException>(() => Handler.Handle(request));
        }

        [Test]
        public async Task AndThePageSizeIsLessThanOneThenValidationFails()
        {
            var request = new GetAgreementEventsRequestBuilder().WithPageSize(0).Build();

            Assert.ThrowsAsync<ValidationException>(() => Handler.Handle(request));
        }

        [Test]
        public async Task AndThePageNumberIsGreaterThanTenThousandThenValidationFails()
        {
            var request = new GetAgreementEventsRequestBuilder().WithPageSize(10001).Build();

            Assert.ThrowsAsync<ValidationException>(() => Handler.Handle(request));
        }

        [Test]
        public async Task AndTheEventIdIsLessThanZeroThenValidationFails()
        {
            var request = new GetAgreementEventsRequestBuilder().WithEventId(-1).Build();

            Assert.ThrowsAsync<ValidationException>(() => Handler.Handle(request));
        }
    }
}
