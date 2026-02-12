using UnityEngine;
using UnityEngine.XR;

public class ForceDeviceTrackingOrigin : MonoBehaviour
{
    void Start()
    {
        var subsystems = new System.Collections.Generic.List<XRInputSubsystem>();
        SubsystemManager.GetSubsystems(subsystems);

        foreach (var s in subsystems)
        {
            s.TrySetTrackingOriginMode(TrackingOriginModeFlags.Device);
        }
    }
}