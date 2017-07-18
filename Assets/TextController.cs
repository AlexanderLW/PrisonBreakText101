using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {
							cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, 
							corridor_0, closet_door, floor, stairs_0, stairs_1, corridor_1,
							in_closet, corridor_2, stairs_2, corridor_3, courtyard
						};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		
		print (myState);
		
		if 		(myState == States.cell) 			{cell();}
		else if (myState == States.sheets_0)		{sheets_0();} 
		else if (myState == States.sheets_1)		{sheets_1();}
		else if (myState == States.mirror) 			{mirror();} 
		else if (myState == States.cell_mirror) 	{cell_mirror();}
		else if (myState == States.lock_0) 			{lock_0();}
		else if (myState == States.lock_1) 			{lock_1();}
		else if (myState == States.corridor_0) 		{corridor_0();}
		else if (myState == States.stairs_0) 		{stairs_0();}
		else if (myState == States.floor) 			{floor();}
		else if (myState == States.closet_door) 	{closet_door();}
		else if (myState == States.corridor_1) 		{corridor_1();}
		else if (myState == States.stairs_1) 		{stairs_1();}
		else if (myState == States.in_closet) 		{in_closet();}
		else if (myState == States.corridor_2) 		{corridor_2();}
		else if (myState == States.stairs_2) 		{stairs_2();}
		else if (myState == States.corridor_3) 		{corridor_3();}
		else if (myState == States.courtyard) 		{courtyard();}
	}
	
	#region State handler methods
	void cell () {
		text.text = "You awaken, cold and confused, and look around you. \n" + 
					"You notice the dimly lit room and look around. \n" + 
					"You see the door with bars in front of you, " + 
					"a dirty toilet, a dirty sink. \n" + 
					"You feel the uncomfortableness " + 
					"of this so called bed. \n\n" + 
					"You remember... You are a prisoner. \n\n" + 
					"<b><i>Press S to View Sheets.</i></b> \n" + 
					"<b><i>Press M to View Mirror.</i></b> \n" + 
					"<b><i>Press L to View Door Lock.</i></b>";

		if 		(Input.GetKeyDown(KeyCode.S)) 		{myState = States.sheets_0;} 
		else if (Input.GetKeyDown(KeyCode.M)) 		{myState = States.mirror;} 
		else if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.lock_0;}
	}
	
	void sheets_0 () {
		text.text = "The sheets you just crawled out from under look awful. \n" + 
					"Grey, dirty, thin, and way to small for your entire body, \n" + 
					"these sheets won't help you at all when winter arrives. \n" +
					"You make up your bed to avoid having your cell searched " + 
					"later in the day \n\n" + 
					"<b><i>Press R to Continue Roaming Your Cell.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
	}
	
	void mirror () {
		text.text = "The mirror hanging on the wall is dirty and crooked. \n" + 
					"You look into the mirror and see yourself, ragged and dejected. \n" +
					"It looks loosly hung from the wall, maybe you can remove it? \n\n" + 
					"<b><i>Press T to Take the Mirror</i></b>. \n" + 
					"<b><i>Press R to Continue Roaming Your Cell.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.T)) 		{myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
	}
	
	void lock_0 () {
		text.text = "The lock is outside in the hallway and you reach your hand through \n" +
					"the bars to try and get an idea of what you are dealing with. \n" + 
					"The lock is not operated with a key, but with a keypad. \n" + 
					"If only you could see what the keypad looked like... \n\n" + 
					"<b><i>Press R to Continue Roaming Your Cell.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
	}
	
	void sheets_1 () {
		text.text = "The sheets are the same as when \n" +
					"you looked at them without " + 
					"the mirror. \n" + 
					"Nothing has changed here. \n\n" + 
					"<b><i>Press R to Continue Roaming Your Cell.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_mirror;}
	}
	
	void cell_mirror () {
		text.text = "So, the mirror is off the wall and you can see where \n" + 
					"the last painting crew did not bother to remove the mirror \n" + 
					"when adding the most recent coat. \n" + 
					"What now? \n\n" + 
					"<b><i>Press S to View Sheets.</i></b> \n" + 
					"<b><i>Press L to View Lock.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.S)) 		{myState = States.sheets_1;}
		else if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.lock_1;}
	}
	
	void lock_1 () {
		text.text = "Checking down the hallway to verify there are no guards \n" + 
					"or cameras, you move the mirror just outside the door to look " + 
					"at the lock... \n" + 
					"What luck! You can see that the numbers 1, 4, and 9 all " + 
					"look warn down. \n\n" + 
					"<b><i>Press A to Attempt the Combination.</i></b> \n" + 
					"<b><i>Press R to Continue Roaming Your Cell.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.A)) 		{myState = States.corridor_0;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_mirror;}
	}
	
	void corridor_0 () {
		text.text = "Exiting your cell and entering the corridor, \n" + 
					"you notice that it is empty and the other inmates are still asleep. \n" +
					"You can smell freedom within your grasp. \n\n" + 
					"<b><i>Press S to Check the Stairs.</i></b> \n" +
					"<b><i>Press F to Look on the Floor.</i></b> \n" +
					"<b><i>Press C to Inspect the Closet Door.</i></b>"; 
		if 		(Input.GetKeyDown(KeyCode.S)) 		{myState = States.stairs_0;	}
		else if (Input.GetKeyDown(KeyCode.F)) 		{myState = States.floor;	}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.closet_door;}
	}
	
	void stairs_0 () {
		text.text = "Starting the climb up the monocolored stairs, \n " + 
					"you hear voices from some of the guards and \n" +
					"see their shadows on the wall. \n" +
					"It is too dangerous to go all the way up. \n\n" + 
					"<b><i>Press R to Return to the Corridor.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.R)) 		{myState = States.corridor_0;}
	}
	
	void closet_door () {
		text.text = "There is a closet on the same floor as your cell. \n" + 
					"You walk up to it and attempt to move the handle... \n" + 
					"Of course it's locked. \n\n" + 
					"<b><i>Press R to Return to the Corridor.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.R)) 		{myState = States.corridor_0;}
	}
	
	void floor () {
		text.text = "On the floor you notice something shining from the morning sun. \n" + 
					"As you walk closer towards it, you notice its just a paper clip. \n" + 
					"One of the guards must have left it. \n\n" + 
					"<b><i>Press R to Return to the Corridor.</i></b> \n" + 
					"<b><i>Press T to Take the Paper Clip.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.R)) 		{myState = States.corridor_0;}
		else if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.corridor_1;}
	}
	
	void corridor_1 () {
		text.text = "You are still in the same hallway. \n" + 
					"The time to get out is now, where should you go? \n\n" + 
					"<b><i>Press S to Check the Stairs.</i></b> \n" +
					"<b><i>Press C to Inspect the Closet Door.</i></b>"; 
		if 		(Input.GetKeyDown(KeyCode.S)) 		{myState = States.stairs_1;	}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.in_closet;}
	}
	
	void stairs_1 () {
		text.text = "As you walk up the stairs, you still hear the voices. \n" + 
					"It's too dangerous to continue with those pesky guards there. \n\n" + 
					"<b><i>Press R to Return to the Corridor.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.R)) 		{myState = States.corridor_1;	}
	}
	
	void in_closet () {
		text.text = "With the paper clip you picked up, you might be able to open \n" +
					"the door and see what is inside... \n\n" +
					"It worked! \n\n" + 
					"You can now see that inside the closet there is a janitor uniform.\n\n" + 
					"<b><i>Press D to Dress as Janitor and Leave.</i></b> \n" + 
					"<b><i>Press R to Return to the Corridor.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.D)) 		{myState = States.corridor_3;	}
		else if	(Input.GetKeyDown(KeyCode.R)) 		{myState = States.corridor_2;	}
	}
	
	void corridor_2 () {
		text.text = "You are still in the same hallway, except now the closet is unlocked. \n" + 
					"The time to get out is now, where should you go? \n\n" + 
					"<b><i>Press S to Check the Stairs.</i></b> \n" +
					"<b><i>Press C to Inspect the Closet Door.</i></b>"; 
		if 		(Input.GetKeyDown(KeyCode.S)) 		{myState = States.stairs_2;	}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.in_closet;}
	}
	
	void stairs_2 () {
		text.text = "As you walk up the stairs, you still hear the voices. \n" + 
					"It's too dangerous to continue with those pesky guards there. \n" + 
					"If only there was some way you could sneak past them. \n\n" + 
					"<b><i>Press R to Return to the Corridor.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.R)) 		{myState = States.corridor_2;	}
	}
	
	void corridor_3 () {
		text.text = "You changed into the janitor's uniform and grabbed some supplies. \n" + 
					"The feeling that you could walk by the guards is strong. \n" + 
					"The sense of freedom is in the air.\n\n" + 
					"<b><i>Press S to Check the Stairs.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.S)) 		{myState = States.courtyard;	}
	}
	
	void courtyard () {
		text.text = "The stairs are long and you still hear the guards at the top. \n" + 
					"You walk past them as you enter the courtyard. \n" + 
					"Keeping your head down, you walk out of the courtyard and out of the gate. \n\n" + 
					"FREEDOM! \n\n" + 
					"Once you get out of sight of the guards, you run as fast as you can, \n" + 
					"to your new, free life. \n\n" + 
					"<b><i>Press P to Play Again.</i></b>";
		if 		(Input.GetKeyDown(KeyCode.P)) 		{myState = States.cell;	}
	}
	#endregion
}
