using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class SwitchAudio : MonoBehaviour
{
	[SerializeField] private AudioMixerSnapshot _normal;
	[SerializeField] private AudioMixerSnapshot _silence;

	private float _transitionSpeed = 1f;
	private bool _isMuted = false;

	public void SwitchMuteAudio()
	{
		if (_isMuted)
		{
			_normal.TransitionTo(_transitionSpeed);
		}
		else
		{
			_silence.TransitionTo(_transitionSpeed);
		}

		_isMuted = !_isMuted;
	}
}
