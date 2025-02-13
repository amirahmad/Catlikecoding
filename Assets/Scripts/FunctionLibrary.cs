﻿//////////////////////////////////////////////////////
//
//
//
//
//
//////////////////////////////////////////////////////

using static UnityEngine.Mathf;
public static class FunctionLibrary
{
    public delegate float Function(float x, float t);

    public enum  _functionName {Wave, MultiWave, Ripple}

    private static Function[] _functions = {Wave, MultiWave, Ripple};
    public static Function GetFunction(_functionName name)
    {
        return _functions[(int)name];
    }
    public static float Wave(float x, float t)
    {
        return Sin(PI * (x + t));
    }

    public static float MultiWave(float x, float t)
    {
        float y = Sin(PI * (x + 0.5f * t));
        y += Sin(2f * PI * (x + t)) *(0.5f);
        
        return y * (2f / 3f);
    }

    public static float Ripple(float x, float t)
    {
        float d = Abs(x);
        float y = Sin(PI * (4f * d - t));
        return y / (1f + 10f * d);
    }
}
