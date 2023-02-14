//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//=================================

using FluentAssertions;
using Moq;
using Sheenam.Api.Models.Foundations.Guests;
using Xunit;

namespace Sheenam.Api.Test.Unit.Sevices.Foundations.Guests
{
    public partial class GuestServiceTests
    {
        [Fact]
        public async Task ShouldAddGuestInWrongWayAsyc()
        {
            //Arrange
            Guest randomGuest = new Guest()
            {
                Id = Guid.NewGuid(),
                FirstName = "Lazizbek",
                LastName = "Rustamov",
                DateOfBirth = new DateTimeOffset(),
                Address = "Tashkent, YangiLife #36",
                PhoneNumber = "999999999",
                Email = "lazizbek@gmail.com",
                Gender = Guest.GenderType.Male
            };

            this.storageBrokerMock.Setup(broker =>
                broker.InsertGuestAsync(randomGuest)).ReturnsAsync(randomGuest);

            //Act
            Guest actual = await this.guestService.AddGuestAsync(randomGuest);
            //Assert
            actual.Should().BeEquivalentTo(randomGuest);
        }

        [Fact]
        public async Task ShouldAddGuestAsyc()
        {
            //given
            Guest randomGuest = CreateRandomGuest();
            Guest inputGuest = randomGuest;
            Guest returningGuest = inputGuest;
            Guest expectedGuest = returningGuest;

            this.storageBrokerMock.Setup(broker =>
                broker.InsertGuestAsync(inputGuest)).ReturnsAsync(returningGuest);
            //when
            Guest actualGuest = await this.guestService.AddGuestAsync(inputGuest);

            //then
            actualGuest.Should().BeEquivalentTo(expectedGuest);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertGuestAsync(inputGuest), Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
        
    }
}
