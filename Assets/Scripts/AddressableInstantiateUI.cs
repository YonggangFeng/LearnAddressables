using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AddressableInstantiateUI : MonoBehaviour
{
    private GameObject instance;

    public async void SpawnGameObject(string address)
    {
        if (instance != null) return;

        instance = await Addressables.InstantiateAsync(address).Task;
    }
}
