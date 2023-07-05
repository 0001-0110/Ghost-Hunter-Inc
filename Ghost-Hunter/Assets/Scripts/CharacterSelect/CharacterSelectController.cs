using UnityEngine;

public class CharacterSelectController : MonoBehaviour
{
	public SceneFader fader;
	public void CharacterSelect(string name)
	{
		PlayerPrefs.SetString("Character", name);
		fader.FadeTo("HowToPlay");
	}
}
