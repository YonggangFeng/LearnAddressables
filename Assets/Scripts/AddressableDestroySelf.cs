using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AddressableDestroySelf : MonoBehaviour
{
    
    public void Release()
    {
        Addressables.ReleaseInstance(gameObject);
    }
}
