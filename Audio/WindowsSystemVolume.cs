using System;
using NAudio.CoreAudioApi;

namespace AvaloniaApplication1.Audio;

internal static class WindowsSystemVolume
{
    /// <summary>
    /// Sets default playback (render) endpoint volume on Windows via WASAPI.
    /// </summary>
    public static void SetMasterVolumeScalar(float level)
    {
        using var enumerator = new MMDeviceEnumerator();
        using var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        var volume = device.AudioEndpointVolume;
        volume.Mute = false;
        volume.MasterVolumeLevelScalar = Math.Clamp(level, 0f, 1f);
    }
}
