# Class TrackedAliasFacade

The public interface into the Tracked Alias Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [DominantControllerIsChanging]
  * [HeadsetBatteryChargeStatusChanged]
  * [HeadsetConnectionStatusChanged]
  * [HeadsetTrackingBegun]
  * [HeadsetTrackingTypeChanged]
  * [LeftControllerBatteryChargeStatusChanged]
  * [LeftControllerConnectionStatusChanged]
  * [LeftControllerTrackingBegun]
  * [LeftControllerTrackingTypeChanged]
  * [RightControllerBatteryChargeStatusChanged]
  * [RightControllerConnectionStatusChanged]
  * [RightControllerTrackingBegun]
  * [RightControllerTrackingTypeChanged]
  * [TrackedAliasChanged]
* [Properties]
  * [ActiveDominantControllerNode]
  * [ActiveDominantControllerObserver]
  * [ActiveDominantControllerRecord]
  * [ActiveHeadset]
  * [ActiveHeadsetBatteryChargeStatus]
  * [ActiveHeadsetBatteryLevel]
  * [ActiveHeadsetCamera]
  * [ActiveHeadsetDetails]
  * [ActiveHeadsetIsConnected]
  * [ActiveHeadsetManufacturer]
  * [ActiveHeadsetModel]
  * [ActiveHeadsetTrackingHasBegun]
  * [ActiveHeadsetTrackingType]
  * [ActiveHeadsetVelocity]
  * [ActiveLeftController]
  * [ActiveLeftControllerBatteryChargeStatus]
  * [ActiveLeftControllerBatteryLevel]
  * [ActiveLeftControllerDetails]
  * [ActiveLeftControllerIsConnected]
  * [ActiveLeftControllerManufacturer]
  * [ActiveLeftControllerModel]
  * [ActiveLeftControllerTrackingHasBegun]
  * [ActiveLeftControllerTrackingType]
  * [ActiveLeftControllerVelocity]
  * [ActiveLeftHapticProcess]
  * [ActiveLeftHapticProfile]
  * [ActiveLeftHapticProfiles]
  * [ActiveLinkedAliasAssociation]
  * [ActivePlayArea]
  * [ActiveRightController]
  * [ActiveRightControllerBatteryChargeStatus]
  * [ActiveRightControllerBatteryLevel]
  * [ActiveRightControllerDetails]
  * [ActiveRightControllerIsConnected]
  * [ActiveRightControllerManufacturer]
  * [ActiveRightControllerModel]
  * [ActiveRightControllerTrackingHasBegun]
  * [ActiveRightControllerTrackingType]
  * [ActiveRightControllerVelocity]
  * [ActiveRightHapticProcess]
  * [ActiveRightHapticProfile]
  * [ActiveRightHapticProfiles]
  * [CameraRigs]
  * [Configuration]
  * [DominantControllerObservers]
  * [HeadsetAlias]
  * [HeadsetCameras]
  * [HeadsetDeviceDetailRecords]
  * [HeadsetOriginAlias]
  * [Headsets]
  * [HeadsetSupplementCameras]
  * [HeadsetVelocityTrackers]
  * [LeftControllerAlias]
  * [LeftControllerDeviceDetailRecords]
  * [LeftControllerHapticProcesses]
  * [LeftControllerHapticProfiles]
  * [LeftControllers]
  * [LeftControllerVelocityTrackers]
  * [PlayAreaAlias]
  * [PlayAreas]
  * [RightControllerAlias]
  * [RightControllerDeviceDetailRecords]
  * [RightControllerHapticProcesses]
  * [RightControllerHapticProfiles]
  * [RightControllers]
  * [RightControllerVelocityTrackers]
* [Methods]
  * [BeginHapticProcessOnLeftController()]
  * [BeginHapticProcessOnLeftController(Int32)]
  * [BeginHapticProcessOnRightController()]
  * [BeginHapticProcessOnRightController(Int32)]
  * [BeginHapticProfile(HapticProcessObservableList, Int32)]
  * [CancelActiveHapticProfileOnLeftController()]
  * [CancelActiveHapticProfileOnRightController()]
  * [CancelAllHapticsOnLeftController()]
  * [CancelAllHapticsOnRightController()]
  * [CancelHapticProcessOnLeftController()]
  * [CancelHapticProcessOnLeftController(Int32)]
  * [CancelHapticProcessOnRightController()]
  * [CancelHapticProcessOnRightController(Int32)]
  * [CancelHapticProfile(HapticProcessObservableList, Int32)]
  * [GetFirstActiveCamera(IEnumerable<Camera>)]
  * [GetFirstActiveDeviceRecord(IEnumerable<DeviceDetailsRecord>)]
  * [GetFirstActiveDominantControllerObserver(IEnumerable<DominantControllerObserver>)]
  * [GetFirstActiveGameObject(IEnumerable<GameObject>)]
  * [GetFirstActiveHapticProcess(IEnumerable<HapticProcess>)]
  * [GetFirstActiveHapticProfile(IEnumerable<HapticProcessObservableList>)]
  * [GetFirstActiveLinkedAliasAssociationCollection(IEnumerable<LinkedAliasAssociationCollection>)]
  * [GetFirstActiveVelocityTracker(IEnumerable<VelocityTracker>)]
  * [IsValidHapticProfile(HapticProcessObservableList, Int32)]
  * [OnAfterCameraRigsChange()]
  * [OnBeforeCameraRigsChange()]
  * [OnCameraRigAdded(LinkedAliasAssociationCollection)]
  * [OnCameraRigRemoved(LinkedAliasAssociationCollection)]
  * [OnDisable()]
  * [OnEnable()]
  * [RefreshCameraRigsConfiguration()]
  * [SubscribeToCameraRigsEvents()]
  * [UnsubscribeFromCameraRigsEvents()]

