using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, flashlight, medicines_0, lock_0, cell_flashlight, medicines_1, lock_1, corridor_0};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		print (myState);
		if 		(myState == States.cell) 		{cell();} 
		else if (myState == States.medicines_0) 	{medicines_0();}
		else if (myState == States.medicines_1) 	{medicines_1();} 
		else if (myState == States.lock_0) 		{lock_0();} 
		else if (myState == States.lock_1) 		{lock_1();}
		else if (myState == States.flashlight) 		{flashlight();}
		else if (myState == States.cell_flashlight) {cell_flashlight();}
		else if (myState == States.corridor_0) 	{corridor_0();}   
			
		}
		
	
	void cell () {
	
		text.text = "You are in a madhouse cell and you want to escape. "
					+"The cell has a small window just below the ceiling and the " 
					+"only light source is street lamps. You can barely see.\n"
					+"There are some medicine in the medicine chest, a flashlight "
					+"on the table and a door is locked from the outside.\n\n"
					+"Press M to view medicines, F to view Flashlight, L to view Lock.";
					
		if (Input.GetKeyDown(KeyCode.M))		 {myState = States.medicines_0;} 
		if (Input.GetKeyDown(KeyCode.F))		 {myState = States.flashlight;}
		if (Input.GetKeyDown(KeyCode.L))		 {myState = States.lock_0;}
	}
	
	void flashlight () {
		
		text.text = "The broken old flashlight on the table seems doesn’t work.\n\n"
					+"Press T to Take the flashlight, R to Return to cell";
					
		if (Input.GetKeyDown(KeyCode.T)) 			{myState = States.cell_flashlight;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
		
		
	}
	
	void cell_flashlight () {
		
		text.text = "You are still in your cell and you still want to escape ! "
					+"The old flashlight works ! How lucky you are ! "
					+"There are some handwritings on pill boxes and that pesky door is "
					+"still there, and firmly locked.\n\n"
					+"Press M to view Medicines, or L to view Lock.";
		
		if (Input.GetKeyDown(KeyCode.M))		 {myState = States.medicines_1;}
		if (Input.GetKeyDown(KeyCode.L))		 {myState = States.lock_1;}
	}
	
	
	void medicines_0 () {
	
		text.text = "There are many pill boxes but all are empty, you try to find "
					+"something sharp to open the door but there is nothing to do this. "
					+"This medicine chest is totally rubbish !\n\n"
					+"Press R to Return to roaming your cell.";
					
		if (Input.GetKeyDown(KeyCode.R))		 {myState = States.cell;}
		
		
	}
	
	void medicines_1 () {
		
		text.text = "The handwritings doesn’t include any useful information like a "
					+"password or a hint to open the lock.\n\n"
					+"Press R to return to roaming your cell";
		
		if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
	}
	
	void lock_0 () {
		
		text.text = "This is one of those button locks. You have no idea what the combination is. "
					+"You wish you could somehow see where the dirty fingerprints were, maybe that would help.\n\n"
					+"Press R to return to roaming your cell";
		
		if (Input.GetKeyDown(KeyCode.R))		 {myState = States.cell;}
	}
	
	void lock_1 () {
		
		text.text = "You hold the flashlight on the buttons and can’t believe your eyes ! "
					+"Some fingerprints on some buttons, you need to find the true combination "
					+"to open the door.\n\n"
					+"Press O to Open, or R to roaming your cell";
		
		if (Input.GetKeyDown(KeyCode.O)) 		{myState = States.corridor_0;} 
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell;}	
		
	}
	
	void corridor_0 () {
		
		text.text = "You are FREE !! \n\n"
					+"Press P play again";
		
		if (Input.GetKeyDown(KeyCode.P))		 {myState = States.cell;}
	}
	
}
