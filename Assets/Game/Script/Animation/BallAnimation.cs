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
public class BallAnimation : UnityEngine.MonoBehaviour {
    
    private UnityEngine.Animator animator;
    
    public float ExcitedLevel {
        get {
            return this.animator.GetFloat(Hash.ExcitedLevel);
        }
        set {
            this.animator.SetFloat(Hash.ExcitedLevel, value);
        }
    }
    
    public bool OutOfControl {
        get {
            return this.animator.GetBool(Hash.OutOfControl);
        }
        set {
            this.animator.SetBool(Hash.OutOfControl, value);
        }
    }
    
    public bool Hit {
        get {
            return false;
        }
        set {
            this.animator.SetTrigger(Hash.Hit);
        }
    }
    
    private void Awake() {
        this.animator = this.GetComponent <UnityEngine.Animator>();
    }
    
    private class Name {
        
        public const string ExcitedLevel = "ExcitedLevel";
        
        public const string OutOfControl = "OutOfControl";
        
        public const string Hit = "Hit";
    }
    
    private class Hash {
        
        public static int ExcitedLevel = UnityEngine.Animator.StringToHash(Name.ExcitedLevel);
        
        public static int OutOfControl = UnityEngine.Animator.StringToHash(Name.OutOfControl);
        
        public static int Hit = UnityEngine.Animator.StringToHash(Name.Hit);
    }
}
