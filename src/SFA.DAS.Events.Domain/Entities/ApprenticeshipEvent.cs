﻿using System;

namespace SFA.DAS.Events.Domain.Entities
{
    public class ApprenticeshipEvent : BaseEvent
    {
        public PaymentStatus PaymentStatus { get; set; }
        public long ApprenticeshipId { get; set; }
        public AgreementStatus AgreementStatus { get; set; }
        public string ProviderId { get; set; }
        public string LearnerId { get; set; }
        public string EmployerAccountId { get; set; }
        public TrainingTypes TrainingType { get; set; }
        public string TrainingId { get; set; }
        public DateTime TrainingStartDate { get; set; }
        public DateTime TrainingEndDate { get; set; }
        public decimal TrainingTotalCost { get; set; }
        public int PaymentOrder { get; set; }
    }
}
