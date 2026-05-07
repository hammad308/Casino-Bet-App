# Casino Bet App

Casino Bet App is a C# Windows Forms casino-style game application built with .NET 10.0 for Windows. It includes a splash screen, a main menu, two playable games, a balance manager, and a printable game report.

## Features

- Splash screen launcher
- Main menu navigation
- Number Guess game
- Roll Dice game
- Bet amount selection with balance validation
- Win/loss balance updates
- Game history report list
- Printable report using `PrintDocument`

## Project Structure

- `Program.cs` — application entry point
- `ClassforObjects.cs` — shared application state and form instances
- `MainMenuForm.cs` — main menu UI and navigation
- `NumberGuessForm.cs` — number guess game logic
- `RollDiceForm.cs` — dice roll game logic
- `ReportForm.cs` — game history and print preview
- `GameReport.cs` — game report model
- `SplashForm.cs` — splash screen logic
- `Properties/Resources.Designer.cs` — generated resource access
- `Images/` — dice images used by the game
- `Resources/` — additional embedded resources

## Requirements

- Windows OS
- .NET SDK 10.0
- Visual Studio or another compatible C# IDE supporting Windows Forms

## Build and Run

1. Open `Casino Bet App.slnx` or `Casino Bet App.csproj` in Visual Studio.
2. Restore NuGet packages if prompted.
3. Build the solution.
4. Run the application.

## Notes

- Starting balance is managed via `ClassforObjects.balance`.
- Selected bets are stored in `ClassforObjects.betAmount`.
- Game reports are stored in `ClassforObjects.Reports`.
- The application uses `Microsoft.ReportingServices.ReportViewerControl.Winforms` and `Microsoft.ReportViewer.WinForms` packages.

## License

This project does not include a license file. Add one if you want to make the repository open source.
