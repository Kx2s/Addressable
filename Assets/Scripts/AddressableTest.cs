using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableTest : MonoBehaviour
{
    public AssetReference a;
    // Start is called before the first frame update
    void Start()
    {
    }

    IEnumerator AddressbleRoutine()
    {
        AsyncOperationHandle<Material> handle = Addressables.LoadAssetAsync<Material>("New Material");
        yield return handle;


        Material m = handle.Result;
    }
}
 