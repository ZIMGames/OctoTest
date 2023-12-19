using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;

public class DialogueTrigger : MonoBehaviour
{
    public string ScriptName;
    public string Label;

    private void OnTriggerEnter (Collider other)
    {
        var blocker = other.gameObject.GetComponentInChildren<MiniGameBlockInput>();
        blocker.IsInputBlocked = true;

        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = true;

        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.PreloadAndPlayAsync(ScriptName, label: Label).Forget();
    }
}
