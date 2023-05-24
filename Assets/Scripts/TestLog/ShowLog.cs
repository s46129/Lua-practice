using UnityEngine;
using XLua;
using NaughtyAttributes;

namespace TestLog
{
    public class ShowLog : MonoBehaviour
    {
        [TextArea] [SerializeField] private string _doString;

        void Start()
        {
            DoString();
        }

        [Button]
        private void DoString()
        {
            LuaEnv luaEnv = new LuaEnv();
            luaEnv.DoString(_doString);
            luaEnv.Dispose();
        }
    }
}