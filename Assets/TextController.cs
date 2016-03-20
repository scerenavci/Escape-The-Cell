using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, flashlight, medicines_0, lock_0, cell_flashlight,
						medicines_1, lock_1, corridor_0, stairs_0, stairs_1, stairs_2,
						courtyard, floor, corridor_1, corridor_2, corridor_3,closet_door, in_closet};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		print (myState);

		if (myState == States.cell)				{cell();} 
		else if (myState == States.medicines_0) 	{medicines_0();}
		else if (myState == States.medicines_1) 	{medicines_1();} 
		else if (myState == States.lock_0)		{lock_0();} 
		else if (myState == States.lock_1)		{lock_1();}
		else if (myState == States.flashlight) 		{flashlight();}
		else if (myState == States.cell_flashlight) {cell_flashlight();}
		else if (myState == States.corridor_0) 		{corridor_0();}
		else if (myState == States.stairs_0)		{stairs_0();} 
		else if (myState == States.stairs_1)		{stairs_1();} 
		else if (myState == States.stairs_2)		{stairs_2();} 
		else if (myState == States.courtyard)		{courtyard();} 
		else if (myState == States.floor)		{floor();} 
		else if (myState == States.corridor_1)		{corridor_1();} 
		else if (myState == States.corridor_2)		{corridor_2();} 
		else if (myState == States.corridor_3)		{corridor_3();} 
		else if (myState == States.closet_door)		{closet_door();} 
		else if (myState == States.in_closet)		{in_closet();}  
			
	}
	
	#region State handler methods	
	void in_closet() { 
		text.text = "Inside the closet you see a cleaner's uniform that looks about your size! " 
		+ "Seems like your day is looking-up.\n\n" 
		+ "Press D to Dress up, or R to Return to the corridor";
		
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_2;} 
		else if (Input.GetKeyDown(KeyCode.D))		{myState = States.corridor_3;}
		 
	}
	void closet_door() { 
	
		text.text = "You are looking at a closet door, unfortunately it's locked. " 
		+ "Maybe you could find something around to help enourage it open?\n\n" 
		+ "Press R to Return to the corridor"; 
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_0;}
		
	}
	
	void corridor_3() { 
	
		text.text = "You're standing back in the corridor, now convincingly dressed as a cleaner. " 
		+ "You strongly consider the run for freedom.\n\n" 
		+ "Press S to take the Stairs, or U to Undress"; 
		if (Input.GetKeyDown(KeyCode.S)) 			{myState = States.courtyard;} 
		else if (Input.GetKeyDown(KeyCode.U)) 		{myState = States.in_closet;} 
		
	}
	
	void corridor_2() { 
	
		text.text = "Back in the corridor, having declined to dress-up as a cleaner.\n\n" 
		+ "Press C to revisit the Closet, and S to climb the stairs"; 
		
		if (Input.GetKeyDown(KeyCode.C))			{myState = States.in_closet;} 
		else if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.stairs_2;} 
		
	}
	
	void corridor_1() { 
	
		text.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " 
		+ "Now what? You wonder if that lock on the closet would succumb to " 
		+ "to some lock-picking?\n\n" 
		+ "P to Pick the lock, and S to climb the stairs"; 
					
		if (Input.GetKeyDown(KeyCode.P))			{myState = States.in_closet;} 
		else if (Input.GetKeyDown(KeyCode.S))		{myState = States.stairs_1;} 
		
	}
	
	void floor () { 
	
		text.text = "Rummagaing around on the dirty floor, you find a hairclip.\n\n" 
		+ "Press R to Return to the standing, or H to take the Hairclip." ; 
					
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_0;} 
		else if (Input.GetKeyDown(KeyCode.H)) 		{myState = States.corridor_1;} 
		
	}
	
	void courtyard () { 
	
		text.text = "You walk through the courtyard dressed as a cleaner. " 
		+ "The guard tips his hat at you as you waltz past, claiming " 
		+ "your freedom. You heart races as you walk into the sunset.\n\n" 
		+ "Press P to Play again." ; 
					
		if (Input.GetKeyDown(KeyCode.P))			{myState = States.cell;} 
		
	}
	
	void stairs_0 () { 
	
		text.text = "You start walking up the stairs towards the outside light. " 
		+ "You realise it's not break time, and you'll be caught immediately. " 
		+ "You slither back down the stairs and reconsider.\n\n" 
		+ "Press R to Return to the corridor." ; 
					
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_0;} 
		
	}
	
	void stairs_1 () { 
	
		text.text = "Unfortunately weilding a puny hairclip hasn't given you the " 
		+ "confidence to walk out into a courtyard surrounded by armed guards!\n\n" 
		+ "Press R to Retreat down the stairs" ; 
					
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_1;} 
		
	}
	
	void stairs_2() { 
	
		text.text = "You feel smug for picking the closet door open, and are still armed with " 
		+ "a hairclip (now badly bent). Even these achievements together don't give " 
		+ "you the courage to climb up the staris to your death!\n\n" 
		+ "Press R to Return to the corridor"; 
		
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.corridor_2;}
	}
		
	
		
	
	void cell () {
	
		text.text = "You are in a madhouse cell and you want to escape. "
		+"The cell has a small window just below the ceiling and the " 
		+"only light source is street lamps. You can barely see.\n"
		+"There are some medicine in the medicine chest, a flashlight "
		+"on the table and a door is locked from the outside.\n\n"
		+"Press M to view medicines, F to view Flashlight, L to view Lock.";
					
		if (Input.GetKeyDown(KeyCode.M))			{myState = States.medicines_0;} 
		if (Input.GetKeyDown(KeyCode.F))			{myState = States.flashlight;}
		if (Input.GetKeyDown(KeyCode.L))			{myState = States.lock_0;}
	}
	
	void flashlight () {
		
		text.text = "The broken old flashlight on the table seems doesn’t work.\n\n"
		+"Press T to Take the flashlight, R to Return to cell";
					
		if (Input.GetKeyDown(KeyCode.T))			{myState = States.cell_flashlight;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
		
		
	}
	
	void cell_flashlight () {
		
		text.text = "You are still in your cell and you still want to escape ! "
		+"The old flashlight works ! How lucky you are ! "
		+"There are some handwritings on pill boxes and that pesky door is "
		+"still there, and firmly locked.\n\n"
		+"Press M to view Medicines, or L to view Lock.";
		
		if (Input.GetKeyDown(KeyCode.M))			{myState = States.medicines_1;}
		if (Input.GetKeyDown(KeyCode.L))			{myState = States.lock_1;}
	}
	
	
	void medicines_0 () {
	
		text.text = "There are many pill boxes but all are empty, you try to find "
		+"something sharp to open the door but there is nothing to do this. "
		+"This medicine chest is totally rubbish !\n\n"
		+"Press R to Return to roaming your cell.";
					
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.cell;}
		
		
	}
	
	void medicines_1 () {
		
		text.text = "The handwritings doesn’t include any useful information like a "
		+"password or a hint to open the lock.\n\n"
		+"Press R to return to roaming your cell";
		
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.cell_flashlight;}
	}
	
	void lock_0 () {
		
		text.text = "This is one of those button locks. You have no idea what the combination is. "
		+"You wish you could somehow see where the dirty fingerprints were, maybe that would help.\n\n"
		+"Press R to Return to roaming your cell";
		
		if (Input.GetKeyDown(KeyCode.R))			{myState = States.cell;}
	}
	
	void lock_1 () {
		
		text.text = "You hold the flashlight on the buttons and can’t believe your eyes ! "
		+"Some fingerprints on some buttons, you need to find the true combination "
		+"to open the door.\n\n"
		+"Press O to Open, or R to Return to roaming your cell";
		
		if (Input.GetKeyDown(KeyCode.O))			{myState = States.corridor_0;} 
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}	
		
	}
	
	void corridor_0 () {
		
		text.text = "You're out of your cell, but not out of trouble." 
		+ "You are in the corridor, there's a closet and some stairs leading to " 
		+ "the courtyard. There's also various detritus on the floor.\n\n" 
		+ "C to view the Closet, F to inspect the Floor, and S to climb the stairs"; 
		
		if (Input.GetKeyDown(KeyCode.S))			{myState = States.stairs_0;} 
		else if (Input.GetKeyDown(KeyCode.F)) 		{myState = States.floor;} 
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.closet_door;}
		
	}
	
	#endregion
}
