using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 平台判断
/// </summary>
public static class Platform
{

    /// <summary>
    /// 是否是安卓模式
    /// </summary>
    public static bool IsAndroid
    {
        get
        {
            bool retValue = false;

#if UNITY_ANDROID
            retValue = true;
#endif
            return retValue;
        }
    }

    /// <summary>
    /// 是否是编辑器模式
    /// </summary>
    public static bool IsEditor
    {
        get
        {
            bool retValue = false;
#if UNITY_EDITOR
            retValue = true;
#endif
            return retValue;
        }
    }

    /// <summary>
    /// 是否是ios模式
    /// </summary>
    public static bool IsiOS
    {
        get
        {
            bool retValue = false;
#if UNITY_IOS
                retValue = true;
#endif
            return retValue;
        }
    }
}
