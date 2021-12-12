using UnityEngine;

namespace usingNamespace

{
    public class Utilities{
        public static void PrintCharger(){
            Debug.Log("Charger Games");
        }
    }

    namespace UI
    {
        public class UIStuff{
            public static void DoUI(){
                Debug.Log("DoUI");
            }
        }
    }
}