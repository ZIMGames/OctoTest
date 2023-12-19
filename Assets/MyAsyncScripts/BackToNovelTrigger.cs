using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;

public class BackToNovelTrigger : MonoBehaviour
{
    public string ScriptName;
    public string Label;

    public void BackToNovel ()
    {
        var blocker = Object.FindObjectOfType<MiniGameBlockInput>();
        blocker.IsInputBlocked = true;

        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = true;

        var advCamera = GameObject.Find("AdventureModeCamera").GetComponent<Camera>();
        advCamera.enabled = false;
        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = true;

        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.PreloadAndPlayAsync(ScriptName, label: Label).Forget();
    }
}
