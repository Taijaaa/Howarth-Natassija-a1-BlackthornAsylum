using System.ComponentModel;
using System.ComponentModel.Design;

//Step 1: introduction

Console.WriteLine("Welcome to the Blackthorn Asylum...");
Console.WriteLine("What is your name...?");
string playername = Console.Readline();
Console.WriteLine($"{playername}, tonight you are here to uncover it's secrets or die trying...");
Console.WriteLine("The choices you make will determine your fate...");
Console.WriteLine("The Blackthorn Aslyum awaits you... enter if you dare...");
Console.WriteLine("Type START GAME to begin.");

string input = Console.ReadLine();

//Step 2: Going inside the Asylum, players first choice that decides their ultimate fate, going foward or going right

if (input == "START GAME")
{

    Console.WriteLine("You arrive at the disheveled gates of the Blackthorn asylum.");
    Console.WriteLine("You exit your car and make your way to the eerie gates. You push open the heavy iron gates.");
    Console.WriteLine("Beyond, the asylum looms, covered in darkness.");
    Console.WriteLine("Inside the grounds, the air is thick with fog. You look straight head at the front doors of the asylum.");
    Console.WriteLine("Slowly, you make your up the steps and stand in front of the doors.");
    Console.WriteLine("You push open the creaking front door, stepping into a grand, but decaying foyer.");
    Console.WriteLine("A long hallway stretches ahead. You glance to your right, noticing a door.");
    Console.WriteLine("Do you go [straight] or [right]?");

}
else
{
    Console.WriteLine("You did not type START GAME try again.");
}

//Step 3: Exploring the hallway, player can go inside the dining hall or run away

string input2 = Console.ReadLine();

if (input2 == "straight")
{

    Console.WriteLine("You continue down the hallway. The hallway seems to stretch on forever, and the air feels colder with each step.");
    Console.WriteLine("Finally, you reach the end of the hall. To your surprise there is an arched open doorway that leads to what you only presume to be a dining hall.");
    Console.WriteLine("You hear something scurry in the shadows, but when you shine the light around, there's nothing there.");
    Console.WriteLine("You have been on edge since you stepped into the front doors of this place, now you are hearing things too...");
    Console.WriteLine("Do you go straight into the [dining hall] or run away back to the [foyer]?");

}

//Step 4: Dining hall continued, player can inspect a portrait or try to leave the dining hall

string input3 = Console.ReadLine();

    if (input3 == "dining hall") 
{

    Console.WriteLine("You step into the dining hall. A grand table stretches the length of the room, its surface covered in decades of dust, and tarnished silverware.");
    Console.WriteLine("You start to move across the room, carefully stepping over the left behind debris.");
    Console.WriteLine("On the far wall, a portrait of Dr. Elias Blackthorn hangs, completely undisturbed by the fire.");
    Console.WriteLine("His eyes seem to follow you as you approach it. You begin to feel uneasy.");
    Console.WriteLine("Do you [investigate] the portrait or turn around to go [back]?");

//Step 5: Inspect the portrait outcome

string input4 = Console.ReadLine();

    if (input4 == "investigate")
{ 

    Console.WriteLine("You make your way closer and closer to the eerily pristine portrait of Dr. Elias Blackthorn.");
    Console.WriteLine("With your flashlight pointed directly at the painting, you notice a tiny inscription on the bottom of the ornate frame.");
    Console.WriteLine("It reads: Never look directly into the eyes of Dr.Elias Blackthorn.");
    Console.WriteLine("Just then you take a step back and cast your light onto the portrait and look into the eyes that have been following you.");
    Console.WriteLine("The eyes blink at you... in this moment you are filled with terror. Frozen in fear as if your feet are glued to the floor.");
    Console.WriteLine("Ghostly arms reach out from the painting, you feel cold fingertips wrapped around your neck. The grip tightens.");
    Console.WriteLine("You feel as if your soul is being ripped from your body. As you try to gasp for air your eyes slowly roll to the back of your head.");
    Console.WriteLine("You collapse onto the floor. Your limp lifeless empty vessel lays still.");
    Console.WriteLine("You failed to uncover the secrets hidden inside and your ghost is forever trapped within the walls of the Blackthorn Asylum...");
    Console.WriteLine("** GAME OVER **");

        bool isplayeralive = false; 
        bool didescape = false;

        Console.WriteLine($"Did you survive : {isplayeralive}");
        Console.WriteLine($"Did you escape : {didescape}");
    
}

//Step 6: Trying to leave outcome

    else if (input4 == "back")
{

    Console.WriteLine("The portrait is unsettling to say the least and now you are starting to feel as if you might not be alone.");
    Console.WriteLine("You quickly start to make your way out of the dining hall. As you walk down the endless hallway, the sound of banging erupts.");
    Console.WriteLine("You realize its coming from the walls... your pace shifts from walking to running. The banging becomes faster and louder, causing your ears to ring.");
    Console.WriteLine("Racing down the toward the front door, but no matter how fast or far you go, it remains just out of reach.");
    Console.WriteLine("The banging is now deafening. The walls begin to close in on you. You claw at the narrowing walls, desperate for escape, but it’s no use.");
    Console.WriteLine("Your flashlight slips from your grasp, its beam flickering out as the crushing darkness envelops you completely.");
    Console.WriteLine("You failed to uncover the secrets hidden inside and your ghost is forever trapped within the walls of Blackthorn Asylum...");
    Console.WriteLine("** GAME OVER **");
        
    bool isplayeralive = false; 
    bool didescape = false;

    Console.WriteLine($"Did you survive : {isplayeralive}");
    Console.WriteLine($"Did you escape : {didescape}");

}

}

    else if (input3 == "foyer")
{
    Console.WriteLine("The darkness you begin to feel overwhelms you, your gut takes over. Before you know it you are sprinting out of the dining hall.");
    Console.WriteLine("As you dart down the never-ending hallway, you hear heavy footsteps racing towards you from behind.");
    Console.WriteLine("You don't dare to peak over you shoulder as you run away. Your heart is pounding as your flashlight guides you to the front door.");
    Console.WriteLine("You reach the front door in a panic and twist the doorknob. You swing the door open and escape. You leap down the stairs and jump into your car.");
    Console.WriteLine("You drive away in a hurry, flooring the gas pedal, still too afraid to look behind you...");
    Console.WriteLine("You've made it out unscathed but have failed to uncover the secrets left within the crumbling walls of the Blackthorn Asylum.");
    Console.WriteLine("Better luck next time... if you dare return again.");
    Console.WriteLine(" ** GAME OVER **");

        bool isplayeralive = true; 
        bool didescape = true;

        Console.WriteLine($"Did you survive : {isplayeralive}");
        Console.WriteLine($"Did you escape : {didescape}");

}