## Details

##### Inheritance

* System.Object
* TrackedAliasFacade

##### Namespace

* [Tilia.CameraRigs.TrackedAlias]

##### Syntax

```
public class TrackedAliasFacade : MonoBehaviour
```

### Fields

#### DominantControllerIsChanging

Emitted when the dominant controller is changing.

##### Declaration

```
public DominantControllerObserver.UnityEvent DominantControllerIsChanging
```

#### HeadsetBatteryChargeStatusChanged

Emitted when the headset battery charge status changes.

##### Declaration

```
public DeviceDetailsRecord.BatteryStatusUnityEvent HeadsetBatteryChargeStatusChanged
```

#### HeadsetConnectionStatusChanged

Emitted when the headset connection status changes.

##### Declaration

```
public DeviceDetailsRecord.BoolUnityEvent HeadsetConnectionStatusChanged
```

#### HeadsetTrackingBegun

Emitted when the headset starts tracking for the first time.

##### Declaration

```
public UnityEvent HeadsetTrackingBegun
```

#### HeadsetTrackingTypeChanged

Emitted when the headset tracking type changes.

##### Declaration

```
public DeviceDetailsRecord.SpatialTrackingTypeUnityEvent HeadsetTrackingTypeChanged
```

#### LeftControllerBatteryChargeStatusChanged

Emitted when the left controller battery charge status changes.

##### Declaration

```
public DeviceDetailsRecord.BatteryStatusUnityEvent LeftControllerBatteryChargeStatusChanged
```

#### LeftControllerConnectionStatusChanged

Emitted when the left controller connection status changes.

##### Declaration

```
public DeviceDetailsRecord.BoolUnityEvent LeftControllerConnectionStatusChanged
```

#### LeftControllerTrackingBegun

Emitted when the left controller starts tracking for the first time.

##### Declaration

```
public UnityEvent LeftControllerTrackingBegun
```

#### LeftControllerTrackingTypeChanged

Emitted when the left controller tracking type changes.

##### Declaration

```
public DeviceDetailsRecord.SpatialTrackingTypeUnityEvent LeftControllerTrackingTypeChanged
```

#### RightControllerBatteryChargeStatusChanged

Emitted when the right controller battery charge status changes.

##### Declaration

```
public DeviceDetailsRecord.BatteryStatusUnityEvent RightControllerBatteryChargeStatusChanged
```

#### RightControllerConnectionStatusChanged

Emitted when the right controller connection status changes.

##### Declaration

```
public DeviceDetailsRecord.BoolUnityEvent RightControllerConnectionStatusChanged
```

#### RightControllerTrackingBegun

Emitted when the right controller starts tracking for the first time.

##### Declaration

```
public UnityEvent RightControllerTrackingBegun
```

#### RightControllerTrackingTypeChanged

Emitted when the right controller tracking type changes.

##### Declaration

```
public DeviceDetailsRecord.SpatialTrackingTypeUnityEvent RightControllerTrackingTypeChanged
```

#### TrackedAliasChanged

Emitted when the tracked alias is about to change.

##### Declaration

```
public TrackedAliasFacade.LinkedAliasAssociationCollectionUnityEvent TrackedAliasChanged
```

### Properties

#### ActiveDominantControllerNode

Retrieves the dominant connected controller node.

##### Declaration

```
public XRNode ActiveDominantControllerNode { get; }
```

#### ActiveDominantControllerObserver

Retrieves the active Headset Detail Record that the TrackedAlias is using.

##### Declaration

```
public DominantControllerObserver ActiveDominantControllerObserver { get; }
```

#### ActiveDominantControllerRecord

Retrieves the dominant connected controller node.

##### Declaration

```
public DeviceDetailsRecord ActiveDominantControllerRecord { get; }
```

#### ActiveHeadset

Retrieves the active Headset that the TrackedAlias is using.

##### Declaration

```
public GameObject ActiveHeadset { get; }
```

#### ActiveHeadsetBatteryChargeStatus

Retrieves the active Headset Detail Battery Charge status that the TrackedAlias is using.

##### Declaration

```
public BatteryStatus ActiveHeadsetBatteryChargeStatus { get; }
```

#### ActiveHeadsetBatteryLevel

Retrieves the active Headset Detail Battery Level status that the TrackedAlias is using.

##### Declaration

```
public float ActiveHeadsetBatteryLevel { get; }
```

#### ActiveHeadsetCamera

Retrieves the active Headset Camera that the TrackedAlias is using.

##### Declaration

```
public Camera ActiveHeadsetCamera { get; }
```

