Console.OutputEncoding = System.Text.Encoding.Default;

const int ROCK = 1;
const int PAPER = 2;
const int SCISSORS = 3;
const int LIZARD = 4;
const int SPOCK = 5;

const int DRAW = 0;
const int PLAYER1_WINS = 1;
const int PLAYER2_WINS = 2;

Console.Write("Player 1, choose (1) for rock 🪨, (2) for paper 📜, (3) for scissors ✂️, (4) for lizard 🦎 and (5) for spock 🖖: ");
int player1 = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.Write("Player 2, choose (1) for rock 🪨, (2) for paper 📜, (3) for scissors ✂️, (4) for lizard 🦎 and (5) for spock 🖖: ");
int player2 = int.Parse(Console.ReadLine()!);
Console.Clear();

int winner = DRAW;

switch (player1)
{
    case ROCK:
        switch (player2)
        {
            case PAPER:
            case SPOCK:
                winner = PLAYER2_WINS;
                break;
            case SCISSORS:
            case LIZARD:
                winner = PLAYER1_WINS;
                break;
            default:
                winner = DRAW;
                break;
        }
        break;

    case PAPER:
        switch (player2)
        {
            case ROCK:
            case SPOCK:
                winner = PLAYER1_WINS;
                break;
            case SCISSORS:
            case LIZARD:
                winner = PLAYER2_WINS;
                break;
            default:
                winner = DRAW;
                break;
        }
        break;

    case SCISSORS:
        switch (player2)
        {
            case ROCK:
            case SPOCK:
                winner = PLAYER2_WINS;
                break;
            case PAPER:
            case LIZARD:
                winner = PLAYER1_WINS;
                break;
            default:
                winner = DRAW;
                break;
        }
        break;

    case LIZARD:
        switch (player2)
        {
            case ROCK:
            case SCISSORS:
                winner = PLAYER2_WINS;
                break;
            case PAPER:
            case SPOCK:
                winner = PLAYER1_WINS;
                break;
            default:
                winner = DRAW;
                break;
        }
        break;

    case SPOCK:
        switch (player2)
        {
            case ROCK:
            case SCISSORS:
                winner = PLAYER1_WINS;
                break;
            case PAPER:
            case LIZARD:
                winner = PLAYER2_WINS;
                break;
            default:
                winner = DRAW;
                break;
        }
        break;
    default:
        break;
}

switch (winner)
{
    case PLAYER1_WINS:
        Console.WriteLine("Congratulations Player 1, you won the game 🥳!\n");
        break;

    case PLAYER2_WINS:
        Console.WriteLine("Congratulations Player 2, you won the game 🥳!\n");
        break;

    case DRAW:
        Console.WriteLine("No winner repeat the game!\n");
        break;
    default:
        break;
}

Console.WriteLine("Press any key to exit: ");
Console.ReadKey();
Console.Clear();


// how to make it with if-statements:
/*
if (player1 == ROCK)
{
    if (player2 == PAPER) { winner = PLAYER2_WINS; }
    else if (player2 == SCISSORS) { winner = PLAYER1_WINS; }
    else if (player2 == LIZARD) { winner = PLAYER1_WINS; }
    else if (player2 == SPOCK) { winner = PLAYER2_WINS; }
}
else if (player1 == PAPER)
{
    if (player2 == ROCK) { winner = PLAYER1_WINS; }
    else if (player2 == SCISSORS) { winner = PLAYER2_WINS; }
    else if (player2 == LIZARD) { winner = PLAYER2_WINS; }
    else if (player2 == SPOCK) { winner = PLAYER1_WINS; }
}
else if (player1 == SCISSORS)
{
    if (player2 == ROCK) { winner = PLAYER2_WINS; }
    else if (player2 == PAPER) { winner = PLAYER1_WINS; }
    else if (player2 == LIZARD) { winner = PLAYER1_WINS; }
    else if (player2 == SPOCK) { winner = PLAYER2_WINS; }
}
else if (player1 == LIZARD)
{
    if (player2 == ROCK) { winner = PLAYER2_WINS; }
    else if (player2 == PAPER) { winner = PLAYER1_WINS; }
    else if (player2 == SCISSORS) { winner = PLAYER2_WINS; }
    else if (player2 == SPOCK) { winner = PLAYER1_WINS; }
}
else if (player1 == SPOCK)
{
    if (player2 == ROCK) { winner = PLAYER1_WINS; }
    else if (player2 == PAPER) { winner = PLAYER2_WINS; }
    else if (player2 == SCISSORS) { winner = PLAYER1_WINS; }
    else if (player2 == LIZARD) { winner = PLAYER2_WINS; }
}

if (winner == DRAW) { Console.WriteLine("\nNo winner repeat game!\n"); }
else { Console.WriteLine("\nPlayer " + winner + " wins! 🥳 \n"); }
*/
