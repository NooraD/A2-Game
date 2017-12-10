using UnityEngine;

public class InventoryUi : MonoBehaviour {

	public Transform itemsParent;
	Camera cam;
	public GameObject inventoryUI;

	Inventory inventory;

	InventorySlot[] slots;

	void Start () 
	{
		inventory = Inventory.instance;
		inventory.onItemChangedCallback += UpdateUI;
		cam = Camera.main;
		slots = itemsParent.GetComponentsInChildren<InventorySlot> ();
	}

	void Update ()
	{
		if (Input.GetButtonDown ("Inventory")) {
			inventoryUI.SetActive (!inventoryUI.activeSelf);
		}

		if (inventoryUI.activeInHierarchy) {
			Cursor.lockState = CursorLockMode.None;

		} else {
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	void UpdateUI ()
	{
		for (int i = 0; i < slots.Length; i++) 
		{
			if (i < inventory.items.Count) {
				slots [i].AddItem (inventory.items [i]);
			} else 
			{
				slots [i].ClearSlot ();
			}
		}
	}
}
