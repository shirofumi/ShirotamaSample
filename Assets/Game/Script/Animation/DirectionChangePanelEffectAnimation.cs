// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



[UnityEngine.RequireComponent(typeof(UnityEngine.Animator))]
public class DirectionChangePanelEffectAnimation : UnityEngine.MonoBehaviour {
    
    private UnityEngine.Animator animator;
    
    public bool ChangeDirection {
        get {
            return false;
        }
        set {
            this.animator.SetTrigger(Hash.ChangeDirection);
        }
    }
    
    private void Awake() {
        this.animator = this.GetComponent <UnityEngine.Animator>();
    }
    
    private class Name {
        
        public const string ChangeDirection = "ChangeDirection";
    }
    
    private class Hash {
        
        public static int ChangeDirection = UnityEngine.Animator.StringToHash(Name.ChangeDirection);
    }
}
