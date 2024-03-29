﻿using HabitCarrots.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitCarrots.Application.Services.Authentication
{
    public record AuthenticationResult
    (
        User user,
        string Token
    );
}
