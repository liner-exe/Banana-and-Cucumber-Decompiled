using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public TextMeshProUGUI text;

	private int count;

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	private void Start()
	{
	}

	public void ResetAchievement()
	{
	}
}
