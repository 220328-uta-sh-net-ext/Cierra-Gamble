// ROLE PLAYING GAME BATTLE CHALLENGE -->
	// In most role playing games, the player's character battles non-player characters, which are usually monsters or the "bad guys". Usually, a battle consists of each character generating a random value using dice and that value is subtracted from the opponent's health score. Once either character's health reaches zero, they die or lose.

	// In this challenge, we'll boil down that interaction to its essence. A hero and a monster start with the same health score. During the hero's turn, they'll generate a random value which will be subtracted from the monster's health. If the monster's health is greater than zero, they'll take their turn and attack the hero. As long as both the hero and the monster have health greater than zero, the battle will resume.
// STEP 1 - DELETE ALL OF THE CODE IN THE .NET EDITOR FROM THE EARLIER EXERCISE.

	// Select all of the code in the .NET Editor then select the del or backspace key to delete it.
// STEP 2 - WRITE CODE IN THE .NET EDITOR TO IMPLEMENT THE GAME RULES.
/*
Implement the following rules for the game:
Game Rules
	The hero and the monster will start with 10 health points.
	All attacks will be a value between 1 and 10.
	The hero will attack first.
	Print the amount of health the monster lost and their remaining health.
	If the monster's health is greater than 0, it can attack the hero.
	Print the amount of health the hero lost and their remaining health.
	Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
	Print the winner.
		Most importantly:
		You must use either the do-while statement, or the while statement.
No matter how you do it, your code should produce a similar output:
Output
*/


Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
// Obviously, because of the random nature of the code, the outcome will be different each time, so your results will definitely be different that the output displayed above. However, you can use this as an example of the output your code should generate.
	// -* Whether you get stuck and need to peek at the solution or you finish successfully, continue on to view a solution to this challenge.
// 				SOLUTION

int hero = 10;
int monster = 10;
// SETTING INTEGERS(INT=TYPE) FOR HERO AND MONSTER VARIABLE (IDENTIFIERS)
Random dice = new Random();
// RANDOM=NAMESPACE?? (YES) DICE IS NAME OF NAMESPACE
do // (METHOD/ATTRIBUTES/FUNCTION)
// START OF DO-WHILE STATEMENT=BOOLEAN EXPRESSION BECAUSE IT EXPRESSES IN "TRUE' OR "FALSE"
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health."); //METHOD FOR TYPE AND INDENTIFIERS AND WHAT TO WRITE 

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
	//METHOD FOR TYPE AND INDENTIFIERS AND WHAT TO WRITE 

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
//METHOD FOR TYPE AND INDENTIFIERS AND WHAT TO WRITE 