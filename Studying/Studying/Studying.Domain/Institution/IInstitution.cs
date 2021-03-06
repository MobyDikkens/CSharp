using System;
using System.Collections.Generic;
using Studying.Domain.Core;
using Studying.Domain.Student;

namespace Studying.Domain.Institution
{
    public interface IInstitution : IEntity<Guid>
    {
        IReadOnlyCollection<IStudent> Students { get; }
        void Enter(IStudent student);
        IReadOnlyCollection<IStudent> Graduate();
        void TickTerm();
    }
}