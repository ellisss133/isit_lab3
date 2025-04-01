using UnityEngine;

public class Simple : MonoBehaviour { void Awake() { Debug.Log("Awake - вызывается перед Start"); }

void OnEnable()
{
    Debug.Log("OnEnable - вызывается при активации объекта");
}

void Start()
{
    Debug.Log("Start - вызывается перед первым кадром");
}

void FixedUpdate()
{
    Debug.Log("FixedUpdate - вызывается на фиксированных интервалах физики");
}

void Update()
{
    Debug.Log("Update - вызывается каждый кадр");
}

void LateUpdate()
{
    Debug.Log("LateUpdate - вызывается после Update каждый кадр");
}

void OnDisable()
{
    Debug.Log("OnDisable - вызывается при деактивации объекта");
}

void OnDestroy()
{
    Debug.Log("OnDestroy - вызывается перед уничтожением объекта");
}

}
