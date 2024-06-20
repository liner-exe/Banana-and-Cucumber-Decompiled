using UnityEngine;
using UnityEngine.UI;

public class DiscordButton : MonoBehaviour
{
	private Button button;

	private void Start()
	{
		button = GetComponent<Button>();
		button.onClick.AddListener(delegate
		{
			Application.OpenURL("discord://discord.gg/mxhmpqkh");
		});
	}

	private void Update()
	{
	}
}
