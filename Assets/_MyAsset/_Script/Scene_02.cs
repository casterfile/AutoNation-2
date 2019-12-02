using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_02 : MonoBehaviour {
	public GameObject Image1,Image2,Image3;
	public GameObject Image2_1,Image2_2,Image2_3,Image2_4,Image2_5,Image2_6,Image2_7,Image2_8,Image2_9;
	public GameObject Buttons;
	public static int GlobalCurrentColor;
	// Use this for initialization
	void Start () {
		GlobalCurrentColor = 0;
		Buttons.SetActive(false);
		Image2_1.SetActive(false);
		Image2_2.SetActive(false);
		Image2_3.SetActive(false);
		Image2_4.SetActive(false);
		Image2_5.SetActive(false);
		Image2_6.SetActive(false);
		Image2_7.SetActive(false);
		Image2_8.SetActive(false);
		Image2_9.SetActive(false);

		if(Main.GlobalCurrentCar == 0){
			Image1.SetActive(true);
			Image2.SetActive(false);
			Image3.SetActive(false);
		}else if(Main.GlobalCurrentCar == 1){
			Image1.SetActive(false);
			Image2.SetActive(true);
			Image3.SetActive(false);
			Buttons.SetActive(true);
			GlobalCurrentColor = 8;
		}else if(Main.GlobalCurrentCar == 2){
			Image1.SetActive(false);
			Image2.SetActive(false);
			Image3.SetActive(true);
		}
	}

	public void ChangeCarDesign(int Number){
		Image1.SetActive(false);
		Image2.SetActive(false);
		Image3.SetActive(false);

		Image2_1.SetActive(false);
		Image2_2.SetActive(false);
		Image2_3.SetActive(false);
		Image2_4.SetActive(false);
		Image2_5.SetActive(false);
		Image2_6.SetActive(false);
		Image2_7.SetActive(false);
		Image2_8.SetActive(false);
		Image2_9.SetActive(false);

		if(Number == 0){
			Image2_1.SetActive(true);
			GlobalCurrentColor = 0;
		}else if(Number == 1){
			Image2_2.SetActive(true);
			GlobalCurrentColor = 1;
		}else if(Number == 2){
			Image2_3.SetActive(true);
			GlobalCurrentColor = 2;
		}else if(Number == 3){
			Image2_4.SetActive(true);
			GlobalCurrentColor = 3;
		}else if(Number == 4){
			Image2_5.SetActive(true);
			GlobalCurrentColor = 4;
		}else if(Number == 5){
			Image2_6.SetActive(true);
			GlobalCurrentColor = 5;
		}else if(Number == 6){
			Image2_7.SetActive(true);
			GlobalCurrentColor = 6;
		}else if(Number == 7){
			Image2_8.SetActive(true);
			GlobalCurrentColor = 7;
		}else if(Number == 8){
			Image2_9.SetActive(true);
			GlobalCurrentColor = 8;
		}
	}
	
	public void GoToLastPage(){
		Application.LoadLevel ("Scene_03");
	}
}
