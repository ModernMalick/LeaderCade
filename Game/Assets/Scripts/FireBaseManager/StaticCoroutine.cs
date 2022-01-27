using System.Collections;
using UnityEngine;

namespace FireBaseManager
{
    public class StaticCoroutine : MonoBehaviour {
        private static StaticCoroutine _mInstance;
 
        // OnDestroy is called when the MonoBehaviour will be destroyed.
        // Coroutines are not stopped when a MonoBehaviour is disabled, but only when it is definitely destroyed.
        private void OnDestroy()
        { _mInstance.StopAllCoroutines(); }
 
        // OnApplicationQuit is called on all game objects before the application is closed.
        // In the editor it is called when the user stops playmode.
        private void OnApplicationQuit()
        { _mInstance.StopAllCoroutines(); }
 
        // Build will attempt to retrieve the class-wide instance, returning it when available.
        // If no instance exists, attempt to find another StaticCoroutine that exists.
        // If no StaticCoroutines are present, create a dedicated StaticCoroutine object.
        private static StaticCoroutine Build() {
            if (_mInstance != null)
            { return _mInstance; }
 
            _mInstance = (StaticCoroutine)FindObjectOfType(typeof(StaticCoroutine));
 
            if (_mInstance != null)
            { return _mInstance; }
 
            GameObject instanceObject = new GameObject("StaticCoroutine");
            instanceObject.AddComponent<StaticCoroutine>();
            _mInstance = instanceObject.GetComponent<StaticCoroutine>();
 
            if (_mInstance != null)
            { return _mInstance; }
 
            Debug.LogError("Build did not generate a replacement instance. Method Failed!");
 
            return null;
        }
 
        // Overloaded Static Coroutine Methods which use Unity's default Coroutines.
        // Polymorphism applied for best compatibility with the standard engine.
        public static void Start(string methodName)
        { Build().StartCoroutine(methodName); }
        public static void Start(string methodName, object value)
        { Build().StartCoroutine(methodName, value); }
        public static void Start(IEnumerator routine)
        { Build().StartCoroutine(routine); }
    }
}