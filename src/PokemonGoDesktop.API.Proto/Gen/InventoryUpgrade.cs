// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Inventory/InventoryUpgrade.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Inventory {

  /// <summary>Holder for reflection information generated from Inventory/InventoryUpgrade.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class InventoryUpgradeReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory/InventoryUpgrade.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InventoryUpgradeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBJbnZlbnRvcnkvSW52ZW50b3J5VXBncmFkZS5wcm90bxIJSW52ZW50b3J5",
            "GhZJbnZlbnRvcnkvSXRlbUlkLnByb3RvGiRJbnZlbnRvcnkvSW52ZW50b3J5",
            "VXBncmFkZVR5cGUucHJvdG8iiQEKEEludmVudG9yeVVwZ3JhZGUSIgoHaXRl",
            "bV9pZBgBIAEoDjIRLkludmVudG9yeS5JdGVtSWQSNQoMdXBncmFkZV90eXBl",
            "GAIgASgOMh8uSW52ZW50b3J5LkludmVudG9yeVVwZ3JhZGVUeXBlEhoKEmFk",
            "ZGl0aW9uYWxfc3RvcmFnZRgDIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Inventory.ItemIdReflection.Descriptor, global::Inventory.InventoryUpgradeTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Inventory.InventoryUpgrade), global::Inventory.InventoryUpgrade.Parser, new[]{ "ItemId", "UpgradeType", "AdditionalStorage" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class InventoryUpgrade : pb::IMessage<InventoryUpgrade> {
    private static readonly pb::MessageParser<InventoryUpgrade> _parser = new pb::MessageParser<InventoryUpgrade>(() => new InventoryUpgrade());
    public static pb::MessageParser<InventoryUpgrade> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Inventory.InventoryUpgradeReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public InventoryUpgrade() {
      OnConstruction();
    }

    partial void OnConstruction();

    public InventoryUpgrade(InventoryUpgrade other) : this() {
      itemId_ = other.itemId_;
      upgradeType_ = other.upgradeType_;
      additionalStorage_ = other.additionalStorage_;
    }

    public InventoryUpgrade Clone() {
      return new InventoryUpgrade(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private global::Inventory.ItemId itemId_ = 0;
    public global::Inventory.ItemId ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "upgrade_type" field.</summary>
    public const int UpgradeTypeFieldNumber = 2;
    private global::Inventory.InventoryUpgradeType upgradeType_ = 0;
    public global::Inventory.InventoryUpgradeType UpgradeType {
      get { return upgradeType_; }
      set {
        upgradeType_ = value;
      }
    }

    /// <summary>Field number for the "additional_storage" field.</summary>
    public const int AdditionalStorageFieldNumber = 3;
    private int additionalStorage_;
    public int AdditionalStorage {
      get { return additionalStorage_; }
      set {
        additionalStorage_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as InventoryUpgrade);
    }

    public bool Equals(InventoryUpgrade other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (UpgradeType != other.UpgradeType) return false;
      if (AdditionalStorage != other.AdditionalStorage) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (UpgradeType != 0) hash ^= UpgradeType.GetHashCode();
      if (AdditionalStorage != 0) hash ^= AdditionalStorage.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemId);
      }
      if (UpgradeType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) UpgradeType);
      }
      if (AdditionalStorage != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(AdditionalStorage);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (UpgradeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UpgradeType);
      }
      if (AdditionalStorage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AdditionalStorage);
      }
      return size;
    }

    public void MergeFrom(InventoryUpgrade other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.UpgradeType != 0) {
        UpgradeType = other.UpgradeType;
      }
      if (other.AdditionalStorage != 0) {
        AdditionalStorage = other.AdditionalStorage;
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
            itemId_ = (global::Inventory.ItemId) input.ReadEnum();
            break;
          }
          case 16: {
            upgradeType_ = (global::Inventory.InventoryUpgradeType) input.ReadEnum();
            break;
          }
          case 24: {
            AdditionalStorage = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code