#### ActiveHeadsetDetails

Retrieves the active Headset Detail Record that the TrackedAlias is using.

##### Declaration

```
public DeviceDetailsRecord ActiveHeadsetDetails { get; }
```

#### ActiveHeadsetIsConnected

Retrieves the active Headset Detail Is Connected status that the TrackedAlias is using.

##### Declaration

```
public bool ActiveHeadsetIsConnected { get; }
```

#### ActiveHeadsetManufacturer

Retrieves the active Headset Detail Manufacturer status that the TrackedAlias is using.

##### Declaration

```
public string ActiveHeadsetManufacturer { get; }
```

#### ActiveHeadsetModel

Retrieves the active Headset Detail Model status that the TrackedAlias is using.

##### Declaration

```
public string ActiveHeadsetModel { get; }
```

#### ActiveHeadsetTrackingHasBegun

Retrieves the active Headset Detail Tracking Begun status that the TrackedAlias is using.

##### Declaration

```
public bool ActiveHeadsetTrackingHasBegun { get; }
```

#### ActiveHeadsetTrackingType

Retrieves the active Headset Detail Tracking Type status that the TrackedAlias is using.

##### Declaration

```
public DeviceDetailsRecord.SpatialTrackingType ActiveHeadsetTrackingType { get; }
```

#### ActiveHeadsetVelocity

Retrieves the active Headset Velocity Tracker that the TrackedAlias is using.

##### Declaration

```
public VelocityTracker ActiveHeadsetVelocity { get; }
```

#### ActiveLeftController

Retrieves the active Left Controller that the TrackedAlias is using.

##### Declaration

```
public GameObject ActiveLeftController { get; }
```

#### ActiveLeftControllerBatteryChargeStatus

Retrieves the active LeftController Detail Battery Charge status that the TrackedAlias is using.

##### Declaration

```
public BatteryStatus ActiveLeftControllerBatteryChargeStatus { get; }
```

#### ActiveLeftControllerBatteryLevel

Retrieves the active LeftController Detail Battery Level status that the TrackedAlias is using.

##### Declaration

```
public float ActiveLeftControllerBatteryLevel { get; }
```

#### ActiveLeftControllerDetails

Retrieves the active LeftController Detail Record that the TrackedAlias is using.

##### Declaration

```
public DeviceDetailsRecord ActiveLeftControllerDetails { get; }
```

#### ActiveLeftControllerIsConnected

Retrieves the active LeftController Detail Is Connected status that the TrackedAlias is using.

##### Declaration

```
public bool ActiveLeftControllerIsConnected { get; }
```

#### ActiveLeftControllerManufacturer

Retrieves the active LeftController Detail Manufacturer status that the TrackedAlias is using.

##### Declaration

```
public string ActiveLeftControllerManufacturer { get; }
```

#### ActiveLeftControllerModel

Retrieves the active LeftController Detail Model status that the TrackedAlias is using.

##### Declaration

```
public string ActiveLeftControllerModel { get; }
```

#### ActiveLeftControllerTrackingHasBegun

Retrieves the active LeftController Detail Tracking Begun status that the TrackedAlias is using.

##### Declaration

```
public bool ActiveLeftControllerTrackingHasBegun { get; }
```

#### ActiveLeftControllerTrackingType

Retrieves the active LeftController Detail Tracking Type status that the TrackedAlias is using.

##### Declaration

```
public DeviceDetailsRecord.SpatialTrackingType ActiveLeftControllerTrackingType { get; }
```

#### ActiveLeftControllerVelocity

Retrieves the active Left Controller Velocity Tracker that the TrackedAlias is using.

##### Declaration

```
public VelocityTracker ActiveLeftControllerVelocity { get; }
```

#### ActiveLeftHapticProcess

Retrieves the active Left Controller Haptic Process that the TrackedAlias is using.

##### Declaration

```
public HapticProcess ActiveLeftHapticProcess { get; }
```

#### ActiveLeftHapticProfile

Retrieves the active Left Controller Haptic Profile that has been most recently used.

##### Declaration

```
public HapticProcess ActiveLeftHapticProfile { get; protected set; }
```

#### ActiveLeftHapticProfiles

Retrieves the active Left Controller Haptic Profiles that the TrackedAlias is using.

##### Declaration

```
public HapticProcessObservableList ActiveLeftHapticProfiles { get; }
```

#### ActiveLinkedAliasAssociation

##### Declaration

```
public LinkedAliasAssociationCollection ActiveLinkedAliasAssociation { get; }
```

#### ActivePlayArea

Retrieves the active PlayArea that the TrackedAlias is using.

##### Declaration

```
public GameObject ActivePlayArea { get; }
```

#### ActiveRightController

Retrieves the active Right Controller that the TrackedAlias is using.

##### Declaration

```
public GameObject ActiveRightController { get; }
```

#### ActiveRightControllerBatteryChargeStatus

Retrieves the active RightController Detail Battery Charge status that the TrackedAlias is using.

##### Declaration

```
public BatteryStatus ActiveRightControllerBatteryChargeStatus { get; }
```

#### ActiveRightControllerBatteryLevel

Retrieves the active RightController Detail Battery Level status that the TrackedAlias is using.

