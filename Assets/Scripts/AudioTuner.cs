using UnityEngine;
using UnityEngine.Audio;

public class AudioTuner : MonoBehaviour
{
	[SerializeField] private AudioMixerGroup _master;
	[SerializeField] private AudioMixerGroup _music;
	[SerializeField] private AudioMixerGroup _effects;
	[SerializeField] private AudioMixerSnapshot _normal;
	[SerializeField] private AudioMixerSnapshot _silence;

	private readonly float _minVolume = -80f;
	private readonly float _maxVolume = 0f;
	private float _transitionSpeed = 1f;
	private bool _isMuted = false;

	public void SetMusicVolume(float volume)
    {
		_music.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(_minVolume, _maxVolume, volume));
    }

	public void SetMasterVolume(float volume)
	{
		_master.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(_minVolume, _maxVolume, volume));
	}

	public void SetEffectsVolume(float volume)
	{
		_effects.audioMixer.SetFloat("EffectsVolume", Mathf.Lerp(_minVolume, _maxVolume, volume));
	}

	public void SwitchMuteAudio()
	{
		if (_isMuted)
		{
			_normal.TransitionTo(_transitionSpeed);
			_isMuted = false;
		}
		else
		{
			_silence.TransitionTo(_transitionSpeed);
			_isMuted = true;
		}
	}
}
