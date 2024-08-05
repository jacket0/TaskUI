using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class AudioTuner : MonoBehaviour
{
	[SerializeField] private AudioMixerGroup _mixer;
	[SerializeField] private string _parameterName;

	private const int CorrectingMixerValue = 20;

	private Slider _slider;

	private void Awake()
	{
		_slider = GetComponent<Slider>();
	}

	private void Start() 
	{
		_slider?.onValueChanged?.AddListener(SetVolume);
	}

	private void OnDisable()
	{
		_slider?.onValueChanged?.RemoveListener(SetVolume);
	}

	public void SetVolume(float value)
	{
		_mixer.audioMixer.SetFloat(_parameterName, Mathf.Log10(value) * CorrectingMixerValue);
	}
}
