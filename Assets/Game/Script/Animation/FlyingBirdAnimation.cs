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
public class FlyingBirdAnimation : UnityEngine.MonoBehaviour {
    
    private UnityEngine.Animator animator;
    
    public bool Start {
        get {
            return false;
        }
        set {
            this.animator.SetTrigger(Hash.Start);
        }
    }
    
    public bool Success {
        get {
            return this.animator.GetBool(Hash.Success);
        }
        set {
            this.animator.SetBool(Hash.Success, value);
        }
    }
    
    private void Awake() {
        this.animator = this.GetComponent <UnityEngine.Animator>();
    }
    
    private class Name {
        
        public const string Start = "Start";
        
        public const string Success = "Success";
    }
    
    private class Hash {
        
        public static int Start = UnityEngine.Animator.StringToHash(Name.Start);
        
        public static int Success = UnityEngine.Animator.StringToHash(Name.Success);
    }
}