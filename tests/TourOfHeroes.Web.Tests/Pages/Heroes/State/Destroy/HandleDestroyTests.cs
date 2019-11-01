using System.Threading;
using TourOfHeroes.Web.Pages.Heroes.Models;
using TourOfHeroes.Web.Pages.Heroes.State;
using Xunit;

namespace TourOfHeroes.Web.Tests.Pages.Heroes.State.Destroy
{
    /// <summary>
    /// Unit tests for <see cref="HeroesState.HandleDestroy"/>.
    /// </summary>
    public class HandleDestroyTests : BaseHeroStateTestSetup
    {
        /// <summary>
        /// The <see cref="HeroesState.HandleDestroy"/> to test with.
        /// </summary>
        private readonly HeroesState.HandleDestroy _handleDestroy;

        /// <summary>
        /// Initializes a new instance of the <see cref="HandleDestroyTests"/> class.
        /// </summary>
        public HandleDestroyTests()
        {
            _handleDestroy = new HeroesState.HandleDestroy(_mockStore.Object);
        }

        /// <summary>
        /// Happy path.
        /// </summary>
        /// <param name="payload">The payload to test with.</param>
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void HandleDestroy_ValidAction_UpdatesState(int payload)
        {
            // Arrange.
            var action = new HeroesState.DestroyAction(payload);
            _heroesState.Heroes.Add(new Hero
            {
                Id = payload
            });
            
            // Act.
            _handleDestroy.Handle(action, new CancellationToken());

            // Assert.
            Assert.Empty(_heroesState.Heroes);
        }
    }
}
