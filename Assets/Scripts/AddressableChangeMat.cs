using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableChangeMat : MonoBehaviour
{
    private GameObject instance;


    public async void SpawnGameObject(string address)
    {
        if (instance != null) return;

        instance = await Addressables.InstantiateAsync(address).Task;
    }

    public async void ChangeMaterial(string address)
    {
        if (instance == null) return;

        Material destMat = await Addressables.LoadAssetAsync<Material>(address).Task;
        instance.transform.Find("Body").GetComponent<MeshRenderer>().material = destMat;
    }

}
