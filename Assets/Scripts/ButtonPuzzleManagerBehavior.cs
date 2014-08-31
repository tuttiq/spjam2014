using UnityEngine;
using System.Collections;

public class ButtonPuzzleManagerBehavior : MonoBehaviour {
	
	string lastButtonPressed = "";
	bool puzzleSolved = false;
	public GameObject[] buttons;	
	
	
	void Start(){
		
	}
	
	void Update(){
		string currentButtonPressed = "";
		if(lastButtonPressed == ""){
			foreach(var button in buttons){
				if(button.GetComponent<ButtonObjectBehaviour>().IsPressed)
				{
					currentButtonPressed = button.tag;
				}			
			
			}
			if(currentButtonPressed != "Button2"){
				RestartPuzzle();
			} else
				lastButtonPressed = currentButtonPressed;
		}else if(lastButtonPressed == "Button2"){
			foreach(var button in buttons){
				if(button.GetComponent<ButtonObjectBehaviour>().IsPressed)
				{
					if(button.tag == "Button2"){
						continue;
					}					
					currentButtonPressed = button.tag;
					
				}			
				
			}
			if(currentButtonPressed != "Button3"){
				RestartPuzzle();
			} else
				lastButtonPressed = currentButtonPressed;
		}else if(lastButtonPressed == "Button3"){
			foreach(var button in buttons){
				if(button.GetComponent<ButtonObjectBehaviour>().IsPressed)
				{
					if(button.tag == "Button2" || button.tag == "Button3"){
						continue;
					}	
					currentButtonPressed = button.tag;					
				}			
				
			}
			if(currentButtonPressed != "Button1"){
				RestartPuzzle();
			} else {
				puzzleSolved = true;
			}
		} 
	}
	public void VerifyPuzzle(string buttonTag){
		
	}
	
	public void RestartPuzzle(){
		lastButtonPressed = "";
		foreach(var button in buttons){
			button.GetComponent<ButtonObjectBehaviour>().IsPressed = false;		
		}
	}	
}
