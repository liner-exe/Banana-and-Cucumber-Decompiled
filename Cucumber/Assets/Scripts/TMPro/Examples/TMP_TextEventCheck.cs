using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TMP_TextEventCheck : MonoBehaviour
{
	public TMP_TextEventHandler TextEventHandler;

	private TMP_Text m_TextComponent;

	private void OnEnable()
	{
		if (TextEventHandler != null)
		{
			m_TextComponent = TextEventHandler.GetComponent<TMP_Text>();
			((UnityEvent<char, int>)TextEventHandler.onCharacterSelection).AddListener((UnityAction<char, int>)OnCharacterSelection);
			((UnityEvent<char, int>)TextEventHandler.onSpriteSelection).AddListener((UnityAction<char, int>)OnSpriteSelection);
			((UnityEvent<string, int, int>)TextEventHandler.onWordSelection).AddListener((UnityAction<string, int, int>)OnWordSelection);
			((UnityEvent<string, int, int>)TextEventHandler.onLineSelection).AddListener((UnityAction<string, int, int>)OnLineSelection);
			((UnityEvent<string, string, int>)TextEventHandler.onLinkSelection).AddListener((UnityAction<string, string, int>)OnLinkSelection);
		}
	}

	private void OnDisable()
	{
		if (TextEventHandler != null)
		{
			((UnityEvent<char, int>)TextEventHandler.onCharacterSelection).RemoveListener((UnityAction<char, int>)OnCharacterSelection);
			((UnityEvent<char, int>)TextEventHandler.onSpriteSelection).RemoveListener((UnityAction<char, int>)OnSpriteSelection);
			((UnityEvent<string, int, int>)TextEventHandler.onWordSelection).RemoveListener((UnityAction<string, int, int>)OnWordSelection);
			((UnityEvent<string, int, int>)TextEventHandler.onLineSelection).RemoveListener((UnityAction<string, int, int>)OnLineSelection);
			((UnityEvent<string, string, int>)TextEventHandler.onLinkSelection).RemoveListener((UnityAction<string, string, int>)OnLinkSelection);
		}
	}

	private void OnCharacterSelection(char c, int index)
	{
		Debug.Log("Character [" + c + "] at Index: " + index + " has been selected.");
	}

	private void OnSpriteSelection(char c, int index)
	{
		Debug.Log("Sprite [" + c + "] at Index: " + index + " has been selected.");
	}

	private void OnWordSelection(string word, int firstCharacterIndex, int length)
	{
		Debug.Log("Word [" + word + "] with first character index of " + firstCharacterIndex + " and length of " + length + " has been selected.");
	}

	private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
	{
		Debug.Log("Line [" + lineText + "] with first character index of " + firstCharacterIndex + " and length of " + length + " has been selected.");
	}

	private void OnLinkSelection(string linkID, string linkText, int linkIndex)
	{
		if (m_TextComponent != null)
		{
			_ = ref m_TextComponent.textInfo.linkInfo[linkIndex];
		}
		Debug.Log("Link Index: " + linkIndex + " with ID [" + linkID + "] and Text \"" + linkText + "\" has been selected.");
	}
}
