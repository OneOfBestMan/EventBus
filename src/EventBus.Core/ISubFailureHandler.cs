﻿using System.Threading.Tasks;

namespace EventBus.Core
{
    public interface ISubFailureHandler
    {
        Task HandleAsync(FailContext context);
    }
}