##### Declaration

```
public float ActiveRightControllerBatteryLevel { get; }
```

#### ActiveRightControllerDetails

Retrieves the active RightController Detail Record that the TrackedAlias is using.

##### Declaration

```
public DeviceDetailsRecord ActiveRightControllerDetails { get; }
```

#### ActiveRightControllerIsConnected

Retrieves the active RightController Detail Is Connected status that the TrackedAlias is using.

##### Declaration

```
public bool ActiveRightControllerIsConnected { get; }
```

#### ActiveRightControllerManufacturer

Retrieves the active RightController Detail Manufacturer status that the TrackedAlias is using.

##### Declaration

```
public string ActiveRightControllerManufacturer { get; }
```

#### ActiveRightControllerModel

Retrieves the active RightController Detail Model status that the TrackedAlias is using.

##### Declaration

```
public string ActiveRightControllerModel { get; }
```

#### ActiveRightControllerTrackingHasBegun

Retrieves the active RightController Detail Tracking Begun status that the TrackedAlias is using.

##### Declaration

```
public bool ActiveRightControllerTrackingHasBegun { get; }
```

#### ActiveRightControllerTrackingType

Retrieves the active RightController Detail Tracking Type status that the TrackedAlias is using.

##### Declaration

```
public DeviceDetailsRecord.SpatialTrackingType ActiveRightControllerTrackingType { get; }
```

#### ActiveRightControllerVelocity

Retrieves the active Right Controller Velocity Tracker that the TrackedAlias is using.

##### Declaration

```
public VelocityTracker ActiveRightControllerVelocity { get; }
```

#### ActiveRightHapticProcess

Retrieves the active Right Controller Haptic Process that the TrackedAlias is using.

##### Declaration

```
public HapticProcess ActiveRightHapticProcess { get; }
```

#### ActiveRightHapticProfile

Retrieves the active Right Controller Haptic Profile that has been most recently used.

##### Declaration

```
public HapticProcess ActiveRightHapticProfile { get; protected set; }
```

#### ActiveRightHapticProfiles

Retrieves the active Left Controller Haptic Profiles that the TrackedAlias is using.

##### Declaration

```
public HapticProcessObservableList ActiveRightHapticProfiles { get; }
```

#### CameraRigs

The associated CameraRigs to track.

##### Declaration

```
public LinkedAliasAssociationCollectionObservableList CameraRigs { get; set; }
```

#### Configuration

The linked Internal Setup.

##### Declaration

```
public TrackedAliasConfigurator Configuration { get; protected set; }
```

#### DominantControllerObservers

Retrieves all of the linked CameraRig Dominant Controller Observers.

##### Declaration

```
public IEnumerable<DominantControllerObserver> DominantControllerObservers { get; }
```

#### HeadsetAlias

The alias follower for the Headset.

##### Declaration

```
public ObjectFollower HeadsetAlias { get; }
```

#### HeadsetCameras

Retrieves all of the linked CameraRig Headset Cameras.

##### Declaration

```
public IEnumerable<Camera> HeadsetCameras { get; }
```

#### HeadsetDeviceDetailRecords

Retrieves all of the linked CameraRig Headset Device Detail Record.

##### Declaration

```
public IEnumerable<DeviceDetailsRecord> HeadsetDeviceDetailRecords { get; }
```

#### HeadsetOriginAlias

The alias follower for the Headset Origin within the [PlayAreaAlias].

##### Declaration

```
public ObjectFollower HeadsetOriginAlias { get; }
```

#### Headsets

Retrieves all of the linked CameraRig Headsets.

##### Declaration

```
public IEnumerable<GameObject> Headsets { get; }
```

#### HeadsetSupplementCameras

Retrieves all of the linked CameraRig Supplement Headset Camera.

##### Declaration

```
public IEnumerable<Camera> HeadsetSupplementCameras { get; }
```

#### HeadsetVelocityTrackers

Retrieves all of the linked CameraRig Headset Velocity Trackers.

##### Declaration

```
public IEnumerable<VelocityTracker> HeadsetVelocityTrackers { get; }
```

#### LeftControllerAlias

The alias follower for the LeftController.

##### Declaration

```
public ObjectFollower LeftControllerAlias { get; }
```

#### LeftControllerDeviceDetailRecords

Retrieves all of the linked CameraRig Left Controller Device Detail Record.

##### Declaration

```
public IEnumerable<DeviceDetailsRecord> LeftControllerDeviceDetailRecords { get; }
```

#### LeftControllerHapticProcesses

Retrieves all of the linked CameraRig Left Controller Haptic Processes.

##### Declaration

```
public IEnumerable<HapticProcess> LeftControllerHapticProcesses { get; }
```

#### LeftControllerHapticProfiles

Retrieves all of the linked CameraRig Left Controller Haptic Profiles.

##### Declaration

```
public IEnumerable<HapticProcessObservableList> LeftControllerHapticProfiles { get; }
```

#### LeftControllers

Retrieves all of the linked CameraRig Left Controllers.

##### Declaration

```
public IEnumerable<GameObject> LeftControllers { get; }
```

#### LeftControllerVelocityTrackers

