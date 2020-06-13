using TourOfHeroes.Web.Common.State.Details;
using Xunit;

namespace TourOfHeroes.Web.Tests.Common.State.Details.RetrieveOne
{
    /// <summary>
    /// Unit tests for <see cref="DetailsState.RetrieveOneAction"/>.
    /// </summary>
    public class RetrieveOneActionTests
    {
        /// <summary>
        /// Happy path.
        /// </summary>
        /// <param name="expectedPayload">The payload to test with.</param>
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void RetrieveOneAction_ValidPayload_SetsPayload(int expectedPayload)
        {
            // Given a well formed action.
            var actualPayload = new DetailsState.RetrieveOneAction(expectedPayload);

            // It should be instantiated with the given payload.
            Assert.Equal(expectedPayload, actualPayload.Id);
        }
    }
}
