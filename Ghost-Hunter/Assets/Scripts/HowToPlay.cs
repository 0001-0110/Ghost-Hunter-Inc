using UnityEngine;

public class HowToPlay : MonoBehaviour
{
	public SceneFader fader;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			fader.FadeTo("FirstCutscene");
		}
	}
}
