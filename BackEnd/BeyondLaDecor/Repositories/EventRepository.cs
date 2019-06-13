﻿using BeyondLaDecor.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IEventRepository : IBaseModelRepository<Event>
    {
    }
    public class EventRepository : BaseModelRepository<Event>, IEventRepository
    {
        public EventRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}