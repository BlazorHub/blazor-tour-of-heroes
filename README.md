# Blazor Tour of Heroes
![.NET Core](https://github.com/georgemathieson/blazor-tour-of-heroes/workflows/.NET%20Core/badge.svg?branch=master)

The [Angular Tour of Heroes](https://angular.io/tutorial) tutorial, but done using [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) instead. Largely built as an opportunity to learn server-side Blazor with a Redux style state management system.

## 🚀 Running the app locally
You'll want the latest version of the [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core).

The simplest way to get started is to use Visual Studio to run the project. Be sure to set your startup project to `TourOfHeroes.Web`.

You can run using the command line:

`dotnet run --project src/TourOfHeroes.Web`.

The tests can also be run this way:

`dotnet test`

## 😎 Credits
* [Adorable Avatars!](http://avatars.adorable.io) for the.. adorable avatars
* [Blazor-State](https://github.com/TimeWarpEngineering/blazor-state) for the Redux style state
* [Blazored Typeahead](https://github.com/Blazored/Typeahead) for the Typeahead control on the search
