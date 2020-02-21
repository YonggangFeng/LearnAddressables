using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AssetReferenceInstantiate : MonoBehaviour
{
    public AssetReference cubeAsset;

    private AsyncOperationHandle<GameObject> instance;

    private bool autoDestroy = true;

    public void SwitchAutoDestroy()
    {
        autoDestroy = !autoDestroy;
        if(autoDestroy)
        {
            Release();
        }
    }

    public void SpawnCube()
    {
        if (instance.IsValid()) return;

        Vector3 position = Random.insideUnitSphere * 5;
        position.Set(position.x, 0.5f, position.z);

        instance = cubeAsset.InstantiateAsync(position, Quaternion.identity);

        if (autoDestroy)
        {
            Invoke("Release", 5f);
        }
    }

    private void Release()
    {
        if (!instance.IsValid()) return;
        cubeAsset.ReleaseInstance(instance.Result);
    }
}
