using System;
using System.Collections;
using System.Collections.Generic;
using HeathenEngineering.SteamworksIntegration.API;
using Steamworks;
using UnityEngine;

public class TimeController : MonoBehaviour
{
	private List<int> itemIds = new List<int> { 98, 92, 84, 83, 82 };

	private List<int> middleItems = new List<int> { 81, 89, 85 };

	private List<int> rareItemIds = new List<int> { 86, 87 };

	public GameObject _prefab;

	public Transform _spawnPoint;

	public Transform _parent;

	private float _hiddenTime;

	private float _hiddenMaxTime;

	public float MaxTimeNormal { get; set; }

	public float MaxTimeMiddle { get; set; }

	public float MaxTimeRare { get; set; }

	private void Awake()
	{
		MaxTimeNormal = 1860f;
		MaxTimeMiddle = 10860f;
		MaxTimeRare = 72060f;
	}

	private void Start()
	{
		StartCoroutine(AddCommonItem());
		StartCoroutine(AddMiddleItem());
		StartCoroutine(AddRareItem());
		Application.targetFrameRate = 30;
		if (!PlayerPrefs.HasKey("FirstStart3"))
		{
			PlayerPrefs.SetInt("FirstStart3", 1);
			StartCoroutine(AddHiddenItem());
		}
	}

	private IEnumerator AddHiddenItem()
	{
		yield return new WaitForSeconds(15f);
		AddItem(itemIds);
	}

	private IEnumerator AddCommonItem()
	{
		while (true)
		{
			yield return new WaitForSeconds(MaxTimeNormal);
			AddItem(itemIds);
		}
	}

	private IEnumerator AddMiddleItem()
	{
		while (true)
		{
			yield return new WaitForSeconds(MaxTimeMiddle);
			AddItem(middleItems);
		}
	}

	private IEnumerator AddRareItem()
	{
		while (true)
		{
			yield return new WaitForSeconds(MaxTimeRare);
			AddItem(rareItemIds);
		}
	}

	private void AddItem(List<int> itemList)
	{
		Debug.Log("Online");
		int index = Random.Range(0, itemList.Count);
		int value = itemList[index];
		SteamItemDef_t itemDef = new SteamItemDef_t(value);
		try
		{
			Inventory.Client.AddPromoItem(itemDef, delegate
			{
				Debug.Log("Item added");
			});
		}
		catch (Exception ex)
		{
			Debug.LogError("Exception while adding item: " + ex.Message);
		}
	}
}
