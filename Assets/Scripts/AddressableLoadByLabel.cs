using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AddressableLoadByLabel : MonoBehaviour
{
    public AssetLabelReference labelReference;

    public async void LoadAssetByLabel()
    {
        IList<GameObject> labelLoadAssets = await Addressables.LoadAssetsAsync<GameObject>(labelReference, null).Task;

        foreach (var asset in labelLoadAssets)
        {
            Vector3 position = Random.insideUnitSphere * 5;
            position.Set(position.x, 0.5f, position.z);

            Instantiate(asset, position, Quaternion.identity, null);
        }
    }
}
