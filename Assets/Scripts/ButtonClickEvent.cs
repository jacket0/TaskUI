using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class ButtonClickEvent : MonoBehaviour
{
	[SerializeField] private Button _button;

	private AudioSource _audioSource;

	private void Start()
	{
		_audioSource = GetComponent<AudioSource>();
	}

	private void OnEnable()
	{
		_button.onClick.AddListener(PlayAudio);
	}

	private void OnDisable()
	{
		_button.onClick.RemoveListener(PlayAudio);
	}

	private void PlayAudio()
	{
		_audioSource.Play();
	}
}
