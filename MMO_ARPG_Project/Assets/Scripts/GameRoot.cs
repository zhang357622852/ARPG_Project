using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;
using System.Collections;
using System.Threading;
using LPC;

public static class GameRoot
{
    #region 属性

    // 根物体
    public static GameObject RootGameObject { get; private set; }

    // 闪屏是否完成
    private static bool isStartAniOver = false;

    /// <summary>
    /// 初始化进度
    /// </summary>
    /// <value>The init progress.</value>
    private static float InitProgress { get; set; }

    // 是否初始化完成
    public static bool IsInit { get; private set; }

    #endregion

    /// <summary>
    /// 初始化游戏根对象
    /// </summary>
    public static void Init()
    {
        // 创建根对象
        CreateRootGameObject();
    }

    /// <summary>
    /// 创建GameObject根对象
    /// </summary>
    private static void CreateRootGameObject()
    {
        // 如果RootGameObject对象已经存在
        if (RootGameObject != null)
            return;

        // 创建一个永远存在的根对象
        // 某些全局的组件可以放在上面
        // GameRoot.cs 是脚本层的逻辑根对象
        // RootGameObject 是GameObject的根对象
        RootGameObject = new GameObject("GameRoot");
        GameObject.DontDestroyOnLoad(RootGameObject);

        // 添加音效组件，用于bgm唯一播放
        // 两个音效之间切换需要叠加淡入淡出（所以这个地方增加两个AudioSource）
        RootGameObject.AddComponent<AudioSource>();
        RootGameObject.AddComponent<AudioSource>();
        RootGameObject.AddComponent<AudioSource>();
        RootGameObject.AddComponent<AudioSource>();
        RootGameObject.AddComponent<AudioSource>();
        RootGameObject.AddComponent<AudioListener>();

        // 逻辑驱动Scheduler
        RootGameObject.AddComponent<Scheduler>();
    }
}