Retrieves all of the linked CameraRig Left Controller Velocity Trackers.

##### Declaration

```
public IEnumerable<VelocityTracker> LeftControllerVelocityTrackers { get; }
```

#### PlayAreaAlias

The alias follower for the PlayArea.

##### Declaration

```
public ObjectFollower PlayAreaAlias { get; }
```

#### PlayAreas

Retrieves all of the linked CameraRig PlayAreas.

##### Declaration

```
public IEnumerable<GameObject> PlayAreas { get; }
```

#### RightControllerAlias

The alias follower for the RightController.

##### Declaration

```
public ObjectFollower RightControllerAlias { get; }
```

#### RightControllerDeviceDetailRecords

Retrieves all of the linked CameraRig Right Controller Device Detail Record.

##### Declaration

```
public IEnumerable<DeviceDetailsRecord> RightControllerDeviceDetailRecords { get; }
```

#### RightControllerHapticProcesses

Retrieves all of the linked CameraRig Right Controller Haptic Processes.

##### Declaration

```
public IEnumerable<HapticProcess> RightControllerHapticProcesses { get; }
```

#### RightControllerHapticProfiles

Retrieves all of the linked CameraRig Right Controller Haptic Processes.

##### Declaration

```
public IEnumerable<HapticProcessObservableList> RightControllerHapticProfiles { get; }
```

#### RightControllers

Retrieves all of the linked CameraRig Right Controllers.

##### Declaration

```
public IEnumerable<GameObject> RightControllers { get; }
```

#### RightControllerVelocityTrackers

Retrieves all of the linked CameraRig Right Controller Velocity Trackers.

##### Declaration

```
public IEnumerable<VelocityTracker> RightControllerVelocityTrackers { get; }
```

### Methods

#### BeginHapticProcessOnLeftController()

Begins the haptic process on the Left Controller using the main HapticProcess.

##### Declaration

```
public virtual void BeginHapticProcessOnLeftController()
```

#### BeginHapticProcessOnLeftController(Int32)

Begins a haptic process on the Left Controller using the given profile.

##### Declaration

