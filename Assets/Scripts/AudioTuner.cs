using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioTuner : MonoBehaviour
{
	[SerializeField] private AudioMixer _mixer;
	[SerializeField] private Slider _slider;

	public void SetVolume(string name)
	{
		_mixer.SetFloat(name, Mathf.Log10(_slider.value) * 20);
	}
}
