const int PIRATE = 1;
const int STONE_CHEWER = 2;
const int GHOST_WARRIOR = 3;
const int OUTWORLDER = 4;
const int MONSTER_KNIGHT = 5;
const int DARK_GOBLIN = 6;

const int HEALTH_PIRATE = 20;
const int HEALTH_STONE_CHEWER = 50;
const int HEALTH_GHOST_WARRIOR = 20;
const int HEALTH_OUTWORLDER = 15;
const int HEALTH_MONSTER_KNIGHT = 15;
const int HEALTH_DARK_GOBLIN = 10;

const int ATTACK_PIRATE = 3;
const int ATTACK_STONE_CHEWER = 8;
const int ATTACK_GHOST_WARRIOR = 2;
const int ATTACK_OUTWORLDER = 1;
const int ATTACK_MONSTER_KNIGHT = 4;
const int ATTACK_DARK_GOBLIN = 1;

const int SPEED_PIRATE = 3;
const int SPEED_STONE_CHEWER = 1;
const int SPEED_GHOST_WARRIOR = 5;
const int SPEED_OUTWORLDER = 10;
const int SPEED_MONSTER_KNIGHT = 3;
const int SPEED_DARK_GOBLIN = 3;

const int ARMOR_PIRATE = 3;
const int ARMOR_STONE_CHEWER = 10;
const int ARMOR_GHOST_WARRIOR = 2;
const int ARMOR_OUTWORLDER = 2;
const int ARMOR_MONSTER_KNIGHT = 3;
const int ARMOR_DARK_GOBLIN = 8;

int health1 = 0;
int health2 = 0;

int attack1 = 0;
int attack2 = 0;

int speed1 = 0;
int speed2 = 0;

int armor1 = 0;
int armor2 = 0;

int armor_health1 = armor1 + health1;
int armor_health2 = armor2 + health2;

Console.Write("Player 1 choose your character role! Type 1 for pirate, 2 for stone chewer, 3 for ghost warrior, 4 for outworlder, 5 for monster knight or 6 for dark goblin: ");
int role1 = int.Parse(Console.ReadLine()!);

Console.Write("Player 2 choose your character role! Type 1 for pirate, 2 for stone chewer, 3 for ghost warrior, 4 for outworlder, 5 for monster knight or 6 for dark goblin: ");
int role2 = int.Parse(Console.ReadLine()!);

switch (role1)
{
    case PIRATE:
        health1 = HEALTH_PIRATE ;
        attack1 = ATTACK_PIRATE;
        speed1 = SPEED_PIRATE;
        armor1 = ARMOR_PIRATE;

        break;

    case STONE_CHEWER:
        health1 = HEALTH_STONE_CHEWER;
        attack1 = ATTACK_STONE_CHEWER;
        speed1 = SPEED_STONE_CHEWER;
        armor1 = ARMOR_STONE_CHEWER;
        break;

    case GHOST_WARRIOR:
        health1 = HEALTH_GHOST_WARRIOR;
        attack1 = ATTACK_GHOST_WARRIOR;
        speed1 = SPEED_GHOST_WARRIOR;
        armor1 = ARMOR_GHOST_WARRIOR;
        break;
    
    case OUTWORLDER:
        health1 = HEALTH_OUTWORLDER;
        attack1 = ATTACK_OUTWORLDER;
        speed1 = SPEED_OUTWORLDER;
        armor1 = ARMOR_OUTWORLDER;
        break;

    case MONSTER_KNIGHT:
        health1 = HEALTH_MONSTER_KNIGHT;
        attack1 = ATTACK_MONSTER_KNIGHT;
        speed1 = SPEED_MONSTER_KNIGHT;
        armor1 = ARMOR_MONSTER_KNIGHT;
        break;
    
    case DARK_GOBLIN:
        health1 = HEALTH_DARK_GOBLIN;
        attack1 = ATTACK_DARK_GOBLIN;
        speed1 = SPEED_DARK_GOBLIN;
        armor1 = ARMOR_DARK_GOBLIN;
        break;
}

switch (role2)
{
    case PIRATE:
        health2 = HEALTH_PIRATE ;
        attack2 = ATTACK_PIRATE;
        speed2 = SPEED_PIRATE;
        armor2 = ARMOR_PIRATE;

        break;

    case STONE_CHEWER:
        health2 = HEALTH_STONE_CHEWER;
        attack2 = ATTACK_STONE_CHEWER;
        speed2 = SPEED_STONE_CHEWER;
        armor2 = ARMOR_STONE_CHEWER;
        break;

    case GHOST_WARRIOR:
        health2 = HEALTH_GHOST_WARRIOR;
        attack2 = ATTACK_GHOST_WARRIOR;
        speed2 = SPEED_GHOST_WARRIOR;
        armor2 = ARMOR_GHOST_WARRIOR;
        break;
    
    case OUTWORLDER:
        health2 = HEALTH_OUTWORLDER;
        attack2 = ATTACK_OUTWORLDER;
        speed2 = SPEED_OUTWORLDER;
        armor2 = ARMOR_OUTWORLDER;
        break;

    case MONSTER_KNIGHT:
        health2 = HEALTH_MONSTER_KNIGHT;
        attack2 = ATTACK_MONSTER_KNIGHT;
        speed2 = SPEED_MONSTER_KNIGHT;
        armor2 = ARMOR_MONSTER_KNIGHT;
        break;
    
    case DARK_GOBLIN:
        health2 = HEALTH_DARK_GOBLIN;
        attack2 = ATTACK_DARK_GOBLIN;
        speed2 = SPEED_DARK_GOBLIN;
        armor2 = ARMOR_DARK_GOBLIN;
        break;
}

while (armor_health1 > 0 && armor_health2 > 0)
{
    
    armor_health1 -= attack2 * speed2;
    armor_health2 -= attack1 * speed1;
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

