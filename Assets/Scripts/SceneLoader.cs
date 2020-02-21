using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

public class SceneLoader : MonoBehaviour
{
    ////游戏主场景地址标识；
    //public string gameMainSceneAddress;

    /// <summary>
    /// 开始游戏
    /// </summary>
    /// <param name="mainSceneAddress">主场景地址标识</param>
    public void StartGame(string mainSceneAddress)
    {
        Addressables.LoadSceneAsync(mainSceneAddress);
    }
}
