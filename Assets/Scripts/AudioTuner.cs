using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class AudioTuner : MonoBehaviour
{
	private const int CorrectingMixerValue = 20;
	private const int MinMixerVolume = -80;

	[SerializeField] private AudioMixerGroup _mixer;
	[SerializeField] private string _mixerName;

	private Slider _slider;

	private void Start()
	{
		_slider = GetComponent<Slider>();
	}

	private void OnEnable() 
	{
		_slider?.onValueChanged?.AddListener(SetVolume);
	}

	private void OnDisable()
	{
		_slider?.onValueChanged?.RemoveListener(SetVolume);
	}

	public void SetVolume(float value)
	{
		if (value == 0)
			_mixer.audioMixer.SetFloat(_mixerName, MinMixerVolume);
		else
			_mixer.audioMixer.SetFloat(_mixerName, Mathf.Log10(value) * CorrectingMixerValue);
	}
}
