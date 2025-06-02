using UnityEngine;

public interface ITrappable
{
    public bool IsBeingCaptured { get; set; }
    public bool CaptureAnimation();
    public int PointValue();
}
