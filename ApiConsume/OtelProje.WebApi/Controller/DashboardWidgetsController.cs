﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otelproje.BusinessLayer1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelProje.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserService;
        private readonly IRoomService _roomService;
        public DashboardWidgetsController(IStaffService staffService, IBookingService bookingService, IAppUserService appUserService, IRoomService roomService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _appUserService = appUserService;
            _roomService = roomService;
        }
        [HttpGet("StaffCount")]
        public IActionResult StaffCount()
        {
            var value = _staffService.TGetStaffCount();
            return Ok(value);
        }

        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            var value = _bookingService.GetBookingCount();
            return Ok(value);
        }

        [HttpGet("AppUserCount")]
        public IActionResult AppUserCount()
        {
            var value = _appUserService.TAppUserCount();
            return Ok(value);
        }

        [HttpGet("RoomCount")]
        public IActionResult RoomCount()
        {
            var value = _roomService.TRoomCount();
            return Ok(value);
        }
    }
}
