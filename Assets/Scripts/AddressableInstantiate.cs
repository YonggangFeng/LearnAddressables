using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AddressableInstantiate : MonoBehaviour
{
    private GameObject instance;

    private bool autoDestroy = true;

    public void SwitchAutoDestroy()
    {
        autoDestroy = !autoDestroy;
        if (autoDestroy)
        {
            Release();
        }
    }

    public async void SpawnGameObject(string address)
    {
        if (instance != null) return;

        instance =  await Addressables.InstantiateAsync(address).Task;

        Vector3 position = Random.insideUnitSphere * 5;
        position.Set(position.x, 0f, position.z);

        instance.transform.position = position;

        if (autoDestroy)
        {
            Invoke("Release", 5f);
        }
    }

    private void Release()
    {
        Addressables.ReleaseInstance(instance);
        instance = null;
    }
}
