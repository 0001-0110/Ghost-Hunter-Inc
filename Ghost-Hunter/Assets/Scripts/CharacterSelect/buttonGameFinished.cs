using UnityEngine;
using UnityEngine.UI;

public class ButtonGameFinished : MonoBehaviour
{
	void Start()
	{
		//if Finished == 0 then it is considered as false, 1 => true
		GetComponent<Button>().interactable = PlayerPrefs.GetInt("Finished", 0) != 0;
	}
}
