﻿using System;
using FluentValidation;
using SFA.DAS.Events.Domain.Entities;

namespace SFA.DAS.Events.Application.Commands.CreateAgreementEvent
{
    public class CreateAgreementEventCommandValidator : AbstractValidator<CreateAgreementEventCommand>
    {
        public CreateAgreementEventCommandValidator()
        {
            RuleFor(model => model.Event).NotEmpty();
            RuleFor(model => model.ProviderId).NotEmpty();
        }
    }
}
