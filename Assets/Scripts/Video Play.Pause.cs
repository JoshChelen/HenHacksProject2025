using UnityEngine;
using UnityEngine.UI;  // If you want to use UI buttons
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;  // Reference to the VideoPlayer component
    public Button playPauseButton;   // Reference to the button that controls play/pause
    public Sprite pauseImage;
    public Sprite playImage;

    private Image buttonImage;

    void Start()
    {
        buttonImage = playPauseButton.GetComponent<Image>();
        // Make sure the button has an onClick event to trigger PlayPause method
        playPauseButton.onClick.AddListener(TogglePlayPause);
    }

    void TogglePlayPause()
    {
        if (videoPlayer.isPlaying)
        {
            // If the video is currently playing, pause it
            videoPlayer.Pause();
            buttonImage.sprite = pauseImage;
        }
        else
        {
            // If the video is paused or stopped, play it
            videoPlayer.Play();
            buttonImage.sprite = playImage;
        }
    }
}
