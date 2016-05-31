using UnityEngine;
using System.Collections;

public static class RendererExtensions
{
    public static bool IsVisiableFrom(this Renderer renderer, Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
    }
}
