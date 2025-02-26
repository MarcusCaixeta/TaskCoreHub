using FluentAssertions;
using NSubstitute;
using TaskCoreHub.Core.Entitites;
using TaskCoreHub.Core.ValueObjects;

namespace CoreTests.Tests
{
    public class CoreTests
    {
        [Fact]
        public void Should_Create_Demand_With_Valid_Data()
        {
            // Arrange
            var team = Substitute.For<Team>();
            var reason = Substitute.For<Reason>();
            var user = Substitute.For<User>();
            var priority = Priority.Medium;
            var effort = 5;
            var dateStart = DateTime.UtcNow;

            // Act
            var demand = new Demand("New Feature", "Implement feature X", team, reason, user, dateStart, priority, effort);

            // Assert
            demand.Should().NotBeNull();
            demand.Title.Should().Be("New Feature");
            demand.Status.Should().Be(DemandStatus.Created);
        }

        [Fact]
        public void Should_Throw_Exception_When_Creating_Demand_With_Invalid_Data()
        {
            // Arrange
            var team = Substitute.For<Team>();
            var reason = Substitute.For<Reason>();
            var user = Substitute.For<User>();
            var priority = Priority.High;
            var effort = 10;
            var dateStart = DateTime.UtcNow;

            // Act & Assert
            FluentActions.Invoking(() => new Demand(null, "Description", team, reason, user, dateStart, priority, effort))
                .Should().Throw<ArgumentException>()
                .WithMessage("Title is required");

            FluentActions.Invoking(() => new Demand("Title", null, team, reason, user, dateStart, priority, effort))
                .Should().Throw<ArgumentException>()
                .WithMessage("Description is required");
        }

        [Fact]
        public void Should_Start_Progress()
        {
            // Arrange
            var team = Substitute.For<Team>();
            var reason = Substitute.For<Reason>();
            var user = Substitute.For<User>();
            var anotherUser = Substitute.For<User>();
            var priority = Priority.Medium;
            var effort = 3;
            var dateStart = DateTime.UtcNow;
            var demand = new Demand("Task A", "Implement X", team, reason, user, dateStart, priority, effort);

            // Act
            demand.StartProgress(anotherUser);

            // Assert
            demand.Status.Should().Be(DemandStatus.InProgress);
            demand.UserInProgress.Should().Be(anotherUser);
        }

        [Fact]
        public void Should_Throw_Exception_When_Starting_Progress_If_Not_Created()
        {
            // Arrange
            var team = Substitute.For<Team>();
            var reason = Substitute.For<Reason>();
            var user = Substitute.For<User>();
            var priority = Priority.High;
            var effort = 5;
            var dateStart = DateTime.UtcNow;
            var demand = new Demand("Feature X", "Build a new module", team, reason, user, dateStart, priority, effort);
            demand.StartProgress(user); // Muda status para InProgress

            // Act & Assert
            FluentActions.Invoking(() => demand.StartProgress(user))
                .Should().Throw<InvalidOperationException>()
                .WithMessage("Cannot start progress on a demand that is not in 'Created' status.");
        }

        [Fact]
        public void Should_Finish_Demand()
        {
            // Arrange
            var team = Substitute.For<Team>();
            var reason = Substitute.For<Reason>();
            var finishReason = Substitute.For<Reason>();
            var user = Substitute.For<User>();
            var priority = Priority.Low;
            var effort = 2;
            var dateStart = DateTime.UtcNow;
            var demand = new Demand("Fix Bug", "Resolve issue Y", team, reason, user, dateStart, priority, effort);
            demand.StartProgress(user);

            // Act
            demand.FinishDemand(user, finishReason);

            // Assert
            demand.Status.Should().Be(DemandStatus.Finished);
            demand.UserFinish.Should().Be(user);
            demand.FinishReason.Should().Be(finishReason);
        }

        [Fact]
        public void Should_Throw_Exception_When_Finishing_Demand_If_Not_InProgress()
        {
            // Arrange
            var team = Substitute.For<Team>();
            var reason = Substitute.For<Reason>();
            var finishReason = Substitute.For<Reason>();
            var user = Substitute.For<User>();
            var priority = Priority.Low;
            var effort = 2;
            var dateStart = DateTime.UtcNow;
            var demand = new Demand("Fix Bug", "Resolve issue Y", team, reason, user, dateStart, priority, effort);

            // Act & Assert
            FluentActions.Invoking(() => demand.FinishDemand(user, finishReason))
                .Should().Throw<InvalidOperationException>()
                .WithMessage("Cannot finish a demand that is not in 'InProgress' status.");
        }
    }
}