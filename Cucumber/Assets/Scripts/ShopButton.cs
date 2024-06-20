using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
	private Button button;

	private void Start()
	{
		button = GetComponent<Button>();
		button.onClick.AddListener(delegate
		{
			Application.OpenURL("https://store.steampowered.com/itemstore/3015610");
		});
	}
}
