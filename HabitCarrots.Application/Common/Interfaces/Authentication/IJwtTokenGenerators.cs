﻿using HabitCarrots.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitCarrots.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerators
    {
        string GenerateToken(User user);
    }
}