```
public virtual void BeginHapticProcessOnLeftController(int profileIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | profileIndex | The index of the haptic profile to use. |

#### BeginHapticProcessOnRightController()

Begins the haptic process on the Right Controller using the main HapticProcess.

##### Declaration

```
public virtual void BeginHapticProcessOnRightController()
```

#### BeginHapticProcessOnRightController(Int32)

Begins a haptic process on the Right Controller using the given profile.

##### Declaration

```
public virtual void BeginHapticProcessOnRightController(int profileIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | profileIndex | The index of the haptic profile to use. |

#### BeginHapticProfile(HapticProcessObservableList, Int32)

Begins the haptic process for the specified profile.

##### Declaration

```
protected virtual HapticProcess BeginHapticProfile(HapticProcessObservableList processes, int profileIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| HapticProcessObservableList | processes | The processes to begin. |
| System.Int32 | profileIndex | The index of the process to use. |

##### Returns

| Type | Description |
| --- | --- |
| HapticProcess | The haptic process being accessed. |

#### CancelActiveHapticProfileOnLeftController()

Cancels the haptic process currently running on the Left Controller for the current haptic profile.

##### Declaration

```
public virtual void CancelActiveHapticProfileOnLeftController()
```

#### CancelActiveHapticProfileOnRightController()

Cancels the haptic process currently running on the Right Controller for the current haptic profile.

##### Declaration

```
public virtual void CancelActiveHapticProfileOnRightController()
```

#### CancelAllHapticsOnLeftController()

Cancels all haptic process currently running on the Left Controller.

##### Declaration

```
public virtual void CancelAllHapticsOnLeftController()
```

#### CancelAllHapticsOnRightController()

Cancels all haptic process currently running on the Right Controller.

##### Declaration

```
public virtual void CancelAllHapticsOnRightController()
```

#### CancelHapticProcessOnLeftController()

Cancels any haptic process currently running on the Left Controller using the main HapticProcess.

##### Declaration

```
public virtual void CancelHapticProcessOnLeftController()
```

#### CancelHapticProcessOnLeftController(Int32)

Cancels the haptic process currently running on the Left Controller for the given profile.

##### Declaration

```
public virtual void CancelHapticProcessOnLeftController(int profileIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | profileIndex | The index of the haptic profile to cancel. |

#### CancelHapticProcessOnRightController()

Cancels any haptic process currently running on the Right Controller using the main HapticProcess.

##### Declaration

```
public virtual void CancelHapticProcessOnRightController()
```

#### CancelHapticProcessOnRightController(Int32)

Cancels the haptic process currently running on the Right Controller for the given profile.

##### Declaration

```
public virtual void CancelHapticProcessOnRightController(int profileIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | profileIndex | The index of the haptic profile to cancel. |

#### CancelHapticProfile(HapticProcessObservableList, Int32)

Cancels the haptic process for the specified profile.

##### Declaration

```
protected virtual HapticProcess CancelHapticProfile(HapticProcessObservableList processes, int profileIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| HapticProcessObservableList | processes | The processes to cancel. |
| System.Int32 | profileIndex | The index of the process to use. |

##### Returns

| Type | Description |
| --- | --- |
| HapticProcess | The haptic process being accessed. |

#### GetFirstActiveCamera(IEnumerable<Camera>)

Gets the first active Camera found in the given collection.

##### Declaration

```
protected virtual Camera GetFirstActiveCamera(IEnumerable<Camera> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<Camera\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| Camera | The found first active element in the collection. |

#### GetFirstActiveDeviceRecord(IEnumerable<DeviceDetailsRecord>)

Gets the first active DeviceDetailsRecord found in the given collection.

##### Declaration

```
protected virtual DeviceDetailsRecord GetFirstActiveDeviceRecord(IEnumerable<DeviceDetailsRecord> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<DeviceDetailsRecord\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| DeviceDetailsRecord | The found first active element in the collection. |

#### GetFirstActiveDominantControllerObserver(IEnumerable<DominantControllerObserver>)

Gets the first active DominantControllerObserver found in the given collection.

##### Declaration

```
protected virtual DominantControllerObserver GetFirstActiveDominantControllerObserver(IEnumerable<DominantControllerObserver> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<DominantControllerObserver\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| DominantControllerObserver | The found first active element in the collection. |

#### GetFirstActiveGameObject(IEnumerable<GameObject>)

Gets the first active GameObject found in the given collection.

##### Declaration

```
protected virtual GameObject GetFirstActiveGameObject(IEnumerable<GameObject> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<GameObject\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| GameObject | The found first active element in the collection. |

#### GetFirstActiveHapticProcess(IEnumerable<HapticProcess>)

Gets the first active HapticProcess found in the given collection.

##### Declaration

```
protected virtual HapticProcess GetFirstActiveHapticProcess(IEnumerable<HapticProcess> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<HapticProcess\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| HapticProcess | The found first active element in the collection. |

#### GetFirstActiveHapticProfile(IEnumerable<HapticProcessObservableList>)

Gets the first active profile found in the given haptic profile collection.

##### Declaration

```
protected virtual HapticProcessObservableList GetFirstActiveHapticProfile(IEnumerable<HapticProcessObservableList> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<HapticProcessObservableList\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| HapticProcessObservableList | The found first active profile collection in the collection. |

#### GetFirstActiveLinkedAliasAssociationCollection(IEnumerable<LinkedAliasAssociationCollection>)

Gets the first active LinkedAliasAssociationCollection found in the given collection.

##### Declaration

```
protected virtual LinkedAliasAssociationCollection GetFirstActiveLinkedAliasAssociationCollection(IEnumerable<LinkedAliasAssociationCollection> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<LinkedAliasAssociationCollection\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| LinkedAliasAssociationCollection | The found first active element in the collection. |

#### GetFirstActiveVelocityTracker(IEnumerable<VelocityTracker>)

Gets the first active VelocityTracker found in the given collection.

##### Declaration

```
protected virtual VelocityTracker GetFirstActiveVelocityTracker(IEnumerable<VelocityTracker> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<VelocityTracker\> | collection | The collection to look for the first active in. |

##### Returns

| Type | Description |
| --- | --- |
| VelocityTracker | The found first active element in the collection. |

#### IsValidHapticProfile(HapticProcessObservableList, Int32)

Determines whether the haptic profile is valid for the given index.

##### Declaration

```
protected virtual bool IsValidHapticProfile(HapticProcessObservableList processes, int profileIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| HapticProcessObservableList | processes | The processes to check. |
| System.Int32 | profileIndex | The index of the process to check validity on. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the given index is a valid profile. |

#### OnAfterCameraRigsChange()

Called after [CameraRigs] has been changed.

##### Declaration

```
protected virtual void OnAfterCameraRigsChange()
```

#### OnBeforeCameraRigsChange()

Called before [CameraRigs] has been changed.

##### Declaration

```
protected virtual void OnBeforeCameraRigsChange()
```

#### OnCameraRigAdded(LinkedAliasAssociationCollection)

Occurs when an item is added to the [CameraRigs] collection.

##### Declaration

```
protected virtual void OnCameraRigAdded(LinkedAliasAssociationCollection cameraRig)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| LinkedAliasAssociationCollection | cameraRig | The added element. |

#### OnCameraRigRemoved(LinkedAliasAssociationCollection)

Occurs when an item is removed from the [CameraRigs] collection.

##### Declaration

```
protected virtual void OnCameraRigRemoved(LinkedAliasAssociationCollection cameraRig)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| LinkedAliasAssociationCollection | cameraRig | The removed element. |

#### OnDisable()

##### Declaration

```
protected virtual void OnDisable()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### RefreshCameraRigsConfiguration()

Refreshes any changes made to the [CameraRigs] collection.

##### Declaration

```
protected virtual void RefreshCameraRigsConfiguration()
```

#### SubscribeToCameraRigsEvents()

Subscribes to the events on the current [CameraRigs] collection.

##### Declaration

```
protected virtual void SubscribeToCameraRigsEvents()
```

#### UnsubscribeFromCameraRigsEvents()

Unsubscribes from the events on the current [CameraRigs] collection.

##### Declaration

```
protected virtual void UnsubscribeFromCameraRigsEvents()
```

[Tilia.CameraRigs.TrackedAlias]: README.md
[TrackedAliasFacade.LinkedAliasAssociationCollectionUnityEvent]: TrackedAliasFacade.LinkedAliasAssociationCollectionUnityEvent.md
[TrackedAliasConfigurator]: TrackedAliasConfigurator.md
[PlayAreaAlias]: TrackedAliasFacade.md#PlayAreaAlias
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[CameraRigs]: TrackedAliasFacade.md#CameraRigs
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[DominantControllerIsChanging]: #DominantControllerIsChanging
[HeadsetBatteryChargeStatusChanged]: #HeadsetBatteryChargeStatusChanged
[HeadsetConnectionStatusChanged]: #HeadsetConnectionStatusChanged
[HeadsetTrackingBegun]: #HeadsetTrackingBegun
[HeadsetTrackingTypeChanged]: #HeadsetTrackingTypeChanged
[LeftControllerBatteryChargeStatusChanged]: #LeftControllerBatteryChargeStatusChanged
[LeftControllerConnectionStatusChanged]: #LeftControllerConnectionStatusChanged
[LeftControllerTrackingBegun]: #LeftControllerTrackingBegun
[LeftControllerTrackingTypeChanged]: #LeftControllerTrackingTypeChanged
[RightControllerBatteryChargeStatusChanged]: #RightControllerBatteryChargeStatusChanged
[RightControllerConnectionStatusChanged]: #RightControllerConnectionStatusChanged
[RightControllerTrackingBegun]: #RightControllerTrackingBegun
[RightControllerTrackingTypeChanged]: #RightControllerTrackingTypeChanged
[TrackedAliasChanged]: #TrackedAliasChanged
[Properties]: #Properties
[ActiveDominantControllerNode]: #ActiveDominantControllerNode
[ActiveDominantControllerObserver]: #ActiveDominantControllerObserver
[ActiveDominantControllerRecord]: #ActiveDominantControllerRecord
[ActiveHeadset]: #ActiveHeadset
[ActiveHeadsetBatteryChargeStatus]: #ActiveHeadsetBatteryChargeStatus
[ActiveHeadsetBatteryLevel]: #ActiveHeadsetBatteryLevel
[ActiveHeadsetCamera]: #ActiveHeadsetCamera
[ActiveHeadsetDetails]: #ActiveHeadsetDetails
[ActiveHeadsetIsConnected]: #ActiveHeadsetIsConnected
[ActiveHeadsetManufacturer]: #ActiveHeadsetManufacturer
[ActiveHeadsetModel]: #ActiveHeadsetModel
[ActiveHeadsetTrackingHasBegun]: #ActiveHeadsetTrackingHasBegun
[ActiveHeadsetTrackingType]: #ActiveHeadsetTrackingType
[ActiveHeadsetVelocity]: #ActiveHeadsetVelocity
[ActiveLeftController]: #ActiveLeftController
[ActiveLeftControllerBatteryChargeStatus]: #ActiveLeftControllerBatteryChargeStatus
[ActiveLeftControllerBatteryLevel]: #ActiveLeftControllerBatteryLevel
[ActiveLeftControllerDetails]: #ActiveLeftControllerDetails
[ActiveLeftControllerIsConnected]: #ActiveLeftControllerIsConnected
[ActiveLeftControllerManufacturer]: #ActiveLeftControllerManufacturer
[ActiveLeftControllerModel]: #ActiveLeftControllerModel
[ActiveLeftControllerTrackingHasBegun]: #ActiveLeftControllerTrackingHasBegun
[ActiveLeftControllerTrackingType]: #ActiveLeftControllerTrackingType
[ActiveLeftControllerVelocity]: #ActiveLeftControllerVelocity
[ActiveLeftHapticProcess]: #ActiveLeftHapticProcess
[ActiveLeftHapticProfile]: #ActiveLeftHapticProfile
[ActiveLeftHapticProfiles]: #ActiveLeftHapticProfiles
[ActiveLinkedAliasAssociation]: #ActiveLinkedAliasAssociation
[ActivePlayArea]: #ActivePlayArea
[ActiveRightController]: #ActiveRightController
[ActiveRightControllerBatteryChargeStatus]: #ActiveRightControllerBatteryChargeStatus
[ActiveRightControllerBatteryLevel]: #ActiveRightControllerBatteryLevel
[ActiveRightControllerDetails]: #ActiveRightControllerDetails
[ActiveRightControllerIsConnected]: #ActiveRightControllerIsConnected
[ActiveRightControllerManufacturer]: #ActiveRightControllerManufacturer
[ActiveRightControllerModel]: #ActiveRightControllerModel
[ActiveRightControllerTrackingHasBegun]: #ActiveRightControllerTrackingHasBegun
[ActiveRightControllerTrackingType]: #ActiveRightControllerTrackingType
[ActiveRightControllerVelocity]: #ActiveRightControllerVelocity
[ActiveRightHapticProcess]: #ActiveRightHapticProcess
[ActiveRightHapticProfile]: #ActiveRightHapticProfile
[ActiveRightHapticProfiles]: #ActiveRightHapticProfiles
[CameraRigs]: #CameraRigs
[Configuration]: #Configuration
[DominantControllerObservers]: #DominantControllerObservers
[HeadsetAlias]: #HeadsetAlias
[HeadsetCameras]: #HeadsetCameras
[HeadsetDeviceDetailRecords]: #HeadsetDeviceDetailRecords
[HeadsetOriginAlias]: #HeadsetOriginAlias
[Headsets]: #Headsets
[HeadsetSupplementCameras]: #HeadsetSupplementCameras
[HeadsetVelocityTrackers]: #HeadsetVelocityTrackers
[LeftControllerAlias]: #LeftControllerAlias
[LeftControllerDeviceDetailRecords]: #LeftControllerDeviceDetailRecords
[LeftControllerHapticProcesses]: #LeftControllerHapticProcesses
[LeftControllerHapticProfiles]: #LeftControllerHapticProfiles
[LeftControllers]: #LeftControllers
[LeftControllerVelocityTrackers]: #LeftControllerVelocityTrackers
[PlayAreaAlias]: #PlayAreaAlias
[PlayAreas]: #PlayAreas
[RightControllerAlias]: #RightControllerAlias
[RightControllerDeviceDetailRecords]: #RightControllerDeviceDetailRecords
[RightControllerHapticProcesses]: #RightControllerHapticProcesses
[RightControllerHapticProfiles]: #RightControllerHapticProfiles
[RightControllers]: #RightControllers
[RightControllerVelocityTrackers]: #RightControllerVelocityTrackers
[Methods]: #Methods
[BeginHapticProcessOnLeftController()]: #BeginHapticProcessOnLeftController
[BeginHapticProcessOnLeftController(Int32)]: #BeginHapticProcessOnLeftControllerInt32
[BeginHapticProcessOnRightController()]: #BeginHapticProcessOnRightController
[BeginHapticProcessOnRightController(Int32)]: #BeginHapticProcessOnRightControllerInt32
[BeginHapticProfile(HapticProcessObservableList, Int32)]: #BeginHapticProfileHapticProcessObservableList-Int32
[CancelActiveHapticProfileOnLeftController()]: #CancelActiveHapticProfileOnLeftController
[CancelActiveHapticProfileOnRightController()]: #CancelActiveHapticProfileOnRightController
[CancelAllHapticsOnLeftController()]: #CancelAllHapticsOnLeftController
[CancelAllHapticsOnRightController()]: #CancelAllHapticsOnRightController
[CancelHapticProcessOnLeftController()]: #CancelHapticProcessOnLeftController
[CancelHapticProcessOnLeftController(Int32)]: #CancelHapticProcessOnLeftControllerInt32
[CancelHapticProcessOnRightController()]: #CancelHapticProcessOnRightController
[CancelHapticProcessOnRightController(Int32)]: #CancelHapticProcessOnRightControllerInt32
[CancelHapticProfile(HapticProcessObservableList, Int32)]: #CancelHapticProfileHapticProcessObservableList-Int32
[GetFirstActiveCamera(IEnumerable<Camera>)]: #GetFirstActiveCameraIEnumerable<Camera>
[GetFirstActiveDeviceRecord(IEnumerable<DeviceDetailsRecord>)]: #GetFirstActiveDeviceRecordIEnumerable<DeviceDetailsRecord>
[GetFirstActiveDominantControllerObserver(IEnumerable<DominantControllerObserver>)]: #GetFirstActiveDominantControllerObserverIEnumerable<DominantControllerObserver>
[GetFirstActiveGameObject(IEnumerable<GameObject>)]: #GetFirstActiveGameObjectIEnumerable<GameObject>
[GetFirstActiveHapticProcess(IEnumerable<HapticProcess>)]: #GetFirstActiveHapticProcessIEnumerable<HapticProcess>
[GetFirstActiveHapticProfile(IEnumerable<HapticProcessObservableList>)]: #GetFirstActiveHapticProfileIEnumerable<HapticProcessObservableList>
[GetFirstActiveLinkedAliasAssociationCollection(IEnumerable<LinkedAliasAssociationCollection>)]: #GetFirstActiveLinkedAliasAssociationCollectionIEnumerable<LinkedAliasAssociationCollection>
[GetFirstActiveVelocityTracker(IEnumerable<VelocityTracker>)]: #GetFirstActiveVelocityTrackerIEnumerable<VelocityTracker>
[IsValidHapticProfile(HapticProcessObservableList, Int32)]: #IsValidHapticProfileHapticProcessObservableList-Int32
[OnAfterCameraRigsChange()]: #OnAfterCameraRigsChange
[OnBeforeCameraRigsChange()]: #OnBeforeCameraRigsChange
[OnCameraRigAdded(LinkedAliasAssociationCollection)]: #OnCameraRigAddedLinkedAliasAssociationCollection
[OnCameraRigRemoved(LinkedAliasAssociationCollection)]: #OnCameraRigRemovedLinkedAliasAssociationCollection
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[RefreshCameraRigsConfiguration()]: #RefreshCameraRigsConfiguration
[SubscribeToCameraRigsEvents()]: #SubscribeToCameraRigsEvents
[UnsubscribeFromCameraRigsEvents()]: #UnsubscribeFromCameraRigsEvents
