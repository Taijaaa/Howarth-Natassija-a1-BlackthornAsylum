using System.ComponentModel;
using System.ComponentModel.Design;

Console.WriteLine("Welcome to Blackthorn Asylum");
Console.WriteLine("Tonight, you are here to uncover it's secrets.");
Console.WriteLine("The choices you make will determine your fate.");
Console.WriteLine("The Blackthorn Aslyum awaits you... enter if you dare.");
Console.WriteLine(" Type * START GAME * to begin.");

string input = Console.ReadLine();

if (input == "START GAME")
{
    Console.WriteLine("You arrive at the disheveled gates of the Blackthorn asylum.");
    Console.WriteLine("You exit your car and make your way to the eerie gates. You push open the heavy iron gates.");
    Console.WriteLine("Beyond, the asylum looms, covered in darkness.");
    Console.WriteLine("Inside the grounds, the air is thick with fog. You look straight head at the front doors of the asylum.");
    Console.WriteLine("Slowly, you make your up the steps and stand in front of the doors.");
    Console.WriteLine("You push open the creaking front door, stepping into a grand, but decaying foyer.");
    Console.WriteLine("A long hallway stretches ahead. As you step fully inside, the door slams shut behind you with a deafening thud.");

}
else
{
    Console.WriteLine("You did not type * START GAME * try again.");
}

Console.WriteLine("You glance to your right, noticing a door. Do you go [straight] or [right]?");

string input2 = Console.ReadLine();

if (input2 == "straight")
{
    Console.WriteLine("You continue down the hallway. The hallway seems to stretch on forever, and the air feels colder with each step.");
    Console.WriteLine("Finally, you reach the end of the hall. To your surprise there is an arched open doorway that leads to what you only presume to be a dining hall.");
    Console.WriteLine("You hear something scurry in the shadows, but when you shine the light around, there's nothing there.");
    Console.WriteLine("Do you go straight into the [dining hall] or run away back to the [foyer]?");

}


string input3 = Console.ReadLine();

    if (input3 == "dining hall") 
{
    Console.WriteLine("You step into the dining hall. A grand table stretches the length of the room, its surface covered in cracked plates and tarnished silverware.");
    Console.WriteLine("You start to move across the room, carefully stepping over the left behind debris.");
    Console.WriteLine("On the far wall, a portrait of Dr. Elias Blackthorn hangs, completely unharmed by the fire.");
    Console.WriteLine("His eyes seem to follow you as you get closer to it. You start to feel uneasy.");
    Console.WriteLine("Do you [investigate] or turn around to go [back]");

}

    else if (input3 == "foyer")
{
    Console.WriteLine("you go to the foyer test.");
}


else if (input2 == "right")
{
    Console.WriteLine("You turn to the door on your right and gently push it open. The room inside is a study, long forgotten by time.");
    Console.WriteLine("An antique desk sits in the center, cluttered with papers and strange, half-finished drawings.");
    Console.WriteLine("You notice a small cabinet in the corner of the study with a lock on it.");
}
else
{
    Console.WriteLine("You did not type a vaild answer.");
}

