# Number Guessing Game

## Description

A simple number guessing game where the player tries to guess a randomly generated number between 1 and 20. The game provides feedback on whether the guess is too high or too low until the correct number is guessed. Players can choose from three difficulty levels, each with a different number of allowed guesses. The player starts with a score of 100, which decreases with each incorrect guess.

## How to Play

1. The game selects a random number between 1 and 20.
2. The player selects a difficulty level:
   - **Easy:** 10 guesses
   - **Medium:** 5 guesses
   - **Hard:** 3 guesses
3. The player starts with a score of 100.
4. The player enters a guess.
5. The game provides feedback:
   - "The secret number is lower" if the guess is greater than the number.
   - "The secret number is higher" if the guess is less than the number.
   - "Correct!" if the guess matches the number.
6. The score decreases with each incorrect guess.
7. The game ends when the player guesses correctly or runs out of guesses.

# Number Guessing Game

## Description

A simple number guessing game written in C# where the player tries to guess a randomly generated number between 1 and 20. The game provides feedback on whether the guess is too high or too low until the correct number is guessed. Players can choose from three difficulty levels, each with a different number of allowed guesses. The player starts with a score of 100, which decreases with each incorrect guess.

## How to Play

1. The game selects a random number between 1 and 20.
2. The player selects a difficulty level:
   - **Easy:** 10 guesses
   - **Medium:** 5 guesses
   - **Hard:** 3 guesses
3. The player starts with a score of 100.
4. The player enters a guess.
5. The game provides feedback:
   - "Too high!" if the guess is greater than the number.
   - "Too low!" if the guess is less than the number.
   - "Correct!" if the guess matches the number.
6. The score decreases with each incorrect guess.
7. The game ends when the player guesses correctly or runs out of guesses.

## Demo

![Number Guessing Game](https://i.imgur.com/k8uANRN.gif)

## Installation

1. Clone this repository:
   ```sh
   git clone https://github.com/your-username/number-guessing-game.git
   ```
2. Navigate to the project directory:
   ```sh
   cd number-guessing-game
   ```
3. Build and run the project using .NET:
   ```sh
   dotnet build
   dotnet run 
   ```

## Usage

- Run the project using .NET CLI and follow the on-screen instructions to select a difficulty level and play the game.
- Modify the range or add extra features as needed.

## Contributing

Contributions are welcome! Feel free to submit issues or pull requests to improve the game.


