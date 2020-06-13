using System.Linq;
using BlazorState;
using Microsoft.AspNetCore.Components;
using TourOfHeroes.Web.Common.State.Heroes;

namespace TourOfHeroes.Web.Common.Containers.TopHeroes
{
    /// <summary>
    /// Top Heroes.
    /// </summary>
    public class TopHeroesBase : BlazorStateComponent
    {
        /// <summary>
        /// Gets or sets the <see cref="NavigationManager"/>.
        /// </summary>
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        /// <summary>
        /// Gets the heroes state.
        /// </summary>
        protected HeroesState HeroesState => GetState<HeroesState>();

        /// <summary>
        /// Send the user to the details page.
        /// </summary>
        /// <param name="id">The id of the Hero to view details for.</param>
        protected void NavigateToHeroDetails(int id)
        {
            NavigationManager.NavigateTo($"/details/{id}");
        }

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            if (HeroesState.Heroes.Any() == false)
            {
                Mediator.Send(new HeroesState.RetrieveManyAction());
            }
        }
    }
}