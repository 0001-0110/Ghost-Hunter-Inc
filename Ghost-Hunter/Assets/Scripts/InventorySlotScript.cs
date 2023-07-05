using UnityEngine;
using UnityEngine.UI;

public class InventorySlotScript : MonoBehaviour
{
	private const string FAILRITUALANIMATION = "FailRitual";

	private Image itemIcon;
	private Animator redFlashAnimation;

	public void Start()
	{
		// We nee to access the first child specificly since both of them have an image
		itemIcon = transform.GetChild(0).GetComponent<Image>();
		redFlashAnimation = GetComponentInChildren<Animator>();
	}

	public void AcceptImage(Sprite image)
	{
		itemIcon.sprite = image;
		gameObject.GetComponent<CanvasGroup>().alpha = 1;
		//animations.SetTrigger("AddItem");
	}

	public void FlashRed()
	{
		redFlashAnimation.SetTrigger(FAILRITUALANIMATION);
	}
}
