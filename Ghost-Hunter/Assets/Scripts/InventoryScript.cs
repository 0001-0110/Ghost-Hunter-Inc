using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    [SerializeField]
    private GameObject inventorySlotPrefab;

    [SerializeField]
    private int inventorySize;
    private InventorySlotScript[] slots;

    private int selectedIndex = 0;
    
    void Start()
    {
        slots = new InventorySlotScript[inventorySize];
        for (int i = 0; i < slots.Length; i++)
            // No need to compute the position since the horizontal group layout is taking care of everything
            slots[i] = Instantiate(inventorySlotPrefab, transform).GetComponent<InventorySlotScript>();
    }

    public void AddMemento(Memento memento)
    {
        slots[selectedIndex].AcceptImage(memento.mySprite);
        selectedIndex++;
    }

    public void FailRitual()
    {
        // We only flash red empty slots
		for (int i = selectedIndex; i < slots.Length; i++)
            slots[i].FlashRed();
	}
}
