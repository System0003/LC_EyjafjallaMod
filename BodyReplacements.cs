using ModelReplacement;
using UnityEngine;

namespace ModelReplacement
{
    public class MREYJAFJALLA : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        { 
            string model_name = "Eyjafjalla";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
}