else if (input2 == "right")
{
    Console.WriteLine("You turn to the door on your right and gently push it open. The room inside is a study, long forgotten by time.");
    Console.WriteLine("An antique desk sits in the centre, cluttered with papers and strange, half-finished drawings.");
    Console.WriteLine("There is also a what appears to be a tiny door on the opposite side of the room.");
    Console.WriteLine("Do you [inspect] the desk or [crawl] through the tiny door?");

    string input5 = Console.ReadLine();

    if (input5 == "inspect")

    {

        Console.WriteLine("You approach the antique desk, brushing away layers of dust to reveal the scattered papers beneath.");
        Console.WriteLine("The drawings appear to be diagrams of human anatomy, with the phrase: unlock the mind and release the soul, written in ink.");
        Console.WriteLine("Among the clutter, you find a journal with E.B. etched into the leather cover. As you open it, you realize it belonged to Dr. Elias Blackthorn.");
        Console.WriteLine("The entries detail gruesome experiments Blackthorn conducted. He believed he could sever the connection between body and soul.");
        Console.WriteLine("Suddenly, a cold draft sweeps through the room, flipping the journal’s pages to a specific entry marked with a bloody handprint.");
        Console.WriteLine("Do you continue to read the [journal] or try to go through the tiny [door]?");
    }
    else if (input5 == "crawl")
    { 
    Console.WriteLine("You kneel down and push open the tiny door, its rusty hinges groaning. The passage way is cramped and suffocating.");
    Console.WriteLine("As you crawl through, your flashlight flickers, illuminating unsettling carvings engraved into the walls");
    Console.WriteLine("Suddenly, you hear a voice whispering incoherently, so close it feels like it’s coming from behind you.");
    Console.WriteLine("Before you can react, the ground beneath you gives away, and you fall through. Your body hits the cold, hard stone floor.");
    Console.WriteLine("You lay paralyzed. The whispers distort, transforming into sinister, mocking laughter that echoes you bleeding ears.");
    Console.WriteLine("You failed to uncover the secrets hidden inside and your ghost is forever trapped within the walls of Blackthorn Asylum...");
    Console.WriteLine("** GAME OVER **");

        bool isplayeralive = false; 
        bool didescape = false;

        Console.WriteLine($"Did you survive : {isplayeralive}");
        Console.WriteLine($"Did you escape : {didescape}");

    
    }
        

    string input6 = Console.ReadLine();

        if (input6 == "journal")
{
    Console.WriteLine("You flip to the blood stained page, and the entry sends a chill down your spine");
    Console.WriteLine("The entry reads:The experiment on Patient 21 was sucessful, the soul is severed but not destroyed.");
    Console.WriteLine("It continues: It lingers, bound to this place; It yearns to be set free, and will use anyone to escape");
    Console.WriteLine("Before you can process the words, the desk begins to shake violently, its drawers fly open and scatter the papers across the study.");
    Console.WriteLine("You sense a malevolent spirit is present. You don't waste another second. You hold onto the journal and make a run for the door.");
    Console.WriteLine("You enter the foyer. The whole asylum is rumbling. You run to the front door and swing it open. You race down the front steps.");
    Console.WriteLine("You make it to your car and watch as the Blackthorn Asylum comes crumbling down.");
    Console.WriteLine("Congratulations, you made it out alive and successfully uncovered the secrets of Dr.Elias Blackthorn.");

        bool isplayeralive = true; 
        bool didescape = true;

        Console.WriteLine($"Did you survive : {isplayeralive}");
        Console.WriteLine($"Did you escape : {didescape}");

}
    else if (input6 == "door")
    {

        Console.WriteLine("You kneel down and push open the tiny door, its rusty hinges groaning. The passage way is cramped and suffocating.");
        Console.WriteLine("As you crawl through, your flashlight flickers, illuminating unsettling carvings etched into the walls.");
        Console.WriteLine("Suddenly, you hear a voice whispering incoherently, so close it feels like it’s coming from behind you.");
        Console.WriteLine("Before you can react, the ground beneath you gives away, and you fall through. Your body hits the cold, hard stone floor.");
        Console.WriteLine("You lay paralyzed. The whispers distort, transforming into sinister, mocking laughter that echoes through your bleeding ears.");
        Console.WriteLine("You failed to uncover the secrets hidden inside and your ghost is forever trapped within the walls of Blackthorn Asylum...");
        Console.WriteLine("** GAME OVER **");

        bool isplayeralive = false; 
        bool didescape = false;

        Console.WriteLine($"Did you survive : {isplayeralive}");
        Console.WriteLine($"Did you escape : {didescape}");


    }

    
}



else
{
    Console.WriteLine("You did not type a vaild answer.");
}

