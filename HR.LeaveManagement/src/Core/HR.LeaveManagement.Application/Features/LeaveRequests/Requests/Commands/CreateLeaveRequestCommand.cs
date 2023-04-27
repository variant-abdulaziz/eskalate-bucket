﻿using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
internal class CreateLeaveRequestCommand : IRequest<int>
{
    public CreateLeaveRequestDto LeaveRequestDto { get; set; }
}
