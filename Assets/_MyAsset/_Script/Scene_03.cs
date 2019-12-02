using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_03 : MonoBehaviour {
	public GameObject Image1;
	public GameObject Image2_1,Image2_2,Image2_3,Image2_4,Image2_5,Image2_6,Image2_7,Image2_8,Image2_9;
	public GameObject Image3;
	// Use this for initialization
	void Start () {
		// Main.GlobalCurrentCar = 2;
		HideAll();
		if(Main.GlobalCurrentCar == 0){
			Image1.SetActive(true);
		}else if(Main.GlobalCurrentCar == 1){
			if(Scene_02.GlobalCurrentColor == 0){
				Image2_1.SetActive(true);
			}else if(Scene_02.GlobalCurrentColor == 1){
				Image2_2.SetActive(true);
			}else if(Scene_02.GlobalCurrentColor == 2){
				Image2_3.SetActive(true);
			}else if(Scene_02.GlobalCurrentColor == 3){
				Image2_4.SetActive(true);
			}else if(Scene_02.GlobalCurrentColor == 4){
				Image2_5.SetActive(true);
			}else if(Scene_02.GlobalCurrentColor == 5){
				Image2_6.SetActive(true);
			}else if(Scene_02.GlobalCurrentColor == 6){
				Image2_7.SetActive(true);
			}else if(Scene_02.GlobalCurrentColor == 7){
				Image2_8.SetActive(true);
			}else if(Scene_02.GlobalCurrentColor == 8){
				Image2_9.SetActive(true);
			}
		}else if(Main.GlobalCurrentCar == 2){;
			Image3.SetActive(true);
		}
	}

	private void HideAll(){
		Image1.SetActive(false);

		Image2_1.SetActive(false);
		Image2_2.SetActive(false);
		Image2_3.SetActive(false);
		Image2_4.SetActive(false);
		Image2_5.SetActive(false);
		Image2_6.SetActive(false);
		Image2_7.SetActive(false);
		Image2_8.SetActive(false);
		Image2_9.SetActive(false);

		Image3.SetActive(false);
	}
	
}
