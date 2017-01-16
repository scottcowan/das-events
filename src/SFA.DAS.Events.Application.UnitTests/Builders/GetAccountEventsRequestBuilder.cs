﻿using SFA.DAS.Events.Application.Queries.GetAccountEvents;

namespace SFA.DAS.Events.Application.UnitTests.Builders
{
    public class GetAccountEventsRequestBuilder : GetEventRequestBuilder<GetAccountEventsRequest>
    {
       public override GetAccountEventsRequest Build()
        {
            return new GetAccountEventsRequest
            {
                FromDateTime = FromDateTime,
                FromEventId = FromEventId,
                PageNumber = PageNumber,
                PageSize = PageSize,
                ToDateTime = ToDateTime
            };
        }
    }
}
