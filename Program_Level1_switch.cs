const int PIRATE = 1;
const int STONE_CHEWER = 2;
const int GHOST_WARRIOR = 3;

const int HEALTH_PIRATE = 20;
const int HEALTH_STONE_CHEWER = 50;
const int HEALTH_GHOST_WARRIOR = 20;

const int ATTACK_PIRATE = 3;
const int ATTACK_STONE_CHEWER = 8;
const int ATTACK_GHOST_WARRIOR = 2;

const int SPEED_PIRATE = 3;
const int SPEED_STONE_CHEWER = 1;
const int SPEED_GHOST_WARRIOR = 5;

int health1 = 0;
int health2 = 0;

int attack1 = 0;
int attack2 = 0;

int speed1 = 0;
int speed2 = 0;

Console.Write("Player 1 choose your character role! Type 1 for pirate, 2 for stone chewer or 3 for ghost warrior: ");
int role1 = int.Parse(Console.ReadLine()!);

Console.Write("Player 2 choose your character role! Type 1 for pirate, 2 for stone chewer or 3 for ghost warrior: ");
int role2 = int.Parse(Console.ReadLine()!);

switch (role1)
{
    case PIRATE:
        health1 = HEALTH_PIRATE;
        break;

    case STONE_CHEWER:
        health1 = HEALTH_STONE_CHEWER;
        break;

    case GHOST_WARRIOR:
        health1 = HEALTH_GHOST_WARRIOR;
        break;
}

switch (role2)
{
    case PIRATE:
        health2 = HEALTH_PIRATE;
        break;

    case STONE_CHEWER:
        health2 = HEALTH_STONE_CHEWER;
        break;

    case GHOST_WARRIOR:
        health2 = HEALTH_GHOST_WARRIOR;
        break;
}

switch (role1)
{
    case PIRATE:
        attack1 = ATTACK_PIRATE;
        break;
    
    case STONE_CHEWER:
        attack1 = ATTACK_STONE_CHEWER;
        break;
    
    case GHOST_WARRIOR:
        attack1 = ATTACK_GHOST_WARRIOR;
        break;
}

switch (role2)
{
    case PIRATE:
        attack2 = ATTACK_PIRATE;
        break;
    
    case STONE_CHEWER:
        attack2 = ATTACK_STONE_CHEWER;
        break;
    
    case GHOST_WARRIOR:
        attack2 = ATTACK_GHOST_WARRIOR;
        break;
}

switch (role1)
{
    case PIRATE:
        speed1 = SPEED_PIRATE;
        break;
    
    case STONE_CHEWER:
        speed1 = SPEED_STONE_CHEWER;
        break;
    
    case GHOST_WARRIOR:
        speed1 = SPEED_GHOST_WARRIOR;
        break;
}

switch (role2)
{
    case PIRATE:
        speed2 = SPEED_PIRATE;
        break;
    
    case STONE_CHEWER:
        speed2 = SPEED_STONE_CHEWER;
        break;
    
    case GHOST_WARRIOR:
        speed2 = SPEED_GHOST_WARRIOR;
        break;
}

while (health1 > 0 && health2 > 0)
{
    health1 -= attack2 * speed2;
    health2 -= attack1 * speed1;
}

if (health1 > 0) { Console.WriteLine("Player 1 wins!"); }
else if (health2 > 0) { Console.WriteLine("Player 2 wins!"); }
else { Console.WriteLine("Draw! Nobody wins."); }

/*
if (role1 == PIRATE)
{
    health1 = HEALTH_PIRATE;
    if (role2 == PIRATE)
    {
        health2 = HEALTH_PIRATE;
        while (health1 >= 0 && health2 >= 0)
        {
            health1 -= 3 * 3;
            health2 -= 3 * 3;
        }
    }

    else if (role2 == STONE_CHEWER)
    {
        health2 = HEALTH_STONE_CHEWER;
        while (health1 >= 0 && health2 >= 0)
        {
            health1 -= 8 * 1;
            health2 -= 3 * 3;
        }
    }

    else if (role2 == GHOST_WARRIOR)
    {
        health2 = HEALTH_GHOST_WARRIOR;
        while (health1 >= 0 && health2 >= 0)
        {
            health1 -= 2 * 5;
            health2 -= 3 * 3;
        }
    }

}

else if (role1 == STONE_CHEWER)
{
    health1 = HEALTH_STONE_CHEWER;
    if (role2 == PIRATE)
    {
        health2 = HEALTH_PIRATE;
        while (health1 >= 0 && health2 >= 0)
        {
            health1 -= 8 * 1;
            health2 -= 3 * 3;
        }
    }

    else if (role2 == STONE_CHEWER)
    {
        health2 = HEALTH_STONE_CHEWER;
        while (health1 >= 0 && health2 >= 0)
        {
            health1 -= 8 * 1;
            health2 -= 8 * 1;
        }
    }

    else if (role2 == GHOST_WARRIOR)
    {
        health2 = HEALTH_GHOST_WARRIOR;
        while (health1 >= 0 && health2 >= 0)
        {
            health1 -= 2 * 5;
            health2 -= 8 * 1;
        }
    }
}

else if (role1 == GHOST_WARRIOR)
{
    health1 = HEALTH_GHOST_WARRIOR;
    if (role2 == PIRATE)
    {
        health2 = HEALTH_PIRATE;
        while (health1 >= 0 && health2 >= 0)
        {
            health1 -= 3 * 3;
            health2 -= 2 * 5;
        }
    }

    else if (role2 == STONE_CHEWER)
    {
        health2 = HEALTH_STONE_CHEWER;
        while (health1 >= 0 && health2 >= 0)
        {
            health1 -= 8 * 1;
            health2 -= 2 * 5;
        }
    }

    else if (role2 == GHOST_WARRIOR)
    {
        health2 = HEALTH_GHOST_WARRIOR;
        while (health1 >= 0 && health2 >= 0)
        {
            health1 -= 2 * 5;
            health2 -= 2 * 5;
        }
    }
}
*/

