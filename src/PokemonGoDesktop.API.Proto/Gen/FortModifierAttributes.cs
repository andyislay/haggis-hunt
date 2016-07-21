// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Settings/Master/Item/FortModifierAttributes.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Settings.Master.Item {

  /// <summary>Holder for reflection information generated from Settings/Master/Item/FortModifierAttributes.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class FortModifierAttributesReflection {

    #region Descriptor
    /// <summary>File descriptor for Settings/Master/Item/FortModifierAttributes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FortModifierAttributesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFTZXR0aW5ncy9NYXN0ZXIvSXRlbS9Gb3J0TW9kaWZpZXJBdHRyaWJ1dGVz",
            "LnByb3RvEhRTZXR0aW5ncy5NYXN0ZXIuSXRlbSJiChZGb3J0TW9kaWZpZXJB",
            "dHRyaWJ1dGVzEiEKGW1vZGlmaWVyX2xpZmV0aW1lX3NlY29uZHMYASABKAUS",
            "JQoddHJveV9kaXNrX251bV9wb2tlbW9uX3NwYXduZWQYAiABKAViBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Settings.Master.Item.FortModifierAttributes), global::Settings.Master.Item.FortModifierAttributes.Parser, new[]{ "ModifierLifetimeSeconds", "TroyDiskNumPokemonSpawned" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class FortModifierAttributes : pb::IMessage<FortModifierAttributes> {
    private static readonly pb::MessageParser<FortModifierAttributes> _parser = new pb::MessageParser<FortModifierAttributes>(() => new FortModifierAttributes());
    public static pb::MessageParser<FortModifierAttributes> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Settings.Master.Item.FortModifierAttributesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public FortModifierAttributes() {
      OnConstruction();
    }

    partial void OnConstruction();

    public FortModifierAttributes(FortModifierAttributes other) : this() {
      modifierLifetimeSeconds_ = other.modifierLifetimeSeconds_;
      troyDiskNumPokemonSpawned_ = other.troyDiskNumPokemonSpawned_;
    }

    public FortModifierAttributes Clone() {
      return new FortModifierAttributes(this);
    }

    /// <summary>Field number for the "modifier_lifetime_seconds" field.</summary>
    public const int ModifierLifetimeSecondsFieldNumber = 1;
    private int modifierLifetimeSeconds_;
    public int ModifierLifetimeSeconds {
      get { return modifierLifetimeSeconds_; }
      set {
        modifierLifetimeSeconds_ = value;
      }
    }

    /// <summary>Field number for the "troy_disk_num_pokemon_spawned" field.</summary>
    public const int TroyDiskNumPokemonSpawnedFieldNumber = 2;
    private int troyDiskNumPokemonSpawned_;
    public int TroyDiskNumPokemonSpawned {
      get { return troyDiskNumPokemonSpawned_; }
      set {
        troyDiskNumPokemonSpawned_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as FortModifierAttributes);
    }

    public bool Equals(FortModifierAttributes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModifierLifetimeSeconds != other.ModifierLifetimeSeconds) return false;
      if (TroyDiskNumPokemonSpawned != other.TroyDiskNumPokemonSpawned) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ModifierLifetimeSeconds != 0) hash ^= ModifierLifetimeSeconds.GetHashCode();
      if (TroyDiskNumPokemonSpawned != 0) hash ^= TroyDiskNumPokemonSpawned.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ModifierLifetimeSeconds != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ModifierLifetimeSeconds);
      }
      if (TroyDiskNumPokemonSpawned != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TroyDiskNumPokemonSpawned);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ModifierLifetimeSeconds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ModifierLifetimeSeconds);
      }
      if (TroyDiskNumPokemonSpawned != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TroyDiskNumPokemonSpawned);
      }
      return size;
    }

    public void MergeFrom(FortModifierAttributes other) {
      if (other == null) {
        return;
      }
      if (other.ModifierLifetimeSeconds != 0) {
        ModifierLifetimeSeconds = other.ModifierLifetimeSeconds;
      }
      if (other.TroyDiskNumPokemonSpawned != 0) {
        TroyDiskNumPokemonSpawned = other.TroyDiskNumPokemonSpawned;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            ModifierLifetimeSeconds = input.ReadInt32();
            break;
          }
          case 16: {
            TroyDiskNumPokemonSpawned = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code