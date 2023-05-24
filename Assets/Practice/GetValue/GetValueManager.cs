using NaughtyAttributes;
using UnityEngine;
using XLua;

namespace Practice.GetValue
{
    [CSharpCallLua]
    public class GetValueManager : MonoBehaviour
    {
        private static int A = 3, B = 5;
        private static LuaEnv _luaEnv = new LuaEnv();
        [SerializeField] [TextArea] private string doString;

        [SerializeField] [ReadOnly] private int result;

        [Button]
        public void Calculate()
        {
            _luaEnv.DoString(doString);
            result = _luaEnv.Global.Get<int>("result");
        }


        public static int GetA()
        {
            return A;
        }

        public static int GetB()
        {
            return B;
        }
    }
}