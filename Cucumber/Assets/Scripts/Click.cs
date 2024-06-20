using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public TextMeshProUGUI text;

	private int count;

	public void OnPointerClick(PointerEventData eventData)
	{
		if (eventData.pointerCurrentRaycast.gameObject == base.gameObject)
		{
			count++;
			text.text = count.ToString();
		}
	}

	private void Start()
	{
		if (!PlayerPrefs.HasKey("FirstStart"))
		{
			PlayerPrefs.SetInt("FirstStart", 1);
			SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1");
			SteamUserStats.StoreStats();
		}
		if (!PlayerPrefs.HasKey("FirstStart2"))
		{
			PlayerPrefs.SetInt("FirstStart2", 1);
			SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_1");
			SteamUserStats.StoreStats();
		}
	}

	public void ResetAchievement()
	{
		SteamUserStats.ClearAchievement("NEW_ACHIEVEMENT_1");
		SteamUserStats.StoreStats();
	}
}
