//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Command.proto
namespace Cmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAccountOperation")]
  public partial class ReqAccountOperation : global::ProtoBuf.IExtensible
  {
    public ReqAccountOperation() {}
    
    private Cmd.AccountAction _action;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"action", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Cmd.AccountAction action
    {
      get { return _action; }
      set { _action = value; }
    }
    private string _user;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"user", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string user
    {
      get { return _user; }
      set { _user = value; }
    }
    private string _password;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RetAccountOperation")]
  public partial class RetAccountOperation : global::ProtoBuf.IExtensible
  {
    public RetAccountOperation() {}
    
    private Cmd.AccountErrorCode _error;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"error", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Cmd.AccountErrorCode error
    {
      get { return _error; }
      set { _error = value; }
    }
    private int _accountid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }
    private int _time;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int time
    {
      get { return _time; }
      set { _time = value; }
    }
    private string _token;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string token
    {
      get { return _token; }
      set { _token = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _late_serverids = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(5, Name=@"late_serverids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> late_serverids
    {
      get { return _late_serverids; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqLoginGameServer")]
  public partial class ReqLoginGameServer : global::ProtoBuf.IExtensible
  {
    public ReqLoginGameServer() {}
    
    private int _accountid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }
    private int _time;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int time
    {
      get { return _time; }
      set { _time = value; }
    }
    private string _token;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string token
    {
      get { return _token; }
      set { _token = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GameRole")]
  public partial class GameRole : global::ProtoBuf.IExtensible
  {
    public GameRole() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _level = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _sex = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"sex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sex
    {
      get { return _sex; }
      set { _sex = value; }
    }
    private int _job = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"job", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int job
    {
      get { return _job; }
      set { _job = value; }
    }
    private int _vip = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"vip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int vip
    {
      get { return _vip; }
      set { _vip = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RetLoginGameServer")]
  public partial class RetLoginGameServer : global::ProtoBuf.IExtensible
  {
    public RetLoginGameServer() {}
    
    private Cmd.LoginGameError _error;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"error", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Cmd.LoginGameError error
    {
      get { return _error; }
      set { _error = value; }
    }
    private Cmd.GameRole _role;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"role", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.GameRole role
    {
      get { return _role; }
      set { _role = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqCreateRole")]
  public partial class ReqCreateRole : global::ProtoBuf.IExtensible
  {
    public ReqCreateRole() {}
    
    private int _sex = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"sex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sex
    {
      get { return _sex; }
      set { _sex = value; }
    }
    private int _job = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"job", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int job
    {
      get { return _job; }
      set { _job = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RetCreateRole")]
  public partial class RetCreateRole : global::ProtoBuf.IExtensible
  {
    public RetCreateRole() {}
    
    private Cmd.CreateRoleError _error = Cmd.CreateRoleError.CreateRoleSucess;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"error", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.CreateRoleError.CreateRoleSucess)]
    public Cmd.CreateRoleError error
    {
      get { return _error; }
      set { _error = value; }
    }
    private Cmd.GameRole _role = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"role", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Cmd.GameRole role
    {
      get { return _role; }
      set { _role = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RTMainUser")]
  public partial class RTMainUser : global::ProtoBuf.IExtensible
  {
    public RTMainUser() {}
    
    private int _charID = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"charID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int charID
    {
      get { return _charID; }
      set { _charID = value; }
    }
    private int _job = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"job", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int job
    {
      get { return _job; }
      set { _job = value; }
    }
    private int _sex = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"sex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sex
    {
      get { return _sex; }
      set { _sex = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _vip = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"vip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int vip
    {
      get { return _vip; }
      set { _vip = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"AccountAction")]
    public enum AccountAction
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountAction_None", Value=0)]
      AccountAction_None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountAction_Create", Value=1)]
      AccountAction_Create = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountAction_Rename", Value=2)]
      AccountAction_Rename = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountAction_Delete", Value=3)]
      AccountAction_Delete = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountAction_Login", Value=4)]
      AccountAction_Login = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"AccountErrorCode")]
    public enum AccountErrorCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountErrorCode_None", Value=0)]
      AccountErrorCode_None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountErrorCode_CreateSucessed", Value=1)]
      AccountErrorCode_CreateSucessed = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountErrorCode_NameRepeated", Value=2)]
      AccountErrorCode_NameRepeated = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountErrorCode_UserCantFind", Value=3)]
      AccountErrorCode_UserCantFind = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountErrorCode_PasswordError", Value=4)]
      AccountErrorCode_PasswordError = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountErrorCode_LoginSucessed", Value=5)]
      AccountErrorCode_LoginSucessed = 5
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"LoginGameError")]
    public enum LoginGameError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"LoginGameSucess", Value=100)]
      LoginGameSucess = 100,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LoginGameOverdue", Value=300)]
      LoginGameOverdue = 300,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LoginGameInvalid", Value=400)]
      LoginGameInvalid = 400
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"CreateRoleError")]
    public enum CreateRoleError
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CreateRoleSucess", Value=0)]
      CreateRoleSucess = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CreateRoleNameRepeated", Value=1)]
      CreateRoleNameRepeated = 1
    }
  
}