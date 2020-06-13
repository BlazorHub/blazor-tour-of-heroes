using System;
using BlazorState;

namespace TourOfHeroes.Web.Common.State.Heroes
{
    /// <inheritdoc/>
    public partial class HeroesState
    {
        /// <summary>
        /// Action for creating a Hero.
        /// </summary>
        public class CreateAction : IAction
        {
            /// <summary>
            /// Gets the name of the Hero.
            /// </summary>
            public string Name { get; }

            /// <summary>
            /// Initializes a new instance of the <see cref="CreateAction"/> class.
            /// </summary>
            /// <param name="name">The payload to create with.</param>
            /// <exception cref="ArgumentNullException">Thrown if name is null.</exception>  
            public CreateAction(string name)
            {
                Name = name ?? throw new ArgumentNullException(nameof(name));
            }
        }
    }
}
