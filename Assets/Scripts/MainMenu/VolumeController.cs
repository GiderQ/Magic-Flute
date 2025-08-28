using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private string mixerParameter;
    private string prefsKey;

    private void Awake()
    {
        prefsKey = mixerParameter + "Volume";
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey(prefsKey))
            LoadVolume();
        else
            SetVolume();
    }

    public void SetVolume()
    {
        float volume = volumeSlider.value;
        myMixer.SetFloat(mixerParameter, Mathf.Log10(Mathf.Clamp(volume, 0.0001f, 1f)) * 20);
        PlayerPrefs.SetFloat(prefsKey, volume);
    }

    private void LoadVolume()
    {
        float savedVolume = PlayerPrefs.GetFloat(prefsKey, 1f);
        volumeSlider.value = savedVolume;
        SetVolume();
    }

    public void AddVolumeButton()
    {
        volumeSlider.value = Mathf.Clamp01(volumeSlider.value + 0.1f);
        SetVolume();
    }

    public void RemoveVolumeButton()
    {
        volumeSlider.value = Mathf.Clamp01(volumeSlider.value - 0.1f);
        SetVolume();
    }
}