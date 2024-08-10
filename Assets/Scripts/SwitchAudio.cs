using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SwitchAudio : MonoBehaviour
{
	[SerializeField] private AudioMixerSnapshot _normal;
	[SerializeField] private AudioMixerSnapshot _silence;
	[SerializeField] private Button _button;

	private bool _isMuted;

	private void OnEnable()
	{
		_button.onClick.AddListener(SwitchMuteAudio);
	}

	private void OnDisable()
	{
		_button.onClick.RemoveListener(SwitchMuteAudio);
	}

	public void SwitchMuteAudio()
	{
		_isMuted = !_isMuted;
		AudioListener.pause = _isMuted;
	}
}
