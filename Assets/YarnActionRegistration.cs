namespace Yarn.Unity.Generated
{
    [System.CodeDom.Compiler.GeneratedCode("YarnActionAnalyzer", "1.0.0.0")]
    public class ActionRegistration
    {
#if UNITY_EDITOR
        [global::UnityEditor.InitializeOnLoadMethod]
#endif
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void AddRegisterFunction()
        {
            Actions.AddRegistrationMethod(RegisterActions);
        }

        [System.CodeDom.Compiler.GeneratedCode("YarnActionAnalyzer", "1.0.0.0")]
        public static void RegisterActions(global::Yarn.Unity.IActionRegistration target)
        {
            // Actions from file:
            // Assets\Scripts\YarnInteractable.cs
            target.AddCommandHandler("disable", typeof(global::YarnInteractable).GetMethod(nameof(global::YarnInteractable.DisableConversation), new System.Type[]{}));
        }
    }
}