//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//=================================

using System;
using Xeptions;

namespace Sheenam.Api.Services.Foundations.Guests.Exeptions
{
    public class GuestValidationException: Xeption
    {
        private static Exception innerException;

        public GuestValidationException(Xeption innerException)
            : base(message: "Guest validation error occured! Fix the errors and try again",
                  innerException: innerException)
        {}
    }
}
