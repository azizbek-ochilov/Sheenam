//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//=================================

using Xeptions;

namespace Sheenam.Api.Services.Foundations.Guests.Exeptions
{
    public class NullGuestException : Xeption
    {
        public NullGuestException() 
            :base(message:"Guest is null")
        {}
    }
}
